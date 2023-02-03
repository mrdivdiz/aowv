using System;

namespace Spine
{
	// Token: 0x0200011E RID: 286
	public class MeshAttachment : Attachment
	{
		// Token: 0x060007AA RID: 1962 RVA: 0x00025F14 File Offset: 0x00024114
		public MeshAttachment(string name) : base(name)
		{
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060007AB RID: 1963 RVA: 0x00025F4C File Offset: 0x0002414C
		// (set) Token: 0x060007AC RID: 1964 RVA: 0x00025F54 File Offset: 0x00024154
		public int HullLength { get; set; }

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060007AD RID: 1965 RVA: 0x00025F60 File Offset: 0x00024160
		// (set) Token: 0x060007AE RID: 1966 RVA: 0x00025F68 File Offset: 0x00024168
		public float[] Vertices
		{
			get
			{
				return this.vertices;
			}
			set
			{
				this.vertices = value;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060007AF RID: 1967 RVA: 0x00025F74 File Offset: 0x00024174
		// (set) Token: 0x060007B0 RID: 1968 RVA: 0x00025F7C File Offset: 0x0002417C
		public float[] RegionUVs
		{
			get
			{
				return this.regionUVs;
			}
			set
			{
				this.regionUVs = value;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060007B1 RID: 1969 RVA: 0x00025F88 File Offset: 0x00024188
		// (set) Token: 0x060007B2 RID: 1970 RVA: 0x00025F90 File Offset: 0x00024190
		public float[] UVs
		{
			get
			{
				return this.uvs;
			}
			set
			{
				this.uvs = value;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060007B3 RID: 1971 RVA: 0x00025F9C File Offset: 0x0002419C
		// (set) Token: 0x060007B4 RID: 1972 RVA: 0x00025FA4 File Offset: 0x000241A4
		public int[] Triangles
		{
			get
			{
				return this.triangles;
			}
			set
			{
				this.triangles = value;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060007B5 RID: 1973 RVA: 0x00025FB0 File Offset: 0x000241B0
		// (set) Token: 0x060007B6 RID: 1974 RVA: 0x00025FB8 File Offset: 0x000241B8
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

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060007B7 RID: 1975 RVA: 0x00025FC4 File Offset: 0x000241C4
		// (set) Token: 0x060007B8 RID: 1976 RVA: 0x00025FCC File Offset: 0x000241CC
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

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060007B9 RID: 1977 RVA: 0x00025FD8 File Offset: 0x000241D8
		// (set) Token: 0x060007BA RID: 1978 RVA: 0x00025FE0 File Offset: 0x000241E0
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

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060007BB RID: 1979 RVA: 0x00025FEC File Offset: 0x000241EC
		// (set) Token: 0x060007BC RID: 1980 RVA: 0x00025FF4 File Offset: 0x000241F4
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

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060007BD RID: 1981 RVA: 0x00026000 File Offset: 0x00024200
		// (set) Token: 0x060007BE RID: 1982 RVA: 0x00026008 File Offset: 0x00024208
		public string Path { get; set; }

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060007BF RID: 1983 RVA: 0x00026014 File Offset: 0x00024214
		// (set) Token: 0x060007C0 RID: 1984 RVA: 0x0002601C File Offset: 0x0002421C
		public object RendererObject { get; set; }

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060007C1 RID: 1985 RVA: 0x00026028 File Offset: 0x00024228
		// (set) Token: 0x060007C2 RID: 1986 RVA: 0x00026030 File Offset: 0x00024230
		public float RegionU { get; set; }

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060007C3 RID: 1987 RVA: 0x0002603C File Offset: 0x0002423C
		// (set) Token: 0x060007C4 RID: 1988 RVA: 0x00026044 File Offset: 0x00024244
		public float RegionV { get; set; }

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060007C5 RID: 1989 RVA: 0x00026050 File Offset: 0x00024250
		// (set) Token: 0x060007C6 RID: 1990 RVA: 0x00026058 File Offset: 0x00024258
		public float RegionU2 { get; set; }

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060007C7 RID: 1991 RVA: 0x00026064 File Offset: 0x00024264
		// (set) Token: 0x060007C8 RID: 1992 RVA: 0x0002606C File Offset: 0x0002426C
		public float RegionV2 { get; set; }

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060007C9 RID: 1993 RVA: 0x00026078 File Offset: 0x00024278
		// (set) Token: 0x060007CA RID: 1994 RVA: 0x00026080 File Offset: 0x00024280
		public bool RegionRotate { get; set; }

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060007CB RID: 1995 RVA: 0x0002608C File Offset: 0x0002428C
		// (set) Token: 0x060007CC RID: 1996 RVA: 0x00026094 File Offset: 0x00024294
		public float RegionOffsetX
		{
			get
			{
				return this.regionOffsetX;
			}
			set
			{
				this.regionOffsetX = value;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060007CD RID: 1997 RVA: 0x000260A0 File Offset: 0x000242A0
		// (set) Token: 0x060007CE RID: 1998 RVA: 0x000260A8 File Offset: 0x000242A8
		public float RegionOffsetY
		{
			get
			{
				return this.regionOffsetY;
			}
			set
			{
				this.regionOffsetY = value;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060007CF RID: 1999 RVA: 0x000260B4 File Offset: 0x000242B4
		// (set) Token: 0x060007D0 RID: 2000 RVA: 0x000260BC File Offset: 0x000242BC
		public float RegionWidth
		{
			get
			{
				return this.regionWidth;
			}
			set
			{
				this.regionWidth = value;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060007D1 RID: 2001 RVA: 0x000260C8 File Offset: 0x000242C8
		// (set) Token: 0x060007D2 RID: 2002 RVA: 0x000260D0 File Offset: 0x000242D0
		public float RegionHeight
		{
			get
			{
				return this.regionHeight;
			}
			set
			{
				this.regionHeight = value;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060007D3 RID: 2003 RVA: 0x000260DC File Offset: 0x000242DC
		// (set) Token: 0x060007D4 RID: 2004 RVA: 0x000260E4 File Offset: 0x000242E4
		public float RegionOriginalWidth
		{
			get
			{
				return this.regionOriginalWidth;
			}
			set
			{
				this.regionOriginalWidth = value;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060007D5 RID: 2005 RVA: 0x000260F0 File Offset: 0x000242F0
		// (set) Token: 0x060007D6 RID: 2006 RVA: 0x000260F8 File Offset: 0x000242F8
		public float RegionOriginalHeight
		{
			get
			{
				return this.regionOriginalHeight;
			}
			set
			{
				this.regionOriginalHeight = value;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060007D7 RID: 2007 RVA: 0x00026104 File Offset: 0x00024304
		// (set) Token: 0x060007D8 RID: 2008 RVA: 0x0002610C File Offset: 0x0002430C
		public int[] Edges { get; set; }

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060007D9 RID: 2009 RVA: 0x00026118 File Offset: 0x00024318
		// (set) Token: 0x060007DA RID: 2010 RVA: 0x00026120 File Offset: 0x00024320
		public float Width { get; set; }

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060007DB RID: 2011 RVA: 0x0002612C File Offset: 0x0002432C
		// (set) Token: 0x060007DC RID: 2012 RVA: 0x00026134 File Offset: 0x00024334
		public float Height { get; set; }

		// Token: 0x060007DD RID: 2013 RVA: 0x00026140 File Offset: 0x00024340
		public void UpdateUVs()
		{
			float regionU = this.RegionU;
			float regionV = this.RegionV;
			float num = this.RegionU2 - this.RegionU;
			float num2 = this.RegionV2 - this.RegionV;
			float[] array = this.regionUVs;
			if (this.uvs == null || this.uvs.Length != array.Length)
			{
				this.uvs = new float[array.Length];
			}
			float[] array2 = this.uvs;
			if (this.RegionRotate)
			{
				int i = 0;
				int num3 = array2.Length;
				while (i < num3)
				{
					array2[i] = regionU + array[i + 1] * num;
					array2[i + 1] = regionV + num2 - array[i] * num2;
					i += 2;
				}
			}
			else
			{
				int j = 0;
				int num4 = array2.Length;
				while (j < num4)
				{
					array2[j] = regionU + array[j] * num;
					array2[j + 1] = regionV + array[j + 1] * num2;
					j += 2;
				}
			}
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x00026240 File Offset: 0x00024440
		public void ComputeWorldVertices(Slot slot, float[] worldVertices)
		{
			Bone bone = slot.bone;
			float num = bone.skeleton.x + bone.worldX;
			float num2 = bone.skeleton.y + bone.worldY;
			float m = bone.m00;
			float m2 = bone.m01;
			float m3 = bone.m10;
			float m4 = bone.m11;
			float[] attachmentVertices = this.vertices;
			int num3 = attachmentVertices.Length;
			if (slot.attachmentVerticesCount == num3)
			{
				attachmentVertices = slot.AttachmentVertices;
			}
			for (int i = 0; i < num3; i += 2)
			{
				float num4 = attachmentVertices[i];
				float num5 = attachmentVertices[i + 1];
				worldVertices[i] = num4 * m + num5 * m2 + num;
				worldVertices[i + 1] = num4 * m3 + num5 * m4 + num2;
			}
		}

		// Token: 0x04000522 RID: 1314
		internal float[] vertices;

		// Token: 0x04000523 RID: 1315
		internal float[] uvs;

		// Token: 0x04000524 RID: 1316
		internal float[] regionUVs;

		// Token: 0x04000525 RID: 1317
		internal int[] triangles;

		// Token: 0x04000526 RID: 1318
		internal float regionOffsetX;

		// Token: 0x04000527 RID: 1319
		internal float regionOffsetY;

		// Token: 0x04000528 RID: 1320
		internal float regionWidth;

		// Token: 0x04000529 RID: 1321
		internal float regionHeight;

		// Token: 0x0400052A RID: 1322
		internal float regionOriginalWidth;

		// Token: 0x0400052B RID: 1323
		internal float regionOriginalHeight;

		// Token: 0x0400052C RID: 1324
		internal float r = 1f;

		// Token: 0x0400052D RID: 1325
		internal float g = 1f;

		// Token: 0x0400052E RID: 1326
		internal float b = 1f;

		// Token: 0x0400052F RID: 1327
		internal float a = 1f;
	}
}
