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
public sealed partial class TestSep :  BeanBase 
{
    public TestSep(JsonElement _json) 
    {
        Id = _json.GetProperty("id").GetInt32();
        X1_l10n_key = _json.GetProperty("x1").GetProperty("key").GetString();X1 = _json.GetProperty("x1").GetProperty("text").GetString();
        X2 = test.SepBean1.DeserializeSepBean1(_json.GetProperty("x2"));
        X3 = test.SepVector.DeserializeSepVector(_json.GetProperty("x3"));
        { var __json0 = _json.GetProperty("x4"); X4 = new System.Collections.Generic.List<test.SepVector>(__json0.GetArrayLength()); foreach(JsonElement __e0 in __json0.EnumerateArray()) { test.SepVector __v0;  __v0 = test.SepVector.DeserializeSepVector(__e0);  X4.Add(__v0); }   }
        { var __json0 = _json.GetProperty("x5"); X5 = new System.Collections.Generic.List<test.SepBean1>(__json0.GetArrayLength()); foreach(JsonElement __e0 in __json0.EnumerateArray()) { test.SepBean1 __v0;  __v0 = test.SepBean1.DeserializeSepBean1(__e0);  X5.Add(__v0); }   }
        { var __json0 = _json.GetProperty("x6"); X6 = new System.Collections.Generic.List<test.SepBean1>(__json0.GetArrayLength()); foreach(JsonElement __e0 in __json0.EnumerateArray()) { test.SepBean1 __v0;  __v0 = test.SepBean1.DeserializeSepBean1(__e0);  X6.Add(__v0); }   }
        PostInit();
    }

    public TestSep(int id, string x1, test.SepBean1 x2, test.SepVector x3, System.Collections.Generic.List<test.SepVector> x4, System.Collections.Generic.List<test.SepBean1> x5, System.Collections.Generic.List<test.SepBean1> x6 ) 
    {
        this.Id = id;
        this.X1 = x1;
        this.X2 = x2;
        this.X3 = x3;
        this.X4 = x4;
        this.X5 = x5;
        this.X6 = x6;
        PostInit();
    }

    public static TestSep DeserializeTestSep(JsonElement _json)
    {
        return new test.TestSep(_json);
    }

    public int Id { get; private set; }
    public string X1 { get; private set; }
    public string X1_l10n_key { get; }
    public test.SepBean1 X2 { get; private set; }
    /// <summary>
    /// SepVector已经定义了sep=,属性
    /// </summary>
    public test.SepVector X3 { get; private set; }
    /// <summary>
    /// 用;来分割数据，然后顺序读入SepVector
    /// </summary>
    public System.Collections.Generic.List<test.SepVector> X4 { get; private set; }
    /// <summary>
    /// 用,分割数据，然后顺序读入
    /// </summary>
    public System.Collections.Generic.List<test.SepBean1> X5 { get; private set; }
    /// <summary>
    /// 用;分割数据，然后再将每个数据用,分割，读入
    /// </summary>
    public System.Collections.Generic.List<test.SepBean1> X6 { get; private set; }

    public const int __ID__ = -543221520;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        X2?.Resolve(_tables);
        X3?.Resolve(_tables);
        foreach(var _e in X4) { _e?.Resolve(_tables); }
        foreach(var _e in X5) { _e?.Resolve(_tables); }
        foreach(var _e in X6) { _e?.Resolve(_tables); }
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        X1 = translator(X1_l10n_key, X1);
        X2?.TranslateText(translator);
        X3?.TranslateText(translator);
        foreach(var _e in X4) { _e?.TranslateText(translator); }
        foreach(var _e in X5) { _e?.TranslateText(translator); }
        foreach(var _e in X6) { _e?.TranslateText(translator); }
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "X1:" + X1 + ","
        + "X2:" + X2 + ","
        + "X3:" + X3 + ","
        + "X4:" + StringUtil.CollectionToString(X4) + ","
        + "X5:" + StringUtil.CollectionToString(X5) + ","
        + "X6:" + StringUtil.CollectionToString(X6) + ","
        + "}";
    }

    partial void PostInit();
    partial void PostResolve();
}
}
