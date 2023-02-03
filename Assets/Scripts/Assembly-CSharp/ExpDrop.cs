using System;
using UnityEngine;

// Token: 0x020000D4 RID: 212
public class ExpDrop : MonoBehaviour
{
	// Token: 0x060005F5 RID: 1525 RVA: 0x0001247C File Offset: 0x0001067C
	private void Start()
	{
		float num = 4f;
		float num2 = (Game.instance.baseEnemy.transform.position.x + Game.instance.baseFriendly.transform.position.x) / 2f;
		base.transform.position = new Vector3(num2 + num * UnityEngine.Random.value - num / 2f, base.transform.position.y);
		this.value = this.ageValues[Game.instance.age];
	}

	// Token: 0x060005F6 RID: 1526 RVA: 0x0001251C File Offset: 0x0001071C
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
				Game.instance.Exp += this.value;
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(PrefabCache.Exp);
				gameObject.transform.position = new Vector3(unitHit.GetComponent<Collider2D>().bounds.center.x, unitHit.GetComponent<Collider2D>().GetComponentInChildren<Collider2D>().bounds.max.y, 0f);
				TextMesh[] componentsInChildren = gameObject.GetComponentsInChildren<TextMesh>();
				foreach (TextMesh textMesh in componentsInChildren)
				{
					textMesh.text = "+" + this.value + " EXP";
					MonoBehaviour.print(textMesh);
				}
			}
			UnityEngine.Object.DestroyImmediate(base.gameObject);
		}
	}

	// Token: 0x060005F7 RID: 1527 RVA: 0x00012724 File Offset: 0x00010924
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

	// Token: 0x040002A1 RID: 673
	public int value;

	// Token: 0x040002A2 RID: 674
	public int[] ageValues;

	// Token: 0x040002A3 RID: 675
	private float dy;
}
