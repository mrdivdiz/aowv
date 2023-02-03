using System;
using UnityEngine;

// Token: 0x02000004 RID: 4
public class RangedTooltipAttribute : PropertyAttribute
{
	// Token: 0x06000003 RID: 3 RVA: 0x000020FC File Offset: 0x000002FC
	public RangedTooltipAttribute(string text, float min, float max)
	{
		this.text = text;
		this.min = min;
		this.max = max;
	}

	// Token: 0x04000001 RID: 1
	public readonly float min;

	// Token: 0x04000002 RID: 2
	public readonly float max;

	// Token: 0x04000003 RID: 3
	public readonly string text;
}
