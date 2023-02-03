using System;
using System.Collections.Generic;

namespace Spine
{
	// Token: 0x02000104 RID: 260
	public class RotateTimeline : CurveTimeline
	{
		// Token: 0x06000702 RID: 1794 RVA: 0x00023908 File Offset: 0x00021B08
		public RotateTimeline(int frameCount) : base(frameCount)
		{
			this.frames = new float[frameCount << 1];
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000703 RID: 1795 RVA: 0x00023920 File Offset: 0x00021B20
		// (set) Token: 0x06000704 RID: 1796 RVA: 0x00023928 File Offset: 0x00021B28
		public int BoneIndex
		{
			get
			{
				return this.boneIndex;
			}
			set
			{
				this.boneIndex = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000705 RID: 1797 RVA: 0x00023934 File Offset: 0x00021B34
		// (set) Token: 0x06000706 RID: 1798 RVA: 0x0002393C File Offset: 0x00021B3C
		public float[] Frames
		{
			get
			{
				return this.frames;
			}
			set
			{
				this.frames = value;
			}
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x00023948 File Offset: 0x00021B48
		public void SetFrame(int frameIndex, float time, float angle)
		{
			frameIndex *= 2;
			this.frames[frameIndex] = time;
			this.frames[frameIndex + 1] = angle;
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x00023964 File Offset: 0x00021B64
		public override void Apply(Skeleton skeleton, float lastTime, float time, List<Event> firedEvents, float alpha)
		{
			float[] array = this.frames;
			if (time < array[0])
			{
				return;
			}
			Bone bone = skeleton.bones[this.boneIndex];
			float num;
			if (time >= array[array.Length - 2])
			{
				for (num = bone.data.rotation + array[array.Length - 1] - bone.rotation; num > 180f; num -= 360f)
				{
				}
				while (num < -180f)
				{
					num += 360f;
				}
				bone.rotation += num * alpha;
				return;
			}
			int num2 = Animation.binarySearch(array, time, 2);
			float num3 = array[num2 - 1];
			float num4 = array[num2];
			float num5 = 1f - (time - num4) / (array[num2 + -2] - num4);
			num5 = base.GetCurvePercent((num2 >> 1) - 1, (num5 >= 0f) ? ((num5 <= 1f) ? num5 : 1f) : 0f);
			for (num = array[num2 + 1] - num3; num > 180f; num -= 360f)
			{
			}
			while (num < -180f)
			{
				num += 360f;
			}
			for (num = bone.data.rotation + (num3 + num * num5) - bone.rotation; num > 180f; num -= 360f)
			{
			}
			while (num < -180f)
			{
				num += 360f;
			}
			bone.rotation += num * alpha;
		}

		// Token: 0x040004AA RID: 1194
		protected const int PREV_FRAME_TIME = -2;

		// Token: 0x040004AB RID: 1195
		protected const int FRAME_VALUE = 1;

		// Token: 0x040004AC RID: 1196
		internal int boneIndex;

		// Token: 0x040004AD RID: 1197
		internal float[] frames;
	}
}
