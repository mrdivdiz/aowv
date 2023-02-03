using System;

namespace OnePF
{
	// Token: 0x02000017 RID: 23
	public interface IOpenIAB
	{
		// Token: 0x060000C2 RID: 194
		void init(Options options);

		// Token: 0x060000C3 RID: 195
		void mapSku(string sku, string storeName, string storeSku);

		// Token: 0x060000C4 RID: 196
		void unbindService();

		// Token: 0x060000C5 RID: 197
		bool areSubscriptionsSupported();

		// Token: 0x060000C6 RID: 198
		void queryInventory();

		// Token: 0x060000C7 RID: 199
		void queryInventory(string[] inAppSkus);

		// Token: 0x060000C8 RID: 200
		void purchaseProduct(string sku, string developerPayload = "");

		// Token: 0x060000C9 RID: 201
		void purchaseSubscription(string sku, string developerPayload = "");

		// Token: 0x060000CA RID: 202
		void consumeProduct(Purchase purchase);

		// Token: 0x060000CB RID: 203
		void restoreTransactions();

		// Token: 0x060000CC RID: 204
		bool isDebugLog();

		// Token: 0x060000CD RID: 205
		void enableDebugLogging(bool enabled);

		// Token: 0x060000CE RID: 206
		void enableDebugLogging(bool enabled, string tag);
	}
}
