using System;
using UnityEngine;

// Token: 0x0200000F RID: 15
public class EventHitBuilder : HitBuilder<EventHitBuilder>
{
	// Token: 0x06000052 RID: 82 RVA: 0x00003D5C File Offset: 0x00001F5C
	public string GetEventCategory()
	{
		return this.eventCategory;
	}

	// Token: 0x06000053 RID: 83 RVA: 0x00003D64 File Offset: 0x00001F64
	public EventHitBuilder SetEventCategory(string eventCategory)
	{
		if (eventCategory != null)
		{
			this.eventCategory = eventCategory;
		}
		return this;
	}

	// Token: 0x06000054 RID: 84 RVA: 0x00003D74 File Offset: 0x00001F74
	public string GetEventAction()
	{
		return this.eventAction;
	}

	// Token: 0x06000055 RID: 85 RVA: 0x00003D7C File Offset: 0x00001F7C
	public EventHitBuilder SetEventAction(string eventAction)
	{
		if (eventAction != null)
		{
			this.eventAction = eventAction;
		}
		return this;
	}

	// Token: 0x06000056 RID: 86 RVA: 0x00003D8C File Offset: 0x00001F8C
	public string GetEventLabel()
	{
		return this.eventLabel;
	}

	// Token: 0x06000057 RID: 87 RVA: 0x00003D94 File Offset: 0x00001F94
	public EventHitBuilder SetEventLabel(string eventLabel)
	{
		if (eventLabel != null)
		{
			this.eventLabel = eventLabel;
		}
		return this;
	}

	// Token: 0x06000058 RID: 88 RVA: 0x00003DA4 File Offset: 0x00001FA4
	public long GetEventValue()
	{
		return this.eventValue;
	}

	// Token: 0x06000059 RID: 89 RVA: 0x00003DAC File Offset: 0x00001FAC
	public EventHitBuilder SetEventValue(long eventValue)
	{
		this.eventValue = eventValue;
		return this;
	}

	// Token: 0x0600005A RID: 90 RVA: 0x00003DB8 File Offset: 0x00001FB8
	public override EventHitBuilder GetThis()
	{
		return this;
	}

	// Token: 0x0600005B RID: 91 RVA: 0x00003DBC File Offset: 0x00001FBC
	public override EventHitBuilder Validate()
	{
		if (string.IsNullOrEmpty(this.eventCategory))
		{
			Debug.LogWarning("No event category provided - Event hit cannot be sent.");
			return null;
		}
		if (string.IsNullOrEmpty(this.eventAction))
		{
			Debug.LogWarning("No event action provided - Event hit cannot be sent.");
			return null;
		}
		return this;
	}

	// Token: 0x04000074 RID: 116
	private string eventCategory = string.Empty;

	// Token: 0x04000075 RID: 117
	private string eventAction = string.Empty;

	// Token: 0x04000076 RID: 118
	private string eventLabel = string.Empty;

	// Token: 0x04000077 RID: 119
	private long eventValue;
}
