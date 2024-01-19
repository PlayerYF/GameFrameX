
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Text.Json;
using Server.Config.Core;


namespace cfg.ai
{
public sealed partial class MoveToTarget : ai.Task
{
    public MoveToTarget(JsonElement _buf)  : base(_buf) 
    {
        TargetActorKey = _buf.GetProperty("target_actor_key").GetString();
        AcceptableRadius = _buf.GetProperty("acceptable_radius").GetSingle();
    }

    public static MoveToTarget DeserializeMoveToTarget(JsonElement _buf)
    {
        return new ai.MoveToTarget(_buf);
    }

    public readonly string TargetActorKey;
    public readonly float AcceptableRadius;
   
    public const int __ID__ = 514987779;
    public override int GetTypeId() => __ID__;

    public override void ResolveRef(Tables tables)
    {
        base.ResolveRef(tables);
        
        
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "nodeName:" + NodeName + ","
        + "decorators:" + StringUtil.CollectionToString(Decorators) + ","
        + "services:" + StringUtil.CollectionToString(Services) + ","
        + "ignoreRestartSelf:" + IgnoreRestartSelf + ","
        + "targetActorKey:" + TargetActorKey + ","
        + "acceptableRadius:" + AcceptableRadius + ","
        + "}";
    }
}

}
