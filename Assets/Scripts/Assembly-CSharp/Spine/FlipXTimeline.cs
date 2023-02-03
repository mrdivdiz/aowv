using System;
using System.Collections.Generic;

namespace Spine
{
	// Token: 0x0200010D RID: 269
	public class FlipXTimeline : Timeline
	{
		// Token: 0x06000745 RID: 1861 RVA: 0x000247B4 File Offset: 0x000229B4
		public FlipXTimeline(int frameCount)
		{
			this.frames = new float[frameCount << 1];
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x000247CC File Offset: 0x000229CC
		// (set) Token: 0x06000747 RID: 1863 RVA: 0x000247D4 File Offset: 0x000229D4
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

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x000247E0 File Offset: 0x000229E0
		// (set) Token: 0x06000749 RID: 1865 RVA: 0x000247E8 File Offset: 0x000229E8
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

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600074A RID: 1866 RVA: 0x000247F4 File Offset: 0x000229F4
		public int FrameCount
		{
			get
			{
				return this.frames.Length >> 1;
			}
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x00024800 File Offset: 0x00022A00
		public void SetFrame(int frameIndex, float time, bool flip)
		{
			frameIndex *= 2;
			this.frames[frameIndex] = time;
			this.frames[frameIndex + 1] = (float)((!flip) ? 0 : 1);
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x00024834 File Offset: 0x00022A34
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
			int num = ((time < array[array.Length - 2]) ? Animation.binarySearch(array, time, 2) : array.Length) - 2;
			if (array[num] <= lastTime)
			{
				return;
			}
			this.SetFlip(skeleton.bones[this.boneIndex], array[num + 1] != 0f);
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x000248CC File Offset: 0x00022ACC
		protected virtual void SetFlip(Bone bone, bool flip)
		{
			bone.flipX = flip;
		}

		// Token: 0x040004CB RID: 1227
		internal int boneIndex;

		// Token: 0x040004CC RID: 1228
		internal float[] frames;
	}
}
