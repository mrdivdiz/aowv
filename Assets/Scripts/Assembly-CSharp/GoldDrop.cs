using System;
using UnityEngine;

// Token: 0x02000006 RID: 6
public class GoldDrop : MonoBehaviour
{
	// Token: 0x06000011 RID: 17 RVA: 0x0000227C File Offset: 0x0000047C
	private void Start()
	{
		float num = 4f;
		float num2 = (Game.instance.baseEnemy.transform.position.x + Game.instance.baseFriendly.transform.position.x) / 2f;
		base.transform.position = new Vector3(num2 + num * UnityEngine.Random.value - num / 2f, base.transform.position.y);
		this.value = this.ageValues[Game.instance.age];
	}

	// Token: 0x06000012 RID: 18 RVA: 0x0000231C File Offset: 0x0000051C
	private void FixedUpdate()
	{
		if (Game.instance.IsPaused)
		{
			return;
		}
		Vector3 position = base.transform.position;
		position.y += this.dy * Time.deltaTime;
		this.dy += -14.1f * Time.deltaTime;
		if (position.y < Game.GROUND_LEVEL)
		{
			this.dy *= -0.35f;
			if (Mathf.Abs(this.dy) < 0.5f)
			{
				position.y = Game.GROUND_LEVEL;
				this.dy = 0f;
			}
			else
			{
				position.y = Game.GROUND_LEVEL + Mathf.Abs(Game.GROUND_LEVEL - position.y);
			}
		}
		base.transform.position = position;
		Unit unitHit = this.getUnitHit();
		if (this.dy == 0f && position.y == Game.GROUND_LEVEL && unitHit)
		{
			if (unitHit.team == 0)
			{
				AudioSource.PlayClipAtPoint(base.GetComponentInChildren<AudioSource>().clip, Vector3.zero, 0.8f);
				Game.instance.Coins += this.value;
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(PrefabCache.Coin);
				gameObject.transform.position = new Vector3(unitHit.GetComponent<Collider2D>().bounds.center.x, unitHit.GetComponent<Collider2D>().GetComponentInChildren<Collider2D>().bounds.max.y, 0f);
				TextMesh[] componentsInChildren = gameObject.GetComponentsInChildren<TextMesh>();
				foreach (TextMesh textMesh in componentsInChildren)
				{
					textMesh.text = "+" + this.value;
					MonoBehaviour.print(textMesh);
				}
			}
			UnityEngine.Object.DestroyImmediate(base.gameObject);
		}
	}

	// Token: 0x06000013 RID: 19 RVA: 0x0000251C File Offset: 0x0000071C
	public Unit getUnitHit()
	{
		foreach (object obj in Game.units)
		{
			Unit unit = (Unit)obj;
			if (unit.GetComponent<Collider2D>().bounds.Intersects(base.GetComponent<Collider2D>().bounds) && !(unit is Base))
			{
				return unit;
			}
		}
		return null;
	}

	// Token: 0x04000010 RID: 16
	public int value;

	// Token: 0x04000011 RID: 17
	public int[] ageValues;

	// Token: 0x04000012 RID: 18
	private float dy;
}
