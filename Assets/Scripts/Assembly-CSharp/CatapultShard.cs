using System;
using UnityEngine;

// Token: 0x020000F1 RID: 241
public class CatapultShard : Bullet
{
	// Token: 0x0600069B RID: 1691 RVA: 0x0001ED04 File Offset: 0x0001CF04
	private void Start()
	{
		float num = UnityEngine.Random.value * 0.4f + 1f;
		base.transform.localScale = new Vector3(num, num, 1f);
		this.xs = UnityEngine.Random.value * 6f * Game.P2U - 3f * Game.P2U;
		this.g = UnityEngine.Random.value * 3f * Game.P2U + 1f * Game.P2U;
		base.transform.position = new Vector3(base.transform.position.x + UnityEngine.Random.value * 9f * Game.P2U - 4f * Game.P2U, base.transform.position.y + UnityEngine.Random.value * 9f * Game.P2U - 4f * Game.P2U, base.transform.position.z);
		this.rot = UnityEngine.Random.value * 4f - 1.5f;
	}

	// Token: 0x0600069C RID: 1692 RVA: 0x0001EE1C File Offset: 0x0001D01C
	private void FixedUpdate()
	{
		if (Game.instance.IsPaused)
		{
			return;
		}
		this.g -= this.gf * Game.P2U;
		this.xs /= 1f + this.f;
		base.transform.position = new Vector3(base.transform.position.x + this.xs, base.transform.position.y + this.g, base.transform.position.z);
		base.transform.localEulerAngles = new Vector3(0f, 0f, base.transform.localEulerAngles.z + this.rot);
		if (base.isBeneathGround())
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x040003F7 RID: 1015
	private float gf = 0.15f;

	// Token: 0x040003F8 RID: 1016
	private float f = 0.1f;

	// Token: 0x040003F9 RID: 1017
	private float xs;

	// Token: 0x040003FA RID: 1018
	private float g;

	// Token: 0x040003FB RID: 1019
	private float rot;
}
