using System;

namespace Spine
{
	// Token: 0x02000123 RID: 291
	public class Event
	{
		// Token: 0x06000881 RID: 2177 RVA: 0x00027394 File Offset: 0x00025594
		public Event(EventData data)
		{
			this.Data = data;
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000882 RID: 2178 RVA: 0x000273A4 File Offset: 0x000255A4
		// (set) Token: 0x06000883 RID: 2179 RVA: 0x000273AC File Offset: 0x000255AC
		public EventData Data { get; private set; }

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000884 RID: 2180 RVA: 0x000273B8 File Offset: 0x000255B8
		// (set) Token: 0x06000885 RID: 2181 RVA: 0x000273C0 File Offset: 0x000255C0
		public int Int { get; set; }

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000886 RID: 2182 RVA: 0x000273CC File Offset: 0x000255CC
		// (set) Token: 0x06000887 RID: 2183 RVA: 0x000273D4 File Offset: 0x000255D4
		public float Float { get; set; }

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000888 RID: 2184 RVA: 0x000273E0 File Offset: 0x000255E0
		// (set) Token: 0x06000889 RID: 2185 RVA: 0x000273E8 File Offset: 0x000255E8
		public string String { get; set; }

		// Token: 0x0600088A RID: 2186 RVA: 0x000273F4 File Offset: 0x000255F4
		public override string ToString()
		{
			return this.Data.Name;
		}
	}
}
