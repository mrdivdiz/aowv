using System;
using UnityEngine;

// Token: 0x020000F7 RID: 247
public class SpecialArrows : MonoBehaviour
{
	// Token: 0x060006B1 RID: 1713 RVA: 0x00020628 File Offset: 0x0001E828
	private void Start()
	{
	}

	// Token: 0x060006B2 RID: 1714 RVA: 0x0002062C File Offset: 0x0001E82C
	private void FixedUpdate()
	{
		if (Game.instance.IsPaused)
		{
			return;
		}
		this.cc++;
		this.frames++;
		Game.instance.shakeCamera();
		if (this.cc == 5)
		{
			UnityEngine.Object.Instantiate<GameObject>(PrefabCache.Arrow).GetComponent<SpecialArrow>().team = this.team;
			this.cc = 0;
		}
		if (this.frames >= 200)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0400044B RID: 1099
	private float spawnTime;

	// Token: 0x0400044C RID: 1100
	private int cc;

	// Token: 0x0400044D RID: 1101
	private int frames;

	// Token: 0x0400044E RID: 1102
	public int team;
}
