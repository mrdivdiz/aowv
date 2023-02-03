using System;
using System.Collections.Generic;

namespace Spine
{
	// Token: 0x0200010B RID: 267
	public class FFDTimeline : CurveTimeline
	{
		// Token: 0x06000733 RID: 1843 RVA: 0x000243D0 File Offset: 0x000225D0
		public FFDTimeline(int frameCount) : base(frameCount)
		{
			this.frames = new float[frameCount];
			this.frameVertices = new float[frameCount][];
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000734 RID: 1844 RVA: 0x000243F4 File Offset: 0x000225F4
		// (set) Token: 0x06000735 RID: 1845 RVA: 0x000243FC File Offset: 0x000225FC
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

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000736 RID: 1846 RVA: 0x00024408 File Offset: 0x00022608
		// (set) Token: 0x06000737 RID: 1847 RVA: 0x00024410 File Offset: 0x00022610
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

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000738 RID: 1848 RVA: 0x0002441C File Offset: 0x0002261C
		// (set) Token: 0x06000739 RID: 1849 RVA: 0x00024424 File Offset: 0x00022624
		public float[][] Vertices
		{
			get
			{
				return this.frameVertices;
			}
			set
			{
				this.frameVertices = value;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600073A RID: 1850 RVA: 0x00024430 File Offset: 0x00022630
		// (set) Token: 0x0600073B RID: 1851 RVA: 0x00024438 File Offset: 0x00022638
		public Attachment Attachment
		{
			get
			{
				return this.attachment;
			}
			set
			{
				this.attachment = value;
			}
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x00024444 File Offset: 0x00022644
		public void setFrame(int frameIndex, float time, float[] vertices)
		{
			this.frames[frameIndex] = time;
			this.frameVertices[frameIndex] = vertices;
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x00024458 File Offset: 0x00022658
		public override void Apply(Skeleton skeleton, float lastTime, float time, List<Event> firedEvents, float alpha)
		{
			Slot slot = skeleton.slots[this.slotIndex];
			if (slot.attachment != this.attachment)
			{
				return;
			}
			float[] array = this.frames;
			if (time < array[0])
			{
				slot.attachmentVerticesCount = 0;
				return;
			}
			float[][] array2 = this.frameVertices;
			int num = array2[0].Length;
			float[] array3 = slot.attachmentVertices;
			if (array3.Length != num)
			{
				alpha = 1f;
			}
			if (array3.Length < num)
			{
				array3 = new float[num];
				slot.attachmentVertices = array3;
			}
			slot.attachmentVerticesCount = num;
			if (time >= array[array.Length - 1])
			{
				float[] array4 = array2[array.Length - 1];
				if (alpha < 1f)
				{
					for (int i = 0; i < num; i++)
					{
						array3[i] += (array4[i] - array3[i]) * alpha;
					}
				}
				else
				{
					Array.Copy(array4, 0, array3, 0, num);
				}
				return;
			}
			int num2 = Animation.binarySearch(array, time);
			float num3 = array[num2];
			float num4 = 1f - (time - num3) / (array[num2 - 1] - num3);
			num4 = base.GetCurvePercent(num2 - 1, (num4 >= 0f) ? ((num4 <= 1f) ? num4 : 1f) : 0f);
			float[] array5 = array2[num2 - 1];
			float[] array6 = array2[num2];
			if (alpha < 1f)
			{
				for (int j = 0; j < num; j++)
				{
					float num5 = array5[j];
					array3[j] += (num5 + (array6[j] - num5) * num4 - array3[j]) * alpha;
				}
			}
			else
			{
				for (int k = 0; k < num; k++)
				{
					float num6 = array5[k];
					array3[k] = num6 + (array6[k] - num6) * num4;
				}
			}
		}

		// Token: 0x040004C1 RID: 1217
		internal int slotIndex;

		// Token: 0x040004C2 RID: 1218
		internal float[] frames;

		// Token: 0x040004C3 RID: 1219
		private float[][] frameVertices;

		// Token: 0x040004C4 RID: 1220
		internal Attachment attachment;
	}
}
