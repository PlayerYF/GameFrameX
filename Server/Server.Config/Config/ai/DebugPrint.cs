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


namespace cfg.ai
{
public sealed partial class DebugPrint :  ai.Task 
{
    public DebugPrint(JsonElement _json)  : base(_json) 
    {
        Text = _json.GetProperty("text").GetString();
        PostInit();
    }

    public DebugPrint(int id, string node_name, System.Collections.Generic.List<ai.Decorator> decorators, System.Collections.Generic.List<ai.Service> services, bool ignore_restart_self, string text )  : base(id,node_name,decorators,services,ignore_restart_self) 
    {
        this.Text = text;
        PostInit();
    }

    public static DebugPrint DeserializeDebugPrint(JsonElement _json)
    {
        return new ai.DebugPrint(_json);
    }

    public string Text { get; private set; }

    public const int __ID__ = 1357409728;
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
        + "Id:" + Id + ","
        + "NodeName:" + NodeName + ","
        + "Decorators:" + StringUtil.CollectionToString(Decorators) + ","
        + "Services:" + StringUtil.CollectionToString(Services) + ","
        + "IgnoreRestartSelf:" + IgnoreRestartSelf + ","
        + "Text:" + Text + ","
        + "}";
    }

    partial void PostInit();
    partial void PostResolve();
}
}
