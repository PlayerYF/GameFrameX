//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Text.Json;



namespace cfg.ai
{
public sealed partial class StringKeyData :  ai.KeyData 
{
    public StringKeyData(JsonElement _json)  : base(_json) 
    {
        Value = _json.GetProperty("value").GetString();
        PostInit();
    }

    public StringKeyData(string value )  : base() 
    {
        this.Value = value;
        PostInit();
    }

    public static StringKeyData DeserializeStringKeyData(JsonElement _json)
    {
        return new ai.StringKeyData(_json);
    }

    public string Value { get; private set; }

    public const int __ID__ = -307888654;
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
        + "Value:" + Value + ","
        + "}";
    }

    partial void PostInit();
    partial void PostResolve();
}
}
