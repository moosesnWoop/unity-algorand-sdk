using System.Collections.Generic;
using AlgoSdk.Crypto;
using AlgoSdk.MessagePack;
using Unity.Collections;

namespace AlgoSdk
{
    public static partial class AtomicTxn
    {
        /// <summary>
        /// Represents an Atomic Txn group that is currently being built up with more transactions.
        /// </summary>
        /// <remarks>
        /// Once you are done building this txn group, use <see cref="Build"/> to prepare the group
        /// for signing.
        /// </remarks>
        public partial struct Building
        {
            List<Transaction> _txns;

            /// <summary>
            /// The current number of transactions in this group.
            /// </summary>
            public int TxnCount => _txns.Count;

            /// <summary>
            /// Get the transaction in this group at the given index.
            /// </summary>
            public Transaction this[int i] => _txns[i];

            List<Transaction> txns
            {
                get
                {
                    if (_txns == null)
                        _txns = new List<Transaction>(4);

                    return _txns;
                }
            }

            public IReadOnlyList<Transaction> Txns => txns;

            /// <summary>
            /// Add a transaction to this group.
            /// </summary>
            /// <remarks>
            /// The transaction must not have its <see cref="ITransaction.Group"/> property set.
            /// Cannot add more transactions than <see cref="MaxTxnCount"/>.
            /// </remarks>
            /// <param name="txn">The transaction to add to this group, with a zeroed-out <see cref="ITransaction.Group"/> property.</param>
            /// <typeparam name="T">The type of the transaction.</typeparam>
            /// <returns>
            /// An Atomic Transaction in the Building state, ready to add more transactions or build.
            /// </returns>
            public Building AddTxn<T>(T txn)
                where T : ITransaction
            {
                if (!txn.Group.Equals(default))
                    throw new System.ArgumentException("The given transaction must have its Group field unset.", nameof(txn));
                if (txns.Count == MaxNumTxns)
                    throw new System.NotSupportedException($"Atomic Transaction Groups cannot be larger than {MaxNumTxns} transactions.");

                Transaction raw = default;
                txn.CopyTo(ref raw);
                txns.Add(raw);

                return this;
            }

            /// <summary>
            /// Builds the current Atomic Transaction, generating a group ID and
            /// assigning it to all transactions in this group.
            /// </summary>
            /// <returns>
            /// An Atomic Transaction that's ready to be signed by
            /// different signers.
            /// </returns>
            public Signing Build()
            {
                var writer = new MessagePackWriter(Allocator.Persistent);
                try
                {
                    for (var i = 0; i < IdPrefix.Length; i++)
                        writer.Data.Add(IdPrefix[i]);
                    writer.WriteMapHeader(1);
                    writer.WriteString(txnGroupKey);
                    writer.WriteArrayHeader(txns.Count);
                    for (var i = 0; i < txns.Count; i++)
                    {
                        AlgoApiFormatterCache<TransactionId>.Formatter.Serialize(ref writer, txns[i].GetId());
                    }

                    TransactionId groupId = Sha512.Hash256Truncated(writer.Data.AsArray().AsReadOnly());
                    var txnsArr = txns.ToArray();
                    for (var i = 0; i < txns.Count; i++)
                    {
                        txnsArr[i].Group = groupId;
                    }

                    return new Signing(txnsArr);
                }
                finally
                {
                    writer.Dispose();
                }
            }
        }
    }
}
