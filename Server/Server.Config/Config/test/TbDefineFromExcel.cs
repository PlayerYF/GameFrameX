//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Text.Json;



namespace cfg.test
{


public sealed partial class TbDefineFromExcel
{
    private readonly Dictionary<int, test.DefineFromExcel> _dataMap;
    private readonly List<test.DefineFromExcel> _dataList;
    
    public TbDefineFromExcel(JsonElement _json)
    {
        _dataMap = new Dictionary<int, test.DefineFromExcel>();
        _dataList = new List<test.DefineFromExcel>();
        
        foreach(JsonElement _row in _json.EnumerateArray())
        {
            var _v = test.DefineFromExcel.DeserializeDefineFromExcel(_row);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
        PostInit();
    }

    public Dictionary<int, test.DefineFromExcel> DataMap => _dataMap;
    public List<test.DefineFromExcel> DataList => _dataList;

    public test.DefineFromExcel GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public test.DefineFromExcel Get(int key) => _dataMap[key];
    public test.DefineFromExcel this[int key] => _dataMap[key];

    public void Resolve(Dictionary<string, object> _tables)
    {
        foreach(var v in _dataList)
        {
            v.Resolve(_tables);
        }
        PostResolve();
    }

    public void TranslateText(System.Func<string, string, string> translator)
    {
        foreach(var v in _dataList)
        {
            v.TranslateText(translator);
        }
    }
    

    partial void PostInit();
    partial void PostResolve();
}

}