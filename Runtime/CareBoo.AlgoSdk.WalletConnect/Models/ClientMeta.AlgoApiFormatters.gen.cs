//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlgoSdk.WalletConnect
{
    
    
    public partial struct ClientMeta
    {
        
        private static bool @__generated__IsValid = ClientMeta.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.WalletConnect.ClientMeta>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.WalletConnect.ClientMeta>(false).Assign("description", null, (AlgoSdk.WalletConnect.ClientMeta x) => x.Description, (ref AlgoSdk.WalletConnect.ClientMeta x, System.String value) => x.Description = value, AlgoSdk.StringComparer.Instance, false).Assign("url", null, (AlgoSdk.WalletConnect.ClientMeta x) => x.Url, (ref AlgoSdk.WalletConnect.ClientMeta x, System.String value) => x.Url = value, AlgoSdk.StringComparer.Instance, false).Assign("icons", null, (AlgoSdk.WalletConnect.ClientMeta x) => x.IconUrls, (ref AlgoSdk.WalletConnect.ClientMeta x, System.String[] value) => x.IconUrls = value, AlgoSdk.ArrayComparer<System.String, AlgoSdk.StringComparer>.Instance, false).Assign("name", null, (AlgoSdk.WalletConnect.ClientMeta x) => x.Name, (ref AlgoSdk.WalletConnect.ClientMeta x, System.String value) => x.Name = value, AlgoSdk.StringComparer.Instance, false));
            return true;
        }
    }
}