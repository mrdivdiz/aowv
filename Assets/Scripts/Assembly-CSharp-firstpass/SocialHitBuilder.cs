using System;
using UnityEngine;

// Token: 0x02000013 RID: 19
public class SocialHitBuilder : HitBuilder<SocialHitBuilder>
{
	// Token: 0x0600008C RID: 140 RVA: 0x000041C4 File Offset: 0x000023C4
	public string GetSocialNetwork()
	{
		return this.socialNetwork;
	}

	// Token: 0x0600008D RID: 141 RVA: 0x000041CC File Offset: 0x000023CC
	public SocialHitBuilder SetSocialNetwork(string socialNetwork)
	{
		if (socialNetwork != null)
		{
			this.socialNetwork = socialNetwork;
		}
		return this;
	}

	// Token: 0x0600008E RID: 142 RVA: 0x000041DC File Offset: 0x000023DC
	public string GetSocialAction()
	{
		return this.socialAction;
	}

	// Token: 0x0600008F RID: 143 RVA: 0x000041E4 File Offset: 0x000023E4
	public SocialHitBuilder SetSocialAction(string socialAction)
	{
		if (socialAction != null)
		{
			this.socialAction = socialAction;
		}
		return this;
	}

	// Token: 0x06000090 RID: 144 RVA: 0x000041F4 File Offset: 0x000023F4
	public string GetSocialTarget()
	{
		return this.socialTarget;
	}

	// Token: 0x06000091 RID: 145 RVA: 0x000041FC File Offset: 0x000023FC
	public SocialHitBuilder SetSocialTarget(string socialTarget)
	{
		if (socialTarget != null)
		{
			this.socialTarget = socialTarget;
		}
		return this;
	}

	// Token: 0x06000092 RID: 146 RVA: 0x0000420C File Offset: 0x0000240C
	public override SocialHitBuilder GetThis()
	{
		return this;
	}

	// Token: 0x06000093 RID: 147 RVA: 0x00004210 File Offset: 0x00002410
	public override SocialHitBuilder Validate()
	{
		if (string.IsNullOrEmpty(this.socialNetwork))
		{
			Debug.LogError("No social network provided - Social hit cannot be sent");
			return null;
		}
		if (string.IsNullOrEmpty(this.socialAction))
		{
			Debug.LogError("No social action provided - Social hit cannot be sent");
			return null;
		}
		if (string.IsNullOrEmpty(this.socialTarget))
		{
			Debug.LogError("No social target provided - Social hit cannot be sent");
			return null;
		}
		return this;
	}

	// Token: 0x0400008B RID: 139
	private string socialNetwork = string.Empty;

	// Token: 0x0400008C RID: 140
	private string socialAction = string.Empty;

	// Token: 0x0400008D RID: 141
	private string socialTarget = string.Empty;
}
