using System;
using System.Collections.Generic;
using OnePF;
using UnityEngine;

// Token: 0x020000BF RID: 191
public class OpenIABTest : MonoBehaviour
{
	// Token: 0x06000582 RID: 1410 RVA: 0x0000E050 File Offset: 0x0000C250
	private void OnEnable()
	{
		OpenIABEventManager.billingSupportedEvent += this.billingSupportedEvent;
		OpenIABEventManager.billingNotSupportedEvent += this.billingNotSupportedEvent;
		OpenIABEventManager.queryInventorySucceededEvent += this.queryInventorySucceededEvent;
		OpenIABEventManager.queryInventoryFailedEvent += this.queryInventoryFailedEvent;
		OpenIABEventManager.purchaseSucceededEvent += this.purchaseSucceededEvent;
		OpenIABEventManager.purchaseFailedEvent += this.purchaseFailedEvent;
		OpenIABEventManager.consumePurchaseSucceededEvent += this.consumePurchaseSucceededEvent;
		OpenIABEventManager.consumePurchaseFailedEvent += this.consumePurchaseFailedEvent;
	}

	// Token: 0x06000583 RID: 1411 RVA: 0x0000E0E8 File Offset: 0x0000C2E8
	private void OnDisable()
	{
		OpenIABEventManager.billingSupportedEvent -= this.billingSupportedEvent;
		OpenIABEventManager.billingNotSupportedEvent -= this.billingNotSupportedEvent;
		OpenIABEventManager.queryInventorySucceededEvent -= this.queryInventorySucceededEvent;
		OpenIABEventManager.queryInventoryFailedEvent -= this.queryInventoryFailedEvent;
		OpenIABEventManager.purchaseSucceededEvent -= this.purchaseSucceededEvent;
		OpenIABEventManager.purchaseFailedEvent -= this.purchaseFailedEvent;
		OpenIABEventManager.consumePurchaseSucceededEvent -= this.consumePurchaseSucceededEvent;
		OpenIABEventManager.consumePurchaseFailedEvent -= this.consumePurchaseFailedEvent;
	}

	// Token: 0x06000584 RID: 1412 RVA: 0x0000E180 File Offset: 0x0000C380
	private void Start()
	{
		OpenIAB.mapSku("sku", OpenIAB_Android.STORE_GOOGLE, "sku");
		OpenIAB.mapSku("sku", OpenIAB_Android.STORE_AMAZON, "sku");
		OpenIAB.mapSku("sku", OpenIAB_Android.STORE_SAMSUNG, "100000105017/samsung_sku");
		OpenIAB.mapSku("sku", OpenIAB_iOS.STORE, "sku");
		OpenIAB.mapSku("sku", OpenIAB_WP8.STORE, "ammo");
	}

	// Token: 0x06000585 RID: 1413 RVA: 0x0000E1F4 File Offset: 0x0000C3F4
	private bool Button(string text)
	{
		float num = (float)Screen.width / 2f - 20f;
		float num2 = (float)((Screen.width < 800 && Screen.height < 800) ? 40 : 100);
		bool result = GUI.Button(new Rect(10f + (float)this._column * 10f * 2f + (float)this._column * num, 10f + (float)this._row * 10f + (float)this._row * num2, num, num2), text);
		this._column++;
		if (this._column > 1)
		{
			this._column = 0;
			this._row++;
		}
		return result;
	}

