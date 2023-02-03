using System;
using UnityEngine;

// Token: 0x020000F3 RID: 243
public class OilPourPart : MonoBehaviour
{
	// Token: 0x060006A2 RID: 1698 RVA: 0x0001F590 File Offset: 0x0001D790
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

	// Token: 0x060006A3 RID: 1699 RVA: 0x0001F6D0 File Offset: 0x0001D8D0
	public Unit getUnitHit()
	{
		foreach (object obj in Game.units)
		{
			Unit unit = (Unit)obj;
			if (this.team != unit.team && unit.GetComponent<Collider2D>().bounds.Intersects(base.GetComponent<Collider2D>().bounds) && !(unit is Base))
			{
				return unit;
			}
		}
		return null;
	}

	// Token: 0x060006A4 RID: 1700 RVA: 0x0001F784 File Offset: 0x0001D984
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
		Unit unitHit = this.getUnitHit();
		if (unitHit != null)
		{
			unitHit.damage((float)this.damage);
			Vector3 position = base.transform.position;
			for (int i = 0; i < 4; i++)
			{
				GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(PrefabCache.particles[9], position, Quaternion.identity);
			}
			UnityEngine.Object.Destroy(base.gameObject);
		}
		else if (base.transform.position.y < Game.GROUND_LEVEL || color.a < 0f || base.transform.localScale.x < 0f)
		{
			base.transform.position = new Vector3(base.transform.position.x, Game.GROUND_LEVEL + 0.1f, base.transform.position.z);
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0400040E RID: 1038
	public float drag = 0.1f;

	// Token: 0x0400040F RID: 1039
	public float scaleOffset = 100f;

	// Token: 0x04000410 RID: 1040
	public float scaleRandom = 40f;

	// Token: 0x04000411 RID: 1041
	public float rotOffset = -1.5f;

	// Token: 0x04000412 RID: 1042
	public float rotRandom = 4f;

	// Token: 0x04000413 RID: 1043
	public Vector2 positionOffset = new Vector2(-4f, -4f);

	// Token: 0x04000414 RID: 1044
	public Vector2 positionRandom = new Vector2(9f, 9f);

	// Token: 0x04000415 RID: 1045
	public Vector2 velocityOffset = new Vector2(-3f, 1f);

	// Token: 0x04000416 RID: 1046
	public Vector2 velocityRandom = new Vector2(6f, 3f);

	// Token: 0x04000417 RID: 1047
	public float alphaDecay;

	// Token: 0x04000418 RID: 1048
	public float scaleDecay;

	// Token: 0x04000419 RID: 1049
	public float gf = 0.15f;

	// Token: 0x0400041A RID: 1050
	protected float angularVelocity;

	// Token: 0x0400041B RID: 1051
	protected Vector2 velocity;

	// Token: 0x0400041C RID: 1052
	public int damage;

	// Token: 0x0400041D RID: 1053
	public int team;
}
