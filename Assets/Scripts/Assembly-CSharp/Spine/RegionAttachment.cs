using System;

namespace Spine
{
	// Token: 0x0200011F RID: 287
	public class RegionAttachment : Attachment
	{
		// Token: 0x060007DF RID: 2015 RVA: 0x00026308 File Offset: 0x00024508
		public RegionAttachment(string name) : base(name)
		{
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060007E0 RID: 2016 RVA: 0x00026378 File Offset: 0x00024578
		// (set) Token: 0x060007E1 RID: 2017 RVA: 0x00026380 File Offset: 0x00024580
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

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060007E2 RID: 2018 RVA: 0x0002638C File Offset: 0x0002458C
		// (set) Token: 0x060007E3 RID: 2019 RVA: 0x00026394 File Offset: 0x00024594
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

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060007E4 RID: 2020 RVA: 0x000263A0 File Offset: 0x000245A0
		// (set) Token: 0x060007E5 RID: 2021 RVA: 0x000263A8 File Offset: 0x000245A8
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

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060007E6 RID: 2022 RVA: 0x000263B4 File Offset: 0x000245B4
		// (set) Token: 0x060007E7 RID: 2023 RVA: 0x000263BC File Offset: 0x000245BC
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

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060007E8 RID: 2024 RVA: 0x000263C8 File Offset: 0x000245C8
		// (set) Token: 0x060007E9 RID: 2025 RVA: 0x000263D0 File Offset: 0x000245D0
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

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060007EA RID: 2026 RVA: 0x000263DC File Offset: 0x000245DC
		// (set) Token: 0x060007EB RID: 2027 RVA: 0x000263E4 File Offset: 0x000245E4
		public float Width
		{
			get
			{
				return this.width;
			}
			set
			{
				this.width = value;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060007EC RID: 2028 RVA: 0x000263F0 File Offset: 0x000245F0
		// (set) Token: 0x060007ED RID: 2029 RVA: 0x000263F8 File Offset: 0x000245F8
		public float Height
		{
			get
			{
				return this.height;
			}
			set
			{
				this.height = value;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060007EE RID: 2030 RVA: 0x00026404 File Offset: 0x00024604
		// (set) Token: 0x060007EF RID: 2031 RVA: 0x0002640C File Offset: 0x0002460C
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

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060007F0 RID: 2032 RVA: 0x00026418 File Offset: 0x00024618
		// (set) Token: 0x060007F1 RID: 2033 RVA: 0x00026420 File Offset: 0x00024620
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

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060007F2 RID: 2034 RVA: 0x0002642C File Offset: 0x0002462C
		// (set) Token: 0x060007F3 RID: 2035 RVA: 0x00026434 File Offset: 0x00024634
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

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060007F4 RID: 2036 RVA: 0x00026440 File Offset: 0x00024640
		// (set) Token: 0x060007F5 RID: 2037 RVA: 0x00026448 File Offset: 0x00024648
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

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060007F6 RID: 2038 RVA: 0x00026454 File Offset: 0x00024654
		// (set) Token: 0x060007F7 RID: 2039 RVA: 0x0002645C File Offset: 0x0002465C
		public string Path { get; set; }

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060007F8 RID: 2040 RVA: 0x00026468 File Offset: 0x00024668
		// (set) Token: 0x060007F9 RID: 2041 RVA: 0x00026470 File Offset: 0x00024670
		public object RendererObject { get; set; }

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060007FA RID: 2042 RVA: 0x0002647C File Offset: 0x0002467C
		// (set) Token: 0x060007FB RID: 2043 RVA: 0x00026484 File Offset: 0x00024684
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

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060007FC RID: 2044 RVA: 0x00026490 File Offset: 0x00024690
		// (set) Token: 0x060007FD RID: 2045 RVA: 0x00026498 File Offset: 0x00024698
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

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060007FE RID: 2046 RVA: 0x000264A4 File Offset: 0x000246A4
		// (set) Token: 0x060007FF RID: 2047 RVA: 0x000264AC File Offset: 0x000246AC
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

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000800 RID: 2048 RVA: 0x000264B8 File Offset: 0x000246B8
		// (set) Token: 0x06000801 RID: 2049 RVA: 0x000264C0 File Offset: 0x000246C0
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

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000802 RID: 2050 RVA: 0x000264CC File Offset: 0x000246CC
		// (set) Token: 0x06000803 RID: 2051 RVA: 0x000264D4 File Offset: 0x000246D4
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

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000804 RID: 2052 RVA: 0x000264E0 File Offset: 0x000246E0
		// (set) Token: 0x06000805 RID: 2053 RVA: 0x000264E8 File Offset: 0x000246E8
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

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000806 RID: 2054 RVA: 0x000264F4 File Offset: 0x000246F4
		public float[] Offset
		{
			get
			{
				return this.offset;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000807 RID: 2055 RVA: 0x000264FC File Offset: 0x000246FC
		public float[] UVs
		{
			get
			{
				return this.uvs;
			}
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x00026504 File Offset: 0x00024704
		public void SetUVs(float u, float v, float u2, float v2, bool rotate)
		{
			float[] array = this.uvs;
			if (rotate)
			{
				array[2] = u;
				array[3] = v2;
				array[4] = u;
				array[5] = v;
				array[6] = u2;
				array[7] = v;
				array[0] = u2;
				array[1] = v2;
			}
			else
			{
				array[0] = u;
				array[1] = v2;
				array[2] = u;
				array[3] = v;
				array[4] = u2;
				array[5] = v;
				array[6] = u2;
				array[7] = v2;
			}
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x00026568 File Offset: 0x00024768
		public void UpdateOffset()
		{
			float num = this.width;
			float num2 = this.height;
			float num3 = this.scaleX;
			float num4 = this.scaleY;
			float num5 = num / this.regionOriginalWidth * num3;
			float num6 = num2 / this.regionOriginalHeight * num4;
			float num7 = -num / 2f * num3 + this.regionOffsetX * num5;
			float num8 = -num2 / 2f * num4 + this.regionOffsetY * num6;
			float num9 = num7 + this.regionWidth * num5;
			float num10 = num8 + this.regionHeight * num6;
			float num11 = this.rotation * 3.1415927f / 180f;
			float num12 = (float)Math.Cos((double)num11);
			float num13 = (float)Math.Sin((double)num11);
			float num14 = this.x;
			float num15 = this.y;
			float num16 = num7 * num12 + num14;
			float num17 = num7 * num13;
			float num18 = num8 * num12 + num15;
			float num19 = num8 * num13;
			float num20 = num9 * num12 + num14;
			float num21 = num9 * num13;
			float num22 = num10 * num12 + num15;
			float num23 = num10 * num13;
			float[] array = this.offset;
			array[0] = num16 - num19;
			array[1] = num18 + num17;
			array[2] = num16 - num23;
			array[3] = num22 + num17;
			array[4] = num20 - num23;
			array[5] = num22 + num21;
			array[6] = num20 - num19;
			array[7] = num18 + num21;
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x000266C0 File Offset: 0x000248C0
		public void ComputeWorldVertices(Bone bone, float[] worldVertices)
		{
			float num = bone.skeleton.x + bone.worldX;
			float num2 = bone.skeleton.y + bone.worldY;
			float m = bone.m00;
			float m2 = bone.m01;
			float m3 = bone.m10;
			float m4 = bone.m11;
			float[] array = this.offset;
			worldVertices[0] = array[0] * m + array[1] * m2 + num;
			worldVertices[1] = array[0] * m3 + array[1] * m4 + num2;
			worldVertices[2] = array[2] * m + array[3] * m2 + num;
			worldVertices[3] = array[2] * m3 + array[3] * m4 + num2;
			worldVertices[4] = array[4] * m + array[5] * m2 + num;
			worldVertices[5] = array[4] * m3 + array[5] * m4 + num2;
			worldVertices[6] = array[6] * m + array[7] * m2 + num;
			worldVertices[7] = array[6] * m3 + array[7] * m4 + num2;
		}

		// Token: 0x0400053B RID: 1339
		public const int X1 = 0;

		// Token: 0x0400053C RID: 1340
		public const int Y1 = 1;

		// Token: 0x0400053D RID: 1341
		public const int X2 = 2;

		// Token: 0x0400053E RID: 1342
		public const int Y2 = 3;

		// Token: 0x0400053F RID: 1343
		public const int X3 = 4;

		// Token: 0x04000540 RID: 1344
		public const int Y3 = 5;

		// Token: 0x04000541 RID: 1345
		public const int X4 = 6;

		// Token: 0x04000542 RID: 1346
		public const int Y4 = 7;

		// Token: 0x04000543 RID: 1347
		internal float x;

		// Token: 0x04000544 RID: 1348
		internal float y;

		// Token: 0x04000545 RID: 1349
		internal float rotation;

		// Token: 0x04000546 RID: 1350
		internal float scaleX = 1f;

		// Token: 0x04000547 RID: 1351
		internal float scaleY = 1f;

		// Token: 0x04000548 RID: 1352
		internal float width;

		// Token: 0x04000549 RID: 1353
		internal float height;

		// Token: 0x0400054A RID: 1354
		internal float regionOffsetX;

		// Token: 0x0400054B RID: 1355
		internal float regionOffsetY;

		// Token: 0x0400054C RID: 1356
		internal float regionWidth;

		// Token: 0x0400054D RID: 1357
		internal float regionHeight;

		// Token: 0x0400054E RID: 1358
		internal float regionOriginalWidth;

		// Token: 0x0400054F RID: 1359
		internal float regionOriginalHeight;

		// Token: 0x04000550 RID: 1360
		internal float[] offset = new float[8];

		// Token: 0x04000551 RID: 1361
		internal float[] uvs = new float[8];

		// Token: 0x04000552 RID: 1362
		internal float r = 1f;

		// Token: 0x04000553 RID: 1363
		internal float g = 1f;

		// Token: 0x04000554 RID: 1364
		internal float b = 1f;

		// Token: 0x04000555 RID: 1365
		internal float a = 1f;
	}
}
