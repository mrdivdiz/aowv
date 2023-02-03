using System;
using UnityEngine;

// Token: 0x020000CA RID: 202
public class Bullet9 : Bullet
{
	// Token: 0x060005C3 RID: 1475 RVA: 0x00010134 File Offset: 0x0000E334
	public override void init()
	{
		this.ys = 0.2f * Game.P2U * Mathf.Sin(base.transform.localEulerAngles.z * 0.017453292f);
		this.xs = 0.2f * Game.P2U * Mathf.Cos(base.transform.localEulerAngles.z * 0.017453292f);
		base.transform.position = new Vector3(base.transform.position.x + this.xs * 200f, base.transform.position.y + this.ys * 200f, 0f);
	}

	// Token: 0x060005C4 RID: 1476 RVA: 0x000101F8 File Offset: 0x0000E3F8
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
				GameObject obj = (GameObject)UnityEngine.Object.Instantiate(PrefabCache.particles[7], position, Quaternion.identity);
				UnityEngine.Object.Destroy(obj, 0.9f);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (base.isBeneathGround())
			{
				Vector3 position2 = base.transform.position;
				position2.y = Game.GROUND_LEVEL + 0.1f;
				for (int k = 0; k < 5; k++)
				{
					GameObject gameObject2 = (GameObject)UnityEngine.Object.Instantiate(PrefabCache.particles[2], base.transform.position, Quaternion.identity);
				}
				GameObject obj2 = (GameObject)UnityEngine.Object.Instantiate(PrefabCache.particles[7], position2, Quaternion.identity);
				UnityEngine.Object.Destroy(obj2, 0.9f);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
		}
	}

	// Token: 0x04000248 RID: 584
	private float xs;

	// Token: 0x04000249 RID: 585
	private float ys;

	// Token: 0x0400024A RID: 586
	private float g;

	// Token: 0x0400024B RID: 587
	private float gf = 0.02f;

	// Token: 0x0400024C RID: 588
	private float rot;
}
