
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Text.Json;


namespace cfg
{
public partial struct vec2
{
    public vec2(JsonElement _buf) 
    {
        X = _buf.GetProperty("x").GetSingle();
        Y = _buf.GetProperty("y").GetSingle();
    }

    public static vec2 Deserializevec2(JsonElement _buf)
    {
        return new vec2(_buf);
    }

    public readonly float X;
    public readonly float Y;
   

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
