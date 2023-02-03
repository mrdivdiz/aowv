using System;
using UnityEngine;

// Token: 0x020000DF RID: 223
public class EnemyAi
{
	// Token: 0x06000639 RID: 1593 RVA: 0x00016FE4 File Offset: 0x000151E4
	public EnemyAi(Game game)
	{
		this.game = game;
	}

	// Token: 0x0600063A RID: 1594 RVA: 0x00017030 File Offset: 0x00015230
	public EnemyAi()
	{
	}

	// Token: 0x0600063B RID: 1595 RVA: 0x00017068 File Offset: 0x00015268
	public virtual void init()
	{
		this.timer = 0f;
		this.u_timer = -1f;
		this.turn_time = 0f;
		this.uf = 0.3f;
		this.step_time = 40f;
		this.check_action = false;
		this.uof = 0f;
		this.tech_timer = 0f;
		this.unit_level = 1;
		this.turret_level = 0;
		this.techLevel = 1;
		this.will_create_unit = 0;
	}

	// Token: 0x0600063C RID: 1596 RVA: 0x000170E8 File Offset: 0x000152E8
	public virtual void update()
	{
		this.tech_timer += 1f;
		if (this.unit_level == 1)
		{
			if (this.tech_timer >= 1500f)
			{
				this.unit_level = 2;
			}
		}
		else if (this.unit_level == 2 && this.tech_timer >= 5000f)
		{
			this.unit_level = 3;
		}
		if (this.tech_timer == 8000f && this.techLevel != 5)
		{
			this.techLevel++;
			Game.instance.baseEnemy.health += (float)(300 * this.techLevel);
			Game.instance.baseEnemy.MaxHealth += (float)(300 * this.techLevel);
			Game.instance.baseEnemy.baseObject.GetComponent<SpriteRenderer>().sprite = Game.instance.baseEnemy.baseAgeSprites[this.techLevel - 1];
			Game.instance.baseEnemy.extend1.GetComponent<SpriteRenderer>().sprite = Game.instance.baseEnemy.extenders1[this.techLevel - 1];
			Game.instance.baseEnemy.extend2.GetComponent<SpriteRenderer>().sprite = Game.instance.baseEnemy.extenders2[this.techLevel - 1];
			Game.instance.baseEnemy.extend3.GetComponent<SpriteRenderer>().sprite = Game.instance.baseEnemy.extenders3[this.techLevel - 1];
			this.unit_level = 1;
			this.tech_timer = 0f;
		}
		int num = 0;
		this.timer += 1f;
		if (this.timer > this.step_time)
		{
			float value = UnityEngine.Random.value;
			if (value < this.uf)
			{
				num = 1;
			}
			else
			{
				num = 3;
			}
			this.timer = 0f;
			this.check_action = true;
		}
		if (this.check_action && num == 1 && this.u_timer < -5f && this.getUOF() < 6)
		{
			int num2 = Mathf.FloorToInt(UnityEngine.Random.value * (float)this.unit_level + 1f);
			num2 += (this.techLevel - 1) * 3;
			this.will_create_unit = num2 - 1;
			this.u_timer = (float)Game.prefabFromType(this.will_create_unit).GetComponent<Unit>().buildTime;
			this.check_action = false;
		}
		if (this.u_timer == 0f)
		{
			Game.instance.spawnUnit(this.will_create_unit, Unit.T_BAD);
		}
		this.u_timer -= 1f;
		if (this.techLevel == 1)
		{
			if (this.tech_timer == 1000f)
			{
				Game.instance.baseEnemy.setUpTurret(0, 0);
				this.turret_level++;
			}
			else if (this.tech_timer == 4000f)
			{
				Game.instance.baseEnemy.destroyTurret(0);
				Game.instance.baseEnemy.setUpTurret(0, 1);
				this.turret_level++;
			}
			else if (this.tech_timer == 6000f)
			{
				Game.instance.baseEnemy.destroyTurret(0);
				Game.instance.baseEnemy.setUpTurret(0, 2);
			}
		}
		if (this.techLevel == 2)
		{
			if (this.tech_timer == 1000f)
			{
				Game.instance.baseEnemy.destroyTurret(0);
				Game.instance.baseEnemy.setUpTurret(0, 3);
				this.turret_level++;
			}
			else if (this.tech_timer == 4000f)
			{
				Game.instance.baseEnemy.addExpansion();
				Game.instance.baseEnemy.destroyTurret(0);
				Game.instance.baseEnemy.setUpTurret(0, 5);
				this.turret_level++;
			}
			else if (this.tech_timer == 6000f)
			{
				Game.instance.baseEnemy.setUpTurret(1, 4);
			}
		}
		if (this.techLevel == 3)
		{
			if (this.tech_timer == 1000f)
			{
				Game.instance.baseEnemy.destroyTurret(0);
				Game.instance.baseEnemy.setUpTurret(0, 6);
				this.turret_level++;
			}
			else if (this.tech_timer == 4000f)
			{
				Game.instance.baseEnemy.addExpansion();
				Game.instance.baseEnemy.destroyTurret(1);
				Game.instance.baseEnemy.setUpTurret(1, 6);
				this.turret_level++;
			}
			else if (this.tech_timer == 6000f)
			{
				Game.instance.baseEnemy.destroyTurret(0);
				Game.instance.baseEnemy.destroyTurret(1);
				Game.instance.baseEnemy.setUpTurret(2, 8);
			}
		}
		if (this.techLevel == 4)
		{
			if (this.tech_timer == 5000f)
			{
				Game.instance.baseEnemy.setUpTurret(0, 9);
				this.turret_level++;
			}
			else if (this.tech_timer == 7000f)
			{
				Game.instance.baseEnemy.addExpansion();
				Game.instance.baseEnemy.destroyTurret(0);
				Game.instance.baseEnemy.destroyTurret(2);
				Game.instance.baseEnemy.setUpTurret(1, 10);
				this.turret_level++;
			}
		}
		if (this.techLevel == 5)
		{
			if (this.tech_timer == 5000f)
			{
				Game.instance.baseEnemy.setUpTurret(0, 12);
				this.turret_level++;
			}
			else if (this.tech_timer == 12000f)
			{
				Game.instance.baseEnemy.destroyTurret(0);
				Game.instance.baseEnemy.destroyTurret(1);
				Game.instance.baseEnemy.destroyTurret(2);
				Game.instance.baseEnemy.setUpTurret(1, 13);
				this.turret_level++;
			}
			else if (this.tech_timer == 20000f)
			{
				Game.instance.baseEnemy.destroyTurret(0);
				Game.instance.baseEnemy.destroyTurret(1);
				Game.instance.baseEnemy.destroyTurret(2);
				Game.instance.baseEnemy.setUpTurret(2, 14);
				this.turret_level++;
			}
		}
	}

	// Token: 0x0600063D RID: 1597 RVA: 0x000177A4 File Offset: 0x000159A4
	private int getUOF()
	{
		int num = 0;
		foreach (object obj in Game.units)
		{
			Unit unit = (Unit)obj;
			if (unit.team == Unit.T_BAD)
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x04000335 RID: 821
	public Game game;

	// Token: 0x04000336 RID: 822
	protected float timer;

	// Token: 0x04000337 RID: 823
	protected float u_timer = -1f;

	// Token: 0x04000338 RID: 824
	protected float turn_time;

	// Token: 0x04000339 RID: 825
	protected float uf = 0.3f;

	// Token: 0x0400033A RID: 826
	protected float step_time = 40f;

	// Token: 0x0400033B RID: 827
	protected bool check_action;

	// Token: 0x0400033C RID: 828
	protected float uof;

	// Token: 0x0400033D RID: 829
	protected float tech_timer;

	// Token: 0x0400033E RID: 830
	protected int unit_level = 1;

	// Token: 0x0400033F RID: 831
	protected int turret_level;

	// Token: 0x04000340 RID: 832
	public int techLevel = 1;

	// Token: 0x04000341 RID: 833
	protected int will_create_unit;
}
