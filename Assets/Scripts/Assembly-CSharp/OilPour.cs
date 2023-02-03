using System;
using UnityEngine;

// Token: 0x020000EF RID: 239
public class OilPour : Bullet
{
	// Token: 0x06000696 RID: 1686 RVA: 0x0001EA94 File Offset: 0x0001CC94
	private void Start()
	{
		if (this.team == 0)
		{
			base.transform.Translate(new Vector3(116f * Game.P2U, 7f * Game.P2U, 0f));
		}
		else
		{
			base.transform.Translate(new Vector3(116f * Game.P2U, 7f * Game.P2U, 0f));
		}
		UnityEngine.Object.Destroy(base.gameObject, 1f);
	}

	// Token: 0x06000697 RID: 1687 RVA: 0x0001EB18 File Offset: 0x0001CD18
	private void FixedUpdate()
	{
		if (Game.instance.IsPaused)
		{
			return;
		}
		this.c++;
		if (this.c == 2)
		{
			GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(PrefabCache.particles[8], base.transform.position, Quaternion.identity);
			gameObject.GetComponent<OilPourPart>().damage = this.damage;
			gameObject.GetComponent<OilPourPart>().team = this.team;
			this.c = 0;
		}
	}

	// Token: 0x040003F6 RID: 1014
	private int c;
}
