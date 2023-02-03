using System;
using System.Collections.Generic;

namespace Spine
{
	// Token: 0x02000109 RID: 265
	public class EventTimeline : Timeline
	{
		// Token: 0x06000723 RID: 1827 RVA: 0x0002419C File Offset: 0x0002239C
		public EventTimeline(int frameCount)
		{
			this.frames = new float[frameCount];
			this.events = new Event[frameCount];
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000724 RID: 1828 RVA: 0x000241BC File Offset: 0x000223BC
		// (set) Token: 0x06000725 RID: 1829 RVA: 0x000241C4 File Offset: 0x000223C4
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

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000726 RID: 1830 RVA: 0x000241D0 File Offset: 0x000223D0
		// (set) Token: 0x06000727 RID: 1831 RVA: 0x000241D8 File Offset: 0x000223D8
		public Event[] Events
		{
			get
			{
				return this.events;
			}
			set
			{
				this.events = value;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000728 RID: 1832 RVA: 0x000241E4 File Offset: 0x000223E4
		public int FrameCount
		{
			get
			{
				return this.frames.Length;
			}
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x000241F0 File Offset: 0x000223F0
		public void setFrame(int frameIndex, float time, Event e)
		{
			this.frames[frameIndex] = time;
			this.events[frameIndex] = e;
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x00024204 File Offset: 0x00022404
		public void Apply(Skeleton skeleton, float lastTime, float time, List<Event> firedEvents, float alpha)
		{
			if (firedEvents == null)
			{
				return;
			}
			float[] array = this.frames;
			int num = array.Length;
			if (lastTime > time)
			{
				this.Apply(skeleton, lastTime, 2.1474836E+09f, firedEvents, alpha);
				lastTime = -1f;
			}
			else if (lastTime >= array[num - 1])
			{
				return;
			}
			if (time < array[0])
			{
				return;
			}
			int i;
			if (lastTime < array[0])
			{
				i = 0;
			}
			else
			{
				i = Animation.binarySearch(array, lastTime);
				float num2 = array[i];
				while (i > 0)
				{
					if (array[i - 1] != num2)
					{
						break;
					}
					i--;
				}
			}
			while (i < num && time >= array[i])
			{
				firedEvents.Add(this.events[i]);
				i++;
			}
		}

		// Token: 0x040004BD RID: 1213
		internal float[] frames;

		// Token: 0x040004BE RID: 1214
		private Event[] events;
	}
}
