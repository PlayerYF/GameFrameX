
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
    
    public sealed partial class Equipment : test.ItemBase
    {
        public Equipment(JSONNode _buf)  : base(_buf) 
        {
            { if(!_buf["attr"].IsNumber) { throw new SerializationException(); }  Attr = (test.DemoEnum)_buf["attr"].AsInt; }
            { if(!_buf["value"].IsNumber) { throw new SerializationException(); }  Value = _buf["value"]; }
        }
    
        public static Equipment DeserializeEquipment(JSONNode _buf)
        {
            return new test.Equipment(_buf);
        }
    
        public readonly test.DemoEnum Attr;
        public readonly int Value;
       
        public const int __ID__ = -76837102;
        public override int GetTypeId() => __ID__;
    
        public override void ResolveRef(Tables tables)
        {
            base.ResolveRef(tables);
            
            
        }
    
        public override string ToString()
        {
            return "{ "
            + "id:" + Id + ","
            + "name:" + Name + ","
            + "desc:" + Desc + ","
            + "attr:" + Attr + ","
            + "value:" + Value + ","
            + "}";
        }
    }

}
