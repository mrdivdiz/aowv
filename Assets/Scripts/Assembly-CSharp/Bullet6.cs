using System;
using UnityEngine;

// Token: 0x020000C7 RID: 199
public class Bullet6 : Bullet
{
	// Token: 0x060005BA RID: 1466 RVA: 0x0000F948 File Offset: 0x0000DB48
	public override void init()
	{
		this.ys = 7f * Game.P2U * Mathf.Sin(base.transform.localEulerAngles.z * 0.017453292f);
		this.xs = 7f * Game.P2U * Mathf.Cos(base.transform.localEulerAngles.z * 0.017453292f);
		base.transform.position = new Vector3(base.transform.position.x + this.xs * 5f, base.transform.position.y + this.ys * 12f, 0f);
	}

	// Token: 0x060005BB RID: 1467 RVA: 0x0000FA0C File Offset: 0x0000DC0C
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
					UnityEngine.Object.Instantiate(PrefabCache.particles[10], base.transform.position, Quaternion.identity);
				}
				for (int k = 0; k < 5; k++)
				{
					UnityEngine.Object.Instantiate(PrefabCache.particles[10], unitHit.GetComponent<Collider2D>().bounds.center, Quaternion.identity);
				}
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (base.isBeneathGround())
			{
				base.transform.position = new Vector3(base.transform.position.x, Game.GROUND_LEVEL + 0.1f, base.transform.position.z);
				for (int l = 0; l < 5; l++)
				{
					UnityEngine.Object.Instantiate(PrefabCache.particles[10], base.transform.position, Quaternion.identity);
				}
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
		}
	}

	// Token: 0x04000239 RID: 569
	private float xs;

	// Token: 0x0400023A RID: 570
	private float ys;

	// Token: 0x0400023B RID: 571
	private float g;

	// Token: 0x0400023C RID: 572
	private float gf = 0.02f;

	// Token: 0x0400023D RID: 573
	private float rot;
}
