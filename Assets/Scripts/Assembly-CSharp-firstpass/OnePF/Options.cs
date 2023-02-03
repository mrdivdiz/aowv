using System;
using System.Collections.Generic;

namespace OnePF
{
	// Token: 0x02000020 RID: 32
	public class Options
	{
		// Token: 0x040000C4 RID: 196
		public const int DISCOVER_TIMEOUT_MS = 5000;

		// Token: 0x040000C5 RID: 197
		public const int INVENTORY_CHECK_TIMEOUT_MS = 10000;

		// Token: 0x040000C6 RID: 198
		public int discoveryTimeoutMs = 5000;

		// Token: 0x040000C7 RID: 199
		public bool checkInventory = true;

		// Token: 0x040000C8 RID: 200
		public int checkInventoryTimeoutMs = 10000;

		// Token: 0x040000C9 RID: 201
		public OptionsVerifyMode verifyMode;

		// Token: 0x040000CA RID: 202
		public SearchStrategy storeSearchStrategy;

		// Token: 0x040000CB RID: 203
		public Dictionary<string, string> storeKeys = new Dictionary<string, string>();

		// Token: 0x040000CC RID: 204
		public string[] prefferedStoreNames = new string[0];

		// Token: 0x040000CD RID: 205
		public string[] availableStoreNames = new string[0];

		// Token: 0x040000CE RID: 206
		public int samsungCertificationRequestCode;
	}
}
