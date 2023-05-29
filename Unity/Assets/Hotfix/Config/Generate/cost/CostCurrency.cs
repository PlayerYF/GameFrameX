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
    public sealed partial class CostCurrency :  cost.Cost 
    {
        public CostCurrency(JSONNode _json)  : base(_json) 
        {
            { if(!_json["type"].IsNumber) { throw new SerializationException(); }  Type = (item.ECurrencyType)_json["type"].AsInt; }
            { if(!_json["num"].IsNumber) { throw new SerializationException(); }  Num = _json["num"]; }
            PostInit();
        }
    
        public CostCurrency(item.ECurrencyType type, int num )  : base() 
        {
            this.Type = type;
            this.Num = num;
            PostInit();
        }
    
        public static CostCurrency DeserializeCostCurrency(JSONNode _json)
        {
            return new cost.CostCurrency(_json);
        }
    
        public item.ECurrencyType Type { get; private set; }
        public int Num { get; private set; }
    
        public const int __ID__ = 911838111;
        public override int GetTypeId() => __ID__;
    
        public override void Resolve(Dictionary<string, object> _tables)
        {
            base.Resolve(_tables);
            PostResolve();
        }
    
        public override void TranslateText(System.Func<string, string, string> translator)
        {
            base.TranslateText(translator);
        }
    
        public override string ToString()
        {
            return "{ "
            + "Type:" + Type + ","
            + "Num:" + Num + ","
            + "}";
        }
        
        partial void PostInit();
        partial void PostResolve();
    }
}
