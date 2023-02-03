using System;
using UnityEngine;

// Token: 0x02000005 RID: 5
public class TooltipAttribute : PropertyAttribute
{
	// Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
	public TooltipAttribute(string text)
	{
		this.text = text;
	}

	// Token: 0x04000004 RID: 4
	public readonly string text;
}
