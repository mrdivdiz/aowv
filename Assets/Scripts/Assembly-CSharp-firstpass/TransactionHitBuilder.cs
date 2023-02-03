using System;
using UnityEngine;

// Token: 0x02000015 RID: 21
public class TransactionHitBuilder : HitBuilder<TransactionHitBuilder>
{
	// Token: 0x060000A0 RID: 160 RVA: 0x0000436C File Offset: 0x0000256C
	public string GetTransactionID()
	{
		return this.transactionID;
	}

	// Token: 0x060000A1 RID: 161 RVA: 0x00004374 File Offset: 0x00002574
	public TransactionHitBuilder SetTransactionID(string transactionID)
	{
		if (transactionID != null)
		{
			this.transactionID = transactionID;
		}
		return this;
	}

	// Token: 0x060000A2 RID: 162 RVA: 0x00004384 File Offset: 0x00002584
	public string GetAffiliation()
	{
		return this.affiliation;
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x0000438C File Offset: 0x0000258C
	public TransactionHitBuilder SetAffiliation(string affiliation)
	{
		if (affiliation != null)
		{
			this.affiliation = affiliation;
		}
		return this;
	}

	// Token: 0x060000A4 RID: 164 RVA: 0x0000439C File Offset: 0x0000259C
	public double GetRevenue()
	{
		return this.revenue;
	}

	// Token: 0x060000A5 RID: 165 RVA: 0x000043A4 File Offset: 0x000025A4
	public TransactionHitBuilder SetRevenue(double revenue)
	{
		this.revenue = revenue;
		return this;
	}

	// Token: 0x060000A6 RID: 166 RVA: 0x000043B0 File Offset: 0x000025B0
	public double GetTax()
	{
		return this.tax;
	}

	// Token: 0x060000A7 RID: 167 RVA: 0x000043B8 File Offset: 0x000025B8
	public TransactionHitBuilder SetTax(double tax)
	{
		this.tax = tax;
		return this;
	}

	// Token: 0x060000A8 RID: 168 RVA: 0x000043C4 File Offset: 0x000025C4
	public double GetShipping()
	{
		return this.shipping;
	}

	// Token: 0x060000A9 RID: 169 RVA: 0x000043CC File Offset: 0x000025CC
	public TransactionHitBuilder SetShipping(double shipping)
	{
		this.shipping = shipping;
		return this;
	}

	// Token: 0x060000AA RID: 170 RVA: 0x000043D8 File Offset: 0x000025D8
	public string GetCurrencyCode()
	{
		return this.currencyCode;
	}

	// Token: 0x060000AB RID: 171 RVA: 0x000043E0 File Offset: 0x000025E0
	public TransactionHitBuilder SetCurrencyCode(string currencyCode)
	{
		if (currencyCode != null)
		{
			this.currencyCode = currencyCode;
		}
		return this;
	}

	// Token: 0x060000AC RID: 172 RVA: 0x000043F0 File Offset: 0x000025F0
	public override TransactionHitBuilder GetThis()
	{
		return this;
	}

	// Token: 0x060000AD RID: 173 RVA: 0x000043F4 File Offset: 0x000025F4
	public override TransactionHitBuilder Validate()
	{
		if (string.IsNullOrEmpty(this.transactionID))
		{
			Debug.LogWarning("No transaction ID provided - Transaction hit cannot be sent.");
			return null;
		}
		if (string.IsNullOrEmpty(this.affiliation))
		{
			Debug.LogWarning("No affiliation provided - Transaction hit cannot be sent.");
			return null;
		}
		if (this.revenue == 0.0)
		{
			Debug.Log("Revenue in transaction hit is 0.");
		}
		if (this.tax == 0.0)
		{
			Debug.Log("Tax in transaction hit is 0.");
		}
		if (this.shipping == 0.0)
		{
			Debug.Log("Shipping in transaction hit is 0.");
		}
		return this;
	}

	// Token: 0x04000092 RID: 146
	private string transactionID = string.Empty;

	// Token: 0x04000093 RID: 147
	private string affiliation = string.Empty;

	// Token: 0x04000094 RID: 148
	private double revenue;

	// Token: 0x04000095 RID: 149
	private double tax;

	// Token: 0x04000096 RID: 150
	private double shipping;

	// Token: 0x04000097 RID: 151
	private string currencyCode = string.Empty;
}