	// Token: 0x06000586 RID: 1414 RVA: 0x0000E2BC File Offset: 0x0000C4BC
	private void OnGUI()
	{
		this._column = 0;
		this._row = 0;
		GUI.skin.button.fontSize = ((Screen.width < 800 && Screen.height < 800) ? 24 : 34);
		if (this.Button("Initialize OpenIAB"))
		{
			string value = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAgEEaiFfxugLWAH4CQqXYttXlj3GI2ozlcnWlZDaO2VYkcUhbrAz368FMmw2g40zgIDfyopFqETXf0dMTDw7VH3JOXZID2ATtTfBXaU4hqTf2lSwcY9RXe/Uz0x1nf1oLAf85oWZ7uuXScR747ekzRZB4vb4afm2DsbE30ohZD/WzQ22xByX6583yYE19RdE9yJzFckEPlHuOeMgKOa4WErt11PHB6FTdT5eN96/jjjeEoYhX/NGkOWKW0Y0T0A7CdUC0D4t2xxkzAQHdgLfcRw9+/EIcaysLhncWYiCifJrRBGpqZU1IrNuehrC5FXUN99786c/TwlxNG5nflE6sWwIDAQAB";
			string value2 = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEApvU8l4ONEEsSGznPN6DnjIbJnv6vEgm08nbbi+2fMc0V46N7x7jBWTWAf2K6XLZg/rLUkqbWISq12PLvt7ydcsD+Hb9ZubdN2h8LNCTohVPeDbJjd5khtF4J5FNP2/XSTc1C7cSCBTGmqH0fUr77v4x/JMpxKlSjPN6KbNnaF2BLDAdi3012lz2XX4BVgUj7LArID/vYSYGlwMzMkvhUSpvZOM/WIPN+8YDgQAFBlRGRjLhY/3Vpq/AtXtVAzzyfTOZYkwNqdXpwAq5+/51LphowUI5NEBYh8lhQeOJmPNA6EcF1h5L9cJTVLy3bkuCXcjoN2eEO1Nq0h/40G0R4pwIDAQAB";
			string value3 = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAogOQb0mMbuq4FQ4ZhWRhN8k76/gXOUE370VubZa9Up25GdptYXoRNniecUTDLyjfvWp7+YFW8iPqIp523qNXtQ0EynNhK4xNLvJCd1CjfAju6M0f+o8MOL1zV7g3dHqxICZoHwqBbQOWneDzG/DzJ22AVdLKwty0qbv8ESaCOCJe31ZnoYVMw5KNVkSuRrrhiGGh6xj7F3qZ0T5TOSp3fK7soDamQLevuU7Ndn5IQACjo92HNN0O2PR2cvEjkCRuIkNk2hnqinac984JCzCC0SC/JBnUZUAeYJ7Y8sjT+79z1T1g7yGgDesopnqORiBkeXEZHrFy7PifdA/ZX7rRwQIDAQAB";
			OpenIAB.init(new Options
			{
				checkInventoryTimeoutMs = 20000,
				discoveryTimeoutMs = 10000,
				checkInventory = false,
				verifyMode = OptionsVerifyMode.VERIFY_SKIP,
				prefferedStoreNames = new string[]
				{
					OpenIAB_Android.STORE_AMAZON
				},
				availableStoreNames = new string[]
				{
					OpenIAB_Android.STORE_AMAZON
				},
				storeKeys = new Dictionary<string, string>
				{
					{
						OpenIAB_Android.STORE_GOOGLE,
						value
					}
				},
				storeSearchStrategy = SearchStrategy.INSTALLER_THEN_BEST_FIT
			});
		}
		if (!this._isInitialized)
		{
			return;
		}
		if (this.Button("Query Inventory"))
		{
			OpenIAB.queryInventory(new string[]
			{
				"sku"
			});
		}
		if (this.Button("Purchase Product"))
		{
			OpenIAB.purchaseProduct("sku", string.Empty);
		}
		if (this.Button("Consume Product") && this._inventory != null && this._inventory.HasPurchase("sku"))
		{
			OpenIAB.consumeProduct(this._inventory.GetPurchase("sku"));
		}
		if (this.Button("Test Purchase"))
		{
			OpenIAB.purchaseProduct("android.test.purchased", string.Empty);
		}
		if (this.Button("Test Consume") && this._inventory != null && this._inventory.HasPurchase("android.test.purchased"))
		{
			OpenIAB.consumeProduct(this._inventory.GetPurchase("android.test.purchased"));
		}
		if (this.Button("Test Item Unavailable"))
		{
			OpenIAB.purchaseProduct("android.test.item_unavailable", string.Empty);
		}
		if (this.Button("Test Purchase Canceled"))
		{
			OpenIAB.purchaseProduct("android.test.canceled", string.Empty);
		}
	}

