
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
    
    public sealed partial class TestNull : LuBan.Runtime.BeanBase
    {
        public TestNull(JSONNode _buf) 
        {
            { if(!_buf["id"].IsNumber) { throw new SerializationException(); }  Id = _buf["id"]; }
            { var _j = _buf["x1"]; if (_j.Tag != JSONNodeType.None && _j.Tag != JSONNodeType.NullValue) { { if(!_j.IsNumber) { throw new SerializationException(); }  X1 = _j; } } else { X1 = null; } }
            { var _j = _buf["x2"]; if (_j.Tag != JSONNodeType.None && _j.Tag != JSONNodeType.NullValue) { { if(!_j.IsNumber) { throw new SerializationException(); }  X2 = (test.DemoEnum?)_j.AsInt; } } else { X2 = null; } }
            { var _j = _buf["x3"]; if (_j.Tag != JSONNodeType.None && _j.Tag != JSONNodeType.NullValue) { { if(!_j.IsObject) { throw new SerializationException(); }  X3 = test.DemoType1.DeserializeDemoType1(_j);  } } else { X3 = null; } }
            { var _j = _buf["x4"]; if (_j.Tag != JSONNodeType.None && _j.Tag != JSONNodeType.NullValue) { { if(!_j.IsObject) { throw new SerializationException(); }  X4 = test.DemoDynamic.DeserializeDemoDynamic(_j);  } } else { X4 = null; } }
            { var _j = _buf["s1"]; if (_j.Tag != JSONNodeType.None && _j.Tag != JSONNodeType.NullValue) { { if(!_j.IsString) { throw new SerializationException(); }  S1 = _j; } } else { S1 = null; } }
            { var _j = _buf["s2"]; if (_j.Tag != JSONNodeType.None && _j.Tag != JSONNodeType.NullValue) { { if(!_j.IsString) { throw new SerializationException(); }  S2 = _j; } } else { S2 = null; } }
        }
    
        public static TestNull DeserializeTestNull(JSONNode _buf)
        {
            return new test.TestNull(_buf);
        }
    
        public readonly int Id;
        public readonly int? X1;
        public readonly test.DemoEnum? X2;
        public readonly test.DemoType1 X3;
        public readonly test.DemoDynamic X4;
        public readonly string S1;
        public readonly string S2;
       
        public const int __ID__ = 339868469;
        public override int GetTypeId() => __ID__;
    
        public  void ResolveRef(Tables tables)
        {
            
            
            
            X3?.ResolveRef(tables);
            X4?.ResolveRef(tables);
            
            
        }
    
        public override string ToString()
        {
            return "{ "
            + "id:" + Id + ","
            + "x1:" + X1 + ","
            + "x2:" + X2 + ","
            + "x3:" + X3 + ","
            + "x4:" + X4 + ","
            + "s1:" + S1 + ","
            + "s2:" + S2 + ","
            + "}";
        }
    }

}
