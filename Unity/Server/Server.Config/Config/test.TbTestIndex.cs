
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Text.Json;


namespace cfg.test
{
public partial class TbTestIndex
{
    private readonly System.Collections.Generic.Dictionary<int, test.TestIndex> _dataMap;
    private readonly System.Collections.Generic.List<test.TestIndex> _dataList;
    
    public TbTestIndex(JsonElement _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, test.TestIndex>();
        _dataList = new System.Collections.Generic.List<test.TestIndex>();
        
        foreach(JsonElement _ele in _buf.EnumerateArray())
        {
            test.TestIndex _v;
            _v = test.TestIndex.DeserializeTestIndex(_ele);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, test.TestIndex> DataMap => _dataMap;
    public System.Collections.Generic.List<test.TestIndex> DataList => _dataList;

    public test.TestIndex GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public test.TestIndex Get(int key) => _dataMap[key];
    public test.TestIndex this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}
