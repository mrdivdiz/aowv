using System;
using System.Collections.Generic;

namespace Spine
{
	// Token: 0x02000120 RID: 288
	public class SkinnedMeshAttachment : Attachment
	{
		// Token: 0x0600080B RID: 2059 RVA: 0x000267B4 File Offset: 0x000249B4
		public SkinnedMeshAttachment(string name) : base(name)
		{
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600080C RID: 2060 RVA: 0x000267EC File Offset: 0x000249EC
		// (set) Token: 0x0600080D RID: 2061 RVA: 0x000267F4 File Offset: 0x000249F4
		public int HullLength { get; set; }

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600080E RID: 2062 RVA: 0x00026800 File Offset: 0x00024A00
		// (set) Token: 0x0600080F RID: 2063 RVA: 0x00026808 File Offset: 0x00024A08
		public int[] Bones
		{
			get
			{
				return this.bones;
			}
			set
			{
				this.bones = value;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000810 RID: 2064 RVA: 0x00026814 File Offset: 0x00024A14
		// (set) Token: 0x06000811 RID: 2065 RVA: 0x0002681C File Offset: 0x00024A1C
		public float[] Weights
		{
			get
			{
				return this.weights;
			}
			set
			{
				this.weights = value;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000812 RID: 2066 RVA: 0x00026828 File Offset: 0x00024A28
		// (set) Token: 0x06000813 RID: 2067 RVA: 0x00026830 File Offset: 0x00024A30
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

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000814 RID: 2068 RVA: 0x0002683C File Offset: 0x00024A3C
		// (set) Token: 0x06000815 RID: 2069 RVA: 0x00026844 File Offset: 0x00024A44
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

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000816 RID: 2070 RVA: 0x00026850 File Offset: 0x00024A50
		// (set) Token: 0x06000817 RID: 2071 RVA: 0x00026858 File Offset: 0x00024A58
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

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000818 RID: 2072 RVA: 0x00026864 File Offset: 0x00024A64
		// (set) Token: 0x06000819 RID: 2073 RVA: 0x0002686C File Offset: 0x00024A6C
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

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600081A RID: 2074 RVA: 0x00026878 File Offset: 0x00024A78
		// (set) Token: 0x0600081B RID: 2075 RVA: 0x00026880 File Offset: 0x00024A80
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

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600081C RID: 2076 RVA: 0x0002688C File Offset: 0x00024A8C
		// (set) Token: 0x0600081D RID: 2077 RVA: 0x00026894 File Offset: 0x00024A94
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

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600081E RID: 2078 RVA: 0x000268A0 File Offset: 0x00024AA0
		// (set) Token: 0x0600081F RID: 2079 RVA: 0x000268A8 File Offset: 0x00024AA8
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

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000820 RID: 2080 RVA: 0x000268B4 File Offset: 0x00024AB4
		// (set) Token: 0x06000821 RID: 2081 RVA: 0x000268BC File Offset: 0x00024ABC
		public string Path { get; set; }

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000822 RID: 2082 RVA: 0x000268C8 File Offset: 0x00024AC8
		// (set) Token: 0x06000823 RID: 2083 RVA: 0x000268D0 File Offset: 0x00024AD0
		public object RendererObject { get; set; }

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000824 RID: 2084 RVA: 0x000268DC File Offset: 0x00024ADC
		// (set) Token: 0x06000825 RID: 2085 RVA: 0x000268E4 File Offset: 0x00024AE4
		public float RegionU { get; set; }

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000826 RID: 2086 RVA: 0x000268F0 File Offset: 0x00024AF0
		// (set) Token: 0x06000827 RID: 2087 RVA: 0x000268F8 File Offset: 0x00024AF8
		public float RegionV { get; set; }

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000828 RID: 2088 RVA: 0x00026904 File Offset: 0x00024B04
		// (set) Token: 0x06000829 RID: 2089 RVA: 0x0002690C File Offset: 0x00024B0C
		public float RegionU2 { get; set; }

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600082A RID: 2090 RVA: 0x00026918 File Offset: 0x00024B18
		// (set) Token: 0x0600082B RID: 2091 RVA: 0x00026920 File Offset: 0x00024B20
		public float RegionV2 { get; set; }

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600082C RID: 2092 RVA: 0x0002692C File Offset: 0x00024B2C
		// (set) Token: 0x0600082D RID: 2093 RVA: 0x00026934 File Offset: 0x00024B34
		public bool RegionRotate { get; set; }

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600082E RID: 2094 RVA: 0x00026940 File Offset: 0x00024B40
		// (set) Token: 0x0600082F RID: 2095 RVA: 0x00026948 File Offset: 0x00024B48
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

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000830 RID: 2096 RVA: 0x00026954 File Offset: 0x00024B54
		// (set) Token: 0x06000831 RID: 2097 RVA: 0x0002695C File Offset: 0x00024B5C
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

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000832 RID: 2098 RVA: 0x00026968 File Offset: 0x00024B68
		// (set) Token: 0x06000833 RID: 2099 RVA: 0x00026970 File Offset: 0x00024B70
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

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000834 RID: 2100 RVA: 0x0002697C File Offset: 0x00024B7C
		// (set) Token: 0x06000835 RID: 2101 RVA: 0x00026984 File Offset: 0x00024B84
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

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000836 RID: 2102 RVA: 0x00026990 File Offset: 0x00024B90
		// (set) Token: 0x06000837 RID: 2103 RVA: 0x00026998 File Offset: 0x00024B98
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

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000838 RID: 2104 RVA: 0x000269A4 File Offset: 0x00024BA4
		// (set) Token: 0x06000839 RID: 2105 RVA: 0x000269AC File Offset: 0x00024BAC
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

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600083A RID: 2106 RVA: 0x000269B8 File Offset: 0x00024BB8
		// (set) Token: 0x0600083B RID: 2107 RVA: 0x000269C0 File Offset: 0x00024BC0
		public int[] Edges { get; set; }

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600083C RID: 2108 RVA: 0x000269CC File Offset: 0x00024BCC
		// (set) Token: 0x0600083D RID: 2109 RVA: 0x000269D4 File Offset: 0x00024BD4
		public float Width { get; set; }

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600083E RID: 2110 RVA: 0x000269E0 File Offset: 0x00024BE0
		// (set) Token: 0x0600083F RID: 2111 RVA: 0x000269E8 File Offset: 0x00024BE8
		public float Height { get; set; }

		// Token: 0x06000840 RID: 2112 RVA: 0x000269F4 File Offset: 0x00024BF4
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

		// Token: 0x06000841 RID: 2113 RVA: 0x00026AF4 File Offset: 0x00024CF4
		public void ComputeWorldVertices(Slot slot, float[] worldVertices)
		{
			Skeleton skeleton = slot.bone.skeleton;
			List<Bone> list = skeleton.bones;
			float x = skeleton.x;
			float y = skeleton.y;
			float[] array = this.weights;
			int[] array2 = this.bones;
			if (slot.attachmentVerticesCount == 0)
			{
				int num = 0;
				int i = 0;
				int num2 = 0;
				int num3 = array2.Length;
				while (i < num3)
				{
					float num4 = 0f;
					float num5 = 0f;
					int num6 = array2[i++] + i;
					while (i < num6)
					{
						Bone bone = list[array2[i]];
						float num7 = array[num2];
						float num8 = array[num2 + 1];
						float num9 = array[num2 + 2];
						num4 += (num7 * bone.m00 + num8 * bone.m01 + bone.worldX) * num9;
						num5 += (num7 * bone.m10 + num8 * bone.m11 + bone.worldY) * num9;
						i++;
						num2 += 3;
					}
					worldVertices[num] = num4 + x;
					worldVertices[num + 1] = num5 + y;
					num += 2;
				}
			}
			else
			{
				float[] attachmentVertices = slot.AttachmentVertices;
				int num10 = 0;
				int j = 0;
				int num11 = 0;
				int num12 = 0;
				int num13 = array2.Length;
				while (j < num13)
				{
					float num14 = 0f;
					float num15 = 0f;
					int num16 = array2[j++] + j;
					while (j < num16)
					{
						Bone bone2 = list[array2[j]];
						float num17 = array[num11] + attachmentVertices[num12];
						float num18 = array[num11 + 1] + attachmentVertices[num12 + 1];
						float num19 = array[num11 + 2];
						num14 += (num17 * bone2.m00 + num18 * bone2.m01 + bone2.worldX) * num19;
						num15 += (num17 * bone2.m10 + num18 * bone2.m11 + bone2.worldY) * num19;
						j++;
						num11 += 3;
						num12 += 2;
					}
					worldVertices[num10] = num14 + x;
					worldVertices[num10 + 1] = num15 + y;
					num10 += 2;
				}
			}
		}

		// Token: 0x04000558 RID: 1368
		internal int[] bones;

		// Token: 0x04000559 RID: 1369
		internal float[] weights;

		// Token: 0x0400055A RID: 1370
		internal float[] uvs;

		// Token: 0x0400055B RID: 1371
		internal float[] regionUVs;

		// Token: 0x0400055C RID: 1372
		internal int[] triangles;

		// Token: 0x0400055D RID: 1373
		internal float regionOffsetX;

		// Token: 0x0400055E RID: 1374
		internal float regionOffsetY;

		// Token: 0x0400055F RID: 1375
		internal float regionWidth;

		// Token: 0x04000560 RID: 1376
		internal float regionHeight;

		// Token: 0x04000561 RID: 1377
		internal float regionOriginalWidth;

		// Token: 0x04000562 RID: 1378
		internal float regionOriginalHeight;

		// Token: 0x04000563 RID: 1379
		internal float r = 1f;

		// Token: 0x04000564 RID: 1380
		internal float g = 1f;

		// Token: 0x04000565 RID: 1381
		internal float b = 1f;

		// Token: 0x04000566 RID: 1382
		internal float a = 1f;
	}
}
