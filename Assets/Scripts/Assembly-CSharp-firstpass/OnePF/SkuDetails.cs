using System;

namespace OnePF
{
	// Token: 0x02000024 RID: 36
	public class SkuDetails
	{
		// Token: 0x06000161 RID: 353 RVA: 0x00006DCC File Offset: 0x00004FCC
		public SkuDetails(string jsonString)
		{
			JSON json = new JSON(jsonString);
			this.ItemType = json.ToString("itemType");
			this.Sku = json.ToString("sku");
			this.Type = json.ToString("type");
			this.Price = json.ToString("price");
			this.Title = json.ToString("title");
			this.Description = json.ToString("description");
			this.Json = json.ToString("json");
			this.CurrencyCode = json.ToString("currencyCode");
			this.PriceValue = json.ToString("priceValue");
			this.ParseFromJson();
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000162 RID: 354 RVA: 0x00006E88 File Offset: 0x00005088
		// (set) Token: 0x06000163 RID: 355 RVA: 0x00006E90 File Offset: 0x00005090
		public string ItemType { get; private set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00006E9C File Offset: 0x0000509C
		// (set) Token: 0x06000165 RID: 357 RVA: 0x00006EA4 File Offset: 0x000050A4
		public string Sku { get; private set; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000166 RID: 358 RVA: 0x00006EB0 File Offset: 0x000050B0
		// (set) Token: 0x06000167 RID: 359 RVA: 0x00006EB8 File Offset: 0x000050B8
		public string Type { get; private set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000168 RID: 360 RVA: 0x00006EC4 File Offset: 0x000050C4
		// (set) Token: 0x06000169 RID: 361 RVA: 0x00006ECC File Offset: 0x000050CC
		public string Price { get; private set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600016A RID: 362 RVA: 0x00006ED8 File Offset: 0x000050D8
		// (set) Token: 0x0600016B RID: 363 RVA: 0x00006EE0 File Offset: 0x000050E0
		public string Title { get; private set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600016C RID: 364 RVA: 0x00006EEC File Offset: 0x000050EC
		// (set) Token: 0x0600016D RID: 365 RVA: 0x00006EF4 File Offset: 0x000050F4
		public string Description { get; private set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600016E RID: 366 RVA: 0x00006F00 File Offset: 0x00005100
		// (set) Token: 0x0600016F RID: 367 RVA: 0x00006F08 File Offset: 0x00005108
		public string Json { get; private set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000170 RID: 368 RVA: 0x00006F14 File Offset: 0x00005114
		// (set) Token: 0x06000171 RID: 369 RVA: 0x00006F1C File Offset: 0x0000511C
		public string CurrencyCode { get; private set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000172 RID: 370 RVA: 0x00006F28 File Offset: 0x00005128
		// (set) Token: 0x06000173 RID: 371 RVA: 0x00006F30 File Offset: 0x00005130
		public string PriceValue { get; private set; }

		// Token: 0x06000174 RID: 372 RVA: 0x00006F3C File Offset: 0x0000513C
		private void ParseFromJson()
		{
			if (string.IsNullOrEmpty(this.Json))
			{
				return;
			}
			JSON json = new JSON(this.Json);
			if (string.IsNullOrEmpty(this.PriceValue))
			{
				float num = json.ToFloat("price_amount_micros");
				this.PriceValue = (num / 1000000f).ToString();
			}
			if (string.IsNullOrEmpty(this.CurrencyCode))
			{
				this.CurrencyCode = json.ToString("price_currency_code");
			}
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00006FB8 File Offset: 0x000051B8
		public override string ToString()
		{
			return string.Format("[SkuDetails: type = {0}, SKU = {1}, title = {2}, price = {3}, description = {4}, priceValue={5}, currency={6}]", new object[]
			{
				this.ItemType,
				this.Sku,
				this.Title,
				this.Price,
				this.Description,
				this.PriceValue,
				this.CurrencyCode
			});
		}
	}
}
