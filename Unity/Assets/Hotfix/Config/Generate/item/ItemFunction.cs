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

namespace cfg.item
{
    public sealed partial class ItemFunction :  Bright.Config.BeanBase 
    {
        public ItemFunction(JSONNode _json) 
        {
            { if(!_json["minor_type"].IsNumber) { throw new SerializationException(); }  MinorType = (item.EMinorType)_json["minor_type"].AsInt; }
            { if(!_json["func_type"].IsNumber) { throw new SerializationException(); }  FuncType = (item.EItemFunctionType)_json["func_type"].AsInt; }
            { if(!_json["method"].IsString) { throw new SerializationException(); }  Method = _json["method"]; }
            { if(!_json["close_bag_ui"].IsBoolean) { throw new SerializationException(); }  CloseBagUi = _json["close_bag_ui"]; }
            PostInit();
        }
    
        public ItemFunction(item.EMinorType minor_type, item.EItemFunctionType func_type, string method, bool close_bag_ui ) 
        {
            this.MinorType = minor_type;
            this.FuncType = func_type;
            this.Method = method;
            this.CloseBagUi = close_bag_ui;
            PostInit();
        }
    
        public static ItemFunction DeserializeItemFunction(JSONNode _json)
        {
            return new item.ItemFunction(_json);
        }
    
        public item.EMinorType MinorType { get; private set; }
        public item.EItemFunctionType FuncType { get; private set; }
        public string Method { get; private set; }
        public bool CloseBagUi { get; private set; }
    
        public const int __ID__ = 1205824294;
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
            + "MinorType:" + MinorType + ","
            + "FuncType:" + FuncType + ","
            + "Method:" + Method + ","
            + "CloseBagUi:" + CloseBagUi + ","
            + "}";
        }
        
        partial void PostInit();
        partial void PostResolve();
    }
}
