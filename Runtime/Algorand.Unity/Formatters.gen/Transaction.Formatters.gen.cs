//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using UnityCollections = Unity.Collections;


namespace Algorand.Unity
{
    
    
    public partial struct Transaction
    {
        
        private static bool @__generated__IsValid = Transaction.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            Algorand.Unity.AlgoApiFormatterLookup.Add<Algorand.Unity.Transaction>(new Algorand.Unity.AlgoApiObjectFormatter<Algorand.Unity.Transaction>(false).Assign("apid", (Algorand.Unity.Transaction x) => x.ApplicationId, (ref Algorand.Unity.Transaction x, Algorand.Unity.AppIndex value) => x.ApplicationId = value).Assign("apan", (Algorand.Unity.Transaction x) => x.OnComplete, (ref Algorand.Unity.Transaction x, Algorand.Unity.OnCompletion value) => x.OnComplete = value, Algorand.Unity.ByteEnumComparer<Algorand.Unity.OnCompletion>.Instance).Assign("apap", (Algorand.Unity.Transaction x) => x.ApprovalProgram, (ref Algorand.Unity.Transaction x, Algorand.Unity.CompiledTeal value) => x.ApprovalProgram = value).Assign("apsu", (Algorand.Unity.Transaction x) => x.ClearStateProgram, (ref Algorand.Unity.Transaction x, Algorand.Unity.CompiledTeal value) => x.ClearStateProgram = value).Assign("apaa", (Algorand.Unity.Transaction x) => x.AppArguments, (ref Algorand.Unity.Transaction x, Algorand.Unity.CompiledTeal[] value) => x.AppArguments = value, Algorand.Unity.ArrayComparer<Algorand.Unity.CompiledTeal>.Instance).Assign("apat", (Algorand.Unity.Transaction x) => x.Accounts, (ref Algorand.Unity.Transaction x, Algorand.Unity.Address[] value) => x.Accounts = value, Algorand.Unity.ArrayComparer<Algorand.Unity.Address>.Instance).Assign("apfa", (Algorand.Unity.Transaction x) => x.ForeignApps, (ref Algorand.Unity.Transaction x, System.UInt64[] value) => x.ForeignApps = value, Algorand.Unity.ArrayComparer<System.UInt64>.Instance).Assign("apas", (Algorand.Unity.Transaction x) => x.ForeignAssets, (ref Algorand.Unity.Transaction x, System.UInt64[] value) => x.ForeignAssets = value, Algorand.Unity.ArrayComparer<System.UInt64>.Instance).Assign("apgs", (Algorand.Unity.Transaction x) => x.GlobalStateSchema, (ref Algorand.Unity.Transaction x, Algorand.Unity.StateSchema value) => x.GlobalStateSchema = value).Assign("apls", (Algorand.Unity.Transaction x) => x.LocalStateSchema, (ref Algorand.Unity.Transaction x, Algorand.Unity.StateSchema value) => x.LocalStateSchema = value).Assign("apep", (Algorand.Unity.Transaction x) => x.ExtraProgramPages, (ref Algorand.Unity.Transaction x, System.UInt64 value) => x.ExtraProgramPages = value).Assign("apbx", (Algorand.Unity.Transaction x) => x.Boxes, (ref Algorand.Unity.Transaction x, Algorand.Unity.BoxRef[] value) => x.Boxes = value, Algorand.Unity.ArrayComparer<Algorand.Unity.BoxRef>.Instance).Assign("caid", (Algorand.Unity.Transaction x) => x.ConfigAsset, (ref Algorand.Unity.Transaction x, Algorand.Unity.AssetIndex value) => x.ConfigAsset = value).Assign("apar", (Algorand.Unity.Transaction x) => x.AssetParams, (ref Algorand.Unity.Transaction x, Algorand.Unity.AssetParams value) => x.AssetParams = value).Assign("fadd", (Algorand.Unity.Transaction x) => x.FreezeAccount, (ref Algorand.Unity.Transaction x, Algorand.Unity.Address value) => x.FreezeAccount = value).Assign("faid", (Algorand.Unity.Transaction x) => x.FreezeAsset, (ref Algorand.Unity.Transaction x, Algorand.Unity.AssetIndex value) => x.FreezeAsset = value).Assign("afrz", (Algorand.Unity.Transaction x) => x.AssetFrozen, (ref Algorand.Unity.Transaction x, Algorand.Unity.Optional<System.Boolean> value) => x.AssetFrozen = value).Assign("xaid", (Algorand.Unity.Transaction x) => x.XferAsset, (ref Algorand.Unity.Transaction x, Algorand.Unity.AssetIndex value) => x.XferAsset = value).Assign("aamt", (Algorand.Unity.Transaction x) => x.AssetAmount, (ref Algorand.Unity.Transaction x, System.UInt64 value) => x.AssetAmount = value).Assign("asnd", (Algorand.Unity.Transaction x) => x.AssetSender, (ref Algorand.Unity.Transaction x, Algorand.Unity.Address value) => x.AssetSender = value).Assign("arcv", (Algorand.Unity.Transaction x) => x.AssetReceiver, (ref Algorand.Unity.Transaction x, Algorand.Unity.Address value) => x.AssetReceiver = value).Assign("aclose", (Algorand.Unity.Transaction x) => x.AssetCloseTo, (ref Algorand.Unity.Transaction x, Algorand.Unity.Address value) => x.AssetCloseTo = value).Assign("votekey", (Algorand.Unity.Transaction x) => x.VoteParticipationKey, (ref Algorand.Unity.Transaction x, Algorand.Unity.ParticipationPublicKey value) => x.VoteParticipationKey = value).Assign("selkey", (Algorand.Unity.Transaction x) => x.SelectionParticipationKey, (ref Algorand.Unity.Transaction x, Algorand.Unity.VrfPubKey value) => x.SelectionParticipationKey = value).Assign("votefst", (Algorand.Unity.Transaction x) => x.VoteFirst, (ref Algorand.Unity.Transaction x, System.UInt64 value) => x.VoteFirst = value).Assign("votelst", (Algorand.Unity.Transaction x) => x.VoteLast, (ref Algorand.Unity.Transaction x, System.UInt64 value) => x.VoteLast = value).Assign("votekd", (Algorand.Unity.Transaction x) => x.VoteKeyDilution, (ref Algorand.Unity.Transaction x, System.UInt64 value) => x.VoteKeyDilution = value).Assign("nonpart", (Algorand.Unity.Transaction x) => x.NonParticipation, (ref Algorand.Unity.Transaction x, Algorand.Unity.Optional<System.Boolean> value) => x.NonParticipation = value).Assign("rcv", (Algorand.Unity.Transaction x) => x.Receiver, (ref Algorand.Unity.Transaction x, Algorand.Unity.Address value) => x.Receiver = value).Assign("amt", (Algorand.Unity.Transaction x) => x.Amount, (ref Algorand.Unity.Transaction x, Algorand.Unity.MicroAlgos value) => x.Amount = value).Assign("close", (Algorand.Unity.Transaction x) => x.CloseRemainderTo, (ref Algorand.Unity.Transaction x, Algorand.Unity.Address value) => x.CloseRemainderTo = value).Assign("fee", (Algorand.Unity.Transaction x) => x.Fee, (ref Algorand.Unity.Transaction x, Algorand.Unity.MicroAlgos value) => x.Fee = value).Assign("fv", (Algorand.Unity.Transaction x) => x.FirstValidRound, (ref Algorand.Unity.Transaction x, System.UInt64 value) => x.FirstValidRound = value).Assign("gh", (Algorand.Unity.Transaction x) => x.GenesisHash, (ref Algorand.Unity.Transaction x, Algorand.Unity.GenesisHash value) => x.GenesisHash = value).Assign("lv", (Algorand.Unity.Transaction x) => x.LastValidRound, (ref Algorand.Unity.Transaction x, System.UInt64 value) => x.LastValidRound = value).Assign("snd", (Algorand.Unity.Transaction x) => x.Sender, (ref Algorand.Unity.Transaction x, Algorand.Unity.Address value) => x.Sender = value).Assign("type", (Algorand.Unity.Transaction x) => x.TransactionType, (ref Algorand.Unity.Transaction x, Algorand.Unity.TransactionType value) => x.TransactionType = value, Algorand.Unity.ByteEnumComparer<Algorand.Unity.TransactionType>.Instance).Assign("gen", (Algorand.Unity.Transaction x) => x.GenesisId, (ref Algorand.Unity.Transaction x, UnityCollections.FixedString32Bytes value) => x.GenesisId = value).Assign("grp", (Algorand.Unity.Transaction x) => x.Group, (ref Algorand.Unity.Transaction x, Algorand.Unity.TransactionId value) => x.Group = value).Assign("lx", (Algorand.Unity.Transaction x) => x.Lease, (ref Algorand.Unity.Transaction x, Algorand.Unity.TransactionId value) => x.Lease = value).Assign("note", (Algorand.Unity.Transaction x) => x.Note, (ref Algorand.Unity.Transaction x, System.Byte[] value) => x.Note = value, Algorand.Unity.ArrayComparer<System.Byte>.Instance).Assign("rekey", (Algorand.Unity.Transaction x) => x.RekeyTo, (ref Algorand.Unity.Transaction x, Algorand.Unity.Address value) => x.RekeyTo = value));
            return true;
        }
    }
}
