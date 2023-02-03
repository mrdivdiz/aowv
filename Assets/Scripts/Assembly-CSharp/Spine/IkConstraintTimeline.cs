using System;
using System.Collections.Generic;

namespace Spine
{
	// Token: 0x0200010C RID: 268
	public class IkConstraintTimeline : CurveTimeline
	{
		// Token: 0x0600073E RID: 1854 RVA: 0x0002463C File Offset: 0x0002283C
		public IkConstraintTimeline(int frameCount) : base(frameCount)
		{
			this.frames = new float[frameCount * 3];
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600073F RID: 1855 RVA: 0x00024654 File Offset: 0x00022854
		// (set) Token: 0x06000740 RID: 1856 RVA: 0x0002465C File Offset: 0x0002285C
		public int IkConstraintIndex
		{
			get
			{
				return this.ikConstraintIndex;
			}
			set
			{
				this.ikConstraintIndex = value;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000741 RID: 1857 RVA: 0x00024668 File Offset: 0x00022868
		// (set) Token: 0x06000742 RID: 1858 RVA: 0x00024670 File Offset: 0x00022870
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

		// Token: 0x06000743 RID: 1859 RVA: 0x0002467C File Offset: 0x0002287C
		public void setFrame(int frameIndex, float time, float mix, int bendDirection)
		{
			frameIndex *= 3;
			this.frames[frameIndex] = time;
			this.frames[frameIndex + 1] = mix;
			this.frames[frameIndex + 2] = (float)bendDirection;
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x000246B0 File Offset: 0x000228B0
		public override void Apply(Skeleton skeleton, float lastTime, float time, List<Event> firedEvents, float alpha)
		{
			float[] array = this.frames;
			if (time < array[0])
			{
				return;
			}
			IkConstraint ikConstraint = skeleton.ikConstraints[this.ikConstraintIndex];
			if (time >= array[array.Length - 3])
			{
				ikConstraint.mix += (array[array.Length - 2] - ikConstraint.mix) * alpha;
				ikConstraint.bendDirection = (int)array[array.Length - 1];
				return;
			}
			int num = Animation.binarySearch(array, time, 3);
			float num2 = array[num + -2];
			float num3 = array[num];
			float num4 = 1f - (time - num3) / (array[num + -3] - num3);
			num4 = base.GetCurvePercent(num / 3 - 1, (num4 >= 0f) ? ((num4 <= 1f) ? num4 : 1f) : 0f);
			float num5 = num2 + (array[num + 1] - num2) * num4;
			ikConstraint.mix += (num5 - ikConstraint.mix) * alpha;
			ikConstraint.bendDirection = (int)array[num + -1];
		}

		// Token: 0x040004C5 RID: 1221
		private const int PREV_FRAME_TIME = -3;

		// Token: 0x040004C6 RID: 1222
		private const int PREV_FRAME_MIX = -2;

		// Token: 0x040004C7 RID: 1223
		private const int PREV_FRAME_BEND_DIRECTION = -1;

		// Token: 0x040004C8 RID: 1224
		private const int FRAME_MIX = 1;

		// Token: 0x040004C9 RID: 1225
		internal int ikConstraintIndex;

		// Token: 0x040004CA RID: 1226
		internal float[] frames;
	}
}
