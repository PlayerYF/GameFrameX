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
public sealed partial class ExcelFromJson :  BeanBase 
{
    public ExcelFromJson(JsonElement _json) 
    {
        X4 = _json.GetProperty("x4").GetInt32();
        X1 = _json.GetProperty("x1").GetBoolean();
        X5 = _json.GetProperty("x5").GetInt64();
        X6 = _json.GetProperty("x6").GetSingle();
        S1 = _json.GetProperty("s1").GetString();
        S2_l10n_key = _json.GetProperty("s2").GetProperty("key").GetString();S2 = _json.GetProperty("s2").GetProperty("text").GetString();
        { var _json0 = _json.GetProperty("v2"); float __x; __x = _json0.GetProperty("x").GetSingle(); float __y; __y = _json0.GetProperty("y").GetSingle(); V2 = new System.Numerics.Vector2(__x, __y); }
        { var _json0 = _json.GetProperty("v3"); float __x; __x = _json0.GetProperty("x").GetSingle(); float __y; __y = _json0.GetProperty("y").GetSingle(); float __z; __z = _json0.GetProperty("z").GetSingle();  V3 = new System.Numerics.Vector3(__x, __y,__z); }
        { var _json0 = _json.GetProperty("v4"); float __x; __x = _json0.GetProperty("x").GetSingle(); float __y; __y = _json0.GetProperty("y").GetSingle(); float __z; __z = _json0.GetProperty("z").GetSingle();  float __w; __w = _json0.GetProperty("w").GetSingle(); V4 = new System.Numerics.Vector4(__x, __y, __z, __w); }
        T1 = _json.GetProperty("t1").GetInt64();
        X12 = test.DemoType1.DeserializeDemoType1(_json.GetProperty("x12"));
        X13 = (test.DemoEnum)_json.GetProperty("x13").GetInt32();
        X14 = test.DemoDynamic.DeserializeDemoDynamic(_json.GetProperty("x14"));
        { var __json0 = _json.GetProperty("k1"); int _n0 = __json0.GetArrayLength(); K1 = new int[_n0]; int __index0=0; foreach(JsonElement __e0 in __json0.EnumerateArray()) { int __v0;  __v0 = __e0.GetInt32();  K1[__index0++] = __v0; }   }
        { var __json0 = _json.GetProperty("k8"); K8 = new System.Collections.Generic.Dictionary<int, int>(__json0.GetArrayLength()); foreach(JsonElement __e0 in __json0.EnumerateArray()) { int _k0;  _k0 = __e0[0].GetInt32(); int _v0;  _v0 = __e0[1].GetInt32();  K8.Add(_k0, _v0); }   }
        { var __json0 = _json.GetProperty("k9"); K9 = new System.Collections.Generic.List<test.DemoE2>(__json0.GetArrayLength()); foreach(JsonElement __e0 in __json0.EnumerateArray()) { test.DemoE2 __v0;  __v0 = test.DemoE2.DeserializeDemoE2(__e0);  K9.Add(__v0); }   }
        { var __json0 = _json.GetProperty("k15"); int _n0 = __json0.GetArrayLength(); K15 = new test.DemoDynamic[_n0]; int __index0=0; foreach(JsonElement __e0 in __json0.EnumerateArray()) { test.DemoDynamic __v0;  __v0 = test.DemoDynamic.DeserializeDemoDynamic(__e0);  K15[__index0++] = __v0; }   }
        PostInit();
    }

    public ExcelFromJson(int x4, bool x1, long x5, float x6, string s1, string s2, System.Numerics.Vector2 v2, System.Numerics.Vector3 v3, System.Numerics.Vector4 v4, long t1, test.DemoType1 x12, test.DemoEnum x13, test.DemoDynamic x14, int[] k1, System.Collections.Generic.Dictionary<int, int> k8, System.Collections.Generic.List<test.DemoE2> k9, test.DemoDynamic[] k15 ) 
    {
        this.X4 = x4;
        this.X1 = x1;
        this.X5 = x5;
        this.X6 = x6;
        this.S1 = s1;
        this.S2 = s2;
        this.V2 = v2;
        this.V3 = v3;
        this.V4 = v4;
        this.T1 = t1;
        this.X12 = x12;
        this.X13 = x13;
        this.X14 = x14;
        this.K1 = k1;
        this.K8 = k8;
        this.K9 = k9;
        this.K15 = k15;
        PostInit();
    }

    public static ExcelFromJson DeserializeExcelFromJson(JsonElement _json)
    {
        return new test.ExcelFromJson(_json);
    }

    public int X4 { get; private set; }
    public bool X1 { get; private set; }
    public long X5 { get; private set; }
    public float X6 { get; private set; }
    public string S1 { get; private set; }
    public string S2 { get; private set; }
    public string S2_l10n_key { get; }
    public System.Numerics.Vector2 V2 { get; private set; }
    public System.Numerics.Vector3 V3 { get; private set; }
    public System.Numerics.Vector4 V4 { get; private set; }
    public long T1 { get; private set; }
    public long T1_Millis => T1 * 1000L;
    public test.DemoType1 X12 { get; private set; }
    public test.DemoEnum X13 { get; private set; }
    public test.DemoDynamic X14 { get; private set; }
    public int[] K1 { get; private set; }
    public System.Collections.Generic.Dictionary<int, int> K8 { get; private set; }
    public System.Collections.Generic.List<test.DemoE2> K9 { get; private set; }
    public test.DemoDynamic[] K15 { get; private set; }

    public const int __ID__ = -1485706483;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        X12?.Resolve(_tables);
        X14?.Resolve(_tables);
        foreach(var _e in K9) { _e?.Resolve(_tables); }
        foreach(var _e in K15) { _e?.Resolve(_tables); }
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        S2 = translator(S2_l10n_key, S2);
        X12?.TranslateText(translator);
        X14?.TranslateText(translator);
        foreach(var _e in K9) { _e?.TranslateText(translator); }
        foreach(var _e in K15) { _e?.TranslateText(translator); }
    }

    public override string ToString()
    {
        return "{ "
        + "X4:" + X4 + ","
        + "X1:" + X1 + ","
        + "X5:" + X5 + ","
        + "X6:" + X6 + ","
        + "S1:" + S1 + ","
        + "S2:" + S2 + ","
        + "V2:" + V2 + ","
        + "V3:" + V3 + ","
        + "V4:" + V4 + ","
        + "T1:" + T1 + ","
        + "X12:" + X12 + ","
        + "X13:" + X13 + ","
        + "X14:" + X14 + ","
        + "K1:" + StringUtil.CollectionToString(K1) + ","
        + "K8:" + StringUtil.CollectionToString(K8) + ","
        + "K9:" + StringUtil.CollectionToString(K9) + ","
        + "K15:" + StringUtil.CollectionToString(K15) + ","
        + "}";
    }

    partial void PostInit();
    partial void PostResolve();
}
}
