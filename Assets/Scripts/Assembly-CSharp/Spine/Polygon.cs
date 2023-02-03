using System;

namespace Spine
{
	// Token: 0x0200012D RID: 301
	public class Polygon
	{
		// Token: 0x06000907 RID: 2311 RVA: 0x00029650 File Offset: 0x00027850
		public Polygon()
		{
			this.Vertices = new float[16];
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000908 RID: 2312 RVA: 0x00029668 File Offset: 0x00027868
		// (set) Token: 0x06000909 RID: 2313 RVA: 0x00029670 File Offset: 0x00027870
		public float[] Vertices { get; set; }

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600090A RID: 2314 RVA: 0x0002967C File Offset: 0x0002787C
		// (set) Token: 0x0600090B RID: 2315 RVA: 0x00029684 File Offset: 0x00027884
		public int Count { get; set; }
	}
}
