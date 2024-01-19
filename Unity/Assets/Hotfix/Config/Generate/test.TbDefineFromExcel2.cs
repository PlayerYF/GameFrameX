
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LuBan.Runtime;
using SimpleJSON;


namespace cfg.test
{
    public partial class TbDefineFromExcel2
    {
        private readonly System.Collections.Generic.Dictionary<int, DefineFromExcel2> _dataMap;
        private readonly System.Collections.Generic.List<DefineFromExcel2> _dataList;
        
        public TbDefineFromExcel2(JSONNode jsonNode)
        {
            _dataMap = new System.Collections.Generic.Dictionary<int, DefineFromExcel2>();
            _dataList = new System.Collections.Generic.List<DefineFromExcel2>();
            
            foreach(JSONNode vNode in jsonNode.Children)
            {
                DefineFromExcel2 deserializeItem;
                { if(!vNode.IsObject) { throw new SerializationException(); }  deserializeItem = DefineFromExcel2.DeserializeDefineFromExcel2(vNode);  }
                _dataList.Add(deserializeItem);
                _dataMap.Add(deserializeItem.Id, deserializeItem);
            }
        }
    
        public System.Collections.Generic.Dictionary<int, DefineFromExcel2> DataMap 
        {
            get { return _dataMap; }
        }

        public System.Collections.Generic.List<DefineFromExcel2> DataList 
        {
            get { return _dataList; }
        }
    
        public DefineFromExcel2 GetOrDefault(int key) 
        {  
            return _dataMap.TryGetValue(key, out var v) ? v : null;
        }
        
        public DefineFromExcel2 Get(int key) 
        { 
            return _dataMap[key];
        }
        
        public DefineFromExcel2 this[int key] 
        {
            get
            {
                return _dataMap[key];
            }
        }
    
        public void ResolveRef(Tables tables)
        {
            foreach(var value in _dataList)
            {
                value.ResolveRef(tables);
            }
        }
        
    }

}
