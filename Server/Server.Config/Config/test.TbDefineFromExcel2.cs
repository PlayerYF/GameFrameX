
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
public partial class TbDefineFromExcel2
{
    private readonly System.Collections.Generic.Dictionary<int, DefineFromExcel2> _dataMap;
    private readonly System.Collections.Generic.List<DefineFromExcel2> _dataList;
    
    public TbDefineFromExcel2(JsonElement _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, DefineFromExcel2>();
        _dataList = new System.Collections.Generic.List<DefineFromExcel2>();
        
        foreach(JsonElement _ele in _buf.EnumerateArray())
        {
            DefineFromExcel2 _v;
            _v = DefineFromExcel2.DeserializeDefineFromExcel2(_ele);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, DefineFromExcel2> DataMap => _dataMap;
    public System.Collections.Generic.List<DefineFromExcel2> DataList => _dataList;

    public DefineFromExcel2 GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public DefineFromExcel2 Get(int key) => _dataMap[key];
    public DefineFromExcel2 this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}
