using System;
using System.Collections.Generic;

namespace Spine
{
	// Token: 0x02000126 RID: 294
	public class IkConstraintData
	{
		// Token: 0x060008A1 RID: 2209 RVA: 0x0002794C File Offset: 0x00025B4C
		public IkConstraintData(string name)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name cannot be null.");
			}
			this.name = name;
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060008A2 RID: 2210 RVA: 0x0002798C File Offset: 0x00025B8C
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060008A3 RID: 2211 RVA: 0x00027994 File Offset: 0x00025B94
		public List<BoneData> Bones
		{
			get
			{
				return this.bones;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060008A4 RID: 2212 RVA: 0x0002799C File Offset: 0x00025B9C
		// (set) Token: 0x060008A5 RID: 2213 RVA: 0x000279A4 File Offset: 0x00025BA4
		public BoneData Target
		{
			get
			{
				return this.target;
			}
			set
			{
				this.target = value;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060008A6 RID: 2214 RVA: 0x000279B0 File Offset: 0x00025BB0
		// (set) Token: 0x060008A7 RID: 2215 RVA: 0x000279B8 File Offset: 0x00025BB8
		public int BendDirection
		{
			get
			{
				return this.bendDirection;
			}
			set
			{
				this.bendDirection = value;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060008A8 RID: 2216 RVA: 0x000279C4 File Offset: 0x00025BC4
		// (set) Token: 0x060008A9 RID: 2217 RVA: 0x000279CC File Offset: 0x00025BCC
		public float Mix
		{
			get
			{
				return this.mix;
			}
			set
			{
				this.mix = value;
			}
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x000279D8 File Offset: 0x00025BD8
		public override string ToString()
		{
			return this.name;
		}

		// Token: 0x040005A4 RID: 1444
		internal string name;

		// Token: 0x040005A5 RID: 1445
		internal List<BoneData> bones = new List<BoneData>();

		// Token: 0x040005A6 RID: 1446
		internal BoneData target;

		// Token: 0x040005A7 RID: 1447
		internal int bendDirection = 1;

		// Token: 0x040005A8 RID: 1448
		internal float mix = 1f;
	}
}
