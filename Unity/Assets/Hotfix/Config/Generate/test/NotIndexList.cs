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
    public sealed partial class NotIndexList :  Bright.Config.BeanBase 
    {
        public NotIndexList(JSONNode _json) 
        {
            { if(!_json["x"].IsNumber) { throw new SerializationException(); }  X = _json["x"]; }
            { if(!_json["y"].IsNumber) { throw new SerializationException(); }  Y = _json["y"]; }
            PostInit();
        }
    
        public NotIndexList(int x, int y ) 
        {
            this.X = x;
            this.Y = y;
            PostInit();
        }
    
        public static NotIndexList DeserializeNotIndexList(JSONNode _json)
        {
            return new test.NotIndexList(_json);
        }
    
        public int X { get; private set; }
        public int Y { get; private set; }
    
        public const int __ID__ = -50446599;
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
            + "X:" + X + ","
            + "Y:" + Y + ","
            + "}";
        }
        
        partial void PostInit();
        partial void PostResolve();
    }
}
