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

namespace cfg.bonus
{
    public sealed partial class MultiBonus :  bonus.Bonus 
    {
        public MultiBonus(JSONNode _json)  : base(_json) 
        {
            { var __json0 = _json["bonuses"]; if(!__json0.IsArray) { throw new SerializationException(); } int _n0 = __json0.Count; Bonuses = new bonus.Bonus[_n0]; int __index0=0; foreach(JSONNode __e0 in __json0.Children) { bonus.Bonus __v0;  { if(!__e0.IsObject) { throw new SerializationException(); }  __v0 = bonus.Bonus.DeserializeBonus(__e0);  }  Bonuses[__index0++] = __v0; }   }
            PostInit();
        }
    
        public MultiBonus(bonus.Bonus[] bonuses )  : base() 
        {
            this.Bonuses = bonuses;
            PostInit();
        }
    
        public static MultiBonus DeserializeMultiBonus(JSONNode _json)
        {
            return new bonus.MultiBonus(_json);
        }
    
        public bonus.Bonus[] Bonuses { get; private set; }
    
        public const int __ID__ = 1421907893;
        public override int GetTypeId() => __ID__;
    
        public override void Resolve(Dictionary<string, object> _tables)
        {
            base.Resolve(_tables);
            foreach(var _e in Bonuses) { _e?.Resolve(_tables); }
            PostResolve();
        }
    
        public override void TranslateText(System.Func<string, string, string> translator)
        {
            base.TranslateText(translator);
            foreach(var _e in Bonuses) { _e?.TranslateText(translator); }
        }
    
        public override string ToString()
        {
            return "{ "
            + "Bonuses:" + Bright.Common.StringUtil.CollectionToString(Bonuses) + ","
            + "}";
        }
        
        partial void PostInit();
        partial void PostResolve();
    }
}
