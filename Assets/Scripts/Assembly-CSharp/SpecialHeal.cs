using System;
using UnityEngine;

// Token: 0x020000FA RID: 250
public class SpecialHeal : MonoBehaviour
{
	// Token: 0x060006BB RID: 1723 RVA: 0x0002097C File Offset: 0x0001EB7C
	private void Start()
	{
	}

	// Token: 0x060006BC RID: 1724 RVA: 0x00020980 File Offset: 0x0001EB80
	private void FixedUpdate()
	{
		if (Game.instance.IsPaused)
		{
			return;
		}
		this.cc--;
		if (this.cc == 0)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			this.cc = 0;
			foreach (object obj in Game.units)
			{
				Unit unit = (Unit)obj;
				if (unit.team == this.team && !(unit is Base))
				{
					unit.SetSpecialHeal(false);
				}
			}
		}
		else if (this.cc < 590)
		{
			foreach (object obj2 in Game.units)
			{
				Unit unit2 = (Unit)obj2;
				if (unit2.team == this.team && !(unit2 is Base))
				{
					unit2.SetSpecialHeal(true);
				}
			}
		}
	}

	// Token: 0x0400045A RID: 1114
	private float spawnTime;

	// Token: 0x0400045B RID: 1115
	private int cc = 600;

	// Token: 0x0400045C RID: 1116
	public int team;
}
