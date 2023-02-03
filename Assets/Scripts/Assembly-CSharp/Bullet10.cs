using System;
using UnityEngine;

// Token: 0x020000C3 RID: 195
public class Bullet10 : Bullet
{
	// Token: 0x060005AE RID: 1454 RVA: 0x0000EFC8 File Offset: 0x0000D1C8
	public override void init()
	{
		this.ys = 0.2f * Game.P2U * Mathf.Sin(base.transform.localEulerAngles.z * 0.017453292f);
		this.xs = 0.2f * Game.P2U * Mathf.Cos(base.transform.localEulerAngles.z * 0.017453292f);
		base.transform.position = new Vector3(base.transform.position.x + this.xs * 42f, base.transform.position.y + this.ys * 42f, 0f);
	}

	// Token: 0x060005AF RID: 1455 RVA: 0x0000F08C File Offset: 0x0000D28C
	private void FixedUpdate()
	{
		if (Game.instance.IsPaused)
		{
			return;
		}
		for (int i = 7; i >= 0; i--)
		{
			this.xs *= 1.01f;
			this.ys *= 1.01f;
			base.transform.position = new Vector3(base.transform.position.x + this.xs, base.transform.position.y + this.ys - this.g, 0f);
			Unit unitHit = base.getUnitHit();
			if (unitHit != null)
			{
				unitHit.damage((float)this.damage);
				Vector3 position = base.transform.position;
				for (int j = 0; j < 5; j++)
				{
					GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(PrefabCache.particles[2], base.transform.position, Quaternion.identity);
				}
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (base.isBeneathGround())
			{
				//base.transform.position.y = Game.GROUND_LEVEL + 0.1f;
				base.transform.position = new Vector3(base.transform.position.x, Game.GROUND_LEVEL + 0.1f, base.transform.position.z);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
		}
	}

	// Token: 0x04000225 RID: 549
	private float xs;

	// Token: 0x04000226 RID: 550
	private float ys;

	// Token: 0x04000227 RID: 551
	private float g;

	// Token: 0x04000228 RID: 552
	private float gf = 0.02f;

	// Token: 0x04000229 RID: 553
	private float rot;
}
