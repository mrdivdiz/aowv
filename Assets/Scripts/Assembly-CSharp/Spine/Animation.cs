using System;
using System.Collections.Generic;

namespace Spine
{
	// Token: 0x02000101 RID: 257
	public class Animation
	{
		// Token: 0x060006EF RID: 1775 RVA: 0x00023468 File Offset: 0x00021668
		public Animation(string name, List<Timeline> timelines, float duration)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name cannot be null.");
			}
			if (timelines == null)
			{
				throw new ArgumentNullException("timelines cannot be null.");
			}
			this.name = name;
			this.timelines = timelines;
			this.duration = duration;
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060006F0 RID: 1776 RVA: 0x000234A8 File Offset: 0x000216A8
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060006F1 RID: 1777 RVA: 0x000234B0 File Offset: 0x000216B0
		// (set) Token: 0x060006F2 RID: 1778 RVA: 0x000234B8 File Offset: 0x000216B8
		public List<Timeline> Timelines
		{
			get
			{
				return this.timelines;
			}
			set
			{
				this.timelines = value;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060006F3 RID: 1779 RVA: 0x000234C4 File Offset: 0x000216C4
		// (set) Token: 0x060006F4 RID: 1780 RVA: 0x000234CC File Offset: 0x000216CC
		public float Duration
		{
			get
			{
				return this.duration;
			}
			set
			{
				this.duration = value;
			}
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x000234D8 File Offset: 0x000216D8
		public void Apply(Skeleton skeleton, float lastTime, float time, bool loop, List<Event> events)
		{
			if (skeleton == null)
			{
				throw new ArgumentNullException("skeleton cannot be null.");
			}
			if (loop && this.duration != 0f)
			{
				time %= this.duration;
				lastTime %= this.duration;
			}
			List<Timeline> list = this.timelines;
			int i = 0;
			int count = list.Count;
			while (i < count)
			{
				list[i].Apply(skeleton, lastTime, time, events, 1f);
				i++;
			}
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x00023558 File Offset: 0x00021758
		public void Mix(Skeleton skeleton, float lastTime, float time, bool loop, List<Event> events, float alpha)
		{
			if (skeleton == null)
			{
				throw new ArgumentNullException("skeleton cannot be null.");
			}
			if (loop && this.duration != 0f)
			{
				time %= this.duration;
				lastTime %= this.duration;
			}
			List<Timeline> list = this.timelines;
			int i = 0;
			int count = list.Count;
			while (i < count)
			{
				list[i].Apply(skeleton, lastTime, time, events, alpha);
				i++;
			}
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x000235D4 File Offset: 0x000217D4
		internal static int binarySearch(float[] values, float target, int step)
		{
			int num = 0;
			int num2 = values.Length / step - 2;
			if (num2 == 0)
			{
				return step;
			}
			int num3 = (int)((uint)num2 >> 1);
			for (;;)
			{
				if (values[(num3 + 1) * step] <= target)
				{
					num = num3 + 1;
				}
				else
				{
					num2 = num3;
				}
				if (num == num2)
				{
					break;
				}
				num3 = (int)((uint)(num + num2) >> 1);
			}
			return (num + 1) * step;
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x00023628 File Offset: 0x00021828
		internal static int binarySearch(float[] values, float target)
		{
			int num = 0;
			int num2 = values.Length - 2;
			if (num2 == 0)
			{
				return 1;
			}
			int num3 = (int)((uint)num2 >> 1);
			for (;;)
			{
				if (values[num3 + 1] <= target)
				{
					num = num3 + 1;
				}
				else
				{
					num2 = num3;
				}
				if (num == num2)
				{
					break;
				}
				num3 = (int)((uint)(num + num2) >> 1);
			}
			return num + 1;
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x00023674 File Offset: 0x00021874
		internal static int linearSearch(float[] values, float target, int step)
		{
			int i = 0;
			int num = values.Length - step;
			while (i <= num)
			{
				if (values[i] > target)
				{
					return i;
				}
				i += step;
			}
			return -1;
		}

		// Token: 0x040004A1 RID: 1185
		internal List<Timeline> timelines;

		// Token: 0x040004A2 RID: 1186
		internal float duration;

		// Token: 0x040004A3 RID: 1187
		internal string name;
	}
}
