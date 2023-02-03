using System;
using System.Collections.Generic;

namespace Spine
{
	// Token: 0x02000105 RID: 261
	public class TranslateTimeline : CurveTimeline
	{
		// Token: 0x06000709 RID: 1801 RVA: 0x00023AFC File Offset: 0x00021CFC
		public TranslateTimeline(int frameCount) : base(frameCount)
		{
			this.frames = new float[frameCount * 3];
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600070A RID: 1802 RVA: 0x00023B14 File Offset: 0x00021D14
		// (set) Token: 0x0600070B RID: 1803 RVA: 0x00023B1C File Offset: 0x00021D1C
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

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600070C RID: 1804 RVA: 0x00023B28 File Offset: 0x00021D28
		// (set) Token: 0x0600070D RID: 1805 RVA: 0x00023B30 File Offset: 0x00021D30
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

		// Token: 0x0600070E RID: 1806 RVA: 0x00023B3C File Offset: 0x00021D3C
		public void SetFrame(int frameIndex, float time, float x, float y)
		{
			frameIndex *= 3;
			this.frames[frameIndex] = time;
			this.frames[frameIndex + 1] = x;
			this.frames[frameIndex + 2] = y;
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x00023B64 File Offset: 0x00021D64
		public override void Apply(Skeleton skeleton, float lastTime, float time, List<Event> firedEvents, float alpha)
		{
			float[] array = this.frames;
			if (time < array[0])
			{
				return;
			}
			Bone bone = skeleton.bones[this.boneIndex];
			if (time >= array[array.Length - 3])
			{
				bone.x += (bone.data.x + array[array.Length - 2] - bone.x) * alpha;
				bone.y += (bone.data.y + array[array.Length - 1] - bone.y) * alpha;
				return;
			}
			int num = Animation.binarySearch(array, time, 3);
			float num2 = array[num - 2];
			float num3 = array[num - 1];
			float num4 = array[num];
			float num5 = 1f - (time - num4) / (array[num + -3] - num4);
			num5 = base.GetCurvePercent(num / 3 - 1, (num5 >= 0f) ? ((num5 <= 1f) ? num5 : 1f) : 0f);
			bone.x += (bone.data.x + num2 + (array[num + 1] - num2) * num5 - bone.x) * alpha;
			bone.y += (bone.data.y + num3 + (array[num + 2] - num3) * num5 - bone.y) * alpha;
		}

		// Token: 0x040004AE RID: 1198
		protected const int PREV_FRAME_TIME = -3;

		// Token: 0x040004AF RID: 1199
		protected const int FRAME_X = 1;

		// Token: 0x040004B0 RID: 1200
		protected const int FRAME_Y = 2;

		// Token: 0x040004B1 RID: 1201
		internal int boneIndex;

		// Token: 0x040004B2 RID: 1202
		internal float[] frames;
	}
}
