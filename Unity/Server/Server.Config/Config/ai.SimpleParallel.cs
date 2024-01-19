
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
public sealed partial class SimpleParallel : ai.ComposeNode
{
    public SimpleParallel(JsonElement _buf)  : base(_buf) 
    {
        FinishMode = (ai.EFinishMode)_buf.GetProperty("finish_mode").GetInt32();
        MainTask = ai.Task.DeserializeTask(_buf.GetProperty("main_task"));
        BackgroundNode = ai.FlowNode.DeserializeFlowNode(_buf.GetProperty("background_node"));
    }

    public static SimpleParallel DeserializeSimpleParallel(JsonElement _buf)
    {
        return new ai.SimpleParallel(_buf);
    }

    public readonly ai.EFinishMode FinishMode;
    public readonly ai.Task MainTask;
    public readonly ai.FlowNode BackgroundNode;
   
    public const int __ID__ = -1952582529;
    public override int GetTypeId() => __ID__;

    public override void ResolveRef(Tables tables)
    {
        base.ResolveRef(tables);
        
        MainTask?.ResolveRef(tables);
        BackgroundNode?.ResolveRef(tables);
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "nodeName:" + NodeName + ","
        + "decorators:" + StringUtil.CollectionToString(Decorators) + ","
        + "services:" + StringUtil.CollectionToString(Services) + ","
        + "finishMode:" + FinishMode + ","
        + "mainTask:" + MainTask + ","
        + "backgroundNode:" + BackgroundNode + ","
        + "}";
    }
}

}
