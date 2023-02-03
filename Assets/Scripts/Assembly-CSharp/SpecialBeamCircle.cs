using System;
using UnityEngine;

// Token: 0x020000CE RID: 206
public class SpecialBeamCircle : Bullet
{
	// Token: 0x060005CF RID: 1487 RVA: 0x00010B90 File Offset: 0x0000ED90
	private void Start()
	{
		this.damage = 1000;
		base.transform.localEulerAngles = new Vector3(0f, 0f, -80f - UnityEngine.Random.value * 20f);
		this.xs = 4f * Game.P2U * Mathf.Cos(base.transform.localEulerAngles.z * 3.1415927f / 180f);
		this.ys = 1f * Game.P2U;
		this.rot = UnityEngine.Random.value * 10f - 5f;
		AudioSource.PlayClipAtPoint(PrefabCache.beam, Camera.main.transform.position);
	}

	// Token: 0x060005D0 RID: 1488 RVA: 0x00010C4C File Offset: 0x0000EE4C
	private void FixedUpdate()
	{
		this.g += -this.gf * Game.P2U;
		base.transform.position = new Vector3(base.transform.position.x + this.xs, base.transform.position.y + this.ys + this.g, 0f);
		base.transform.localEulerAngles = new Vector3(0f, 0f, base.transform.localEulerAngles.z + this.rot);
		Unit unitHit = base.getUnitHit();
		if (unitHit != null)
		{
			unitHit.damage((float)this.damage);
			for (int i = 0; i < 5; i++)
			{
				UnityEngine.Object.Instantiate(PrefabCache.particles[2], base.transform.position, Quaternion.identity);
			}
			UnityEngine.Object.Destroy(base.gameObject);
		}
		else if (base.isBeneathGround())
		{
			base.transform.position = new Vector3(base.transform.position.x, Game.GROUND_LEVEL, base.transform.position.z);
			UnityEngine.Object.Destroy(base.gameObject);
		}
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x0400025C RID: 604
	private float ys;

	// Token: 0x0400025D RID: 605
	private float xs;

	// Token: 0x0400025E RID: 606
	private float gf = 0.2f;

	// Token: 0x0400025F RID: 607
	private float g;

	// Token: 0x04000260 RID: 608
	private int c;

	// Token: 0x04000261 RID: 609
	private float rot;
}
