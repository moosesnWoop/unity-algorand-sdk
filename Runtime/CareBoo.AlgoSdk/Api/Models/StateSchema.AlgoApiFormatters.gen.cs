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
    
    
    public partial struct StateSchema
    {
        
        private static bool @__generated__IsValid = StateSchema.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.StateSchema>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.StateSchema>(false).Assign("num-byte-slice", "nbs", (AlgoSdk.StateSchema x) => x.NumByteSlices, (ref AlgoSdk.StateSchema x, System.UInt64 value) => x.NumByteSlices = value, false).Assign("num-uint", "nui", (AlgoSdk.StateSchema x) => x.NumUints, (ref AlgoSdk.StateSchema x, System.UInt64 value) => x.NumUints = value, false));
            return true;
        }
    }
}
