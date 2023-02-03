using System;
using UnityEngine;

// Token: 0x020000DD RID: 221
public class CaesarAi : EnemyAi
{
	// Token: 0x06000631 RID: 1585 RVA: 0x000160A0 File Offset: 0x000142A0
	public CaesarAi(Game game)
	{
		this.game = game;
	}

	// Token: 0x06000632 RID: 1586 RVA: 0x000160B0 File Offset: 0x000142B0
	public override void init()
	{
		this.specialTimer = 0;
		base.init();
	}

	// Token: 0x06000633 RID: 1587 RVA: 0x000160C0 File Offset: 0x000142C0
	public override void update()
	{
		this.tech_timer += 1f;
		if (this.game.baseEnemy.health > 0f)
		{
			this.game.baseEnemy.health += 0.01f;
		}
		this.specialTimer++;
		if (this.specialTimer > 7500 && this.techLevel > 2)
		{
			this.game.baseEnemy.special();
			this.specialTimer = 0;
		}
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
			int num2 = Mathf.FloorToInt(3f * UnityEngine.Random.value * (float)this.unit_level + 1f);
			if (num2 > 3)
			{
				num2 = 3;
			}
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
				Game.instance.baseEnemy.setUpTurret(1, 2);
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
				Game.instance.baseEnemy.setUpTurret(1, 13);
				this.turret_level++;
			}
			else if (this.tech_timer == 20000f)
			{
				Game.instance.baseEnemy.destroyTurret(0);
				Game.instance.baseEnemy.destroyTurret(1);
				Game.instance.baseEnemy.setUpTurret(2, 14);
				this.turret_level++;
			}
		}
	}

	// Token: 0x06000634 RID: 1588 RVA: 0x000167C4 File Offset: 0x000149C4
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

	// Token: 0x04000333 RID: 819
	private int specialTimer;
}
