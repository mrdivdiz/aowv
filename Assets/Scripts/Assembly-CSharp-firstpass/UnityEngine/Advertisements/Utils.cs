using System;

namespace UnityEngine.Advertisements
{
	// Token: 0x02000035 RID: 53
	internal static class Utils
	{
		// Token: 0x06000216 RID: 534 RVA: 0x000093D0 File Offset: 0x000075D0
		private static void Log(Advertisement.DebugLevel debugLevel, string message)
		{
			if ((Advertisement.debugLevel & debugLevel) != Advertisement.DebugLevel.NONE)
			{
				Debug.Log(message);
			}
		}

		// Token: 0x06000217 RID: 535 RVA: 0x000093E4 File Offset: 0x000075E4
		public static void LogDebug(string message)
		{
			Utils.Log(Advertisement.DebugLevel.DEBUG, "Debug: " + message);
		}

		// Token: 0x06000218 RID: 536 RVA: 0x000093F8 File Offset: 0x000075F8
		public static void LogInfo(string message)
		{
			Utils.Log(Advertisement.DebugLevel.INFO, "Info:" + message);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0000940C File Offset: 0x0000760C
		public static void LogWarning(string message)
		{
			Utils.Log(Advertisement.DebugLevel.WARNING, "Warning:" + message);
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00009420 File Offset: 0x00007620
		public static void LogError(string message)
		{
			Utils.Log(Advertisement.DebugLevel.ERROR, "Error: " + message);
		}
	}
}
