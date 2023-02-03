using System;
using OnePF;
using UnityEngine;

// Token: 0x0200001F RID: 31
public class OpenIABEventManager : MonoBehaviour
{
	// Token: 0x14000001 RID: 1
	// (add) Token: 0x0600011F RID: 287 RVA: 0x00006688 File Offset: 0x00004888
	// (remove) Token: 0x06000120 RID: 288 RVA: 0x000066A0 File Offset: 0x000048A0
	public static event Action billingSupportedEvent;

	// Token: 0x14000002 RID: 2
	// (add) Token: 0x06000121 RID: 289 RVA: 0x000066B8 File Offset: 0x000048B8
	// (remove) Token: 0x06000122 RID: 290 RVA: 0x000066D0 File Offset: 0x000048D0
	public static event Action<string> billingNotSupportedEvent;

	// Token: 0x14000003 RID: 3
	// (add) Token: 0x06000123 RID: 291 RVA: 0x000066E8 File Offset: 0x000048E8
	// (remove) Token: 0x06000124 RID: 292 RVA: 0x00006700 File Offset: 0x00004900
	public static event Action<Inventory> queryInventorySucceededEvent;

	// Token: 0x14000004 RID: 4
	// (add) Token: 0x06000125 RID: 293 RVA: 0x00006718 File Offset: 0x00004918
	// (remove) Token: 0x06000126 RID: 294 RVA: 0x00006730 File Offset: 0x00004930
	public static event Action<string> queryInventoryFailedEvent;

	// Token: 0x14000005 RID: 5
	// (add) Token: 0x06000127 RID: 295 RVA: 0x00006748 File Offset: 0x00004948
	// (remove) Token: 0x06000128 RID: 296 RVA: 0x00006760 File Offset: 0x00004960
	public static event Action<Purchase> purchaseSucceededEvent;

	// Token: 0x14000006 RID: 6
	// (add) Token: 0x06000129 RID: 297 RVA: 0x00006778 File Offset: 0x00004978
	// (remove) Token: 0x0600012A RID: 298 RVA: 0x00006790 File Offset: 0x00004990
	public static event Action<int, string> purchaseFailedEvent;

	// Token: 0x14000007 RID: 7
	// (add) Token: 0x0600012B RID: 299 RVA: 0x000067A8 File Offset: 0x000049A8
	// (remove) Token: 0x0600012C RID: 300 RVA: 0x000067C0 File Offset: 0x000049C0
	public static event Action<Purchase> consumePurchaseSucceededEvent;

	// Token: 0x14000008 RID: 8
	// (add) Token: 0x0600012D RID: 301 RVA: 0x000067D8 File Offset: 0x000049D8
	// (remove) Token: 0x0600012E RID: 302 RVA: 0x000067F0 File Offset: 0x000049F0
	public static event Action<string> consumePurchaseFailedEvent;

	// Token: 0x14000009 RID: 9
	// (add) Token: 0x0600012F RID: 303 RVA: 0x00006808 File Offset: 0x00004A08
	// (remove) Token: 0x06000130 RID: 304 RVA: 0x00006820 File Offset: 0x00004A20
	public static event Action<string> transactionRestoredEvent;

	// Token: 0x1400000A RID: 10
	// (add) Token: 0x06000131 RID: 305 RVA: 0x00006838 File Offset: 0x00004A38
	// (remove) Token: 0x06000132 RID: 306 RVA: 0x00006850 File Offset: 0x00004A50
	public static event Action<string> restoreFailedEvent;

	// Token: 0x1400000B RID: 11
	// (add) Token: 0x06000133 RID: 307 RVA: 0x00006868 File Offset: 0x00004A68
	// (remove) Token: 0x06000134 RID: 308 RVA: 0x00006880 File Offset: 0x00004A80
	public static event Action restoreSucceededEvent;

	// Token: 0x06000135 RID: 309 RVA: 0x00006898 File Offset: 0x00004A98
	private void Awake()
	{
		base.gameObject.name = base.GetType().ToString();
		UnityEngine.Object.DontDestroyOnLoad(this);
	}

