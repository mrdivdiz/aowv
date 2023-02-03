using System;
using System.Collections.Generic;

namespace Spine
{
	// Token: 0x02000107 RID: 263
	public class ColorTimeline : CurveTimeline
	{
		// Token: 0x06000712 RID: 1810 RVA: 0x00023E30 File Offset: 0x00022030
		public ColorTimeline(int frameCount) : base(frameCount)
		{
			this.frames = new float[frameCount * 5];
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000713 RID: 1811 RVA: 0x00023E48 File Offset: 0x00022048
		// (set) Token: 0x06000714 RID: 1812 RVA: 0x00023E50 File Offset: 0x00022050
		public int SlotIndex
		{
			get
			{
				return this.slotIndex;
			}
			set
			{
				this.slotIndex = value;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000715 RID: 1813 RVA: 0x00023E5C File Offset: 0x0002205C
		// (set) Token: 0x06000716 RID: 1814 RVA: 0x00023E64 File Offset: 0x00022064
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

		// Token: 0x06000717 RID: 1815 RVA: 0x00023E70 File Offset: 0x00022070
		public void setFrame(int frameIndex, float time, float r, float g, float b, float a)
		{
			frameIndex *= 5;
			this.frames[frameIndex] = time;
			this.frames[frameIndex + 1] = r;
			this.frames[frameIndex + 2] = g;
			this.frames[frameIndex + 3] = b;
			this.frames[frameIndex + 4] = a;
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x00023EB0 File Offset: 0x000220B0
		public override void Apply(Skeleton skeleton, float lastTime, float time, List<Event> firedEvents, float alpha)
		{
			float[] array = this.frames;
			if (time < array[0])
			{
				return;
			}
			float num2;
			float num3;
			float num4;
			float num5;
			if (time >= array[array.Length - 5])
			{
				int num = array.Length - 1;
				num2 = array[num - 3];
				num3 = array[num - 2];
				num4 = array[num - 1];
				num5 = array[num];
			}
			else
			{
				int num6 = Animation.binarySearch(array, time, 5);
				float num7 = array[num6 - 4];
				float num8 = array[num6 - 3];
				float num9 = array[num6 - 2];
				float num10 = array[num6 - 1];
				float num11 = array[num6];
				float num12 = 1f - (time - num11) / (array[num6 + -5] - num11);
				num12 = base.GetCurvePercent(num6 / 5 - 1, (num12 >= 0f) ? ((num12 <= 1f) ? num12 : 1f) : 0f);
				num2 = num7 + (array[num6 + 1] - num7) * num12;
				num3 = num8 + (array[num6 + 2] - num8) * num12;
				num4 = num9 + (array[num6 + 3] - num9) * num12;
				num5 = num10 + (array[num6 + 4] - num10) * num12;
			}
			Slot slot = skeleton.slots[this.slotIndex];
			if (alpha < 1f)
			{
				slot.r += (num2 - slot.r) * alpha;
				slot.g += (num3 - slot.g) * alpha;
				slot.b += (num4 - slot.b) * alpha;
				slot.a += (num5 - slot.a) * alpha;
			}
			else
			{
				slot.r = num2;
				slot.g = num3;
				slot.b = num4;
				slot.a = num5;
			}
		}

		// Token: 0x040004B3 RID: 1203
		protected const int PREV_FRAME_TIME = -5;

		// Token: 0x040004B4 RID: 1204
		protected const int FRAME_R = 1;

		// Token: 0x040004B5 RID: 1205
		protected const int FRAME_G = 2;

		// Token: 0x040004B6 RID: 1206
		protected const int FRAME_B = 3;

		// Token: 0x040004B7 RID: 1207
		protected const int FRAME_A = 4;

		// Token: 0x040004B8 RID: 1208
		internal int slotIndex;

		// Token: 0x040004B9 RID: 1209
		internal float[] frames;
	}
}
