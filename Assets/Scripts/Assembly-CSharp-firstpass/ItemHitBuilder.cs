using System;
using UnityEngine;

// Token: 0x02000012 RID: 18
public class ItemHitBuilder : HitBuilder<ItemHitBuilder>
{
	// Token: 0x0600007B RID: 123 RVA: 0x0000405C File Offset: 0x0000225C
	public string GetTransactionID()
	{
		return this.transactionID;
	}

	// Token: 0x0600007C RID: 124 RVA: 0x00004064 File Offset: 0x00002264
	public ItemHitBuilder SetTransactionID(string transactionID)
	{
		if (transactionID != null)
		{
			this.transactionID = transactionID;
		}
		return this;
	}

	// Token: 0x0600007D RID: 125 RVA: 0x00004074 File Offset: 0x00002274
	public string GetName()
	{
		return this.name;
	}

	// Token: 0x0600007E RID: 126 RVA: 0x0000407C File Offset: 0x0000227C
	public ItemHitBuilder SetName(string name)
	{
		if (name != null)
		{
			this.name = name;
		}
		return this;
	}

	// Token: 0x0600007F RID: 127 RVA: 0x0000408C File Offset: 0x0000228C
	public string GetSKU()
	{
		return this.name;
	}

	// Token: 0x06000080 RID: 128 RVA: 0x00004094 File Offset: 0x00002294
	public ItemHitBuilder SetSKU(string SKU)
	{
		if (SKU != null)
		{
			this.SKU = SKU;
		}
		return this;
	}

	// Token: 0x06000081 RID: 129 RVA: 0x000040A4 File Offset: 0x000022A4
	public double GetPrice()
	{
		return this.price;
	}

	// Token: 0x06000082 RID: 130 RVA: 0x000040AC File Offset: 0x000022AC
	public ItemHitBuilder SetPrice(double price)
	{
		this.price = price;
		return this;
	}

	// Token: 0x06000083 RID: 131 RVA: 0x000040B8 File Offset: 0x000022B8
	public string GetCategory()
	{
		return this.category;
	}

	// Token: 0x06000084 RID: 132 RVA: 0x000040C0 File Offset: 0x000022C0
	public ItemHitBuilder SetCategory(string category)
	{
		if (category != null)
		{
			this.category = category;
		}
		return this;
	}

	// Token: 0x06000085 RID: 133 RVA: 0x000040D0 File Offset: 0x000022D0
	public long GetQuantity()
	{
		return this.quantity;
	}

	// Token: 0x06000086 RID: 134 RVA: 0x000040D8 File Offset: 0x000022D8
	public ItemHitBuilder SetQuantity(long quantity)
	{
		this.quantity = quantity;
		return this;
	}

	// Token: 0x06000087 RID: 135 RVA: 0x000040E4 File Offset: 0x000022E4
	public string GetCurrencyCode()
	{
		return this.currencyCode;
	}

	// Token: 0x06000088 RID: 136 RVA: 0x000040EC File Offset: 0x000022EC
	public ItemHitBuilder SetCurrencyCode(string currencyCode)
	{
		if (currencyCode != null)
		{
			this.currencyCode = currencyCode;
		}
		return this;
	}

	// Token: 0x06000089 RID: 137 RVA: 0x000040FC File Offset: 0x000022FC
	public override ItemHitBuilder GetThis()
	{
		return this;
	}

	// Token: 0x0600008A RID: 138 RVA: 0x00004100 File Offset: 0x00002300
	public override ItemHitBuilder Validate()
	{
		if (string.IsNullOrEmpty(this.transactionID))
		{
			Debug.LogWarning("No transaction ID provided - Item hit cannot be sent.");
			return null;
		}
		if (string.IsNullOrEmpty(this.name))
		{
			Debug.LogWarning("No name provided - Item hit cannot be sent.");
			return null;
		}
		if (string.IsNullOrEmpty(this.SKU))
		{
			Debug.LogWarning("No SKU provided - Item hit cannot be sent.");
			return null;
		}
		if (this.price == 0.0)
		{
			Debug.Log("Price in item hit is 0.");
		}
		if (this.quantity == 0L)
		{
			Debug.Log("Quantity in item hit is 0.");
		}
		return this;
	}

	// Token: 0x04000084 RID: 132
	private string transactionID = string.Empty;

	// Token: 0x04000085 RID: 133
	private string name = string.Empty;

	// Token: 0x04000086 RID: 134
	private string SKU = string.Empty;

	// Token: 0x04000087 RID: 135
	private double price;

	// Token: 0x04000088 RID: 136
	private string category = string.Empty;

	// Token: 0x04000089 RID: 137
	private long quantity;

	// Token: 0x0400008A RID: 138
	private string currencyCode = string.Empty;
}
