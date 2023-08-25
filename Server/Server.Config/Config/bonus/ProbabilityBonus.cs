//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Text.Json;
using Server.Config.Core;


namespace cfg.bonus
{
public sealed partial class ProbabilityBonus :  bonus.Bonus 
{
    public ProbabilityBonus(JsonElement _json)  : base(_json) 
    {
        { var __json0 = _json.GetProperty("bonuses"); int _n0 = __json0.GetArrayLength(); Bonuses = new bonus.ProbabilityBonusInfo[_n0]; int __index0=0; foreach(JsonElement __e0 in __json0.EnumerateArray()) { bonus.ProbabilityBonusInfo __v0;  __v0 = bonus.ProbabilityBonusInfo.DeserializeProbabilityBonusInfo(__e0);  Bonuses[__index0++] = __v0; }   }
        PostInit();
    }

    public ProbabilityBonus(bonus.ProbabilityBonusInfo[] bonuses )  : base() 
    {
        this.Bonuses = bonuses;
        PostInit();
    }

    public static ProbabilityBonus DeserializeProbabilityBonus(JsonElement _json)
    {
        return new bonus.ProbabilityBonus(_json);
    }

    public bonus.ProbabilityBonusInfo[] Bonuses { get; private set; }

    public const int __ID__ = 359783161;
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
        + "Bonuses:" + StringUtil.CollectionToString(Bonuses) + ","
        + "}";
    }

    partial void PostInit();
    partial void PostResolve();
}
}
