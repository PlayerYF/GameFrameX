
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LuBan.Runtime;
using SimpleJSON;


namespace cfg.test
{
    
    public sealed partial class DemoType2 : LuBan.Runtime.BeanBase
    {
        public DemoType2(JSONNode _buf) 
        {
            { if(!_buf["x4"].IsNumber) { throw new SerializationException(); }  X4 = _buf["x4"]; }
            { if(!_buf["x1"].IsBoolean) { throw new SerializationException(); }  X1 = _buf["x1"]; }
            { if(!_buf["x2"].IsNumber) { throw new SerializationException(); }  X2 = _buf["x2"]; }
            { if(!_buf["x3"].IsNumber) { throw new SerializationException(); }  X3 = _buf["x3"]; }
            { if(!_buf["x5"].IsNumber) { throw new SerializationException(); }  X5 = _buf["x5"]; }
            { if(!_buf["x6"].IsNumber) { throw new SerializationException(); }  X6 = _buf["x6"]; }
            { if(!_buf["x7"].IsNumber) { throw new SerializationException(); }  X7 = _buf["x7"]; }
            { if(!_buf["x8_0"].IsNumber) { throw new SerializationException(); }  X80 = _buf["x8_0"]; }
            { if(!_buf["x8"].IsNumber) { throw new SerializationException(); }  X8 = _buf["x8"]; }
            { if(!_buf["x9"].IsNumber) { throw new SerializationException(); }  X9 = _buf["x9"]; }
            { if(!_buf["x10"].IsString) { throw new SerializationException(); }  X10 = _buf["x10"]; }
            { if(!_buf["x12"].IsObject) { throw new SerializationException(); }  X12 = test.DemoType1.DeserializeDemoType1(_buf["x12"]);  }
            { if(!_buf["x13"].IsNumber) { throw new SerializationException(); }  X13 = (test.DemoEnum)_buf["x13"].AsInt; }
            { if(!_buf["x14"].IsObject) { throw new SerializationException(); }  X14 = test.DemoDynamic.DeserializeDemoDynamic(_buf["x14"]);  }
            { if(!_buf["s1"].IsString) { throw new SerializationException(); }  S1 = _buf["s1"]; }
            { if(!_buf["t1"].IsNumber) { throw new SerializationException(); }  T1 = _buf["t1"]; }
            { var __json0 = _buf["k1"]; if(!__json0.IsArray) { throw new SerializationException(); } int _n0 = __json0.Count; K1 = new int[_n0]; int __index0=0; foreach(JSONNode __e0 in __json0.Children) { int __v0;  { if(!__e0.IsNumber) { throw new SerializationException(); }  __v0 = __e0; }  K1[__index0++] = __v0; }   }
            { var __json0 = _buf["k2"]; if(!__json0.IsArray) { throw new SerializationException(); } K2 = new System.Collections.Generic.List<int>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { int __v0;  { if(!__e0.IsNumber) { throw new SerializationException(); }  __v0 = __e0; }  K2.Add(__v0); }   }
            { var __json0 = _buf["k5"]; if(!__json0.IsArray) { throw new SerializationException(); } K5 = new System.Collections.Generic.HashSet<int>(/*__json0.Count*/); foreach(JSONNode __e0 in __json0.Children) { int __v0;  { if(!__e0.IsNumber) { throw new SerializationException(); }  __v0 = __e0; }  K5.Add(__v0); }   }
            { var __json0 = _buf["k8"]; if(!__json0.IsArray) { throw new SerializationException(); } K8 = new System.Collections.Generic.Dictionary<int, int>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { int _k0;  { if(!__e0[0].IsNumber) { throw new SerializationException(); }  _k0 = __e0[0]; } int _v0;  { if(!__e0[1].IsNumber) { throw new SerializationException(); }  _v0 = __e0[1]; }  K8.Add(_k0, _v0); }   }
            { var __json0 = _buf["k9"]; if(!__json0.IsArray) { throw new SerializationException(); } K9 = new System.Collections.Generic.List<test.DemoE2>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { test.DemoE2 __v0;  { if(!__e0.IsObject) { throw new SerializationException(); }  __v0 = test.DemoE2.DeserializeDemoE2(__e0);  }  K9.Add(__v0); }   }
            { var __json0 = _buf["k15"]; if(!__json0.IsArray) { throw new SerializationException(); } int _n0 = __json0.Count; K15 = new test.DemoDynamic[_n0]; int __index0=0; foreach(JSONNode __e0 in __json0.Children) { test.DemoDynamic __v0;  { if(!__e0.IsObject) { throw new SerializationException(); }  __v0 = test.DemoDynamic.DeserializeDemoDynamic(__e0);  }  K15[__index0++] = __v0; }   }
        }
    
        public static DemoType2 DeserializeDemoType2(JSONNode _buf)
        {
            return new test.DemoType2(_buf);
        }
    
        public readonly int X4;
        public readonly bool X1;
        public readonly byte X2;
        public readonly short X3;
        public readonly long X5;
        public readonly float X6;
        public readonly double X7;
        public readonly short X80;
        public readonly int X8;
        public readonly long X9;
        public readonly string X10;
        public readonly test.DemoType1 X12;
        public readonly test.DemoEnum X13;
        public readonly test.DemoDynamic X14;
        public readonly string S1;
        public readonly long T1;
        public readonly int[] K1;
        public readonly System.Collections.Generic.List<int> K2;
        public readonly System.Collections.Generic.HashSet<int> K5;
        public readonly System.Collections.Generic.Dictionary<int, int> K8;
        public System.Collections.Generic.Dictionary<int, test.DemoType2> K8_Ref;
        public readonly System.Collections.Generic.List<test.DemoE2> K9;
        public readonly test.DemoDynamic[] K15;
       
        public const int __ID__ = -367048295;
        public override int GetTypeId() => __ID__;
    
        public  void ResolveRef(Tables tables)
        {
            
            
            
            
            
            
            
            
            
            
            
            X12?.ResolveRef(tables);
            
            X14?.ResolveRef(tables);
            
            
            
            
            
            K8_Ref = new System.Collections.Generic.Dictionary<int, test.DemoType2>();
            foreach (var _kv in K8) { K8_Ref.Add(_kv.Key, tables.TbFullTypes.GetOrDefault(_kv.Value)); }

            
            foreach (var _e in K15) { _e?.ResolveRef(tables); }
        }
    
        public override string ToString()
        {
            return "{ "
            + "x4:" + X4 + ","
            + "x1:" + X1 + ","
            + "x2:" + X2 + ","
            + "x3:" + X3 + ","
            + "x5:" + X5 + ","
            + "x6:" + X6 + ","
            + "x7:" + X7 + ","
            + "x80:" + X80 + ","
            + "x8:" + X8 + ","
            + "x9:" + X9 + ","
            + "x10:" + X10 + ","
            + "x12:" + X12 + ","
            + "x13:" + X13 + ","
            + "x14:" + X14 + ","
            + "s1:" + S1 + ","
            + "t1:" + T1 + ","
            + "k1:" + StringUtil.CollectionToString(K1) + ","
            + "k2:" + StringUtil.CollectionToString(K2) + ","
            + "k5:" + StringUtil.CollectionToString(K5) + ","
            + "k8:" + StringUtil.CollectionToString(K8) + ","
            + "k9:" + StringUtil.CollectionToString(K9) + ","
            + "k15:" + StringUtil.CollectionToString(K15) + ","
            + "}";
        }
    }

}
