using System;
using UnityEngine;

// Token: 0x02000014 RID: 20
public class TimingHitBuilder : HitBuilder<TimingHitBuilder>
{
	// Token: 0x06000095 RID: 149 RVA: 0x000042A0 File Offset: 0x000024A0
	public string GetTimingCategory()
	{
		return this.timingCategory;
	}

	// Token: 0x06000096 RID: 150 RVA: 0x000042A8 File Offset: 0x000024A8
	public TimingHitBuilder SetTimingCategory(string timingCategory)
	{
		if (timingCategory != null)
		{
			this.timingCategory = timingCategory;
		}
		return this;
	}

	// Token: 0x06000097 RID: 151 RVA: 0x000042B8 File Offset: 0x000024B8
	public long GetTimingInterval()
	{
		return this.timingInterval;
	}

	// Token: 0x06000098 RID: 152 RVA: 0x000042C0 File Offset: 0x000024C0
	public TimingHitBuilder SetTimingInterval(long timingInterval)
	{
		this.timingInterval = timingInterval;
		return this;
	}

	// Token: 0x06000099 RID: 153 RVA: 0x000042CC File Offset: 0x000024CC
	public string GetTimingName()
	{
		return this.timingName;
	}

	// Token: 0x0600009A RID: 154 RVA: 0x000042D4 File Offset: 0x000024D4
	public TimingHitBuilder SetTimingName(string timingName)
	{
		if (timingName != null)
		{
			this.timingName = timingName;
		}
		return this;
	}

	// Token: 0x0600009B RID: 155 RVA: 0x000042E4 File Offset: 0x000024E4
	public string GetTimingLabel()
	{
		return this.timingLabel;
	}

	// Token: 0x0600009C RID: 156 RVA: 0x000042EC File Offset: 0x000024EC
	public TimingHitBuilder SetTimingLabel(string timingLabel)
	{
		if (timingLabel != null)
		{
			this.timingLabel = timingLabel;
		}
		return this;
	}

	// Token: 0x0600009D RID: 157 RVA: 0x000042FC File Offset: 0x000024FC
	public override TimingHitBuilder GetThis()
	{
		return this;
	}

	// Token: 0x0600009E RID: 158 RVA: 0x00004300 File Offset: 0x00002500
	public override TimingHitBuilder Validate()
	{
		if (string.IsNullOrEmpty(this.timingCategory))
		{
			Debug.LogError("No timing category provided - Timing hit cannot be sent");
			return null;
		}
		if (this.timingInterval == 0L)
		{
			Debug.Log("Interval in timing hit is 0.");
		}
		return this;
	}

	// Token: 0x0400008E RID: 142
	private string timingCategory = string.Empty;

	// Token: 0x0400008F RID: 143
	private long timingInterval;

	// Token: 0x04000090 RID: 144
	private string timingName = string.Empty;

	// Token: 0x04000091 RID: 145
	private string timingLabel = string.Empty;
}
