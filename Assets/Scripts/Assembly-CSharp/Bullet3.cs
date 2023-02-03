using System;
using UnityEngine;

// Token: 0x020000C5 RID: 197
public class Bullet3 : Bullet
{
	// Token: 0x060005B4 RID: 1460 RVA: 0x0000F380 File Offset: 0x0000D580
	public override void init()
	{
		this.ys = 7f * Game.P2U * Mathf.Sin(base.transform.localEulerAngles.z * 0.017453292f);
		this.xs = 7f * Game.P2U * Mathf.Cos(base.transform.localEulerAngles.z * 0.017453292f);
		this.rot = 2f;
		float num = 0f;
		if (this.team == 1)
		{
			num -= this.xs * 5f;
		}
		else
		{
			num += this.xs * 5f;
		}
		base.transform.position += new Vector3(0f, num, 0f);
	}

	// Token: 0x060005B5 RID: 1461 RVA: 0x0000F454 File Offset: 0x0000D654
	private void FixedUpdate()
	{
		if (Game.instance.IsPaused)
		{
			return;
		}
		this.g += this.gf * Game.P2U;
		base.transform.position = new Vector3(base.transform.position.x + this.xs, base.transform.position.y + this.ys - this.g, 0f);
		base.transform.localEulerAngles = new Vector3(0f, 0f, base.transform.localEulerAngles.z + this.rot);
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

	// Token: 0x0400022F RID: 559
	private float xs;

	// Token: 0x04000230 RID: 560
	private float ys;

	// Token: 0x04000231 RID: 561
	private float g;

	// Token: 0x04000232 RID: 562
	private float gf = 0.05f;

	// Token: 0x04000233 RID: 563
	private float rot;
}
