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


namespace cfg.test
{
public abstract partial class Shape :  BeanBase 
{
    public Shape(JsonElement _json) 
    {
        PostInit();
    }

    public Shape() 
    {
        PostInit();
    }

    public static Shape DeserializeShape(JsonElement _json)
    {
        switch (_json.GetProperty("$type").GetString())
        {
            case "Circle": return new test.Circle(_json);
            case "test2.Rectangle": return new test2.Rectangle(_json);
            default: throw new SerializationException();
        }
    }



    public virtual void Resolve(Dictionary<string, object> _tables)
    {
        PostResolve();
    }

    public virtual void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "}";
    }

    partial void PostInit();
    partial void PostResolve();
}
}
