
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
public sealed partial class MultiRowType2 : Server.Config.Core.BeanBase
{
    public MultiRowType2(JsonElement _buf) 
    {
        Id = _buf.GetProperty("id").GetInt32();
        X = _buf.GetProperty("x").GetInt32();
        Y = _buf.GetProperty("y").GetSingle();
    }

    public static MultiRowType2 DeserializeMultiRowType2(JsonElement _buf)
    {
        return new test.MultiRowType2(_buf);
    }

    public readonly int Id;
    public readonly int X;
    public readonly float Y;
   
    public const int __ID__ = 540474971;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
        
        
        
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "x:" + X + ","
        + "y:" + Y + ","
        + "}";
    }
}

}
