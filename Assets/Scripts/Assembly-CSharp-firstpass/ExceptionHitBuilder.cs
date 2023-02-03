using System;

// Token: 0x02000010 RID: 16
public class ExceptionHitBuilder : HitBuilder<ExceptionHitBuilder>
{
	// Token: 0x0600005D RID: 93 RVA: 0x00003E0C File Offset: 0x0000200C
	public string GetExceptionDescription()
	{
		return this.exceptionDescription;
	}

	// Token: 0x0600005E RID: 94 RVA: 0x00003E14 File Offset: 0x00002014
	public ExceptionHitBuilder SetExceptionDescription(string exceptionDescription)
	{
		if (exceptionDescription != null)
		{
			this.exceptionDescription = exceptionDescription;
		}
		return this;
	}

	// Token: 0x0600005F RID: 95 RVA: 0x00003E24 File Offset: 0x00002024
	public bool IsFatal()
	{
		return this.fatal;
	}

	// Token: 0x06000060 RID: 96 RVA: 0x00003E2C File Offset: 0x0000202C
	public ExceptionHitBuilder SetFatal(bool fatal)
	{
		this.fatal = fatal;
		return this;
	}

	// Token: 0x06000061 RID: 97 RVA: 0x00003E38 File Offset: 0x00002038
	public override ExceptionHitBuilder GetThis()
	{
		return this;
	}

	// Token: 0x06000062 RID: 98 RVA: 0x00003E3C File Offset: 0x0000203C
	public override ExceptionHitBuilder Validate()
	{
		return this;
	}

	// Token: 0x04000078 RID: 120
	private string exceptionDescription = string.Empty;

	// Token: 0x04000079 RID: 121
	private bool fatal;
}
