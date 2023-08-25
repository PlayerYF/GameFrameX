//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Text.Json;



namespace cfg.condition
{
public sealed partial class MaxLevel :  condition.BoolRoleCondition 
{
    public MaxLevel(JsonElement _json)  : base(_json) 
    {
        Level = _json.GetProperty("level").GetInt32();
        PostInit();
    }

    public MaxLevel(int level )  : base() 
    {
        this.Level = level;
        PostInit();
    }

    public static MaxLevel DeserializeMaxLevel(JsonElement _json)
    {
        return new condition.MaxLevel(_json);
    }

    public int Level { get; private set; }

    public const int __ID__ = 700922899;
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
        + "Level:" + Level + ","
        + "}";
    }

    partial void PostInit();
    partial void PostResolve();
}
}
