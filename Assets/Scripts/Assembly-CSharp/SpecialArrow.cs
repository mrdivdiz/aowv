using System;
using UnityEngine;

// Token: 0x020000CD RID: 205
public class SpecialArrow : Bullet
{
	// Token: 0x060005CC RID: 1484 RVA: 0x00010940 File Offset: 0x0000EB40
	private void Start()
	{
		this.damage = 200;
		base.transform.localEulerAngles = new Vector3(0f, 0f, -80f - UnityEngine.Random.value * 20f);
		this.xs = 10f * Game.P2U * Mathf.Cos(base.transform.localEulerAngles.z * 3.1415927f / 180f);
		this.ys = 10f * Game.P2U * Mathf.Sin(base.transform.localEulerAngles.z * 3.1415927f / 180f);
		base.transform.position = new Vector3(Game.instance.baseFriendly.GetComponent<Collider2D>().bounds.center.x + Game.LEVEL_LENGTH * UnityEngine.Random.value, Game.instance.TopOfTheScreen, 0f);
	}

	// Token: 0x060005CD RID: 1485 RVA: 0x00010A40 File Offset: 0x0000EC40
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
		}
		Unit unitHit = base.getUnitHit();
		if (unitHit != null)
		{
			unitHit.damage((float)this.damage);
			for (int i = 0; i < 3; i++)
			{
			}
			for (int j = 0; j < 3; j++)
			{
			}
			UnityEngine.Object.Destroy(base.gameObject);
		}
		else if (base.isBeneathGround())
		{
			base.transform.position = new Vector3(base.transform.position.x, Game.GROUND_LEVEL + 0.1f, base.transform.position.z);
			for (int k = 0; k < 6; k++)
			{
			}
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x04000257 RID: 599
	private float ys;

	// Token: 0x04000258 RID: 600
	private float xs;

	// Token: 0x04000259 RID: 601
	private float gf = 0.05f;

	// Token: 0x0400025A RID: 602
	private float g;

	// Token: 0x0400025B RID: 603
	private int c;
}
