using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000011 RID: 17
public abstract class HitBuilder<T>
{
	// Token: 0x06000064 RID: 100
	public abstract T GetThis();

	// Token: 0x06000065 RID: 101
	public abstract T Validate();

	// Token: 0x06000066 RID: 102 RVA: 0x00003EC4 File Offset: 0x000020C4
	public T SetCustomDimension(int dimensionNumber, string value)
	{
		this.customDimensions.Add(dimensionNumber, value);
		return this.GetThis();
	}

	// Token: 0x06000067 RID: 103 RVA: 0x00003EDC File Offset: 0x000020DC
	public Dictionary<int, string> GetCustomDimensions()
	{
		return this.customDimensions;
	}

	// Token: 0x06000068 RID: 104 RVA: 0x00003EE4 File Offset: 0x000020E4
	public T SetCustomMetric(int metricNumber, string value)
	{
		this.customMetrics.Add(metricNumber, value);
		return this.GetThis();
	}

	// Token: 0x06000069 RID: 105 RVA: 0x00003EFC File Offset: 0x000020FC
	public Dictionary<int, string> GetCustomMetrics()
	{
		return this.customMetrics;
	}

	// Token: 0x0600006A RID: 106 RVA: 0x00003F04 File Offset: 0x00002104
	public string GetCampaignName()
	{
		return this.campaignName;
	}

	// Token: 0x0600006B RID: 107 RVA: 0x00003F0C File Offset: 0x0000210C
	public T SetCampaignName(string campaignName)
	{
		if (campaignName != null)
		{
			this.campaignName = campaignName;
		}
		return this.GetThis();
	}

	// Token: 0x0600006C RID: 108 RVA: 0x00003F24 File Offset: 0x00002124
	public string GetCampaignSource()
	{
		return this.campaignSource;
	}

	// Token: 0x0600006D RID: 109 RVA: 0x00003F2C File Offset: 0x0000212C
	public T SetCampaignSource(string campaignSource)
	{
		if (campaignSource != null)
		{
			this.campaignSource = campaignSource;
		}
		else
		{
			Debug.Log("Campaign source cannot be null or empty");
		}
		return this.GetThis();
	}

	// Token: 0x0600006E RID: 110 RVA: 0x00003F5C File Offset: 0x0000215C
	public string GetCampaignMedium()
	{
		return this.campaignMedium;
	}

	// Token: 0x0600006F RID: 111 RVA: 0x00003F64 File Offset: 0x00002164
	public T SetCampaignMedium(string campaignMedium)
	{
		if (campaignMedium != null)
		{
			this.campaignMedium = campaignMedium;
		}
		return this.GetThis();
	}

	// Token: 0x06000070 RID: 112 RVA: 0x00003F7C File Offset: 0x0000217C
	public string GetCampaignKeyword()
	{
		return this.campaignKeyword;
	}

	// Token: 0x06000071 RID: 113 RVA: 0x00003F84 File Offset: 0x00002184
	public T SetCampaignKeyword(string campaignKeyword)
	{
		if (campaignKeyword != null)
		{
			this.campaignKeyword = campaignKeyword;
		}
		return this.GetThis();
	}

	// Token: 0x06000072 RID: 114 RVA: 0x00003F9C File Offset: 0x0000219C
	public string GetCampaignContent()
	{
		return this.campaignContent;
	}

	// Token: 0x06000073 RID: 115 RVA: 0x00003FA4 File Offset: 0x000021A4
	public T SetCampaignContent(string campaignContent)
	{
		if (campaignContent != null)
		{
			this.campaignContent = campaignContent;
		}
		return this.GetThis();
	}

	// Token: 0x06000074 RID: 116 RVA: 0x00003FBC File Offset: 0x000021BC
	public string GetCampaignID()
	{
		return this.campaignID;
	}

	// Token: 0x06000075 RID: 117 RVA: 0x00003FC4 File Offset: 0x000021C4
	public T SetCampaignID(string campaignID)
	{
		if (campaignID != null)
		{
			this.campaignID = campaignID;
		}
		return this.GetThis();
	}

	// Token: 0x06000076 RID: 118 RVA: 0x00003FDC File Offset: 0x000021DC
	public string GetGclid()
	{
		return this.gclid;
	}

	// Token: 0x06000077 RID: 119 RVA: 0x00003FE4 File Offset: 0x000021E4
	public T SetGclid(string gclid)
	{
		if (gclid != null)
		{
			this.gclid = gclid;
		}
		return this.GetThis();
	}

	// Token: 0x06000078 RID: 120 RVA: 0x00003FFC File Offset: 0x000021FC
	public string GetDclid()
	{
		return this.dclid;
	}

	// Token: 0x06000079 RID: 121 RVA: 0x00004004 File Offset: 0x00002204
	public T SetDclid(string dclid)
	{
		if (dclid != null)
		{
			this.dclid = dclid;
		}
		return this.GetThis();
	}

	// Token: 0x0400007A RID: 122
	private Dictionary<int, string> customDimensions = new Dictionary<int, string>();

	// Token: 0x0400007B RID: 123
	private Dictionary<int, string> customMetrics = new Dictionary<int, string>();

	// Token: 0x0400007C RID: 124
	private string campaignName = string.Empty;

	// Token: 0x0400007D RID: 125
	private string campaignSource = string.Empty;

	// Token: 0x0400007E RID: 126
	private string campaignMedium = string.Empty;

	// Token: 0x0400007F RID: 127
	private string campaignKeyword = string.Empty;

	// Token: 0x04000080 RID: 128
	private string campaignContent = string.Empty;

	// Token: 0x04000081 RID: 129
	private string campaignID = string.Empty;

	// Token: 0x04000082 RID: 130
	private string gclid = string.Empty;

	// Token: 0x04000083 RID: 131
	private string dclid = string.Empty;
}
