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
    
    
    public partial struct BalancesResponse
    {
        
        private static bool @__generated__IsValid = BalancesResponse.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.BalancesResponse>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.BalancesResponse>(false).Assign("balances", null, (AlgoSdk.BalancesResponse x) => x.Balances, (ref AlgoSdk.BalancesResponse x, AlgoSdk.MiniAssetHolding[] value) => x.Balances = value, AlgoSdk.ArrayComparer<AlgoSdk.MiniAssetHolding>.Instance, false).Assign("current-round", null, (AlgoSdk.BalancesResponse x) => x.CurrentRound, (ref AlgoSdk.BalancesResponse x, System.UInt64 value) => x.CurrentRound = value, false).Assign("next-token", null, (AlgoSdk.BalancesResponse x) => x.NextToken, (ref AlgoSdk.BalancesResponse x, Unity.Collections.FixedString128Bytes value) => x.NextToken = value, false));
            return true;
        }
    }
}