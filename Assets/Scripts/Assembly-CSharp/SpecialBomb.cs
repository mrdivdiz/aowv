using System;
using UnityEngine;

// Token: 0x020000CF RID: 207
public class SpecialBomb : Bullet
{
	// Token: 0x060005D2 RID: 1490 RVA: 0x00010DA8 File Offset: 0x0000EFA8
	private void Start()
	{
		this.damage = 400;
		base.transform.localEulerAngles = new Vector3(0f, 0f, -80f - UnityEngine.Random.value * 20f);
		this.xs = 4f * Game.P2U * Mathf.Cos(base.transform.localEulerAngles.z * 3.1415927f / 180f);
		this.ys = 1f * Game.P2U;
		this.rot = UnityEngine.Random.value * 10f - 5f;
	}

	// Token: 0x060005D3 RID: 1491 RVA: 0x00010E4C File Offset: 0x0000F04C
	private void FixedUpdate()
	{
		if (Game.instance.IsPaused)
		{
			return;
		}
		this.g += -this.gf * Game.P2U;
		base.transform.position = new Vector3(base.transform.position.x + this.xs, base.transform.position.y + this.ys + this.g, 0f);
		base.transform.localEulerAngles = new Vector3(0f, 0f, base.transform.localEulerAngles.z + this.rot);
		this.c++;
		if (this.c % 2 == 0)
		{
		}
		Unit unitHit = base.getUnitHit();
		if (unitHit != null)
		{
			unitHit.damage((float)this.damage);
			GameObject obj = (GameObject)UnityEngine.Object.Instantiate(PrefabCache.particles[12], base.transform.position, Quaternion.identity);
			UnityEngine.Object.Destroy(obj, 0.95f);
			for (int i = 0; i < 5; i++)
			{
				UnityEngine.Object.Instantiate(PrefabCache.particles[2], base.transform.position, Quaternion.identity);
			}
			UnityEngine.Object.Destroy(base.gameObject);
		}
		else if (base.isBeneathGround())
		{
			base.transform.position = new Vector3(base.transform.position.x, Game.GROUND_LEVEL, base.transform.position.z);
			GameObject obj2 = (GameObject)UnityEngine.Object.Instantiate(PrefabCache.particles[12], base.transform.position, Quaternion.identity);
			UnityEngine.Object.Destroy(obj2, 0.95f);
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x04000262 RID: 610
	private float ys;

	// Token: 0x04000263 RID: 611
	private float xs;

	// Token: 0x04000264 RID: 612
	private float gf = 0.2f;

	// Token: 0x04000265 RID: 613
	private float g;

	// Token: 0x04000266 RID: 614
	private int c;

	// Token: 0x04000267 RID: 615
	private float rot;
}
