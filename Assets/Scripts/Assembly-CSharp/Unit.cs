using System;
using UnityEngine;

// Token: 0x020000FF RID: 255
public class Unit : MonoBehaviour
{
	// Token: 0x17000068 RID: 104
	// (get) Token: 0x060006D4 RID: 1748 RVA: 0x00021950 File Offset: 0x0001FB50
	// (set) Token: 0x060006D5 RID: 1749 RVA: 0x00021958 File Offset: 0x0001FB58
	public float MaxHealth
	{
		get
		{
			return this.maxHealth;
		}
		set
		{
			this.maxHealth = value;
		}
	}

	// Token: 0x17000069 RID: 105
	// (get) Token: 0x060006D6 RID: 1750 RVA: 0x00021964 File Offset: 0x0001FB64
	// (set) Token: 0x060006D7 RID: 1751 RVA: 0x0002196C File Offset: 0x0001FB6C
	public int Id
	{
		get
		{
			return this.id;
		}
		set
		{
			this.id = value;
		}
	}

	// Token: 0x1700006A RID: 106
	// (get) Token: 0x060006D8 RID: 1752 RVA: 0x00021978 File Offset: 0x0001FB78
	// (set) Token: 0x060006D9 RID: 1753 RVA: 0x00021980 File Offset: 0x0001FB80
	public GameObject Aura
	{
		get
		{
			return this.aura;
		}
		set
		{
			this.aura = value;
		}
	}

	// Token: 0x060006DA RID: 1754 RVA: 0x0002198C File Offset: 0x0001FB8C
	private void Start()
	{
		this.maxHealth = this.health;
		this.mreward = Mathf.RoundToInt((float)this.cost * 1.3f);
		if (this.team == Unit.T_BAD)
		{
			this.direction = -1;
			base.transform.localScale = new Vector3(-1f * base.transform.localScale.x, 1f * base.transform.localScale.y, 1f * base.transform.localScale.z);
		}
		Animator componentInChildren = base.GetComponentInChildren<Animator>();
		this.aura = UnityEngine.Object.Instantiate<GameObject>(PrefabCache.Aura);
		this.aura.transform.parent = base.gameObject.transform;
		this.aura.transform.localPosition = new Vector3(base.GetComponent<Collider2D>().bounds.center.x - base.transform.position.x, base.GetComponent<Collider2D>().bounds.min.y - base.transform.position.y, 0f);
		if (this.team == Unit.T_BAD)
		{
			this.aura.transform.localPosition = new Vector3(-this.aura.transform.localPosition.x, this.aura.transform.localPosition.y, this.aura.transform.localPosition.z);
		}
		this.aura.SetActive(false);
		float num = 1f;
		if (this.team == 1)
		{
			if (Game.difficulty == Game.D_HARDER)
			{
				num = 1.3f;
			}
			else if (Game.difficulty == Game.D_IMPOSSIBLE)
			{
				num = 2f;
			}
		}
		this.health *= num;
		this.MaxHealth *= num;
		this.weaponDamage *= num;
		this.rangedWeaponDamage *= num;
		this.SetSpecialHeal(false);
	}

	// Token: 0x060006DB RID: 1755 RVA: 0x00021BE0 File Offset: 0x0001FDE0
	public bool isAlive()
	{
		return this.health > 0f;
	}

