using System;
using UnityEngine;

// Token: 0x020000C8 RID: 200
public class Bullet7 : Bullet
{
	// Token: 0x060005BD RID: 1469 RVA: 0x0000FBCC File Offset: 0x0000DDCC
	public override void init()
	{
		this.ys = 7f * Game.P2U * Mathf.Sin(base.transform.localEulerAngles.z * 0.017453292f);
		this.xs = 7f * Game.P2U * Mathf.Cos(base.transform.localEulerAngles.z * 0.017453292f);
		base.transform.position = new Vector3(base.transform.position.x + this.xs * 5f, base.transform.position.y + this.ys * 5f, 0f);
	}

	// Token: 0x060005BE RID: 1470 RVA: 0x0000FC90 File Offset: 0x0000DE90
	private void FixedUpdate()
	{
		if (Game.instance.IsPaused)
		{
			return;
		}
		for (int i = 3; i >= 0; i--)
		{
			this.g += this.gf * Game.P2U;
			base.transform.position = new Vector3(base.transform.position.x + this.xs, base.transform.position.y + this.ys - this.g, 0f);
			Unit unitHit = base.getUnitHit();
			if (unitHit != null)
			{
				unitHit.damage((float)this.damage);
				Vector3 position = base.transform.position;
				for (int j = 0; j < 3; j++)
				{
					GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(PrefabCache.particles[11], base.transform.position, Quaternion.identity);
					gameObject.GetComponent<OilPart>().damage = 30;
					gameObject.GetComponent<OilPart>().team = this.team;
				}
				GameObject obj = (GameObject)UnityEngine.Object.Instantiate(PrefabCache.particles[7], position, Quaternion.identity);
				UnityEngine.Object.Destroy(obj, 0.9f);
				for (int k = 0; k < 5; k++)
				{
					UnityEngine.Object.Instantiate(PrefabCache.particles[2], unitHit.GetComponent<Collider2D>().bounds.center, Quaternion.identity);
				}
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (base.isBeneathGround())
			{
				Vector3 position2 = base.transform.position;
				position2.y = Game.GROUND_LEVEL + 0.1f;
				for (int l = 0; l < 4; l++)
				{
					GameObject gameObject2 = (GameObject)UnityEngine.Object.Instantiate(PrefabCache.particles[11], base.transform.position, Quaternion.identity);
					gameObject2.GetComponent<OilPart>().damage = 30;
					gameObject2.GetComponent<OilPart>().team = this.team;
				}
				GameObject obj2 = (GameObject)UnityEngine.Object.Instantiate(PrefabCache.particles[7], position2, Quaternion.identity);
				UnityEngine.Object.Destroy(obj2, 0.9f);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
		}
	}

	// Token: 0x0400023E RID: 574
	private float xs;

	// Token: 0x0400023F RID: 575
	private float ys;

	// Token: 0x04000240 RID: 576
	private float g;

	// Token: 0x04000241 RID: 577
	private float gf = 0.02f;

	// Token: 0x04000242 RID: 578
	private float rot;
}
