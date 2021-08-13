using System;
using AlgoSdk.Crypto;
using AlgoSdk.MsgPack;

namespace AlgoSdk
{
    public static partial class Transaction
    {
        public struct Payment
            : IDisposable
            , ITransaction
            , IEquatable<Payment>
        {
            public Header Header;
            public Address Receiver;
            public ulong Amount;
            public Address CloseRemainderTo;

            Header ITransaction.Header => Header;

            public Payment(
                in ulong fee,
                in ulong firstValidRound,
                in Sha512_256_Hash genesisHash,
                in ulong lastValidRound,
                in Address sender,
                in Address receiver,
                in ulong amount
            )
            {
                Header = new Header(
                    in fee,
                    in firstValidRound,
                    in genesisHash,
                    in lastValidRound,
                    in sender,
                    TransactionType.Payment
                );
                Receiver = receiver;
                Amount = amount;
                CloseRemainderTo = default;
            }

            public void Dispose()
            {
                Header.Dispose();
            }

            public Header GetHeader() => Header;

            public void CopyTo(ref RawTransaction rawTransaction)
            {
                Header.CopyTo(ref rawTransaction);
                rawTransaction.Receiver = Receiver;
                rawTransaction.Amount = Amount;
                if (CloseRemainderTo != default)
                    rawTransaction.CloseRemainderTo = CloseRemainderTo;
            }

            public void CopyFrom(in RawTransaction rawTransaction)
            {
                Header.CopyFrom(in rawTransaction);
                Receiver = rawTransaction.Receiver;
                Amount = rawTransaction.Amount;
                if (rawTransaction.CloseRemainderTo.IsCreated)
                    CloseRemainderTo = rawTransaction.CloseRemainderTo;
            }

            public bool Equals(Payment other)
            {
                return Header.Equals(other.Header)
                    && Receiver == other.Receiver
                    && Amount == other.Amount
                    && CloseRemainderTo == other.CloseRemainderTo
                    ;
            }
        }
    }
}