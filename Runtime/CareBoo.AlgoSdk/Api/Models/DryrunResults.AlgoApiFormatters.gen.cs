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
    
    
    public partial struct DryrunResults
    {
        
        private static bool @__generated__IsValid = DryrunResults.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.DryrunResults>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.DryrunResults>(false).Assign("error", null, (AlgoSdk.DryrunResults x) => x.Error, (ref AlgoSdk.DryrunResults x, System.String value) => x.Error = value, AlgoSdk.StringComparer.Instance, false).Assign("protocol-version", null, (AlgoSdk.DryrunResults x) => x.ProtocolVersion, (ref AlgoSdk.DryrunResults x, Unity.Collections.FixedString128Bytes value) => x.ProtocolVersion = value, false).Assign("txns", null, (AlgoSdk.DryrunResults x) => x.Txns, (ref AlgoSdk.DryrunResults x, AlgoSdk.DryrunTxnResult[] value) => x.Txns = value, AlgoSdk.ArrayComparer<AlgoSdk.DryrunTxnResult>.Instance, false));
            return true;
        }
    }
}
