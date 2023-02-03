using System;
using UnityEngine;

// Token: 0x020000CC RID: 204
public class Sling : Bullet
{
	// Token: 0x060005C9 RID: 1481 RVA: 0x000106D8 File Offset: 0x0000E8D8
	public override void init()
	{
		this.ys = 7f * Game.P2U * Mathf.Sin(base.transform.localEulerAngles.z * 0.017453292f);
		this.xs = 7f * Game.P2U * Mathf.Cos(base.transform.localEulerAngles.z * 0.017453292f);
		this.rot = UnityEngine.Random.value * 6f - 3f;
	}

	// Token: 0x060005CA RID: 1482 RVA: 0x0001075C File Offset: 0x0000E95C
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

	// Token: 0x04000252 RID: 594
	private float xs;

	// Token: 0x04000253 RID: 595
	private float ys;

	// Token: 0x04000254 RID: 596
	private float g;

	// Token: 0x04000255 RID: 597
	private float gf = 0.05f;

	// Token: 0x04000256 RID: 598
	private float rot;
}
