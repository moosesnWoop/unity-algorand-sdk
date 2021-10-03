using AlgoSdk.Json;
using AlgoSdk.MessagePack;
using Unity.Collections;

namespace AlgoSdk
{
    public class SignedTransactionFormatter : IAlgoApiFormatter<SignedTransaction>
    {
        static readonly FixedString32Bytes TxnKey = "txn";
        static readonly FixedString32Bytes SigKey = "sig";
        static readonly FixedString32Bytes LogicSigKey = "lsig";
        static readonly FixedString32Bytes MultiSigKey = "msig";

        public SignedTransaction Deserialize(ref JsonReader reader)
        {
            TransactionSignature signature = default;
            Transaction txn = default;
            if (!reader.TryRead(JsonToken.ObjectBegin))
                JsonReadError.IncorrectType.ThrowIfError();
            while (reader.Peek() != JsonToken.ObjectEnd && reader.Peek() != JsonToken.None)
            {
                FixedString32Bytes key = default;
                reader.ReadString(ref key).ThrowIfError();
                if (key == TxnKey)
                    txn = AlgoApiFormatterCache<Transaction>.Formatter.Deserialize(ref reader);
                else if (key == SigKey)
                    signature = AlgoApiFormatterCache<Sig>.Formatter.Deserialize(ref reader);
                else if (key == LogicSigKey)
                    signature = AlgoApiFormatterCache<LogicSig>.Formatter.Deserialize(ref reader);
                else if (key == MultiSigKey)
                    signature = AlgoApiFormatterCache<MultiSig>.Formatter.Deserialize(ref reader);
            }
            if (!reader.TryRead(JsonToken.ObjectEnd))
                JsonReadError.IncorrectFormat.ThrowIfError();
            txn.Signature = signature;
            return new SignedTransaction { Transaction = txn };
        }

        public SignedTransaction Deserialize(ref MessagePackReader reader)
        {
            var length = reader.ReadMapHeader();
            TransactionSignature signature = default;
            Transaction txn = default;
            for (var i = 0; i < length; i++)
            {
                var key = new FixedString32Bytes();
                reader.ReadString(ref key);
                if (key == TxnKey)
                    txn = AlgoApiFormatterCache<Transaction>.Formatter.Deserialize(ref reader);
                else if (key == SigKey)
                    signature = AlgoApiFormatterCache<Sig>.Formatter.Deserialize(ref reader);
                else if (key == LogicSigKey)
                    signature = AlgoApiFormatterCache<LogicSig>.Formatter.Deserialize(ref reader);
                else if (key == MultiSigKey)
                    signature = AlgoApiFormatterCache<MultiSig>.Formatter.Deserialize(ref reader);
            }
            txn.Signature = signature;
            return new SignedTransaction { Transaction = txn };
        }

        public void Serialize(ref JsonWriter writer, SignedTransaction value)
        {
            writer.BeginObject();
            if (!value.Signature.Sig.Equals(default))
            {
                writer.WriteObjectKey(SigKey);
                AlgoApiFormatterCache<Sig>.Formatter.Serialize(ref writer, value.Signature.Sig);
            }
            else if (!value.Signature.LogicSig.Equals(default))
            {
                writer.WriteObjectKey(LogicSigKey);
                AlgoApiFormatterCache<LogicSig>.Formatter.Serialize(ref writer, value.Signature.LogicSig);
            }
            else if (!value.Signature.MultiSig.Equals(default))
            {
                writer.WriteObjectKey(MultiSigKey);
                AlgoApiFormatterCache<MultiSig>.Formatter.Serialize(ref writer, value.Signature.MultiSig);
            }
            writer.WriteObjectKey(TxnKey);
            AlgoApiFormatterCache<Transaction>.Formatter.Serialize(ref writer, value.Transaction);
            writer.EndObject();
        }

        public void Serialize(ref MessagePackWriter writer, SignedTransaction value)
        {
            writer.WriteMapHeader(2);
            if (!value.Signature.Sig.Equals(default))
            {
                writer.WriteString(SigKey);
                AlgoApiFormatterCache<Sig>.Formatter.Serialize(ref writer, value.Signature.Sig);
            }
            else if (!value.Signature.LogicSig.Equals(default))
            {
                writer.WriteString(LogicSigKey);
                AlgoApiFormatterCache<LogicSig>.Formatter.Serialize(ref writer, value.Signature.LogicSig);
            }
            else if (!value.Signature.MultiSig.Equals(default))
            {
                writer.WriteString(MultiSigKey);
                AlgoApiFormatterCache<MultiSig>.Formatter.Serialize(ref writer, value.Signature.MultiSig);
            }
            writer.WriteString(TxnKey);
            AlgoApiFormatterCache<Transaction>.Formatter.Serialize(ref writer, value.Transaction);
        }
    }
}