//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlgoSdk.Experimental.Abi
{


    public partial struct Contract
    {

        private static bool @__generated__IsValid = Contract.@__generated__InitializeAlgoApiFormatters();

        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.Experimental.Abi.Contract>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.Experimental.Abi.Contract>(false).Assign("name", (AlgoSdk.Experimental.Abi.Contract x) => x.Name, (ref AlgoSdk.Experimental.Abi.Contract x, System.String value) => x.Name = value, AlgoSdk.StringComparer.Instance).Assign("desc", (AlgoSdk.Experimental.Abi.Contract x) => x.Description, (ref AlgoSdk.Experimental.Abi.Contract x, System.String value) => x.Description = value, AlgoSdk.StringComparer.Instance).Assign("networks", (AlgoSdk.Experimental.Abi.Contract x) => x.Networks, (ref AlgoSdk.Experimental.Abi.Contract x, AlgoSdk.Experimental.Abi.Contract.Deployments value) => x.Networks = value).Assign("methods", (AlgoSdk.Experimental.Abi.Contract x) => x.Methods, (ref AlgoSdk.Experimental.Abi.Contract x, AlgoSdk.Experimental.Abi.Method[] value) => x.Methods = value, AlgoSdk.ArrayComparer<AlgoSdk.Experimental.Abi.Method>.Instance));
            return true;
        }

        public partial struct Deployments
        {

            private static bool @__generated__IsValid = Deployments.@__generated__InitializeAlgoApiFormatters();

            private static bool @__generated__InitializeAlgoApiFormatters()
            {
                AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.Experimental.Abi.Contract.Deployments>(new AlgoSdk.Experimental.Abi.Contract.Deployments.Formatter());
                return true;
            }
        }
    }
}
