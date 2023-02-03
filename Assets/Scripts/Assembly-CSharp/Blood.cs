using System;
using UnityEngine;

// Token: 0x020000F0 RID: 240
public class Blood : global::Particle
{
	// Token: 0x06000699 RID: 1689 RVA: 0x0001EBA4 File Offset: 0x0001CDA4
	private void Start()
	{
		base.transform.position = base.transform.position + new Vector3(this.positionOffset.x + UnityEngine.Random.value * this.positionRandom.x, this.positionOffset.y + UnityEngine.Random.value * this.positionRandom.y, 0f) * Game.P2U;
		this.velocity = new Vector2(this.velocityOffset.x + UnityEngine.Random.value * this.velocityRandom.x, this.velocityOffset.y + UnityEngine.Random.value * this.velocityRandom.y) * Game.P2U;
		float num = UnityEngine.Random.value * this.scaleRandom;
		base.transform.localScale = new Vector3(this.scaleOffset + num, this.scaleOffset + num, this.scaleOffset + num) / 100f;
		this.angularVelocity = this.rotOffset + UnityEngine.Random.value * this.rotRandom;
		base.GetComponentInChildren<Animator>().Play("Blood", 0, UnityEngine.Random.value);
		base.GetComponentInChildren<Animator>().StopPlayback();
	}
}
