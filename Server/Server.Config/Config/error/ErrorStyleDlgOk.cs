//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Text.Json;



namespace cfg.error
{
public sealed partial class ErrorStyleDlgOk :  error.ErrorStyle 
{
    public ErrorStyleDlgOk(JsonElement _json)  : base(_json) 
    {
        BtnName = _json.GetProperty("btn_name").GetString();
        PostInit();
    }

    public ErrorStyleDlgOk(string btn_name )  : base() 
    {
        this.BtnName = btn_name;
        PostInit();
    }

    public static ErrorStyleDlgOk DeserializeErrorStyleDlgOk(JsonElement _json)
    {
        return new error.ErrorStyleDlgOk(_json);
    }

    public string BtnName { get; private set; }

    public const int __ID__ = -2010134516;
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
        + "BtnName:" + BtnName + ","
        + "}";
    }

    partial void PostInit();
    partial void PostResolve();
}
}
