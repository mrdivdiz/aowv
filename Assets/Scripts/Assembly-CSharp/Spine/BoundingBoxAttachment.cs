using System;

namespace Spine
{
	// Token: 0x0200011D RID: 285
	public class BoundingBoxAttachment : Attachment
	{
		// Token: 0x060007A6 RID: 1958 RVA: 0x00025E4C File Offset: 0x0002404C
		public BoundingBoxAttachment(string name) : base(name)
		{
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060007A7 RID: 1959 RVA: 0x00025E58 File Offset: 0x00024058
		// (set) Token: 0x060007A8 RID: 1960 RVA: 0x00025E60 File Offset: 0x00024060
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

		// Token: 0x060007A9 RID: 1961 RVA: 0x00025E6C File Offset: 0x0002406C
		public void ComputeWorldVertices(Bone bone, float[] worldVertices)
		{
			float num = bone.skeleton.x + bone.worldX;
			float num2 = bone.skeleton.y + bone.worldY;
			float m = bone.m00;
			float m2 = bone.m01;
			float m3 = bone.m10;
			float m4 = bone.m11;
			float[] array = this.vertices;
			int i = 0;
			int num3 = array.Length;
			while (i < num3)
			{
				float num4 = array[i];
				float num5 = array[i + 1];
				worldVertices[i] = num4 * m + num5 * m2 + num;
				worldVertices[i + 1] = num4 * m3 + num5 * m4 + num2;
				i += 2;
			}
		}

		// Token: 0x04000521 RID: 1313
		internal float[] vertices;
	}
}
