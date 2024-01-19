
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Text.Json;
using Server.Config.Core;


namespace cfg.test
{
public partial class TbTestMultiColumn
{
    private readonly System.Collections.Generic.Dictionary<int, test.TestMultiColumn> _dataMap;
    private readonly System.Collections.Generic.List<test.TestMultiColumn> _dataList;
    
    public TbTestMultiColumn(JsonElement _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, test.TestMultiColumn>();
        _dataList = new System.Collections.Generic.List<test.TestMultiColumn>();
        
        foreach(JsonElement _ele in _buf.EnumerateArray())
        {
            test.TestMultiColumn _v;
            _v = test.TestMultiColumn.DeserializeTestMultiColumn(_ele);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, test.TestMultiColumn> DataMap => _dataMap;
    public System.Collections.Generic.List<test.TestMultiColumn> DataList => _dataList;

    public test.TestMultiColumn GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public test.TestMultiColumn Get(int key) => _dataMap[key];
    public test.TestMultiColumn this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}
