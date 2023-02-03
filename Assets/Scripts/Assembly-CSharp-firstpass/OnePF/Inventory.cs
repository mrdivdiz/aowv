using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnePF
{
	// Token: 0x02000018 RID: 24
	public class Inventory
	{
		// Token: 0x060000CF RID: 207 RVA: 0x00004D88 File Offset: 0x00002F88
		public Inventory(string json)
		{
			JSON json2 = new JSON(json);
			foreach (object obj in ((List<object>)json2.fields["purchaseMap"]))
			{
				List<object> list = (List<object>)obj;
				string key = list[0].ToString();
				Purchase value = new Purchase(list[1].ToString());
				this._purchaseMap.Add(key, value);
			}
			foreach (object obj2 in ((List<object>)json2.fields["skuMap"]))
			{
				List<object> list2 = (List<object>)obj2;
				string key2 = list2[0].ToString();
				SkuDetails value2 = new SkuDetails(list2[1].ToString());
				this._skuMap.Add(key2, value2);
			}
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00004EEC File Offset: 0x000030EC
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{purchaseMap:{");
			foreach (KeyValuePair<string, Purchase> keyValuePair in this._purchaseMap)
			{
				stringBuilder.Append(string.Concat(new string[]
				{
					"\"",
					keyValuePair.Key,
					"\":{",
					keyValuePair.Value.ToString(),
					"},"
				}));
			}
			stringBuilder.Append("},");
			stringBuilder.Append("skuMap:{");
			foreach (KeyValuePair<string, SkuDetails> keyValuePair2 in this._skuMap)
			{
				stringBuilder.Append(string.Concat(new string[]
				{
					"\"",
					keyValuePair2.Key,
					"\":{",
					keyValuePair2.Value.ToString(),
					"},"
				}));
			}
			stringBuilder.Append("}}");
			return stringBuilder.ToString();
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00005060 File Offset: 0x00003260
		public SkuDetails GetSkuDetails(string sku)
		{
			if (!this._skuMap.ContainsKey(sku))
			{
				return null;
			}
			return this._skuMap[sku];
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00005084 File Offset: 0x00003284
		public Purchase GetPurchase(string sku)
		{
			if (!this._purchaseMap.ContainsKey(sku))
			{
				return null;
			}
			return this._purchaseMap[sku];
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000050A8 File Offset: 0x000032A8
		public bool HasPurchase(string sku)
		{
			return this._purchaseMap.ContainsKey(sku);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000050B8 File Offset: 0x000032B8
		public bool HasDetails(string sku)
		{
			return this._skuMap.ContainsKey(sku);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x000050C8 File Offset: 0x000032C8
		public void ErasePurchase(string sku)
		{
			if (this._purchaseMap.ContainsKey(sku))
			{
				this._purchaseMap.Remove(sku);
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000050E8 File Offset: 0x000032E8
		public List<string> GetAllOwnedSkus()
		{
			return this._purchaseMap.Keys.ToList<string>();
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x000050FC File Offset: 0x000032FC
		public List<string> GetAllOwnedSkus(string itemType)
		{
			List<string> list = new List<string>();
			foreach (Purchase purchase in this._purchaseMap.Values)
			{
				if (purchase.ItemType == itemType)
				{
					list.Add(purchase.Sku);
				}
			}
			return list;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00005184 File Offset: 0x00003384
		public List<Purchase> GetAllPurchases()
		{
			return this._purchaseMap.Values.ToList<Purchase>();
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00005198 File Offset: 0x00003398
		public List<SkuDetails> GetAllAvailableSkus()
		{
			return this._skuMap.Values.ToList<SkuDetails>();
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000051AC File Offset: 0x000033AC
		public void AddSkuDetails(SkuDetails d)
		{
			this._skuMap.Add(d.Sku, d);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000051C0 File Offset: 0x000033C0
		public void AddPurchase(Purchase p)
		{
			this._purchaseMap.Add(p.Sku, p);
		}

		// Token: 0x040000A3 RID: 163
		private Dictionary<string, SkuDetails> _skuMap = new Dictionary<string, SkuDetails>();

		// Token: 0x040000A4 RID: 164
		private Dictionary<string, Purchase> _purchaseMap = new Dictionary<string, Purchase>();
	}
}
