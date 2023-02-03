using System;
using UnityEngine;

// Token: 0x020000C4 RID: 196
public class Bullet2 : Bullet
{
	// Token: 0x060005B1 RID: 1457 RVA: 0x0000F1E8 File Offset: 0x0000D3E8
	public override void init()
	{
		this.ys = 7f * Game.P2U * Mathf.Sin(base.transform.localEulerAngles.z * 0.017453292f);
		this.xs = 7f * Game.P2U * Mathf.Cos(base.transform.localEulerAngles.z * 0.017453292f);
		this.rot = UnityEngine.Random.value * 6f - 3f;
	}

	// Token: 0x060005B2 RID: 1458 RVA: 0x0000F26C File Offset: 0x0000D46C
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
			UnityEngine.Object.Destroy(base.gameObject);
		}
		else if (base.isBeneathGround())
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0400022A RID: 554
	private float xs;

	// Token: 0x0400022B RID: 555
	private float ys;

	// Token: 0x0400022C RID: 556
	private float g;

	// Token: 0x0400022D RID: 557
	private float gf = 0.05f;

	// Token: 0x0400022E RID: 558
	private float rot;
}
