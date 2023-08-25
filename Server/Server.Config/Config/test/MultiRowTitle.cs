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
public sealed partial class MultiRowTitle :  BeanBase 
{
    public MultiRowTitle(JsonElement _json) 
    {
        Id = _json.GetProperty("id").GetInt32();
        Name = _json.GetProperty("name").GetString();
        X1 = test.H1.DeserializeH1(_json.GetProperty("x1"));
        { if (_json.TryGetProperty("x2_0", out var _j) && _j.ValueKind != JsonValueKind.Null) { X20 = test.H2.DeserializeH2(_j); } else { X20 = null; } }
        { var __json0 = _json.GetProperty("x2"); X2 = new System.Collections.Generic.List<test.H2>(__json0.GetArrayLength()); foreach(JsonElement __e0 in __json0.EnumerateArray()) { test.H2 __v0;  __v0 = test.H2.DeserializeH2(__e0);  X2.Add(__v0); }   }
        { var __json0 = _json.GetProperty("x3"); int _n0 = __json0.GetArrayLength(); X3 = new test.H2[_n0]; int __index0=0; foreach(JsonElement __e0 in __json0.EnumerateArray()) { test.H2 __v0;  __v0 = test.H2.DeserializeH2(__e0);  X3[__index0++] = __v0; }   }
        { var __json0 = _json.GetProperty("x4"); int _n0 = __json0.GetArrayLength(); X4 = new test.H2[_n0]; int __index0=0; foreach(JsonElement __e0 in __json0.EnumerateArray()) { test.H2 __v0;  __v0 = test.H2.DeserializeH2(__e0);  X4[__index0++] = __v0; }   }
        PostInit();
    }

    public MultiRowTitle(int id, string name, test.H1 x1, test.H2 x2_0, System.Collections.Generic.List<test.H2> x2, test.H2[] x3, test.H2[] x4 ) 
    {
        this.Id = id;
        this.Name = name;
        this.X1 = x1;
        this.X20 = x2_0;
        this.X2 = x2;
        this.X3 = x3;
        this.X4 = x4;
        PostInit();
    }

    public static MultiRowTitle DeserializeMultiRowTitle(JsonElement _json)
    {
        return new test.MultiRowTitle(_json);
    }

    public int Id { get; private set; }
    public string Name { get; private set; }
    public test.H1 X1 { get; private set; }
    public test.H2 X20 { get; private set; }
    public System.Collections.Generic.List<test.H2> X2 { get; private set; }
    public test.H2[] X3 { get; private set; }
    public test.H2[] X4 { get; private set; }

    public const int __ID__ = 540002427;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        X1?.Resolve(_tables);
        X20?.Resolve(_tables);
        foreach(var _e in X2) { _e?.Resolve(_tables); }
        foreach(var _e in X3) { _e?.Resolve(_tables); }
        foreach(var _e in X4) { _e?.Resolve(_tables); }
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        X1?.TranslateText(translator);
        X20?.TranslateText(translator);
        foreach(var _e in X2) { _e?.TranslateText(translator); }
        foreach(var _e in X3) { _e?.TranslateText(translator); }
        foreach(var _e in X4) { _e?.TranslateText(translator); }
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "Name:" + Name + ","
        + "X1:" + X1 + ","
        + "X20:" + X20 + ","
        + "X2:" + StringUtil.CollectionToString(X2) + ","
        + "X3:" + StringUtil.CollectionToString(X3) + ","
        + "X4:" + StringUtil.CollectionToString(X4) + ","
        + "}";
    }

    partial void PostInit();
    partial void PostResolve();
}
}
