using System;
using System.IO;

namespace SimpleJSON
{
	// Token: 0x0200002B RID: 43
	public class JSONData : JSONNode
	{
		// Token: 0x060001C8 RID: 456 RVA: 0x000082F8 File Offset: 0x000064F8
		public JSONData(string aData)
		{
			this.m_Data = aData;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00008308 File Offset: 0x00006508
		public JSONData(float aData)
		{
			this.AsFloat = aData;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00008318 File Offset: 0x00006518
		public JSONData(double aData)
		{
			this.AsDouble = aData;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00008328 File Offset: 0x00006528
		public JSONData(bool aData)
		{
			this.AsBool = aData;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00008338 File Offset: 0x00006538
		public JSONData(int aData)
		{
			this.AsInt = aData;
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060001CD RID: 461 RVA: 0x00008348 File Offset: 0x00006548
		// (set) Token: 0x060001CE RID: 462 RVA: 0x00008350 File Offset: 0x00006550
		public override string Value
		{
			get
			{
				return this.m_Data;
			}
			set
			{
				this.m_Data = value;
			}
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0000835C File Offset: 0x0000655C
		public override string ToString()
		{
			return "\"" + JSONNode.Escape(this.m_Data) + "\"";
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00008378 File Offset: 0x00006578
		public override string ToString(string aPrefix)
		{
			return "\"" + JSONNode.Escape(this.m_Data) + "\"";
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00008394 File Offset: 0x00006594
		public override void Serialize(BinaryWriter aWriter)
		{
			JSONData jsondata = new JSONData(string.Empty);
			jsondata.AsInt = this.AsInt;
			if (jsondata.m_Data == this.m_Data)
			{
				aWriter.Write(4);
				aWriter.Write(this.AsInt);
				return;
			}
			jsondata.AsFloat = this.AsFloat;
			if (jsondata.m_Data == this.m_Data)
			{
				aWriter.Write(7);
				aWriter.Write(this.AsFloat);
				return;
			}
			jsondata.AsDouble = this.AsDouble;
			if (jsondata.m_Data == this.m_Data)
			{
				aWriter.Write(5);
				aWriter.Write(this.AsDouble);
				return;
			}
			jsondata.AsBool = this.AsBool;
			if (jsondata.m_Data == this.m_Data)
			{
				aWriter.Write(6);
				aWriter.Write(this.AsBool);
				return;
			}
			aWriter.Write(3);
			aWriter.Write(this.m_Data);
		}

		// Token: 0x040000F8 RID: 248
		private string m_Data;
	}
}
