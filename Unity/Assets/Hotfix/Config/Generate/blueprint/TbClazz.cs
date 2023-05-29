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

namespace cfg.blueprint
{
    public sealed partial class TbClazz
    {
        private readonly Dictionary<string, blueprint.Clazz> _dataMap;
        private readonly List<blueprint.Clazz> _dataList;
        
        public TbClazz(JSONNode _json)
        {
            var count = _json.Children.Count();
            _dataMap = new Dictionary<string, blueprint.Clazz>(count);
            _dataList = new List<blueprint.Clazz>(count);
            
            foreach(var _row in _json.Children)
            {
                var _v = blueprint.Clazz.DeserializeClazz(_row);
                _dataList.Add(_v);
                _dataMap.Add(_v.Name, _v);
            }
            PostInit();
        }
    
        public Dictionary<string, blueprint.Clazz> DataMap => _dataMap;
        public List<blueprint.Clazz> DataList => _dataList;
    
        public T GetOrDefaultAs<T>(string key) where T : blueprint.Clazz => _dataMap.TryGetValue(key, out var v) ? (T)v : null;
        public T GetAs<T>(string key) where T : blueprint.Clazz => (T)_dataMap[key];
        public blueprint.Clazz GetOrDefault(string key)
        {
            return _dataMap.TryGetValue(key, out var v) ? v : null;
        }
        
        public blueprint.Clazz Get(string key)
        {
            return _dataMap[key];
        }
        
        public blueprint.Clazz this[string key]
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