//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Text.Json;



namespace cfg.test
{
public sealed partial class Decorator :  test.ItemBase 
{
    public Decorator(JsonElement _json)  : base(_json) 
    {
        Duration = _json.GetProperty("duration").GetInt32();
        PostInit();
    }

    public Decorator(int id, string name, string desc, int duration )  : base(id,name,desc) 
    {
        this.Duration = duration;
        PostInit();
    }

    public static Decorator DeserializeDecorator(JsonElement _json)
    {
        return new test.Decorator(_json);
    }

    public int Duration { get; private set; }

    public const int __ID__ = -625155649;
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
        + "Name:" + Name + ","
        + "Desc:" + Desc + ","
        + "Duration:" + Duration + ","
        + "}";
    }

    partial void PostInit();
    partial void PostResolve();
}
}
