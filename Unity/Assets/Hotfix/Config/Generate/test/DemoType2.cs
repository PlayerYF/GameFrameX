//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;

namespace cfg.test
{
    public sealed partial class DemoType2 :  Bright.Config.BeanBase 
    {
        public DemoType2(JSONNode _json) 
        {
            { if(!_json["x4"].IsNumber) { throw new SerializationException(); }  X4 = _json["x4"]; }
            { if(!_json["x1"].IsBoolean) { throw new SerializationException(); }  X1 = _json["x1"]; }
            { if(!_json["x2"].IsNumber) { throw new SerializationException(); }  X2 = _json["x2"]; }
            { if(!_json["x3"].IsNumber) { throw new SerializationException(); }  X3 = _json["x3"]; }
            { if(!_json["x5"].IsNumber) { throw new SerializationException(); }  X5 = _json["x5"]; }
            { if(!_json["x6"].IsNumber) { throw new SerializationException(); }  X6 = _json["x6"]; }
            { if(!_json["x7"].IsNumber) { throw new SerializationException(); }  X7 = _json["x7"]; }
            { if(!_json["x8_0"].IsNumber) { throw new SerializationException(); }  X80 = _json["x8_0"]; }
            { if(!_json["x8"].IsNumber) { throw new SerializationException(); }  X8 = _json["x8"]; }
            { if(!_json["x9"].IsNumber) { throw new SerializationException(); }  X9 = _json["x9"]; }
            { if(!_json["x10"].IsString) { throw new SerializationException(); }  X10 = _json["x10"]; }
            { if(!_json["x12"].IsObject) { throw new SerializationException(); }  X12 = test.DemoType1.DeserializeDemoType1(_json["x12"]);  }
            { if(!_json["x13"].IsNumber) { throw new SerializationException(); }  X13 = (test.DemoEnum)_json["x13"].AsInt; }
            { if(!_json["x14"].IsObject) { throw new SerializationException(); }  X14 = test.DemoDynamic.DeserializeDemoDynamic(_json["x14"]);  }
            { if(!_json["s1"]["key"].IsString) { throw new SerializationException(); }  S1_l10n_key = _json["s1"]["key"]; if(!_json["s1"]["text"].IsString) { throw new SerializationException(); }  S1 = _json["s1"]["text"]; }
            { var _json2 = _json["v2"]; if(!_json2.IsObject) { throw new SerializationException(); }  float __x; { if(!_json2["x"].IsNumber) { throw new SerializationException(); }  __x = _json2["x"]; } float __y; { if(!_json2["y"].IsNumber) { throw new SerializationException(); }  __y = _json2["y"]; } V2 = new UnityEngine.Vector2(__x, __y); }
            { var _json2 = _json["v3"]; if(!_json2.IsObject) { throw new SerializationException(); } float __x; { if(!_json2["x"].IsNumber) { throw new SerializationException(); }  __x = _json2["x"]; } float __y; { if(!_json2["y"].IsNumber) { throw new SerializationException(); }  __y = _json2["y"]; } float __z; { if(!_json2["z"].IsNumber) { throw new SerializationException(); }  __z = _json2["z"]; }  V3 = new UnityEngine.Vector3(__x, __y,__z); }
            { var _json2 = _json["v4"]; if(!_json2.IsObject) { throw new SerializationException(); } float __x; { if(!_json2["x"].IsNumber) { throw new SerializationException(); }  __x = _json2["x"]; } float __y; { if(!_json2["y"].IsNumber) { throw new SerializationException(); }  __y = _json2["y"]; } float __z; { if(!_json2["z"].IsNumber) { throw new SerializationException(); }  __z = _json2["z"]; }  float __w; { if(!_json2["w"].IsNumber) { throw new SerializationException(); }  __w = _json2["w"]; } V4 = new UnityEngine.Vector4(__x, __y, __z, __w); }
            { if(!_json["t1"].IsNumber) { throw new SerializationException(); }  T1 = _json["t1"]; }
            { var __json0 = _json["k1"]; if(!__json0.IsArray) { throw new SerializationException(); } int _n0 = __json0.Count; K1 = new int[_n0]; int __index0=0; foreach(JSONNode __e0 in __json0.Children) { int __v0;  { if(!__e0.IsNumber) { throw new SerializationException(); }  __v0 = __e0; }  K1[__index0++] = __v0; }   }
            { var __json0 = _json["k2"]; if(!__json0.IsArray) { throw new SerializationException(); } K2 = new System.Collections.Generic.List<int>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { int __v0;  { if(!__e0.IsNumber) { throw new SerializationException(); }  __v0 = __e0; }  K2.Add(__v0); }   }
            { var __json0 = _json["k5"]; if(!__json0.IsArray) { throw new SerializationException(); } K5 = new System.Collections.Generic.HashSet<int>(/*__json0.Count*/); foreach(JSONNode __e0 in __json0.Children) { int __v0;  { if(!__e0.IsNumber) { throw new SerializationException(); }  __v0 = __e0; }  K5.Add(__v0); }   }
            { var __json0 = _json["k8"]; if(!__json0.IsArray) { throw new SerializationException(); } K8 = new System.Collections.Generic.Dictionary<int, int>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { int _k0;  { if(!__e0[0].IsNumber) { throw new SerializationException(); }  _k0 = __e0[0]; } int _v0;  { if(!__e0[1].IsNumber) { throw new SerializationException(); }  _v0 = __e0[1]; }  K8.Add(_k0, _v0); }   }
            { var __json0 = _json["k9"]; if(!__json0.IsArray) { throw new SerializationException(); } K9 = new System.Collections.Generic.List<test.DemoE2>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { test.DemoE2 __v0;  { if(!__e0.IsObject) { throw new SerializationException(); }  __v0 = test.DemoE2.DeserializeDemoE2(__e0);  }  K9.Add(__v0); }   }
            { var __json0 = _json["k15"]; if(!__json0.IsArray) { throw new SerializationException(); } int _n0 = __json0.Count; K15 = new test.DemoDynamic[_n0]; int __index0=0; foreach(JSONNode __e0 in __json0.Children) { test.DemoDynamic __v0;  { if(!__e0.IsObject) { throw new SerializationException(); }  __v0 = test.DemoDynamic.DeserializeDemoDynamic(__e0);  }  K15[__index0++] = __v0; }   }
            PostInit();
        }
    
