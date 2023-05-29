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
    public abstract partial class FlowNode :  ai.Node 
    {
        public FlowNode(JSONNode _json)  : base(_json) 
        {
            { var __json0 = _json["decorators"]; if(!__json0.IsArray) { throw new SerializationException(); } Decorators = new System.Collections.Generic.List<ai.Decorator>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { ai.Decorator __v0;  { if(!__e0.IsObject) { throw new SerializationException(); }  __v0 = ai.Decorator.DeserializeDecorator(__e0);  }  Decorators.Add(__v0); }   }
            { var __json0 = _json["services"]; if(!__json0.IsArray) { throw new SerializationException(); } Services = new System.Collections.Generic.List<ai.Service>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { ai.Service __v0;  { if(!__e0.IsObject) { throw new SerializationException(); }  __v0 = ai.Service.DeserializeService(__e0);  }  Services.Add(__v0); }   }
            PostInit();
        }
    
        public FlowNode(int id, string node_name, System.Collections.Generic.List<ai.Decorator> decorators, System.Collections.Generic.List<ai.Service> services )  : base(id,node_name) 
        {
            this.Decorators = decorators;
            this.Services = services;
            PostInit();
        }
    
        public static FlowNode DeserializeFlowNode(JSONNode _json)
        {
            string type = _json["$type"];
            switch (type)
            {
                case "Sequence": return new ai.Sequence(_json);
                case "Selector": return new ai.Selector(_json);
                case "SimpleParallel": return new ai.SimpleParallel(_json);
                case "UeWait": return new ai.UeWait(_json);
                case "UeWaitBlackboardTime": return new ai.UeWaitBlackboardTime(_json);
                case "MoveToTarget": return new ai.MoveToTarget(_json);
                case "ChooseSkill": return new ai.ChooseSkill(_json);
                case "MoveToRandomLocation": return new ai.MoveToRandomLocation(_json);
                case "MoveToLocation": return new ai.MoveToLocation(_json);
                case "DebugPrint": return new ai.DebugPrint(_json);
                default: throw new SerializationException();
            }
        }
    
        public System.Collections.Generic.List<ai.Decorator> Decorators { get; private set; }
        public System.Collections.Generic.List<ai.Service> Services { get; private set; }
    
    
        public override void Resolve(Dictionary<string, object> _tables)
        {
            base.Resolve(_tables);
            foreach(var _e in Decorators) { _e?.Resolve(_tables); }
            foreach(var _e in Services) { _e?.Resolve(_tables); }
            PostResolve();
        }
    
        public override void TranslateText(System.Func<string, string, string> translator)
        {
            base.TranslateText(translator);
            foreach(var _e in Decorators) { _e?.TranslateText(translator); }
            foreach(var _e in Services) { _e?.TranslateText(translator); }
        }
    
        public override string ToString()
        {
            return "{ "
            + "Id:" + Id + ","
            + "NodeName:" + NodeName + ","
            + "Decorators:" + Bright.Common.StringUtil.CollectionToString(Decorators) + ","
            + "Services:" + Bright.Common.StringUtil.CollectionToString(Services) + ","
            + "}";
        }
        
        partial void PostInit();
        partial void PostResolve();
    }
}
