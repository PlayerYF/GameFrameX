
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Text.Json;


namespace cfg.test
{
public sealed partial class CompositeJsonTable3 : Server.Config.Core.BeanBase
{
    public CompositeJsonTable3(JsonElement _buf) 
    {
        A = _buf.GetProperty("a").GetInt32();
        B = _buf.GetProperty("b").GetInt32();
    }

    public static CompositeJsonTable3 DeserializeCompositeJsonTable3(JsonElement _buf)
    {
        return new test.CompositeJsonTable3(_buf);
    }

    public readonly int A;
    public readonly int B;
   
    public const int __ID__ = 1566207896;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
        
        
    }

    public override string ToString()
    {
        return "{ "
        + "a:" + A + ","
        + "b:" + B + ","
        + "}";
    }
}

}