        public DemoType2(int x4, bool x1, byte x2, short x3, long x5, float x6, double x7, short x8_0, int x8, long x9, string x10, test.DemoType1 x12, test.DemoEnum x13, test.DemoDynamic x14, string s1, UnityEngine.Vector2 v2, UnityEngine.Vector3 v3, UnityEngine.Vector4 v4, long t1, int[] k1, System.Collections.Generic.List<int> k2, System.Collections.Generic.HashSet<int> k5, System.Collections.Generic.Dictionary<int, int> k8, System.Collections.Generic.List<test.DemoE2> k9, test.DemoDynamic[] k15 ) 
        {
            this.X4 = x4;
            this.X1 = x1;
            this.X2 = x2;
            this.X3 = x3;
            this.X5 = x5;
            this.X6 = x6;
            this.X7 = x7;
            this.X80 = x8_0;
            this.X8 = x8;
            this.X9 = x9;
            this.X10 = x10;
            this.X12 = x12;
            this.X13 = x13;
            this.X14 = x14;
            this.S1 = s1;
            this.V2 = v2;
            this.V3 = v3;
            this.V4 = v4;
            this.T1 = t1;
            this.K1 = k1;
            this.K2 = k2;
            this.K5 = k5;
            this.K8 = k8;
            this.K9 = k9;
            this.K15 = k15;
            PostInit();
        }
    
        public static DemoType2 DeserializeDemoType2(JSONNode _json)
        {
            return new test.DemoType2(_json);
        }
    
