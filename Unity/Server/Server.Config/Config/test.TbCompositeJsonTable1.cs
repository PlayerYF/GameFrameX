
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
public partial class TbCompositeJsonTable1
{
    private readonly System.Collections.Generic.Dictionary<int, test.CompositeJsonTable1> _dataMap;
    private readonly System.Collections.Generic.List<test.CompositeJsonTable1> _dataList;
    
    public TbCompositeJsonTable1(JsonElement _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, test.CompositeJsonTable1>();
        _dataList = new System.Collections.Generic.List<test.CompositeJsonTable1>();
        
        foreach(JsonElement _ele in _buf.EnumerateArray())
        {
            test.CompositeJsonTable1 _v;
            _v = test.CompositeJsonTable1.DeserializeCompositeJsonTable1(_ele);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, test.CompositeJsonTable1> DataMap => _dataMap;
    public System.Collections.Generic.List<test.CompositeJsonTable1> DataList => _dataList;

    public test.CompositeJsonTable1 GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public test.CompositeJsonTable1 Get(int key) => _dataMap[key];
    public test.CompositeJsonTable1 this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}
