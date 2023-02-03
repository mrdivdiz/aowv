using System;
using UnityEngine;

// Token: 0x020000C9 RID: 201
public class Bullet8 : Bullet
{
	// Token: 0x060005C0 RID: 1472 RVA: 0x0000FEE4 File Offset: 0x0000E0E4
	public override void init()
	{
		this.ys = 7f * Game.P2U * Mathf.Sin(base.transform.localEulerAngles.z * 0.017453292f);
		this.xs = 7f * Game.P2U * Mathf.Cos(base.transform.localEulerAngles.z * 0.017453292f);
		base.transform.position = new Vector3(base.transform.position.x + this.xs * 5f, base.transform.position.y + this.ys * 5f, 0f);
	}

	// Token: 0x060005C1 RID: 1473 RVA: 0x0000FFA8 File Offset: 0x0000E1A8
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
				for (int j = 0; j < 5; j++)
				{
					GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(PrefabCache.particles[2], base.transform.position, Quaternion.identity);
				}
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (base.isBeneathGround())
			{
				base.transform.position = new Vector3(base.transform.position.x, Game.GROUND_LEVEL + 0.1f, base.transform.position.z);
				for (int k = 0; k < 5; k++)
				{
					GameObject gameObject2 = (GameObject)UnityEngine.Object.Instantiate(PrefabCache.particles[2], base.transform.position, Quaternion.identity);
				}
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
		}
	}

	// Token: 0x04000243 RID: 579
	private float xs;

	// Token: 0x04000244 RID: 580
	private float ys;

	// Token: 0x04000245 RID: 581
	private float g;

	// Token: 0x04000246 RID: 582
	private float gf = 0.02f;

	// Token: 0x04000247 RID: 583
	private float rot;
}
