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
    
    
    public partial struct ListMultisigResponse
    {
        
        private static bool @__generated__IsValid = ListMultisigResponse.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.ListMultisigResponse>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.ListMultisigResponse>(false).Assign("addresses", null, (AlgoSdk.ListMultisigResponse x) => x.Addresses, (ref AlgoSdk.ListMultisigResponse x, AlgoSdk.Address[] value) => x.Addresses = value, AlgoSdk.ArrayComparer<AlgoSdk.Address>.Instance, false).Assign("error", null, (AlgoSdk.ListMultisigResponse x) => x.Error, (ref AlgoSdk.ListMultisigResponse x, AlgoSdk.Optional<System.Boolean> value) => x.Error = value, false).Assign("message", null, (AlgoSdk.ListMultisigResponse x) => x.Message, (ref AlgoSdk.ListMultisigResponse x, System.String value) => x.Message = value, AlgoSdk.StringComparer.Instance, false));
            return true;
        }
    }
}
