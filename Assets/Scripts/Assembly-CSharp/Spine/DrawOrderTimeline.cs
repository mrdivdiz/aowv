using System;
using System.Collections.Generic;

namespace Spine
{
	// Token: 0x0200010A RID: 266
	public class DrawOrderTimeline : Timeline
	{
		// Token: 0x0600072B RID: 1835 RVA: 0x000242C4 File Offset: 0x000224C4
		public DrawOrderTimeline(int frameCount)
		{
			this.frames = new float[frameCount];
			this.drawOrders = new int[frameCount][];
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600072C RID: 1836 RVA: 0x000242E4 File Offset: 0x000224E4
		// (set) Token: 0x0600072D RID: 1837 RVA: 0x000242EC File Offset: 0x000224EC
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

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600072E RID: 1838 RVA: 0x000242F8 File Offset: 0x000224F8
		// (set) Token: 0x0600072F RID: 1839 RVA: 0x00024300 File Offset: 0x00022500
		public int[][] DrawOrders
		{
			get
			{
				return this.drawOrders;
			}
			set
			{
				this.drawOrders = value;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000730 RID: 1840 RVA: 0x0002430C File Offset: 0x0002250C
		public int FrameCount
		{
			get
			{
				return this.frames.Length;
			}
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x00024318 File Offset: 0x00022518
		public void setFrame(int frameIndex, float time, int[] drawOrder)
		{
			this.frames[frameIndex] = time;
			this.drawOrders[frameIndex] = drawOrder;
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x0002432C File Offset: 0x0002252C
		public void Apply(Skeleton skeleton, float lastTime, float time, List<Event> firedEvents, float alpha)
		{
			float[] array = this.frames;
			if (time < array[0])
			{
				return;
			}
			int num;
			if (time >= array[array.Length - 1])
			{
				num = array.Length - 1;
			}
			else
			{
				num = Animation.binarySearch(array, time) - 1;
			}
			List<Slot> drawOrder = skeleton.drawOrder;
			List<Slot> slots = skeleton.slots;
			int[] array2 = this.drawOrders[num];
			if (array2 == null)
			{
				drawOrder.Clear();
				drawOrder.AddRange(slots);
			}
			else
			{
				int i = 0;
				int num2 = array2.Length;
				while (i < num2)
				{
					drawOrder[i] = slots[array2[i]];
					i++;
				}
			}
		}

		// Token: 0x040004BF RID: 1215
		internal float[] frames;

		// Token: 0x040004C0 RID: 1216
		private int[][] drawOrders;
	}
}
