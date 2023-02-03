using System;

namespace Spine
{
	// Token: 0x02000124 RID: 292
	public class EventData
	{
		// Token: 0x0600088B RID: 2187 RVA: 0x00027404 File Offset: 0x00025604
		public EventData(string name)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name cannot be null.");
			}
			this.name = name;
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x0600088C RID: 2188 RVA: 0x00027424 File Offset: 0x00025624
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x0600088D RID: 2189 RVA: 0x0002742C File Offset: 0x0002562C
		// (set) Token: 0x0600088E RID: 2190 RVA: 0x00027434 File Offset: 0x00025634
		public int Int { get; set; }

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x0600088F RID: 2191 RVA: 0x00027440 File Offset: 0x00025640
		// (set) Token: 0x06000890 RID: 2192 RVA: 0x00027448 File Offset: 0x00025648
		public float Float { get; set; }

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000891 RID: 2193 RVA: 0x00027454 File Offset: 0x00025654
		// (set) Token: 0x06000892 RID: 2194 RVA: 0x0002745C File Offset: 0x0002565C
		public string String { get; set; }

		// Token: 0x06000893 RID: 2195 RVA: 0x00027468 File Offset: 0x00025668
		public override string ToString()
		{
			return this.Name;
		}

		// Token: 0x0400059A RID: 1434
		internal string name;
	}
}
