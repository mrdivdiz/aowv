using System;

namespace Spine
{
	// Token: 0x02000133 RID: 307
	public class SlotData
	{
		// Token: 0x0600095F RID: 2399 RVA: 0x0002C260 File Offset: 0x0002A460
		public SlotData(string name, BoneData boneData)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name cannot be null.");
			}
			if (boneData == null)
			{
				throw new ArgumentNullException("boneData cannot be null.");
			}
			this.name = name;
			this.boneData = boneData;
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000960 RID: 2400 RVA: 0x0002C2D0 File Offset: 0x0002A4D0
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000961 RID: 2401 RVA: 0x0002C2D8 File Offset: 0x0002A4D8
		public BoneData BoneData
		{
			get
			{
				return this.boneData;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000962 RID: 2402 RVA: 0x0002C2E0 File Offset: 0x0002A4E0
		// (set) Token: 0x06000963 RID: 2403 RVA: 0x0002C2E8 File Offset: 0x0002A4E8
		public float R
		{
			get
			{
				return this.r;
			}
			set
			{
				this.r = value;
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000964 RID: 2404 RVA: 0x0002C2F4 File Offset: 0x0002A4F4
		// (set) Token: 0x06000965 RID: 2405 RVA: 0x0002C2FC File Offset: 0x0002A4FC
		public float G
		{
			get
			{
				return this.g;
			}
			set
			{
				this.g = value;
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000966 RID: 2406 RVA: 0x0002C308 File Offset: 0x0002A508
		// (set) Token: 0x06000967 RID: 2407 RVA: 0x0002C310 File Offset: 0x0002A510
		public float B
		{
			get
			{
				return this.b;
			}
			set
			{
				this.b = value;
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000968 RID: 2408 RVA: 0x0002C31C File Offset: 0x0002A51C
		// (set) Token: 0x06000969 RID: 2409 RVA: 0x0002C324 File Offset: 0x0002A524
		public float A
		{
			get
			{
				return this.a;
			}
			set
			{
				this.a = value;
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x0600096A RID: 2410 RVA: 0x0002C330 File Offset: 0x0002A530
		// (set) Token: 0x0600096B RID: 2411 RVA: 0x0002C338 File Offset: 0x0002A538
		public string AttachmentName
		{
			get
			{
				return this.attachmentName;
			}
			set
			{
				this.attachmentName = value;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x0600096C RID: 2412 RVA: 0x0002C344 File Offset: 0x0002A544
		// (set) Token: 0x0600096D RID: 2413 RVA: 0x0002C34C File Offset: 0x0002A54C
		public bool AdditiveBlending
		{
			get
			{
				return this.additiveBlending;
			}
			set
			{
				this.additiveBlending = value;
			}
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x0002C358 File Offset: 0x0002A558
		public override string ToString()
		{
			return this.name;
		}

		// Token: 0x040005EF RID: 1519
		internal string name;

		// Token: 0x040005F0 RID: 1520
		internal BoneData boneData;

		// Token: 0x040005F1 RID: 1521
		internal float r = 1f;

		// Token: 0x040005F2 RID: 1522
		internal float g = 1f;

		// Token: 0x040005F3 RID: 1523
		internal float b = 1f;

		// Token: 0x040005F4 RID: 1524
		internal float a = 1f;

		// Token: 0x040005F5 RID: 1525
		internal string attachmentName;

		// Token: 0x040005F6 RID: 1526
		internal bool additiveBlending;
	}
}
