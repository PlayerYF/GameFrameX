
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Text.Json;


namespace cfg.ai
{
public sealed partial class FloatKeyData : ai.KeyData
{
    public FloatKeyData(JsonElement _buf)  : base(_buf) 
    {
        Value = _buf.GetProperty("value").GetSingle();
    }

    public static FloatKeyData DeserializeFloatKeyData(JsonElement _buf)
    {
        return new ai.FloatKeyData(_buf);
    }

    public readonly float Value;
   
    public const int __ID__ = -719747885;
    public override int GetTypeId() => __ID__;

    public override void ResolveRef(Tables tables)
    {
        base.ResolveRef(tables);
        
    }

    public override string ToString()
    {
        return "{ "
        + "value:" + Value + ","
        + "}";
    }
}

}
