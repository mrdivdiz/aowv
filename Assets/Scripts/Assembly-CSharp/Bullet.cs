using System;
using UnityEngine;

// Token: 0x020000C2 RID: 194
public class Bullet : MonoBehaviour
{
	// Token: 0x060005AA RID: 1450 RVA: 0x0000EECC File Offset: 0x0000D0CC
	public virtual void init()
	{
	}

	// Token: 0x060005AB RID: 1451 RVA: 0x0000EED0 File Offset: 0x0000D0D0
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

	// Token: 0x060005AC RID: 1452 RVA: 0x0000EF84 File Offset: 0x0000D184
	public bool isBeneathGround()
	{
		return base.transform.position.y < Game.GROUND_LEVEL;
	}

	// Token: 0x04000223 RID: 547
	public int team;

	// Token: 0x04000224 RID: 548
	public int damage;
}
