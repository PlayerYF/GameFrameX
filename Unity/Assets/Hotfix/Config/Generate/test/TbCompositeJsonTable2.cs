//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using System.Linq;
using SimpleJSON;

namespace cfg.test
{
    public sealed partial class TbCompositeJsonTable2
    {
        private readonly Dictionary<int, test.CompositeJsonTable2> _dataMap;
        private readonly List<test.CompositeJsonTable2> _dataList;
        
        public TbCompositeJsonTable2(JSONNode _json)
        {
            var count = _json.Children.Count();
            _dataMap = new Dictionary<int, test.CompositeJsonTable2>(count);
            _dataList = new List<test.CompositeJsonTable2>(count);
            
            foreach(var _row in _json.Children)
            {
                var _v = test.CompositeJsonTable2.DeserializeCompositeJsonTable2(_row);
                _dataList.Add(_v);
                _dataMap.Add(_v.Id, _v);
            }
            PostInit();
        }
    
        public Dictionary<int, test.CompositeJsonTable2> DataMap => _dataMap;
        public List<test.CompositeJsonTable2> DataList => _dataList;
    
        public test.CompositeJsonTable2 GetOrDefault(int key)
        {
            return _dataMap.TryGetValue(key, out var v) ? v : null;
        }
        
        public test.CompositeJsonTable2 Get(int key)
        {
            return _dataMap[key];
        }
        
        public test.CompositeJsonTable2 this[int key]
        {
            get { return _dataMap[key]; }
        }
    
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