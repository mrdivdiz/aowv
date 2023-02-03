using System;
using UnityEngine;

namespace OnePF
{
	// Token: 0x0200001E RID: 30
	public class OpenIAB
	{
		// Token: 0x0600010F RID: 271 RVA: 0x00006594 File Offset: 0x00004794
		static OpenIAB()
		{
			Debug.Log("********** Android OpenIAB plugin initialized **********");
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000110 RID: 272 RVA: 0x000065AC File Offset: 0x000047AC
		public static GameObject EventManager
		{
			get
			{
				return GameObject.Find(typeof(OpenIABEventManager).ToString());
			}
		}

		// Token: 0x06000111 RID: 273 RVA: 0x000065C4 File Offset: 0x000047C4
		public static void mapSku(string sku, string storeName, string storeSku)
		{
			OpenIAB._billing.mapSku(sku, storeName, storeSku);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000065D4 File Offset: 0x000047D4
		public static void init(Options options)
		{
			OpenIAB._billing.init(options);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x000065E4 File Offset: 0x000047E4
		public static void unbindService()
		{
			OpenIAB._billing.unbindService();
		}

		// Token: 0x06000114 RID: 276 RVA: 0x000065F0 File Offset: 0x000047F0
		public static bool areSubscriptionsSupported()
		{
			return OpenIAB._billing.areSubscriptionsSupported();
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000065FC File Offset: 0x000047FC
		public static void queryInventory()
		{
			OpenIAB._billing.queryInventory();
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00006608 File Offset: 0x00004808
		public static void queryInventory(string[] skus)
		{
			OpenIAB._billing.queryInventory(skus);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00006618 File Offset: 0x00004818
		public static void purchaseProduct(string sku, string developerPayload = "")
		{
			OpenIAB._billing.purchaseProduct(sku, developerPayload);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00006628 File Offset: 0x00004828
		public static void purchaseSubscription(string sku, string developerPayload = "")
		{
			OpenIAB._billing.purchaseSubscription(sku, developerPayload);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00006638 File Offset: 0x00004838
		public static void consumeProduct(Purchase purchase)
		{
			OpenIAB._billing.consumeProduct(purchase);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00006648 File Offset: 0x00004848
		public static void restoreTransactions()
		{
			OpenIAB._billing.restoreTransactions();
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00006654 File Offset: 0x00004854
		public static bool isDebugLog()
		{
			return OpenIAB._billing.isDebugLog();
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00006660 File Offset: 0x00004860
		public static void enableDebugLogging(bool enabled)
		{
			OpenIAB._billing.enableDebugLogging(enabled);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00006670 File Offset: 0x00004870
		public static void enableDebugLogging(bool enabled, string tag)
		{
			OpenIAB._billing.enableDebugLogging(enabled, tag);
		}

		// Token: 0x040000B8 RID: 184
		private static IOpenIAB _billing = new OpenIAB_Android();
	}
}