	// Token: 0x06000587 RID: 1415 RVA: 0x0000E518 File Offset: 0x0000C718
	private void billingSupportedEvent()
	{
		this._isInitialized = true;
		Debug.Log("billingSupportedEvent");
	}

	// Token: 0x06000588 RID: 1416 RVA: 0x0000E52C File Offset: 0x0000C72C
	private void billingNotSupportedEvent(string error)
	{
		Debug.Log("billingNotSupportedEvent: " + error);
	}

	// Token: 0x06000589 RID: 1417 RVA: 0x0000E540 File Offset: 0x0000C740
	private void queryInventorySucceededEvent(Inventory inventory)
	{
		Debug.Log("queryInventorySucceededEvent: " + inventory);
		if (inventory != null)
		{
			this._label = inventory.ToString();
			this._inventory = inventory;
		}
	}

	// Token: 0x0600058A RID: 1418 RVA: 0x0000E56C File Offset: 0x0000C76C
	private void queryInventoryFailedEvent(string error)
	{
		Debug.Log("queryInventoryFailedEvent: " + error);
		this._label = error;
	}

	// Token: 0x0600058B RID: 1419 RVA: 0x0000E588 File Offset: 0x0000C788
	private void purchaseSucceededEvent(Purchase purchase)
	{
		Debug.Log("purchaseSucceededEvent: " + purchase);
		this._label = "PURCHASED:" + purchase.ToString();
	}

	// Token: 0x0600058C RID: 1420 RVA: 0x0000E5BC File Offset: 0x0000C7BC
	private void purchaseFailedEvent(int errorCode, string errorMessage)
	{
		Debug.Log("purchaseFailedEvent: " + errorMessage);
		this._label = "Purchase Failed: " + errorMessage;
	}

	// Token: 0x0600058D RID: 1421 RVA: 0x0000E5E0 File Offset: 0x0000C7E0
	private void consumePurchaseSucceededEvent(Purchase purchase)
	{
		Debug.Log("consumePurchaseSucceededEvent: " + purchase);
		this._label = "CONSUMED: " + purchase.ToString();
	}

	// Token: 0x0600058E RID: 1422 RVA: 0x0000E614 File Offset: 0x0000C814
	private void consumePurchaseFailedEvent(string error)
	{
		Debug.Log("consumePurchaseFailedEvent: " + error);
		this._label = "Consume Failed: " + error;
	}

	// Token: 0x04000203 RID: 515
	private const string SKU = "sku";

	// Token: 0x04000204 RID: 516
	private const float X_OFFSET = 10f;

	// Token: 0x04000205 RID: 517
	private const float Y_OFFSET = 10f;

	// Token: 0x04000206 RID: 518
	private const int SMALL_SCREEN_SIZE = 800;

	// Token: 0x04000207 RID: 519
	private const int LARGE_FONT_SIZE = 34;

	// Token: 0x04000208 RID: 520
	private const int SMALL_FONT_SIZE = 24;

	// Token: 0x04000209 RID: 521
	private const int LARGE_WIDTH = 380;

	// Token: 0x0400020A RID: 522
	private const int SMALL_WIDTH = 160;

	// Token: 0x0400020B RID: 523
	private const int LARGE_HEIGHT = 100;

	// Token: 0x0400020C RID: 524
	private const int SMALL_HEIGHT = 40;

	// Token: 0x0400020D RID: 525
	private string _label = string.Empty;

	// Token: 0x0400020E RID: 526
	private bool _isInitialized;

	// Token: 0x0400020F RID: 527
	private Inventory _inventory;

	// Token: 0x04000210 RID: 528
	private int _column;

	// Token: 0x04000211 RID: 529
	private int _row;
}
