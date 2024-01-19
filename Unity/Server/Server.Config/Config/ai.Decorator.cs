
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Text.Json;


namespace cfg.ai
{
public abstract partial class Decorator : ai.Node
{
    public Decorator(JsonElement _buf)  : base(_buf) 
    {
        FlowAbortMode = (ai.EFlowAbortMode)_buf.GetProperty("flow_abort_mode").GetInt32();
    }

    public static Decorator DeserializeDecorator(JsonElement _buf)
    {
        switch (_buf.GetProperty("$type").GetString())
        {
            case "UeLoop": return new ai.UeLoop(_buf);
            case "UeCooldown": return new ai.UeCooldown(_buf);
            case "UeTimeLimit": return new ai.UeTimeLimit(_buf);
            case "UeBlackboard": return new ai.UeBlackboard(_buf);
            case "UeForceSuccess": return new ai.UeForceSuccess(_buf);
            case "IsAtLocation": return new ai.IsAtLocation(_buf);
            case "DistanceLessThan": return new ai.DistanceLessThan(_buf);
            default: throw new SerializationException();
        }
    }

    public readonly ai.EFlowAbortMode FlowAbortMode;
   

    public override void ResolveRef(Tables tables)
    {
        base.ResolveRef(tables);
        
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "nodeName:" + NodeName + ","
        + "flowAbortMode:" + FlowAbortMode + ","
        + "}";
    }
}

}
