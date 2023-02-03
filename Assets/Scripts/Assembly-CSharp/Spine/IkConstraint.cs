using System;
using System.Collections.Generic;

namespace Spine
{
	// Token: 0x02000125 RID: 293
	public class IkConstraint
	{
		// Token: 0x06000894 RID: 2196 RVA: 0x00027470 File Offset: 0x00025670
		public IkConstraint(IkConstraintData data, Skeleton skeleton)
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
			this.mix = data.mix;
			this.bendDirection = data.bendDirection;
			this.bones = new List<Bone>(data.bones.Count);
			foreach (BoneData boneData in data.bones)
			{
				this.bones.Add(skeleton.FindBone(boneData.name));
			}
			this.target = skeleton.FindBone(data.target.name);
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000895 RID: 2197 RVA: 0x00027568 File Offset: 0x00025768
		public IkConstraintData Data
		{
			get
			{
				return this.data;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000896 RID: 2198 RVA: 0x00027570 File Offset: 0x00025770
		public List<Bone> Bones
		{
			get
			{
				return this.bones;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000897 RID: 2199 RVA: 0x00027578 File Offset: 0x00025778
		// (set) Token: 0x06000898 RID: 2200 RVA: 0x00027580 File Offset: 0x00025780
		public Bone Target
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

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000899 RID: 2201 RVA: 0x0002758C File Offset: 0x0002578C
		// (set) Token: 0x0600089A RID: 2202 RVA: 0x00027594 File Offset: 0x00025794
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

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x0600089B RID: 2203 RVA: 0x000275A0 File Offset: 0x000257A0
		// (set) Token: 0x0600089C RID: 2204 RVA: 0x000275A8 File Offset: 0x000257A8
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

		// Token: 0x0600089D RID: 2205 RVA: 0x000275B4 File Offset: 0x000257B4
		public void apply()
		{
			Bone bone = this.target;
			List<Bone> list = this.bones;
			int count = list.Count;
			if (count != 1)
			{
				if (count == 2)
				{
					IkConstraint.apply(list[0], list[1], bone.worldX, bone.worldY, this.bendDirection, this.mix);
				}
			}
			else
			{
				IkConstraint.apply(list[0], bone.worldX, bone.worldY, this.mix);
			}
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x0002763C File Offset: 0x0002583C
		public override string ToString()
		{
			return this.data.name;
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x0002764C File Offset: 0x0002584C
		public static void apply(Bone bone, float targetX, float targetY, float alpha)
		{
			float num = (bone.data.inheritRotation && bone.parent != null) ? bone.parent.worldRotation : 0f;
			float rotation = bone.rotation;
			float num2 = (float)Math.Atan2((double)(targetY - bone.worldY), (double)(targetX - bone.worldX)) * 57.295776f - num;
			bone.rotationIK = rotation + (num2 - rotation) * alpha;
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x000276C0 File Offset: 0x000258C0
		public static void apply(Bone parent, Bone child, float targetX, float targetY, int bendDirection, float alpha)
		{
			float rotation = child.rotation;
			float rotation2 = parent.rotation;
			if (alpha == 0f)
			{
				child.rotationIK = rotation;
				parent.rotationIK = rotation2;
				return;
			}
			Bone parent2 = parent.parent;
			float x;
			float y;
			if (parent2 != null)
			{
				parent2.worldToLocal(targetX, targetY, out x, out y);
				targetX = (x - parent.x) * parent2.worldScaleX;
				targetY = (y - parent.y) * parent2.worldScaleY;
			}
			else
			{
				targetX -= parent.x;
				targetY -= parent.y;
			}
			if (child.parent == parent)
			{
				x = child.x;
				y = child.y;
			}
			else
			{
				child.parent.localToWorld(child.x, child.y, out x, out y);
				parent.worldToLocal(x, y, out x, out y);
			}
			float num = x * parent.worldScaleX;
			float num2 = y * parent.worldScaleY;
			float num3 = (float)Math.Atan2((double)num2, (double)num);
			float num4 = (float)Math.Sqrt((double)(num * num + num2 * num2));
			float num5 = child.data.length * child.worldScaleX;
			float num6 = 2f * num4 * num5;
			if (num6 < 0.0001f)
			{
				child.rotationIK = rotation + ((float)Math.Atan2((double)targetY, (double)targetX) * 57.295776f - rotation2 - rotation) * alpha;
				return;
			}
			float num7 = (targetX * targetX + targetY * targetY - num4 * num4 - num5 * num5) / num6;
			if (num7 < -1f)
			{
				num7 = -1f;
			}
			else if (num7 > 1f)
			{
				num7 = 1f;
			}
			float num8 = (float)Math.Acos((double)num7) * (float)bendDirection;
			float num9 = num4 + num5 * num7;
			float num10 = num5 * (float)Math.Sin((double)num8);
			float num11 = (float)Math.Atan2((double)(targetY * num9 - targetX * num10), (double)(targetX * num9 + targetY * num10));
			float num12 = (num11 - num3) * 57.295776f - rotation2;
			if (num12 > 180f)
			{
				num12 -= 360f;
			}
			else if (num12 < -180f)
			{
				num12 += 360f;
			}
			parent.rotationIK = rotation2 + num12 * alpha;
			num12 = (num8 + num3) * 57.295776f - rotation;
			if (num12 > 180f)
			{
				num12 -= 360f;
			}
			else if (num12 < -180f)
			{
				num12 += 360f;
			}
			child.rotationIK = rotation + (num12 + parent.worldRotation - child.parent.worldRotation) * alpha;
		}

		// Token: 0x0400059E RID: 1438
		private const float radDeg = 57.295776f;

		// Token: 0x0400059F RID: 1439
		internal IkConstraintData data;

		// Token: 0x040005A0 RID: 1440
		internal List<Bone> bones = new List<Bone>();

		// Token: 0x040005A1 RID: 1441
		internal Bone target;

		// Token: 0x040005A2 RID: 1442
		internal int bendDirection;

		// Token: 0x040005A3 RID: 1443
		internal float mix;
	}
}