	// Token: 0x060006DC RID: 1756 RVA: 0x00021BF0 File Offset: 0x0001FDF0
	public virtual void damage(float amount)
	{
		if (this.health <= 0f)
		{
			return;
		}
		this.health -= amount + UnityEngine.Random.value * 2f;
		if (this.hitClip != null)
		{
			AudioSource.PlayClipAtPoint(this.hitClip, Camera.main.transform.position, Game.EFFECT_VOLUME);
		}
		if (!(this is Base))
		{
			for (int i = 0; i < 5; i++)
			{
				UnityEngine.Object.Instantiate(PrefabCache.particles[2], base.GetComponent<Collider2D>().bounds.center, Quaternion.identity);
			}
			if (this.health <= 0f)
			{
				AudioSource.PlayClipAtPoint(PrefabCache.deathClips[UnityEngine.Random.Range(0, PrefabCache.deathClips.Length)], Camera.main.transform.position, Game.EFFECT_VOLUME);
				for (int j = 0; j < 5; j++)
				{
					UnityEngine.Object.Instantiate(PrefabCache.particles[2], base.GetComponent<Collider2D>().bounds.center, Quaternion.identity);
				}
				Game.units.Remove(this);
				this.aura.SetActive(false);
				base.GetComponentInChildren<Animator>().Play("Die");
				UnityEngine.Object.Destroy(base.gameObject, 5f);
				base.gameObject.GetComponent<Collider2D>().enabled = false;
				UnityEngine.Object.Destroy(base.gameObject.GetComponent<Rigidbody2D>());
				if (this.team == Unit.T_BAD)
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(PrefabCache.Coin);
					gameObject.transform.position = new Vector3(base.GetComponent<Collider2D>().bounds.center.x, base.GetComponent<Collider2D>().GetComponentInChildren<Collider2D>().bounds.min.y, 0f);
					TextMesh[] componentsInChildren = gameObject.GetComponentsInChildren<TextMesh>();
					foreach (TextMesh textMesh in componentsInChildren)
					{
						textMesh.text = "+" + this.mreward;
						MonoBehaviour.print(textMesh);
					}
					Game.instance.Coins += this.mreward;
					Game.instance.Exp += 2 * this.mreward;
					Game.instance.Exp = Mathf.Min(Game.instance.Exp, 999999);
				}
				else
				{
					Game.instance.numFriendlyUnits--;
					Game.instance.E_coins += this.mreward;
					Game.instance.Exp += (int)Mathf.Round((float)(this.mreward / 2));
					Game.instance.Exp = Mathf.Min(Game.instance.Exp, 999999);
				}
			}
		}
	}

	// Token: 0x060006DD RID: 1757 RVA: 0x00021EE4 File Offset: 0x000200E4
	protected Unit getClosestEnemy()
	{
		float num = float.MaxValue;
		Unit result = null;
		foreach (object obj in Game.units)
		{
			Unit unit = (Unit)obj;
			if (unit.team != this.team)
			{
				float num2 = Mathf.Abs(unit.transform.position.x - base.transform.position.x);
				if (num2 < num)
				{
					result = unit;
					num = num2;
				}
			}
		}
		return result;
	}

	// Token: 0x060006DE RID: 1758 RVA: 0x00021FA8 File Offset: 0x000201A8
	protected Unit getClosestFriend()
	{
		float num = float.MaxValue;
		Unit result = null;
		foreach (object obj in Game.units)
		{
			Unit unit = (Unit)obj;
			if (unit.team == this.team && unit.id < this.id && !(unit is Base))
			{
				float num2 = Mathf.Abs(unit.transform.position.x - base.transform.position.x);
				if (num2 < num)
				{
					result = unit;
					num = num2;
				}
			}
		}
		return result;
	}

	// Token: 0x060006DF RID: 1759 RVA: 0x00022088 File Offset: 0x00020288
	public void attack()
	{
		Unit closestEnemy = this.getClosestEnemy();
		float num = Mathf.Min(Mathf.Abs(closestEnemy.GetComponent<Collider2D>().bounds.max.x - base.GetComponent<Collider2D>().bounds.center.x), Mathf.Abs(closestEnemy.GetComponent<Collider2D>().bounds.min.x - base.GetComponent<Collider2D>().bounds.center.x));
		if (num < this.weaponRange * Game.P2U || (closestEnemy is Base && num < 2f * this.weaponRange * Game.P2U))
		{
			closestEnemy.damage(this.weaponDamage);
			this.updateEnemyDeathAchievements(closestEnemy);
		}
	}

	// Token: 0x060006E0 RID: 1760 RVA: 0x00022168 File Offset: 0x00020368
	public void rangedAttack()
	{
		Unit closestEnemy = this.getClosestEnemy();
		float num = Mathf.Min(Mathf.Abs(closestEnemy.GetComponent<Collider2D>().bounds.max.x - base.GetComponent<Collider2D>().bounds.center.x), Mathf.Abs(closestEnemy.GetComponent<Collider2D>().bounds.min.x - base.GetComponent<Collider2D>().bounds.center.x));
		if (num < this.rangedWeaponRange * Game.P2U || (closestEnemy is Base && num < 2f * this.rangedWeaponRange * Game.P2U))
		{
			closestEnemy.damage(this.rangedWeaponDamage);
			this.updateEnemyDeathAchievements(closestEnemy);
		}
	}

	// Token: 0x060006E1 RID: 1761 RVA: 0x00022248 File Offset: 0x00020448
	private void updateEnemyDeathAchievements(Unit enemy)
	{
		if (!enemy.isAlive())
		{
			if (this.typeId != 0 || enemy.typeId != 5)
			{
				if (this.typeId == 15 && enemy.typeId == 0 && !(enemy is Base))
				{
					MonoBehaviour.print(enemy);
					GameState.unlockAchievement(GameState.A_SUPER_KILL_CAVEMAN);
				}
			}
		}
	}

	// Token: 0x060006E2 RID: 1762 RVA: 0x000222B0 File Offset: 0x000204B0
	public void SetSpecialHeal(bool value)
	{
		this.isSpecialHealing = value;
		if (this.aura != null)
		{
			this.aura.SetActive(value);
		}
	}

	// Token: 0x060006E3 RID: 1763 RVA: 0x000222E4 File Offset: 0x000204E4
	private void FixedUpdate()
	{
		if (Game.instance.IsPaused)
		{
			base.GetComponentInChildren<Animator>().speed = 0f;
			return;
		}
		base.GetComponentInChildren<Animator>().speed = 1f;
		if (this.isAlive())
		{
			if (this.isSpecialHealing)
			{
				this.health += 1f;
				if (this.health > this.MaxHealth)
				{
					this.health = this.MaxHealth;
				}
			}
			Unit closestEnemy = this.getClosestEnemy();
			Unit closestFriend = this.getClosestFriend();
			float num = Mathf.Min(Mathf.Abs(closestEnemy.GetComponent<Collider2D>().bounds.center.x - base.GetComponent<Collider2D>().bounds.center.x), Mathf.Abs(closestEnemy.GetComponent<Collider2D>().bounds.center.x - base.GetComponent<Collider2D>().bounds.center.x));
			if (closestEnemy is Base)
			{
				num = Mathf.Min(Mathf.Abs(closestEnemy.GetComponent<Collider2D>().bounds.max.x - base.GetComponent<Collider2D>().bounds.center.x), Mathf.Abs(closestEnemy.GetComponent<Collider2D>().bounds.min.x - base.GetComponent<Collider2D>().bounds.center.x));
			}
			bool flag = true;
			bool flag2;
			bool flag3;
			if (num < this.weaponRange * Game.P2U)
			{
				flag2 = true;
				flag3 = false;
				flag = false;
			}
			else if (num < this.rangedWeaponRange * Game.P2U)
			{
				flag2 = false;
				flag3 = true;
			}
			else
			{
				flag2 = false;
				flag3 = false;
			}
			if (closestFriend != null)
			{
				Bounds bounds = new Bounds(base.GetComponent<Collider2D>().bounds.center, base.GetComponent<Collider2D>().bounds.size + new Vector3(Game.P2U * 25f, 0f, 0f));
				if (closestFriend.GetComponent<Collider2D>().bounds.Intersects(bounds))
				{
					flag = false;
				}
			}
			float normalizedTime = base.GetComponentInChildren<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime;
			if (flag3)
			{
				string stateName = "Shoot";
				if (flag)
				{
					stateName = "WalkShoot";
				}
				base.GetComponentInChildren<Animator>().Play(stateName);
			}
			else if (flag2)
			{
				base.GetComponentInChildren<Animator>().Play("Attack", 0);
			}
			if (flag && !flag2)
			{
				base.transform.Translate(new Vector3((float)this.direction * this.speed * Game.P2U * Time.deltaTime * 40f, 0f));
				if (!flag3)
				{
					base.GetComponentInChildren<Animator>().Play("Walk", 0);
				}
			}
			else if (!flag2 && !flag3)
			{
				base.GetComponentInChildren<Animator>().Play("Idle", 0);
			}
		}
	}

	// Token: 0x04000475 RID: 1141
	public float health;

	// Token: 0x04000476 RID: 1142
	protected float maxHealth;

	// Token: 0x04000477 RID: 1143
	public float weaponDamage;

	// Token: 0x04000478 RID: 1144
	public float rangedWeaponDamage;

	// Token: 0x04000479 RID: 1145
	public float weaponRange;

	// Token: 0x0400047A RID: 1146
	public float rangedWeaponRange;

	// Token: 0x0400047B RID: 1147
	public float attackTime;

	// Token: 0x0400047C RID: 1148
	public float rangedAttackTime;

	// Token: 0x0400047D RID: 1149
	public int cost;

	// Token: 0x0400047E RID: 1150
	public int reward;

	// Token: 0x0400047F RID: 1151
	public int buildTime;

	// Token: 0x04000480 RID: 1152
	public AudioClip shootClip;

	// Token: 0x04000481 RID: 1153
	public AudioClip attackClip;

	// Token: 0x04000482 RID: 1154
	public AudioClip dieClip;

	// Token: 0x04000483 RID: 1155
	public AudioClip extraClip1;

	// Token: 0x04000484 RID: 1156
	public AudioClip extraClip2;

	// Token: 0x04000485 RID: 1157
	public AudioClip hitClip;

	// Token: 0x04000486 RID: 1158
	protected int mreward;

	// Token: 0x04000487 RID: 1159
	public int team;

	// Token: 0x04000488 RID: 1160
	protected int id;

	// Token: 0x04000489 RID: 1161
	protected float speed = 0.7f;

	// Token: 0x0400048A RID: 1162
	public static int T_GOOD;

	// Token: 0x0400048B RID: 1163
	public static int T_BAD = 1;

	// Token: 0x0400048C RID: 1164
	protected int direction = 1;

	// Token: 0x0400048D RID: 1165
	protected bool hasAttacked;

	// Token: 0x0400048E RID: 1166
	protected float attackStartTime;

	// Token: 0x0400048F RID: 1167
	protected GameObject unitInFront;

	// Token: 0x04000490 RID: 1168
	protected GameObject aura;

	// Token: 0x04000491 RID: 1169
	public bool canShootAndWalk;

	// Token: 0x04000492 RID: 1170
	public int typeId;

	// Token: 0x04000493 RID: 1171
	protected bool isSpecialHealing;
}
