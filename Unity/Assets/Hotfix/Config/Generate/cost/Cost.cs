//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;

namespace cfg.cost
{
    public abstract partial class Cost :  Bright.Config.BeanBase 
    {
        public Cost(JSONNode _json) 
        {
            PostInit();
        }
    
        public Cost() 
        {
            PostInit();
        }
    
        public static Cost DeserializeCost(JSONNode _json)
        {
            string type = _json["$type"];
            switch (type)
            {
                case "CostCurrency": return new cost.CostCurrency(_json);
                case "CostCurrencies": return new cost.CostCurrencies(_json);
                case "CostOneItem": return new cost.CostOneItem(_json);
                case "CostItem": return new cost.CostItem(_json);
                case "CostItems": return new cost.CostItems(_json);
                default: throw new SerializationException();
            }
        }
    
    
    
        public virtual void Resolve(Dictionary<string, object> _tables)
        {
            PostResolve();
        }
    
        public virtual void TranslateText(System.Func<string, string, string> translator)
        {
        }
    
        public override string ToString()
        {
            return "{ "
            + "}";
        }
        
        partial void PostInit();
        partial void PostResolve();
    }
}
