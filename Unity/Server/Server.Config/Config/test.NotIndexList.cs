
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
public sealed partial class NotIndexList : Server.Config.Core.BeanBase
{
    public NotIndexList(JsonElement _buf) 
    {
        X = _buf.GetProperty("x").GetInt32();
        Y = _buf.GetProperty("y").GetInt32();
    }

    public static NotIndexList DeserializeNotIndexList(JsonElement _buf)
    {
        return new test.NotIndexList(_buf);
    }

    public readonly int X;
    public readonly int Y;
   
    public const int __ID__ = -50446599;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
        
        
    }

    public override string ToString()
    {
        return "{ "
        + "x:" + X + ","
        + "y:" + Y + ","
        + "}";
    }
}

}
