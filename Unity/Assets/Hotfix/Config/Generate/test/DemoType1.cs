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
    public sealed partial class DemoType1 :  Bright.Config.BeanBase 
    {
        public DemoType1(JSONNode _json) 
        {
            { if(!_json["x1"].IsNumber) { throw new SerializationException(); }  X1 = _json["x1"]; }
            PostInit();
        }
    
        public DemoType1(int x1 ) 
        {
            this.X1 = x1;
            PostInit();
        }
    
        public static DemoType1 DeserializeDemoType1(JSONNode _json)
        {
            return new test.DemoType1(_json);
        }
    
        public int X1 { get; private set; }
    
        public const int __ID__ = -367048296;
        public override int GetTypeId() => __ID__;
    
        public  void Resolve(Dictionary<string, object> _tables)
        {
            PostResolve();
        }
    
        public  void TranslateText(System.Func<string, string, string> translator)
        {
        }
    
        public override string ToString()
        {
            return "{ "
            + "X1:" + X1 + ","
            + "}";
        }
        
        partial void PostInit();
        partial void PostResolve();
    }
}