        public int X4 { get; private set; }
        public bool X1 { get; private set; }
        public byte X2 { get; private set; }
        public short X3 { get; private set; }
        public long X5 { get; private set; }
        public float X6 { get; private set; }
        public double X7 { get; private set; }
        public short X80 { get; private set; }
        public int X8 { get; private set; }
        public long X9 { get; private set; }
        public string X10 { get; private set; }
        public test.DemoType1 X12 { get; private set; }
        public test.DemoEnum X13 { get; private set; }
        public test.DemoDynamic X14 { get; private set; }
        public string S1 { get; private set; }
        public string S1_l10n_key { get; }
        public UnityEngine.Vector2 V2 { get; private set; }
        public UnityEngine.Vector3 V3 { get; private set; }
        public UnityEngine.Vector4 V4 { get; private set; }
        public long T1 { get; private set; }
        public long T1_Millis => T1 * 1000L;
        public int[] K1 { get; private set; }
        public System.Collections.Generic.List<int> K2 { get; private set; }
        public System.Collections.Generic.HashSet<int> K5 { get; private set; }
        public System.Collections.Generic.Dictionary<int, int> K8 { get; private set; }
        public System.Collections.Generic.Dictionary<int, test.DemoType2> K8_Ref { get; private set; }
        public System.Collections.Generic.List<test.DemoE2> K9 { get; private set; }
        public test.DemoDynamic[] K15 { get; private set; }
    
        public const int __ID__ = -367048295;
        public override int GetTypeId() => __ID__;
    
        public  void Resolve(Dictionary<string, object> _tables)
        {
            X12?.Resolve(_tables);
            X14?.Resolve(_tables);
            { test.TbFullTypes __table = (test.TbFullTypes)_tables["test.TbFullTypes"]; this.K8_Ref = new System.Collections.Generic.Dictionary<int, test.DemoType2>(); foreach(var __e in K8) { this.K8_Ref.Add(__e.Key, __table.GetOrDefault(__e.Value)); } }
            foreach(var _e in K9) { _e?.Resolve(_tables); }
            foreach(var _e in K15) { _e?.Resolve(_tables); }
            PostResolve();
        }
    
        public  void TranslateText(System.Func<string, string, string> translator)
        {
            X12?.TranslateText(translator);
            X14?.TranslateText(translator);
            S1 = translator(S1_l10n_key, S1);
            foreach(var _e in K9) { _e?.TranslateText(translator); }
            foreach(var _e in K15) { _e?.TranslateText(translator); }
        }
    
        public override string ToString()
        {
            return "{ "
            + "X4:" + X4 + ","
            + "X1:" + X1 + ","
            + "X2:" + X2 + ","
            + "X3:" + X3 + ","
            + "X5:" + X5 + ","
            + "X6:" + X6 + ","
            + "X7:" + X7 + ","
            + "X80:" + X80 + ","
            + "X8:" + X8 + ","
            + "X9:" + X9 + ","
            + "X10:" + X10 + ","
            + "X12:" + X12 + ","
            + "X13:" + X13 + ","
            + "X14:" + X14 + ","
            + "S1:" + S1 + ","
            + "V2:" + V2 + ","
            + "V3:" + V3 + ","
            + "V4:" + V4 + ","
            + "T1:" + T1 + ","
            + "K1:" + Bright.Common.StringUtil.CollectionToString(K1) + ","
            + "K2:" + Bright.Common.StringUtil.CollectionToString(K2) + ","
            + "K5:" + Bright.Common.StringUtil.CollectionToString(K5) + ","
            + "K8:" + Bright.Common.StringUtil.CollectionToString(K8) + ","
            + "K9:" + Bright.Common.StringUtil.CollectionToString(K9) + ","
            + "K15:" + Bright.Common.StringUtil.CollectionToString(K15) + ","
            + "}";
        }
        
        partial void PostInit();
        partial void PostResolve();
    }
}
