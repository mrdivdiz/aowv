using System;

namespace Spine
{
	// Token: 0x02000122 RID: 290
	public class BoneData
	{
		// Token: 0x06000869 RID: 2153 RVA: 0x0002725C File Offset: 0x0002545C
		public BoneData(string name, BoneData parent)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name cannot be null.");
			}
			this.name = name;
			this.parent = parent;
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600086A RID: 2154 RVA: 0x000272B4 File Offset: 0x000254B4
		public BoneData Parent
		{
			get
			{
				return this.parent;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600086B RID: 2155 RVA: 0x000272BC File Offset: 0x000254BC
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600086C RID: 2156 RVA: 0x000272C4 File Offset: 0x000254C4
		// (set) Token: 0x0600086D RID: 2157 RVA: 0x000272CC File Offset: 0x000254CC
		public float Length
		{
			get
			{
				return this.length;
			}
			set
			{
				this.length = value;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600086E RID: 2158 RVA: 0x000272D8 File Offset: 0x000254D8
		// (set) Token: 0x0600086F RID: 2159 RVA: 0x000272E0 File Offset: 0x000254E0
		public float X
		{
			get
			{
				return this.x;
			}
			set
			{
				this.x = value;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000870 RID: 2160 RVA: 0x000272EC File Offset: 0x000254EC
		// (set) Token: 0x06000871 RID: 2161 RVA: 0x000272F4 File Offset: 0x000254F4
		public float Y
		{
			get
			{
				return this.y;
			}
			set
			{
				this.y = value;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000872 RID: 2162 RVA: 0x00027300 File Offset: 0x00025500
		// (set) Token: 0x06000873 RID: 2163 RVA: 0x00027308 File Offset: 0x00025508
		public float Rotation
		{
			get
			{
				return this.rotation;
			}
			set
			{
				this.rotation = value;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000874 RID: 2164 RVA: 0x00027314 File Offset: 0x00025514
		// (set) Token: 0x06000875 RID: 2165 RVA: 0x0002731C File Offset: 0x0002551C
		public float ScaleX
		{
			get
			{
				return this.scaleX;
			}
			set
			{
				this.scaleX = value;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000876 RID: 2166 RVA: 0x00027328 File Offset: 0x00025528
		// (set) Token: 0x06000877 RID: 2167 RVA: 0x00027330 File Offset: 0x00025530
		public float ScaleY
		{
			get
			{
				return this.scaleY;
			}
			set
			{
				this.scaleY = value;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000878 RID: 2168 RVA: 0x0002733C File Offset: 0x0002553C
		// (set) Token: 0x06000879 RID: 2169 RVA: 0x00027344 File Offset: 0x00025544
		public bool FlipX
		{
			get
			{
				return this.flipX;
			}
			set
			{
				this.flipX = value;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600087A RID: 2170 RVA: 0x00027350 File Offset: 0x00025550
		// (set) Token: 0x0600087B RID: 2171 RVA: 0x00027358 File Offset: 0x00025558
		public bool FlipY
		{
			get
			{
				return this.flipY;
			}
			set
			{
				this.flipY = value;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x0600087C RID: 2172 RVA: 0x00027364 File Offset: 0x00025564
		// (set) Token: 0x0600087D RID: 2173 RVA: 0x0002736C File Offset: 0x0002556C
		public bool InheritScale
		{
			get
			{
				return this.inheritScale;
			}
			set
			{
				this.inheritScale = value;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x0600087E RID: 2174 RVA: 0x00027378 File Offset: 0x00025578
		// (set) Token: 0x0600087F RID: 2175 RVA: 0x00027380 File Offset: 0x00025580
		public bool InheritRotation
		{
			get
			{
				return this.inheritRotation;
			}
			set
			{
				this.inheritRotation = value;
			}
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x0002738C File Offset: 0x0002558C
		public override string ToString()
		{
			return this.name;
		}

		// Token: 0x0400058A RID: 1418
		internal BoneData parent;

		// Token: 0x0400058B RID: 1419
		internal string name;

		// Token: 0x0400058C RID: 1420
		internal float length;

		// Token: 0x0400058D RID: 1421
		internal float x;

		// Token: 0x0400058E RID: 1422
		internal float y;

		// Token: 0x0400058F RID: 1423
		internal float rotation;

		// Token: 0x04000590 RID: 1424
		internal float scaleX = 1f;

		// Token: 0x04000591 RID: 1425
		internal float scaleY = 1f;

		// Token: 0x04000592 RID: 1426
		internal bool flipX;

		// Token: 0x04000593 RID: 1427
		internal bool flipY;

		// Token: 0x04000594 RID: 1428
		internal bool inheritScale = true;

		// Token: 0x04000595 RID: 1429
		internal bool inheritRotation = true;
	}
}
