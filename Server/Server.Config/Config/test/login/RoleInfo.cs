//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Text.Json;



namespace cfg.test.login
{
public sealed partial class RoleInfo :  test.DemoD3 
{
    public RoleInfo(JsonElement _json)  : base(_json) 
    {
        RoleId = _json.GetProperty("role_id").GetInt64();
        PostInit();
    }

    public RoleInfo(int x1, int x3, long role_id )  : base(x1,x3) 
    {
        this.RoleId = role_id;
        PostInit();
    }

    public static RoleInfo DeserializeRoleInfo(JsonElement _json)
    {
        return new test.login.RoleInfo(_json);
    }

    public long RoleId { get; private set; }

    public const int __ID__ = -989153243;
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
        + "X1:" + X1 + ","
        + "X3:" + X3 + ","
        + "RoleId:" + RoleId + ","
        + "}";
    }

    partial void PostInit();
    partial void PostResolve();
}
}
