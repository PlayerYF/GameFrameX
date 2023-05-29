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

namespace cfg.ai
{
    public sealed partial class KeepFaceTarget :  ai.Service 
    {
        public KeepFaceTarget(JSONNode _json)  : base(_json) 
        {
            { if(!_json["target_actor_key"].IsString) { throw new SerializationException(); }  TargetActorKey = _json["target_actor_key"]; }
            PostInit();
        }
    
        public KeepFaceTarget(int id, string node_name, string target_actor_key )  : base(id,node_name) 
        {
            this.TargetActorKey = target_actor_key;
            PostInit();
        }
    
        public static KeepFaceTarget DeserializeKeepFaceTarget(JSONNode _json)
        {
            return new ai.KeepFaceTarget(_json);
        }
    
        public string TargetActorKey { get; private set; }
    
        public const int __ID__ = 1195270745;
        public override int GetTypeId() => __ID__;
    
        public override void Resolve(Dictionary<string, object> _tables)
        {
            base.Resolve(_tables);
            PostResolve();
        }
    
        public override void TranslateText(System.Func<string, string, string> translator)
        {
            base.TranslateText(translator);
        }
    
        public override string ToString()
        {
            return "{ "
            + "Id:" + Id + ","
            + "NodeName:" + NodeName + ","
            + "TargetActorKey:" + TargetActorKey + ","
            + "}";
        }
        
        partial void PostInit();
        partial void PostResolve();
    }
}
