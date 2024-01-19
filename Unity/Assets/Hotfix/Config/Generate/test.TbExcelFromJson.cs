
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
    public partial class TbExcelFromJson
    {
        private readonly System.Collections.Generic.Dictionary<int, test.ExcelFromJson> _dataMap;
        private readonly System.Collections.Generic.List<test.ExcelFromJson> _dataList;
        
        public TbExcelFromJson(JSONNode jsonNode)
        {
            _dataMap = new System.Collections.Generic.Dictionary<int, test.ExcelFromJson>();
            _dataList = new System.Collections.Generic.List<test.ExcelFromJson>();
            
            foreach(JSONNode vNode in jsonNode.Children)
            {
                test.ExcelFromJson deserializeItem;
                { if(!vNode.IsObject) { throw new SerializationException(); }  deserializeItem = test.ExcelFromJson.DeserializeExcelFromJson(vNode);  }
                _dataList.Add(deserializeItem);
                _dataMap.Add(deserializeItem.X4, deserializeItem);
            }
        }
    
        public System.Collections.Generic.Dictionary<int, test.ExcelFromJson> DataMap 
        {
            get { return _dataMap; }
        }

        public System.Collections.Generic.List<test.ExcelFromJson> DataList 
        {
            get { return _dataList; }
        }
    
        public test.ExcelFromJson GetOrDefault(int key) 
        {  
            return _dataMap.TryGetValue(key, out var v) ? v : null;
        }
        
        public test.ExcelFromJson Get(int key) 
        { 
            return _dataMap[key];
        }
        
        public test.ExcelFromJson this[int key] 
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
