using System;

namespace Spine
{
	// Token: 0x02000132 RID: 306
	public class Slot
	{
		// Token: 0x06000948 RID: 2376 RVA: 0x0002C02C File Offset: 0x0002A22C
		public Slot(SlotData data, Bone bone)
		{
			if (data == null)
			{
				throw new ArgumentNullException("data cannot be null.");
			}
			if (bone == null)
			{
				throw new ArgumentNullException("bone cannot be null.");
			}
			this.data = data;
			this.bone = bone;
			this.SetToSetupPose();
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000949 RID: 2377 RVA: 0x0002C084 File Offset: 0x0002A284
		public SlotData Data
		{
			get
			{
				return this.data;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600094A RID: 2378 RVA: 0x0002C08C File Offset: 0x0002A28C
		public Bone Bone
		{
			get
			{
				return this.bone;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600094B RID: 2379 RVA: 0x0002C094 File Offset: 0x0002A294
		public Skeleton Skeleton
		{
			get
			{
				return this.bone.skeleton;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x0600094C RID: 2380 RVA: 0x0002C0A4 File Offset: 0x0002A2A4
		// (set) Token: 0x0600094D RID: 2381 RVA: 0x0002C0AC File Offset: 0x0002A2AC
		public float R
		{
			get
			{
				return this.r;
			}
			set
			{
				this.r = value;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x0600094E RID: 2382 RVA: 0x0002C0B8 File Offset: 0x0002A2B8
		// (set) Token: 0x0600094F RID: 2383 RVA: 0x0002C0C0 File Offset: 0x0002A2C0
		public float G
		{
			get
			{
				return this.g;
			}
			set
			{
				this.g = value;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000950 RID: 2384 RVA: 0x0002C0CC File Offset: 0x0002A2CC
		// (set) Token: 0x06000951 RID: 2385 RVA: 0x0002C0D4 File Offset: 0x0002A2D4
		public float B
		{
			get
			{
				return this.b;
			}
			set
			{
				this.b = value;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000952 RID: 2386 RVA: 0x0002C0E0 File Offset: 0x0002A2E0
		// (set) Token: 0x06000953 RID: 2387 RVA: 0x0002C0E8 File Offset: 0x0002A2E8
		public float A
		{
			get
			{
				return this.a;
			}
			set
			{
				this.a = value;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000954 RID: 2388 RVA: 0x0002C0F4 File Offset: 0x0002A2F4
		// (set) Token: 0x06000955 RID: 2389 RVA: 0x0002C0FC File Offset: 0x0002A2FC
		public Attachment Attachment
		{
			get
			{
				return this.attachment;
			}
			set
			{
				this.attachment = value;
				this.attachmentTime = this.bone.skeleton.time;
				this.attachmentVerticesCount = 0;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000956 RID: 2390 RVA: 0x0002C130 File Offset: 0x0002A330
		// (set) Token: 0x06000957 RID: 2391 RVA: 0x0002C14C File Offset: 0x0002A34C
		public float AttachmentTime
		{
			get
			{
				return this.bone.skeleton.time - this.attachmentTime;
			}
			set
			{
				this.attachmentTime = this.bone.skeleton.time - value;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000958 RID: 2392 RVA: 0x0002C168 File Offset: 0x0002A368
		// (set) Token: 0x06000959 RID: 2393 RVA: 0x0002C170 File Offset: 0x0002A370
		public float[] AttachmentVertices
		{
			get
			{
				return this.attachmentVertices;
			}
			set
			{
				this.attachmentVertices = value;
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x0600095A RID: 2394 RVA: 0x0002C17C File Offset: 0x0002A37C
		// (set) Token: 0x0600095B RID: 2395 RVA: 0x0002C184 File Offset: 0x0002A384
		public int AttachmentVerticesCount
		{
			get
			{
				return this.attachmentVerticesCount;
			}
			set
			{
				this.attachmentVerticesCount = value;
			}
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x0002C190 File Offset: 0x0002A390
		internal void SetToSetupPose(int slotIndex)
		{
			this.r = this.data.r;
			this.g = this.data.g;
			this.b = this.data.b;
			this.a = this.data.a;
			this.Attachment = ((this.data.attachmentName != null) ? this.bone.skeleton.GetAttachment(slotIndex, this.data.attachmentName) : null);
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x0002C21C File Offset: 0x0002A41C
		public void SetToSetupPose()
		{
			this.SetToSetupPose(this.bone.skeleton.data.slots.IndexOf(this.data));
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x0002C250 File Offset: 0x0002A450
		public override string ToString()
		{
			return this.data.name;
		}

		// Token: 0x040005E5 RID: 1509
		internal SlotData data;

		// Token: 0x040005E6 RID: 1510
		internal Bone bone;

		// Token: 0x040005E7 RID: 1511
		internal float r;

		// Token: 0x040005E8 RID: 1512
		internal float g;

		// Token: 0x040005E9 RID: 1513
		internal float b;

		// Token: 0x040005EA RID: 1514
		internal float a;

		// Token: 0x040005EB RID: 1515
		internal Attachment attachment;

		// Token: 0x040005EC RID: 1516
		internal float attachmentTime;

		// Token: 0x040005ED RID: 1517
		internal float[] attachmentVertices = new float[0];

		// Token: 0x040005EE RID: 1518
		internal int attachmentVerticesCount;
	}
}
