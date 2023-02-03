using System;
using UnityEngine;

// Token: 0x020000F2 RID: 242
public class OilPart : MonoBehaviour
{
	// Token: 0x0600069E RID: 1694 RVA: 0x0001EFB8 File Offset: 0x0001D1B8
	private void Start()
	{
		base.transform.position = base.transform.position + new Vector3(this.positionOffset.x + UnityEngine.Random.value * this.positionRandom.x, this.positionOffset.y + UnityEngine.Random.value * this.positionRandom.y, 0f) * Game.P2U;
		this.velocity = new Vector2(this.velocityOffset.x + UnityEngine.Random.value * this.velocityRandom.x, this.velocityOffset.y + UnityEngine.Random.value * this.velocityRandom.y) * Game.P2U;
		float num = UnityEngine.Random.value * this.scaleRandom;
		base.transform.localScale = new Vector3(this.scaleOffset + num, this.scaleOffset + num, this.scaleOffset + num) / 100f;
		this.angularVelocity = this.rotOffset + UnityEngine.Random.value * this.rotRandom;
		base.transform.localEulerAngles = new Vector3(0f, 0f, 90f + UnityEngine.Random.value * 60f - 30f);
		this.velocity = new Vector2(7f * Mathf.Cos(base.transform.localEulerAngles.z * 0.017453292f), 7f * Mathf.Sin(base.transform.localEulerAngles.z * 0.017453292f)) * Game.P2U;
		this.timeCreated = Time.time;
	}

	// Token: 0x0600069F RID: 1695 RVA: 0x0001F170 File Offset: 0x0001D370
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

	// Token: 0x060006A0 RID: 1696 RVA: 0x0001F224 File Offset: 0x0001D424
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
		this.cc++;
		if (this.cc == 2)
		{
			this.cc = 0;
		}
		base.transform.localScale = new Vector3(base.transform.localScale.x - this.scaleDecay / 100f, base.transform.localScale.x - this.scaleDecay / 100f, base.transform.localScale.x - this.scaleDecay / 100f);
		Unit unitHit = this.getUnitHit();
		if (unitHit != null && Time.time - this.timeCreated > 1f)
		{
			unitHit.damage((float)this.damage);
			Vector3 position = base.transform.position;
			GameObject obj = (GameObject)UnityEngine.Object.Instantiate(PrefabCache.particles[7], position, Quaternion.identity);
			UnityEngine.Object.Destroy(obj, 0.9f);
			UnityEngine.Object.Destroy(base.gameObject);
		}
		else if (base.transform.position.y < Game.GROUND_LEVEL || color.a < 0f || base.transform.localScale.x < 0f)
		{
			Vector3 position2 = base.transform.position;
			position2.y = Game.GROUND_LEVEL + 0.1f;
			UnityEngine.Object.Instantiate(PrefabCache.particles[6], position2, Quaternion.identity);
			GameObject obj2 = (GameObject)UnityEngine.Object.Instantiate(PrefabCache.particles[7], position2, Quaternion.identity);
			UnityEngine.Object.Destroy(obj2, 0.9f);
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x040003FC RID: 1020
	public float drag = 0.1f;

	// Token: 0x040003FD RID: 1021
	public float scaleOffset = 100f;

	// Token: 0x040003FE RID: 1022
	public float scaleRandom = 40f;

	// Token: 0x040003FF RID: 1023
	public float rotOffset = -1.5f;

	// Token: 0x04000400 RID: 1024
	public float rotRandom = 4f;

	// Token: 0x04000401 RID: 1025
	public Vector2 positionOffset = new Vector2(-4f, -4f);

	// Token: 0x04000402 RID: 1026
	public Vector2 positionRandom = new Vector2(9f, 9f);

	// Token: 0x04000403 RID: 1027
	public Vector2 velocityOffset = new Vector2(-3f, 1f);

	// Token: 0x04000404 RID: 1028
	public Vector2 velocityRandom = new Vector2(6f, 3f);

	// Token: 0x04000405 RID: 1029
	public float alphaDecay;

	// Token: 0x04000406 RID: 1030
	public float scaleDecay;

	// Token: 0x04000407 RID: 1031
	public float gf = 0.15f;

	// Token: 0x04000408 RID: 1032
	protected float angularVelocity;

	// Token: 0x04000409 RID: 1033
	protected Vector2 velocity;

	// Token: 0x0400040A RID: 1034
	public int damage;

	// Token: 0x0400040B RID: 1035
	public int team;

	// Token: 0x0400040C RID: 1036
	private int cc;

	// Token: 0x0400040D RID: 1037
	private float timeCreated;
}
