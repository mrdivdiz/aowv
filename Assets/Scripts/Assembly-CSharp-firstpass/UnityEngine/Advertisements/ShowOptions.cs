using System;

namespace UnityEngine.Advertisements
{
	// Token: 0x0200003B RID: 59
	public class ShowOptions
	{
		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000272 RID: 626 RVA: 0x0000A0A4 File Offset: 0x000082A4
		// (set) Token: 0x06000273 RID: 627 RVA: 0x0000A0AC File Offset: 0x000082AC
		public bool pause { get; set; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000274 RID: 628 RVA: 0x0000A0B8 File Offset: 0x000082B8
		// (set) Token: 0x06000275 RID: 629 RVA: 0x0000A0C0 File Offset: 0x000082C0
		public Action<ShowResult> resultCallback { get; set; }
	}
}
