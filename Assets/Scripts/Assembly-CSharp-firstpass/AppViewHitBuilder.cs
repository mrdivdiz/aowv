using System;
using UnityEngine;

// Token: 0x0200000E RID: 14
public class AppViewHitBuilder : HitBuilder<AppViewHitBuilder>
{
	// Token: 0x0600004D RID: 77 RVA: 0x00003CF4 File Offset: 0x00001EF4
	public string GetScreenName()
	{
		return this.screenName;
	}

	// Token: 0x0600004E RID: 78 RVA: 0x00003CFC File Offset: 0x00001EFC
	public AppViewHitBuilder SetScreenName(string screenName)
	{
		if (screenName != null)
		{
			this.screenName = screenName;
		}
		return this;
	}

	// Token: 0x0600004F RID: 79 RVA: 0x00003D0C File Offset: 0x00001F0C
	public override AppViewHitBuilder GetThis()
	{
		return this;
	}

	// Token: 0x06000050 RID: 80 RVA: 0x00003D10 File Offset: 0x00001F10
	public override AppViewHitBuilder Validate()
	{
		if (string.IsNullOrEmpty(this.screenName))
		{
			Debug.Log("No screen name provided - App View hit cannot be sent.");
			return null;
		}
		return this;
	}

	// Token: 0x04000073 RID: 115
	private string screenName = string.Empty;
}
