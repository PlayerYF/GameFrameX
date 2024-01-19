
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LuBan.Runtime;
using SimpleJSON;


namespace cfg.common
{
    
    public sealed partial class GlobalConfig : LuBan.Runtime.BeanBase
    {
        public GlobalConfig(JSONNode _buf) 
        {
            { if(!_buf["x1"].IsNumber) { throw new SerializationException(); }  X1 = _buf["x1"]; }
            { if(!_buf["x2"].IsNumber) { throw new SerializationException(); }  X2 = _buf["x2"]; }
            { if(!_buf["x3"].IsNumber) { throw new SerializationException(); }  X3 = _buf["x3"]; }
            { if(!_buf["x4"].IsNumber) { throw new SerializationException(); }  X4 = _buf["x4"]; }
            { if(!_buf["x5"].IsNumber) { throw new SerializationException(); }  X5 = _buf["x5"]; }
            { if(!_buf["x6"].IsNumber) { throw new SerializationException(); }  X6 = _buf["x6"]; }
            { var __json0 = _buf["x7"]; if(!__json0.IsArray) { throw new SerializationException(); } X7 = new System.Collections.Generic.List<int>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { int __v0;  { if(!__e0.IsNumber) { throw new SerializationException(); }  __v0 = __e0; }  X7.Add(__v0); }   }
        }
    
        public static GlobalConfig DeserializeGlobalConfig(JSONNode _buf)
        {
            return new common.GlobalConfig(_buf);
        }
    
        /// <summary>
        /// 背包容量
        /// </summary>
        public readonly int X1;
        public readonly int X2;
        public readonly int X3;
        public readonly int X4;
        public readonly int X5;
        public readonly int X6;
        public readonly System.Collections.Generic.List<int> X7;
       
        public const int __ID__ = -848234488;
        public override int GetTypeId() => __ID__;
    
        public  void ResolveRef(Tables tables)
        {
            
            
            
            
            
            
            
        }
    
        public override string ToString()
        {
            return "{ "
            + "x1:" + X1 + ","
            + "x2:" + X2 + ","
            + "x3:" + X3 + ","
            + "x4:" + X4 + ","
            + "x5:" + X5 + ","
            + "x6:" + X6 + ","
            + "x7:" + StringUtil.CollectionToString(X7) + ","
            + "}";
        }
    }

}
