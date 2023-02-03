using System;

namespace OnePF
{
	// Token: 0x02000022 RID: 34
	public class Purchase
	{
		// Token: 0x06000143 RID: 323 RVA: 0x00006AA0 File Offset: 0x00004CA0
		private Purchase()
		{
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00006AA8 File Offset: 0x00004CA8
		public Purchase(string jsonString)
		{
			JSON json = new JSON(jsonString);
			this.ItemType = json.ToString("itemType");
			this.OrderId = json.ToString("orderId");
			this.PackageName = json.ToString("packageName");
			this.Sku = json.ToString("sku");
			this.PurchaseTime = json.ToLong("purchaseTime");
			this.PurchaseState = json.ToInt("purchaseState");
			this.DeveloperPayload = json.ToString("developerPayload");
			this.Token = json.ToString("token");
			this.OriginalJson = json.ToString("originalJson");
			this.Signature = json.ToString("signature");
			this.AppstoreName = json.ToString("appstoreName");
			this.Receipt = json.ToString("receipt");
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000145 RID: 325 RVA: 0x00006B90 File Offset: 0x00004D90
		// (set) Token: 0x06000146 RID: 326 RVA: 0x00006B98 File Offset: 0x00004D98
		public string ItemType { get; private set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000147 RID: 327 RVA: 0x00006BA4 File Offset: 0x00004DA4
		// (set) Token: 0x06000148 RID: 328 RVA: 0x00006BAC File Offset: 0x00004DAC
		public string OrderId { get; private set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000149 RID: 329 RVA: 0x00006BB8 File Offset: 0x00004DB8
		// (set) Token: 0x0600014A RID: 330 RVA: 0x00006BC0 File Offset: 0x00004DC0
		public string PackageName { get; private set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00006BCC File Offset: 0x00004DCC
		// (set) Token: 0x0600014C RID: 332 RVA: 0x00006BD4 File Offset: 0x00004DD4
		public string Sku { get; private set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600014D RID: 333 RVA: 0x00006BE0 File Offset: 0x00004DE0
		// (set) Token: 0x0600014E RID: 334 RVA: 0x00006BE8 File Offset: 0x00004DE8
		public long PurchaseTime { get; private set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600014F RID: 335 RVA: 0x00006BF4 File Offset: 0x00004DF4
		// (set) Token: 0x06000150 RID: 336 RVA: 0x00006BFC File Offset: 0x00004DFC
		public int PurchaseState { get; private set; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000151 RID: 337 RVA: 0x00006C08 File Offset: 0x00004E08
		// (set) Token: 0x06000152 RID: 338 RVA: 0x00006C10 File Offset: 0x00004E10
		public string DeveloperPayload { get; private set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000153 RID: 339 RVA: 0x00006C1C File Offset: 0x00004E1C
		// (set) Token: 0x06000154 RID: 340 RVA: 0x00006C24 File Offset: 0x00004E24
		public string Token { get; private set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000155 RID: 341 RVA: 0x00006C30 File Offset: 0x00004E30
		// (set) Token: 0x06000156 RID: 342 RVA: 0x00006C38 File Offset: 0x00004E38
		public string OriginalJson { get; private set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000157 RID: 343 RVA: 0x00006C44 File Offset: 0x00004E44
		// (set) Token: 0x06000158 RID: 344 RVA: 0x00006C4C File Offset: 0x00004E4C
		public string Signature { get; private set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000159 RID: 345 RVA: 0x00006C58 File Offset: 0x00004E58
		// (set) Token: 0x0600015A RID: 346 RVA: 0x00006C60 File Offset: 0x00004E60
		public string AppstoreName { get; private set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00006C6C File Offset: 0x00004E6C
		// (set) Token: 0x0600015C RID: 348 RVA: 0x00006C74 File Offset: 0x00004E74
		public string Receipt { get; private set; }

		// Token: 0x0600015D RID: 349 RVA: 0x00006C80 File Offset: 0x00004E80
		public static Purchase CreateFromSku(string sku)
		{
			return Purchase.CreateFromSku(sku, string.Empty);
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00006C90 File Offset: 0x00004E90
		public static Purchase CreateFromSku(string sku, string developerPayload)
		{
			return new Purchase
			{
				Sku = sku,
				DeveloperPayload = developerPayload
			};
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00006CB4 File Offset: 0x00004EB4
		public override string ToString()
		{
			return "SKU:" + this.Sku + ";" + this.OriginalJson;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00006CDC File Offset: 0x00004EDC
		public string Serialize()
		{
			JSON json = new JSON();
			json["itemType"] = this.ItemType;
			json["orderId"] = this.OrderId;
			json["packageName"] = this.PackageName;
			json["sku"] = this.Sku;
			json["purchaseTime"] = this.PurchaseTime;
			json["purchaseState"] = this.PurchaseState;
			json["developerPayload"] = this.DeveloperPayload;
			json["token"] = this.Token;
			json["originalJson"] = this.OriginalJson;
			json["signature"] = this.Signature;
			json["appstoreName"] = this.AppstoreName;
			json["receipt"] = this.Receipt;
			return json.serialized;
		}
	}
}
