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
public sealed partial class Equipment :  test.ItemBase 
{
    public Equipment(JsonElement _json)  : base(_json) 
    {
        Attr = (test.DemoEnum)_json.GetProperty("attr").GetInt32();
        Value = _json.GetProperty("value").GetInt32();
        PostInit();
    }

    public Equipment(int id, string name, string desc, test.DemoEnum attr, int value )  : base(id,name,desc) 
    {
        this.Attr = attr;
        this.Value = value;
        PostInit();
    }

    public static Equipment DeserializeEquipment(JsonElement _json)
    {
        return new test.Equipment(_json);
    }

    public test.DemoEnum Attr { get; private set; }
    public int Value { get; private set; }

    public const int __ID__ = -76837102;
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
        + "Attr:" + Attr + ","
        + "Value:" + Value + ","
        + "}";
    }

    partial void PostInit();
    partial void PostResolve();
}
}
