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
    
    
    public partial struct SignMultisigRequest
    {
        
        private static bool @__generated__IsValid = SignMultisigRequest.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.SignMultisigRequest>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.SignMultisigRequest>(false).Assign("partial_multisig", null, (AlgoSdk.SignMultisigRequest x) => x.Multisig, (ref AlgoSdk.SignMultisigRequest x, AlgoSdk.Multisig value) => x.Multisig = value, false).Assign("public_key", null, (AlgoSdk.SignMultisigRequest x) => x.PublicKey, (ref AlgoSdk.SignMultisigRequest x, AlgoSdk.Crypto.Ed25519.PublicKey value) => x.PublicKey = value, false).Assign("signer", null, (AlgoSdk.SignMultisigRequest x) => x.Signer, (ref AlgoSdk.SignMultisigRequest x, AlgoSdk.Address value) => x.Signer = value, false).Assign("transaction", null, (AlgoSdk.SignMultisigRequest x) => x.Transaction, (ref AlgoSdk.SignMultisigRequest x, System.Byte[] value) => x.Transaction = value, AlgoSdk.ArrayComparer<System.Byte>.Instance, false).Assign("wallet_handle_token", null, (AlgoSdk.SignMultisigRequest x) => x.WalletHandleToken, (ref AlgoSdk.SignMultisigRequest x, Unity.Collections.FixedString128Bytes value) => x.WalletHandleToken = value, false).Assign("wallet_password", null, (AlgoSdk.SignMultisigRequest x) => x.WalletPassword, (ref AlgoSdk.SignMultisigRequest x, Unity.Collections.FixedString128Bytes value) => x.WalletPassword = value, false));
            return true;
        }
    }
}