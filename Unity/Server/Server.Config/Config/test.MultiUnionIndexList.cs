
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
public sealed partial class MultiUnionIndexList : Server.Config.Core.BeanBase
{
    public MultiUnionIndexList(JsonElement _buf) 
    {
        Id1 = _buf.GetProperty("id1").GetInt32();
        Id2 = _buf.GetProperty("id2").GetInt64();
        Id3 = _buf.GetProperty("id3").GetString();
        Num = _buf.GetProperty("num").GetInt32();
        Desc = _buf.GetProperty("desc").GetString();
    }

    public static MultiUnionIndexList DeserializeMultiUnionIndexList(JsonElement _buf)
    {
        return new test.MultiUnionIndexList(_buf);
    }

    public readonly int Id1;
    public readonly long Id2;
    public readonly string Id3;
    public readonly int Num;
    public readonly string Desc;
   
    public const int __ID__ = 1966847134;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
        
        
        
        
        
    }

    public override string ToString()
    {
        return "{ "
        + "id1:" + Id1 + ","
        + "id2:" + Id2 + ","
        + "id3:" + Id3 + ","
        + "num:" + Num + ","
        + "desc:" + Desc + ","
        + "}";
    }
}

}
