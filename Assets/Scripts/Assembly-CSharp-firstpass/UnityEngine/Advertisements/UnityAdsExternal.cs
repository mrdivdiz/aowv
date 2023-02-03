using System;

namespace UnityEngine.Advertisements
{
	// Token: 0x02000039 RID: 57
	internal static class UnityAdsExternal
	{
		// Token: 0x06000251 RID: 593 RVA: 0x00009FA4 File Offset: 0x000081A4
		private static UnityAdsPlatform getImpl()
		{
			if (!UnityAdsExternal.initialized)
			{
				UnityAdsExternal.initialized = true;
				UnityAdsExternal.impl = new UnityAdsAndroid();
			}
			return UnityAdsExternal.impl;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00009FC8 File Offset: 0x000081C8
		public static void init(string gameId, bool testModeEnabled, string gameObjectName, string unityVersion)
		{
			UnityAdsExternal.getImpl().init(gameId, testModeEnabled, gameObjectName, unityVersion);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00009FD8 File Offset: 0x000081D8
		public static bool show(string zoneId, string rewardItemKey, string options)
		{
			return UnityAdsExternal.getImpl().show(zoneId, rewardItemKey, options);
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00009FE8 File Offset: 0x000081E8
		public static void hide()
		{
			UnityAdsExternal.getImpl().hide();
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00009FF4 File Offset: 0x000081F4
		public static bool isSupported()
		{
			return UnityAdsExternal.getImpl().isSupported();
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0000A000 File Offset: 0x00008200
		public static string getSDKVersion()
		{
			return UnityAdsExternal.getImpl().getSDKVersion();
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0000A00C File Offset: 0x0000820C
		public static bool canShowZone(string zone)
		{
			return UnityAdsExternal.getImpl().canShowZone(zone);
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0000A01C File Offset: 0x0000821C
		public static bool hasMultipleRewardItems()
		{
			return UnityAdsExternal.getImpl().hasMultipleRewardItems();
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0000A028 File Offset: 0x00008228
		public static string getRewardItemKeys()
		{
			return UnityAdsExternal.getImpl().getRewardItemKeys();
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0000A034 File Offset: 0x00008234
		public static string getDefaultRewardItemKey()
		{
			return UnityAdsExternal.getImpl().getDefaultRewardItemKey();
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0000A040 File Offset: 0x00008240
		public static string getCurrentRewardItemKey()
		{
			return UnityAdsExternal.getImpl().getCurrentRewardItemKey();
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0000A04C File Offset: 0x0000824C
		public static bool setRewardItemKey(string rewardItemKey)
		{
			return UnityAdsExternal.getImpl().setRewardItemKey(rewardItemKey);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0000A05C File Offset: 0x0000825C
		public static void setDefaultRewardItemAsRewardItem()
		{
			UnityAdsExternal.getImpl().setDefaultRewardItemAsRewardItem();
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0000A068 File Offset: 0x00008268
		public static string getRewardItemDetailsWithKey(string rewardItemKey)
		{
			return UnityAdsExternal.getImpl().getRewardItemDetailsWithKey(rewardItemKey);
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0000A078 File Offset: 0x00008278
		public static string getRewardItemDetailsKeys()
		{
			return UnityAdsExternal.getImpl().getRewardItemDetailsKeys();
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0000A084 File Offset: 0x00008284
		public static void setLogLevel(Advertisement.DebugLevel logLevel)
		{
			UnityAdsExternal.getImpl().setLogLevel(logLevel);
		}

		// Token: 0x04000128 RID: 296
		private static UnityAdsPlatform impl;

		// Token: 0x04000129 RID: 297
		private static bool initialized;
	}
}
