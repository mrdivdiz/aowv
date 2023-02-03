using System;
using UnityEngine;

// Token: 0x020000F9 RID: 249
public class SpecialComets : MonoBehaviour
{
	// Token: 0x060006B8 RID: 1720 RVA: 0x000208BC File Offset: 0x0001EABC
	private void Start()
	{
	}

	// Token: 0x060006B9 RID: 1721 RVA: 0x000208C0 File Offset: 0x0001EAC0
	private void FixedUpdate()
	{
		if (Game.instance.IsPaused)
		{
			return;
		}
		this.cc++;
		this.frames++;
		if (this.cc == 9 && this.frames < 200)
		{
			UnityEngine.Object.Instantiate<GameObject>(PrefabCache.Comet).GetComponent<Comet>().team = this.team;
			this.cc = 0;
		}
		if (this.frames >= 200)
		{
			UnityEngine.Object.Destroy(base.gameObject, 2f);
		}
		else
		{
			Game.instance.shakeCamera();
		}
	}

	// Token: 0x04000456 RID: 1110
	private float spawnTime;

	// Token: 0x04000457 RID: 1111
	private int cc;

	// Token: 0x04000458 RID: 1112
	private int frames;

	// Token: 0x04000459 RID: 1113
	public int team;
}
