using System;
using System.Collections.Generic;

namespace Spine
{
	// Token: 0x02000108 RID: 264
	public class AttachmentTimeline : Timeline
	{
		// Token: 0x06000719 RID: 1817 RVA: 0x00024074 File Offset: 0x00022274
		public AttachmentTimeline(int frameCount)
		{
			this.frames = new float[frameCount];
			this.attachmentNames = new string[frameCount];
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x00024094 File Offset: 0x00022294
		// (set) Token: 0x0600071B RID: 1819 RVA: 0x0002409C File Offset: 0x0002229C
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

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600071C RID: 1820 RVA: 0x000240A8 File Offset: 0x000222A8
		// (set) Token: 0x0600071D RID: 1821 RVA: 0x000240B0 File Offset: 0x000222B0
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

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x000240BC File Offset: 0x000222BC
		// (set) Token: 0x0600071F RID: 1823 RVA: 0x000240C4 File Offset: 0x000222C4
		public string[] AttachmentNames
		{
			get
			{
				return this.attachmentNames;
			}
			set
			{
				this.attachmentNames = value;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000720 RID: 1824 RVA: 0x000240D0 File Offset: 0x000222D0
		public int FrameCount
		{
			get
			{
				return this.frames.Length;
			}
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x000240DC File Offset: 0x000222DC
		public void setFrame(int frameIndex, float time, string attachmentName)
		{
			this.frames[frameIndex] = time;
			this.attachmentNames[frameIndex] = attachmentName;
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x000240F0 File Offset: 0x000222F0
		public void Apply(Skeleton skeleton, float lastTime, float time, List<Event> firedEvents, float alpha)
		{
			float[] array = this.frames;
			if (time < array[0])
			{
				if (lastTime > time)
				{
					this.Apply(skeleton, lastTime, 2.1474836E+09f, null, 0f);
				}
				return;
			}
			if (lastTime > time)
			{
				lastTime = -1f;
			}
			int num = (time < array[array.Length - 1]) ? (Animation.binarySearch(array, time) - 1) : (array.Length - 1);
			if (array[num] < lastTime)
			{
				return;
			}
			string text = this.attachmentNames[num];
			skeleton.slots[this.slotIndex].Attachment = ((text != null) ? skeleton.GetAttachment(this.slotIndex, text) : null);
		}

		// Token: 0x040004BA RID: 1210
		internal int slotIndex;

		// Token: 0x040004BB RID: 1211
		internal float[] frames;

		// Token: 0x040004BC RID: 1212
		private string[] attachmentNames;
	}
}
