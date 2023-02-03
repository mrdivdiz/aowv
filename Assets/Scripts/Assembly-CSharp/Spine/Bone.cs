using System;
using System.Collections.Generic;

namespace Spine
{
	// Token: 0x02000121 RID: 289
	public class Bone
	{
		// Token: 0x06000842 RID: 2114 RVA: 0x00026D1C File Offset: 0x00024F1C
		public Bone(BoneData data, Skeleton skeleton, Bone parent)
		{
			if (data == null)
			{
				throw new ArgumentNullException("data cannot be null.");
			}
			if (skeleton == null)
			{
				throw new ArgumentNullException("skeleton cannot be null.");
			}
			this.data = data;
			this.skeleton = skeleton;
			this.parent = parent;
			this.SetToSetupPose();
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000843 RID: 2115 RVA: 0x00026D78 File Offset: 0x00024F78
		public BoneData Data
		{
			get
			{
				return this.data;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000844 RID: 2116 RVA: 0x00026D80 File Offset: 0x00024F80
		public Skeleton Skeleton
		{
			get
			{
				return this.skeleton;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000845 RID: 2117 RVA: 0x00026D88 File Offset: 0x00024F88
		public Bone Parent
		{
			get
			{
				return this.parent;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000846 RID: 2118 RVA: 0x00026D90 File Offset: 0x00024F90
		public List<Bone> Children
		{
			get
			{
				return this.children;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000847 RID: 2119 RVA: 0x00026D98 File Offset: 0x00024F98
		// (set) Token: 0x06000848 RID: 2120 RVA: 0x00026DA0 File Offset: 0x00024FA0
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

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000849 RID: 2121 RVA: 0x00026DAC File Offset: 0x00024FAC
		// (set) Token: 0x0600084A RID: 2122 RVA: 0x00026DB4 File Offset: 0x00024FB4
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

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600084B RID: 2123 RVA: 0x00026DC0 File Offset: 0x00024FC0
		// (set) Token: 0x0600084C RID: 2124 RVA: 0x00026DC8 File Offset: 0x00024FC8
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

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600084D RID: 2125 RVA: 0x00026DD4 File Offset: 0x00024FD4
		// (set) Token: 0x0600084E RID: 2126 RVA: 0x00026DDC File Offset: 0x00024FDC
		public float RotationIK
		{
			get
			{
				return this.rotationIK;
			}
			set
			{
				this.rotationIK = value;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600084F RID: 2127 RVA: 0x00026DE8 File Offset: 0x00024FE8
		// (set) Token: 0x06000850 RID: 2128 RVA: 0x00026DF0 File Offset: 0x00024FF0
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

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000851 RID: 2129 RVA: 0x00026DFC File Offset: 0x00024FFC
		// (set) Token: 0x06000852 RID: 2130 RVA: 0x00026E04 File Offset: 0x00025004
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

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000853 RID: 2131 RVA: 0x00026E10 File Offset: 0x00025010
		// (set) Token: 0x06000854 RID: 2132 RVA: 0x00026E18 File Offset: 0x00025018
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

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000855 RID: 2133 RVA: 0x00026E24 File Offset: 0x00025024
		// (set) Token: 0x06000856 RID: 2134 RVA: 0x00026E2C File Offset: 0x0002502C
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

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000857 RID: 2135 RVA: 0x00026E38 File Offset: 0x00025038
		public float M00
		{
			get
			{
				return this.m00;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000858 RID: 2136 RVA: 0x00026E40 File Offset: 0x00025040
		public float M01
		{
			get
			{
				return this.m01;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000859 RID: 2137 RVA: 0x00026E48 File Offset: 0x00025048
		public float M10
		{
			get
			{
				return this.m10;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600085A RID: 2138 RVA: 0x00026E50 File Offset: 0x00025050
		public float M11
		{
			get
			{
				return this.m11;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600085B RID: 2139 RVA: 0x00026E58 File Offset: 0x00025058
		public float WorldX
		{
			get
			{
				return this.worldX;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600085C RID: 2140 RVA: 0x00026E60 File Offset: 0x00025060
		public float WorldY
		{
			get
			{
				return this.worldY;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600085D RID: 2141 RVA: 0x00026E68 File Offset: 0x00025068
		public float WorldRotation
		{
			get
			{
				return this.worldRotation;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x0600085E RID: 2142 RVA: 0x00026E70 File Offset: 0x00025070
		public float WorldScaleX
		{
			get
			{
				return this.worldScaleX;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600085F RID: 2143 RVA: 0x00026E78 File Offset: 0x00025078
		public float WorldScaleY
		{
			get
			{
				return this.worldScaleY;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000860 RID: 2144 RVA: 0x00026E80 File Offset: 0x00025080
		// (set) Token: 0x06000861 RID: 2145 RVA: 0x00026E88 File Offset: 0x00025088
		public bool WorldFlipX
		{
			get
			{
				return this.worldFlipX;
			}
			set
			{
				this.worldFlipX = value;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000862 RID: 2146 RVA: 0x00026E94 File Offset: 0x00025094
		// (set) Token: 0x06000863 RID: 2147 RVA: 0x00026E9C File Offset: 0x0002509C
		public bool WorldFlipY
		{
			get
			{
				return this.worldFlipY;
			}
			set
			{
				this.worldFlipY = value;
			}
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x00026EA8 File Offset: 0x000250A8
		public void UpdateWorldTransform()
		{
			Bone bone = this.parent;
			Skeleton skeleton = this.skeleton;
			float num = this.x;
			float num2 = this.y;
			if (bone != null)
			{
				this.worldX = num * bone.m00 + num2 * bone.m01 + bone.worldX;
				this.worldY = num * bone.m10 + num2 * bone.m11 + bone.worldY;
				if (this.data.inheritScale)
				{
					this.worldScaleX = bone.worldScaleX * this.scaleX;
					this.worldScaleY = bone.worldScaleY * this.scaleY;
				}
				else
				{
					this.worldScaleX = this.scaleX;
					this.worldScaleY = this.scaleY;
				}
				this.worldRotation = ((!this.data.inheritRotation) ? this.rotationIK : (bone.worldRotation + this.rotationIK));
				this.worldFlipX = (bone.worldFlipX ^ this.flipX);
				this.worldFlipY = (bone.worldFlipY ^ this.flipY);
			}
			else
			{
				bool flag = skeleton.flipX;
				bool flag2 = skeleton.flipY;
				this.worldX = ((!flag) ? num : (-num));
				this.worldY = ((flag2 == Bone.yDown) ? num2 : (-num2));
				this.worldScaleX = this.scaleX;
				this.worldScaleY = this.scaleY;
				this.worldRotation = this.rotationIK;
				this.worldFlipX = (flag ^ this.flipX);
				this.worldFlipY = (flag2 ^ this.flipY);
			}
			float num3 = this.worldRotation * 3.1415927f / 180f;
			float num4 = (float)Math.Cos((double)num3);
			float num5 = (float)Math.Sin((double)num3);
			if (this.worldFlipX)
			{
				this.m00 = -num4 * this.worldScaleX;
				this.m01 = num5 * this.worldScaleY;
			}
			else
			{
				this.m00 = num4 * this.worldScaleX;
				this.m01 = -num5 * this.worldScaleY;
			}
			if (this.worldFlipY != Bone.yDown)
			{
				this.m10 = -num5 * this.worldScaleX;
				this.m11 = -num4 * this.worldScaleY;
			}
			else
			{
				this.m10 = num5 * this.worldScaleX;
				this.m11 = num4 * this.worldScaleY;
			}
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x0002710C File Offset: 0x0002530C
		public void SetToSetupPose()
		{
			BoneData boneData = this.data;
			this.x = boneData.x;
			this.y = boneData.y;
			this.rotation = boneData.rotation;
			this.rotationIK = this.rotation;
			this.scaleX = boneData.scaleX;
			this.scaleY = boneData.scaleY;
			this.flipX = boneData.flipX;
			this.flipY = boneData.flipY;
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x00027180 File Offset: 0x00025380
		public void worldToLocal(float worldX, float worldY, out float localX, out float localY)
		{
			float num = worldX - this.worldX;
			float num2 = worldY - this.worldY;
			float num3 = this.m00;
			float num4 = this.m10;
			float num5 = this.m01;
			float num6 = this.m11;
			if (this.worldFlipX != (this.worldFlipY != Bone.yDown))
			{
				num3 = -num3;
				num6 = -num6;
			}
			float num7 = 1f / (num3 * num6 - num5 * num4);
			localX = num * num3 * num7 - num2 * num5 * num7;
			localY = num2 * num6 * num7 - num * num4 * num7;
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00027214 File Offset: 0x00025414
		public void localToWorld(float localX, float localY, out float worldX, out float worldY)
		{
			worldX = localX * this.m00 + localY * this.m01 + this.worldX;
			worldY = localX * this.m10 + localY * this.m11 + this.worldY;
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x0002724C File Offset: 0x0002544C
		public override string ToString()
		{
			return this.data.name;
		}

		// Token: 0x04000572 RID: 1394
		public static bool yDown;

		// Token: 0x04000573 RID: 1395
		internal BoneData data;

		// Token: 0x04000574 RID: 1396
		internal Skeleton skeleton;

		// Token: 0x04000575 RID: 1397
		internal Bone parent;

		// Token: 0x04000576 RID: 1398
		internal List<Bone> children = new List<Bone>();

		// Token: 0x04000577 RID: 1399
		internal float x;

		// Token: 0x04000578 RID: 1400
		internal float y;

		// Token: 0x04000579 RID: 1401
		internal float rotation;

		// Token: 0x0400057A RID: 1402
		internal float rotationIK;

		// Token: 0x0400057B RID: 1403
		internal float scaleX;

		// Token: 0x0400057C RID: 1404
		internal float scaleY;

		// Token: 0x0400057D RID: 1405
		internal bool flipX;

		// Token: 0x0400057E RID: 1406
		internal bool flipY;

		// Token: 0x0400057F RID: 1407
		internal float m00;

		// Token: 0x04000580 RID: 1408
		internal float m01;

		// Token: 0x04000581 RID: 1409
		internal float m10;

		// Token: 0x04000582 RID: 1410
		internal float m11;

		// Token: 0x04000583 RID: 1411
		internal float worldX;

		// Token: 0x04000584 RID: 1412
		internal float worldY;

		// Token: 0x04000585 RID: 1413
		internal float worldRotation;

		// Token: 0x04000586 RID: 1414
		internal float worldScaleX;

		// Token: 0x04000587 RID: 1415
		internal float worldScaleY;

		// Token: 0x04000588 RID: 1416
		internal bool worldFlipX;

		// Token: 0x04000589 RID: 1417
		internal bool worldFlipY;
	}
}
