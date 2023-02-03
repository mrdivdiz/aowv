using System;
using UnityEngine;

// Token: 0x020000CB RID: 203
public class Comet : Bullet
{
	// Token: 0x060005C6 RID: 1478 RVA: 0x000103D8 File Offset: 0x0000E5D8
	private void Start()
	{
		this.damage = 200;
		base.transform.localEulerAngles = new Vector3(0f, 0f, -80f - UnityEngine.Random.value * 20f);
		this.xs = 10f * Game.P2U * Mathf.Cos(base.transform.localEulerAngles.z * 3.1415927f / 180f);
		this.ys = 10f * Game.P2U * Mathf.Sin(base.transform.localEulerAngles.z * 3.1415927f / 180f);
		base.transform.position = new Vector3(Game.instance.baseFriendly.GetComponent<Collider2D>().bounds.center.x + Game.LEVEL_LENGTH * UnityEngine.Random.value, Game.instance.TopOfTheScreen, 0f);
	}

	// Token: 0x060005C7 RID: 1479 RVA: 0x000104D8 File Offset: 0x0000E6D8
	private void FixedUpdate()
	{
		if (Game.instance.IsPaused)
		{
			return;
		}
		this.g += -this.gf * Game.P2U;
		base.transform.position = new Vector3(base.transform.position.x + this.xs, base.transform.position.y + this.ys + this.g, 0f);
		this.c++;
		if (this.c % 2 == 0)
		{
			UnityEngine.Object.Instantiate(PrefabCache.particles[4], base.transform.position + Vector3.up * 0.5f, base.transform.rotation);
		}
		Unit unitHit = base.getUnitHit();
		if (unitHit != null)
		{
			unitHit.damage((float)this.damage);
			for (int i = 0; i < 3; i++)
			{
				UnityEngine.Object.Instantiate(PrefabCache.particles[3], base.transform.position, Quaternion.identity);
			}
			for (int j = 0; j < 3; j++)
			{
				UnityEngine.Object.Instantiate(PrefabCache.particles[3], unitHit.GetComponent<Collider2D>().bounds.center, Quaternion.identity);
			}
			UnityEngine.Object.Destroy(base.gameObject);
		}
		else if (base.isBeneathGround())
		{
			Vector3 position = base.transform.position;
			position.y = Game.GROUND_LEVEL;
			for (int k = 0; k < 6; k++)
			{
				UnityEngine.Object.Instantiate(PrefabCache.particles[3], position + new Vector3(0f, 10f, 0f) * Game.P2U, Quaternion.identity);
			}
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0400024D RID: 589
	private float ys;

	// Token: 0x0400024E RID: 590
	private float xs;

	// Token: 0x0400024F RID: 591
	private float gf = 0.05f;

	// Token: 0x04000250 RID: 592
	private float g;

	// Token: 0x04000251 RID: 593
	private int c;
}
