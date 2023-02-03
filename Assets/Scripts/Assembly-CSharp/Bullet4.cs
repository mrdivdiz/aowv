using System;
using UnityEngine;

// Token: 0x020000C6 RID: 198
public class Bullet4 : Bullet
{
	// Token: 0x060005B7 RID: 1463 RVA: 0x0000F638 File Offset: 0x0000D838
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

	// Token: 0x060005B8 RID: 1464 RVA: 0x0000F70C File Offset: 0x0000D90C
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
			Vector3 position = base.transform.position;
			for (int i = 0; i < 3; i++)
			{
				GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(PrefabCache.particles[5], position, Quaternion.identity);
				gameObject.GetComponent<OilPart>().damage = 10;
				gameObject.GetComponent<OilPart>().team = this.team;
			}
			GameObject obj = (GameObject)UnityEngine.Object.Instantiate(PrefabCache.particles[7], position, Quaternion.identity);
			UnityEngine.Object.Destroy(obj, 0.9f);
			UnityEngine.Object.Destroy(base.gameObject);
		}
		else if (base.isBeneathGround())
		{
			Vector3 position2 = base.transform.position;
			position2.y = Game.GROUND_LEVEL + 0.1f;
			for (int j = 0; j < 3; j++)
			{
				GameObject gameObject2 = (GameObject)UnityEngine.Object.Instantiate(PrefabCache.particles[5], position2, Quaternion.identity);
				gameObject2.GetComponent<OilPart>().damage = 10;
				gameObject2.GetComponent<OilPart>().team = this.team;
			}
			UnityEngine.Object.Instantiate(PrefabCache.particles[6], position2, Quaternion.identity);
			GameObject obj2 = (GameObject)UnityEngine.Object.Instantiate(PrefabCache.particles[7], position2, Quaternion.identity);
			UnityEngine.Object.Destroy(obj2, 0.9f);
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x04000234 RID: 564
	private float xs;

	// Token: 0x04000235 RID: 565
	private float ys;

	// Token: 0x04000236 RID: 566
	private float g;

	// Token: 0x04000237 RID: 567
	private float gf = 0.05f;

	// Token: 0x04000238 RID: 568
	private float rot;
}
