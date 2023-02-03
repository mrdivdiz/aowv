using System;
using UnityEngine;

// Token: 0x020000F4 RID: 244
public class Particle : MonoBehaviour
{
	// Token: 0x060006A6 RID: 1702 RVA: 0x0001FA88 File Offset: 0x0001DC88
	private void Start()
	{
		base.transform.position = base.transform.position + new Vector3(this.positionOffset.x + UnityEngine.Random.value * this.positionRandom.x, this.positionOffset.y + UnityEngine.Random.value * this.positionRandom.y, 0f) * Game.P2U;
		this.velocity = new Vector2(this.velocityOffset.x + UnityEngine.Random.value * this.velocityRandom.x, this.velocityOffset.y + UnityEngine.Random.value * this.velocityRandom.y) * Game.P2U;
		float num = UnityEngine.Random.value * this.scaleRandom;
		base.transform.localScale = new Vector3(this.scaleOffset + num, this.scaleOffset + num, this.scaleOffset + num) * Game.P2U;
		this.angularVelocity = this.rotOffset + UnityEngine.Random.value * this.rotRandom;
	}

	// Token: 0x060006A7 RID: 1703 RVA: 0x0001FBA8 File Offset: 0x0001DDA8
	private void FixedUpdate()
	{
		if (Game.instance.IsPaused)
		{
			return;
		}
		this.velocity.x = this.velocity.x / (1f + this.drag);
		this.velocity.y = this.velocity.y + -this.gf * Game.P2U;
		base.transform.position = base.transform.position + new Vector3(this.velocity.x, this.velocity.y, 0f);
		base.transform.localEulerAngles = new Vector3(0f, 0f, base.transform.localEulerAngles.z + this.angularVelocity);
		Color color = base.GetComponent<Renderer>().material.color;
		color.a -= this.alphaDecay / 100f;
		base.GetComponent<Renderer>().material.color = color;
		base.transform.localScale = new Vector3(base.transform.localScale.x - this.scaleDecay / 100f, base.transform.localScale.x - this.scaleDecay / 100f, base.transform.localScale.x - this.scaleDecay / 100f);
		if (base.transform.position.y < Game.GROUND_LEVEL || color.a < 0f || base.transform.localScale.x < 0f)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0400041E RID: 1054
	public float drag = 0.1f;

	// Token: 0x0400041F RID: 1055
	public float scaleOffset = 100f;

	// Token: 0x04000420 RID: 1056
	public float scaleRandom = 40f;

	// Token: 0x04000421 RID: 1057
	public float rotOffset = -1.5f;

	// Token: 0x04000422 RID: 1058
	public float rotRandom = 4f;

	// Token: 0x04000423 RID: 1059
	public Vector2 positionOffset = new Vector2(-4f, -4f);

	// Token: 0x04000424 RID: 1060
	public Vector2 positionRandom = new Vector2(9f, 9f);

	// Token: 0x04000425 RID: 1061
	public Vector2 velocityOffset = new Vector2(-3f, 1f);

	// Token: 0x04000426 RID: 1062
	public Vector2 velocityRandom = new Vector2(6f, 3f);

	// Token: 0x04000427 RID: 1063
	public float alphaDecay;

	// Token: 0x04000428 RID: 1064
	public float scaleDecay;

	// Token: 0x04000429 RID: 1065
	public float gf = 0.15f;

	// Token: 0x0400042A RID: 1066
	protected float angularVelocity;

	// Token: 0x0400042B RID: 1067
	protected Vector2 velocity;
}
