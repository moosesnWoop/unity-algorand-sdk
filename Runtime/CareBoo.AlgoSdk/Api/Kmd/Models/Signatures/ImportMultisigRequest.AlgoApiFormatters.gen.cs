//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlgoSdk
{
    
    
    public partial struct ImportMultisigRequest
    {
        
        private static bool @__generated__IsValid = ImportMultisigRequest.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.ImportMultisigRequest>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.ImportMultisigRequest>(false).Assign("multisig_version", null, (AlgoSdk.ImportMultisigRequest x) => x.Version, (ref AlgoSdk.ImportMultisigRequest x, System.Byte value) => x.Version = value, false).Assign("pks", null, (AlgoSdk.ImportMultisigRequest x) => x.PublicKeys, (ref AlgoSdk.ImportMultisigRequest x, AlgoSdk.Crypto.Ed25519.PublicKey[] value) => x.PublicKeys = value, AlgoSdk.ArrayComparer<AlgoSdk.Crypto.Ed25519.PublicKey>.Instance, false).Assign("threshold", null, (AlgoSdk.ImportMultisigRequest x) => x.Threshold, (ref AlgoSdk.ImportMultisigRequest x, System.Byte value) => x.Threshold = value, false).Assign("wallet_handle_token", null, (AlgoSdk.ImportMultisigRequest x) => x.WalletHandleToken, (ref AlgoSdk.ImportMultisigRequest x, Unity.Collections.FixedString128Bytes value) => x.WalletHandleToken = value, false));
            return true;
        }
    }
}