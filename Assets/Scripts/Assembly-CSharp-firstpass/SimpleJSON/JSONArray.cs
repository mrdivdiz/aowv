using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace SimpleJSON
{
	// Token: 0x02000029 RID: 41
	public class JSONArray : JSONNode, IEnumerable
	{
		// Token: 0x17000029 RID: 41
		public override JSONNode this[int aIndex]
		{
			get
			{
				if (aIndex < 0 || aIndex >= this.m_List.Count)
				{
					return new JSONLazyCreator(this);
				}
				return this.m_List[aIndex];
			}
			set
			{
				if (aIndex < 0 || aIndex >= this.m_List.Count)
				{
					this.m_List.Add(value);
				}
				else
				{
					this.m_List[aIndex] = value;
				}
			}
		}

		// Token: 0x1700002A RID: 42
		public override JSONNode this[string aKey]
		{
			get
			{
				return new JSONLazyCreator(this);
			}
			set
			{
				this.m_List.Add(value);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x00007B7C File Offset: 0x00005D7C
		public override int Count
		{
			get
			{
				return this.m_List.Count;
			}
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00007B8C File Offset: 0x00005D8C
		public override void Add(string aKey, JSONNode aItem)
		{
			this.m_List.Add(aItem);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00007B9C File Offset: 0x00005D9C
		public override JSONNode Remove(int aIndex)
		{
			if (aIndex < 0 || aIndex >= this.m_List.Count)
			{
				return null;
			}
			JSONNode result = this.m_List[aIndex];
			this.m_List.RemoveAt(aIndex);
			return result;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00007BE0 File Offset: 0x00005DE0
		public override JSONNode Remove(JSONNode aNode)
		{
			this.m_List.Remove(aNode);
			return aNode;
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x00007BF0 File Offset: 0x00005DF0
		public override IEnumerable<JSONNode> Childs
		{
			get
			{
				foreach (JSONNode N in this.m_List)
				{
					yield return N;
				}
				yield break;
			}
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00007C14 File Offset: 0x00005E14
		public IEnumerator GetEnumerator()
		{
			foreach (JSONNode N in this.m_List)
			{
				yield return N;
			}
			yield break;
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00007C30 File Offset: 0x00005E30
		public override string ToString()
		{
			string text = "[ ";
			foreach (JSONNode jsonnode in this.m_List)
			{
				if (text.Length > 2)
				{
					text += ", ";
				}
				text += jsonnode.ToString();
			}
			text += " ]";
			return text;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00007CC8 File Offset: 0x00005EC8
		public override string ToString(string aPrefix)
		{
			string text = "[ ";
			foreach (JSONNode jsonnode in this.m_List)
			{
				if (text.Length > 3)
				{
					text += ", ";
				}
				text = text + "\n" + aPrefix + "   ";
				text += jsonnode.ToString(aPrefix + "   ");
			}
			text = text + "\n" + aPrefix + "]";
			return text;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00007D84 File Offset: 0x00005F84
		public override void Serialize(BinaryWriter aWriter)
		{
			aWriter.Write(1);
			aWriter.Write(this.m_List.Count);
			for (int i = 0; i < this.m_List.Count; i++)
			{
				this.m_List[i].Serialize(aWriter);
			}
		}

		// Token: 0x040000F6 RID: 246
		private List<JSONNode> m_List = new List<JSONNode>();
	}
}