	// Token: 0x06000136 RID: 310 RVA: 0x000068C4 File Offset: 0x00004AC4
	private void OnMapSkuFailed(string exception)
	{
		Debug.LogError("SKU mapping failed: " + exception);
	}

	// Token: 0x06000137 RID: 311 RVA: 0x000068D8 File Offset: 0x00004AD8
	private void OnBillingSupported(string empty)
	{
		if (OpenIABEventManager.billingSupportedEvent != null)
		{
			OpenIABEventManager.billingSupportedEvent();
		}
	}

	// Token: 0x06000138 RID: 312 RVA: 0x000068F0 File Offset: 0x00004AF0
	private void OnBillingNotSupported(string error)
	{
		if (OpenIABEventManager.billingNotSupportedEvent != null)
		{
			OpenIABEventManager.billingNotSupportedEvent(error);
		}
	}

	// Token: 0x06000139 RID: 313 RVA: 0x00006908 File Offset: 0x00004B08
	private void OnQueryInventorySucceeded(string json)
	{
		if (OpenIABEventManager.queryInventorySucceededEvent != null)
		{
			Inventory obj = new Inventory(json);
			OpenIABEventManager.queryInventorySucceededEvent(obj);
		}
	}

	// Token: 0x0600013A RID: 314 RVA: 0x00006934 File Offset: 0x00004B34
	private void OnQueryInventoryFailed(string error)
	{
		if (OpenIABEventManager.queryInventoryFailedEvent != null)
		{
			OpenIABEventManager.queryInventoryFailedEvent(error);
		}
	}

	// Token: 0x0600013B RID: 315 RVA: 0x0000694C File Offset: 0x00004B4C
	private void OnPurchaseSucceeded(string json)
	{
		if (OpenIABEventManager.purchaseSucceededEvent != null)
		{
			OpenIABEventManager.purchaseSucceededEvent(new Purchase(json));
		}
	}

	// Token: 0x0600013C RID: 316 RVA: 0x00006968 File Offset: 0x00004B68
	private void OnPurchaseFailed(string message)
	{
		int arg = -1;
		string arg2 = "Unknown error";
		if (!string.IsNullOrEmpty(message))
		{
			string[] array = message.Split(new char[]
			{
				'|'
			});
			if (array.Length >= 2)
			{
				int.TryParse(array[0], out arg);
				arg2 = array[1];
			}
			else
			{
				arg2 = message;
			}
		}
		if (OpenIABEventManager.purchaseFailedEvent != null)
		{
			OpenIABEventManager.purchaseFailedEvent(arg, arg2);
		}
	}

	// Token: 0x0600013D RID: 317 RVA: 0x000069D0 File Offset: 0x00004BD0
	private void OnConsumePurchaseSucceeded(string json)
	{
		if (OpenIABEventManager.consumePurchaseSucceededEvent != null)
		{
			OpenIABEventManager.consumePurchaseSucceededEvent(new Purchase(json));
		}
	}

	// Token: 0x0600013E RID: 318 RVA: 0x000069EC File Offset: 0x00004BEC
	private void OnConsumePurchaseFailed(string error)
	{
		if (OpenIABEventManager.consumePurchaseFailedEvent != null)
		{
			OpenIABEventManager.consumePurchaseFailedEvent(error);
		}
	}

	// Token: 0x0600013F RID: 319 RVA: 0x00006A04 File Offset: 0x00004C04
	public void OnTransactionRestored(string sku)
	{
		if (OpenIABEventManager.transactionRestoredEvent != null)
		{
			OpenIABEventManager.transactionRestoredEvent(sku);
		}
	}

	// Token: 0x06000140 RID: 320 RVA: 0x00006A1C File Offset: 0x00004C1C
	public void OnRestoreTransactionFailed(string error)
	{
		if (OpenIABEventManager.restoreFailedEvent != null)
		{
			OpenIABEventManager.restoreFailedEvent(error);
		}
	}

	// Token: 0x06000141 RID: 321 RVA: 0x00006A34 File Offset: 0x00004C34
	public void OnRestoreTransactionSucceeded(string message)
	{
		if (OpenIABEventManager.restoreSucceededEvent != null)
		{
			OpenIABEventManager.restoreSucceededEvent();
		}
	}
}
