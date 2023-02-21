using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssetStudio
{
	public class ObjectData {
		readonly public Object obj;
		readonly public List<TypeData> dataList = new List<TypeData>();
		public string ObjType => obj.type.ToString();
		public ObjectData(Object obj) {
			this.obj = obj;
		}
		public class TypeData {
			public TypeTreeNode m_Node;
			public long offset;
			public string m_Name => m_Node.m_Name;
			public string m_Type => m_Node.m_Type;
			public object value;
		}
	}
}