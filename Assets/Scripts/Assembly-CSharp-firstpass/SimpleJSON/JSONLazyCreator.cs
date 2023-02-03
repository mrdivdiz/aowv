using System;

namespace SimpleJSON
{
	// Token: 0x0200002C RID: 44
	internal class JSONLazyCreator : JSONNode
	{
		// Token: 0x060001D2 RID: 466 RVA: 0x00008498 File Offset: 0x00006698
		public JSONLazyCreator(JSONNode aNode)
		{
			this.m_Node = aNode;
			this.m_Key = null;
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x000084B0 File Offset: 0x000066B0
		public JSONLazyCreator(JSONNode aNode, string aKey)
		{
			this.m_Node = aNode;
			this.m_Key = aKey;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x000084C8 File Offset: 0x000066C8
		private void Set(JSONNode aVal)
		{
			if (this.m_Key == null)
			{
				this.m_Node.Add(aVal);
			}
			else
			{
				this.m_Node.Add(this.m_Key, aVal);
			}
			this.m_Node = null;
		}

		// Token: 0x17000032 RID: 50
		public override JSONNode this[int aIndex]
		{
			get
			{
				return new JSONLazyCreator(this);
			}
			set
			{
				this.Set(new JSONArray
				{
					value
				});
			}
		}

		// Token: 0x17000033 RID: 51
		public override JSONNode this[string aKey]
		{
			get
			{
				return new JSONLazyCreator(this, aKey);
			}
			set
			{
				this.Set(new JSONClass
				{
					{
						aKey,
						value
					}
				});
			}
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0000855C File Offset: 0x0000675C
		public override void Add(JSONNode aItem)
		{
			this.Set(new JSONArray
			{
				aItem
			});
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00008580 File Offset: 0x00006780
		public override void Add(string aKey, JSONNode aItem)
		{
			this.Set(new JSONClass
			{
				{
					aKey,
					aItem
				}
			});
		}

		// Token: 0x060001DB RID: 475 RVA: 0x000085A4 File Offset: 0x000067A4
		public override bool Equals(object obj)
		{
			return obj == null || object.ReferenceEquals(this, obj);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x000085B8 File Offset: 0x000067B8
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x060001DD RID: 477 RVA: 0x000085C0 File Offset: 0x000067C0
		public override string ToString()
		{
			return string.Empty;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x000085C8 File Offset: 0x000067C8
		public override string ToString(string aPrefix)
		{
			return string.Empty;
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060001DF RID: 479 RVA: 0x000085D0 File Offset: 0x000067D0
		// (set) Token: 0x060001E0 RID: 480 RVA: 0x000085EC File Offset: 0x000067EC
		public override int AsInt
		{
			get
			{
				JSONData aVal = new JSONData(0);
				this.Set(aVal);
				return 0;
			}
			set
			{
				JSONData aVal = new JSONData(value);
				this.Set(aVal);
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x00008608 File Offset: 0x00006808
		// (set) Token: 0x060001E2 RID: 482 RVA: 0x0000862C File Offset: 0x0000682C
		public override float AsFloat
		{
			get
			{
				JSONData aVal = new JSONData(0f);
				this.Set(aVal);
				return 0f;
			}
			set
			{
				JSONData aVal = new JSONData(value);
				this.Set(aVal);
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x00008648 File Offset: 0x00006848
		// (set) Token: 0x060001E4 RID: 484 RVA: 0x00008674 File Offset: 0x00006874
		public override double AsDouble
		{
			get
			{
				JSONData aVal = new JSONData(0.0);
				this.Set(aVal);
				return 0.0;
			}
			set
			{
				JSONData aVal = new JSONData(value);
				this.Set(aVal);
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x00008690 File Offset: 0x00006890
		// (set) Token: 0x060001E6 RID: 486 RVA: 0x000086AC File Offset: 0x000068AC
		public override bool AsBool
		{
			get
			{
				JSONData aVal = new JSONData(false);
				this.Set(aVal);
				return false;
			}
			set
			{
				JSONData aVal = new JSONData(value);
				this.Set(aVal);
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x000086C8 File Offset: 0x000068C8
		public override JSONArray AsArray
		{
			get
			{
				JSONArray jsonarray = new JSONArray();
				this.Set(jsonarray);
				return jsonarray;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x000086E4 File Offset: 0x000068E4
		public override JSONClass AsObject
		{
			get
			{
				JSONClass jsonclass = new JSONClass();
				this.Set(jsonclass);
				return jsonclass;
			}
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00008700 File Offset: 0x00006900
		public static bool operator ==(JSONLazyCreator a, object b)
		{
			return b == null || object.ReferenceEquals(a, b);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00008714 File Offset: 0x00006914
		public static bool operator !=(JSONLazyCreator a, object b)
		{
			return !(a == b);
		}

		// Token: 0x040000F9 RID: 249
		private JSONNode m_Node;

		// Token: 0x040000FA RID: 250
		private string m_Key;
	}
}
