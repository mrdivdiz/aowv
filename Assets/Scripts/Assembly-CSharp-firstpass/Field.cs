using System;

// Token: 0x02000006 RID: 6
public class Field
{
	// Token: 0x06000005 RID: 5 RVA: 0x0000212C File Offset: 0x0000032C
	public Field(string parameter)
	{
		this.parameter = parameter;
	}

	// Token: 0x06000006 RID: 6 RVA: 0x0000213C File Offset: 0x0000033C
	public override string ToString()
	{
		return this.parameter;
	}

	// Token: 0x04000005 RID: 5
	private readonly string parameter;
}
