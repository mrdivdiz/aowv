using System;
using UnityEngine;

// Token: 0x020000FD RID: 253
public class Turret : MonoBehaviour
{
	// Token: 0x17000067 RID: 103
	// (get) Token: 0x060006C4 RID: 1732 RVA: 0x00020B70 File Offset: 0x0001ED70
	// (set) Token: 0x060006C5 RID: 1733 RVA: 0x00020B78 File Offset: 0x0001ED78
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

	// Token: 0x060006C6 RID: 1734 RVA: 0x00020B84 File Offset: 0x0001ED84
	private void Start()
	{
		base.gameObject.GetComponentInChildren<Animator>().speed = 0f;
	}

	// Token: 0x060006C7 RID: 1735 RVA: 0x00020B9C File Offset: 0x0001ED9C
	public void setUpTurret(int id)
	{
		base.gameObject.SetActive(true);
		this.range = (float)Game.instance.turrets[id].range;
		this.shot_speed = (float)Game.instance.turrets[id].shotSpeed;
		this.damage = Game.instance.turrets[id].damage;
		this.bulletId = Game.instance.turrets[id].bulletId;
		base.gameObject.GetComponentInChildren<Animator>().speed = 0f;
		this.id = id;
		this.turretAnimation = "Turret" + (id + 1);
		base.gameObject.GetComponentInChildren<Animator>().Play(this.turretAnimation, 0, 1f);
	}

	// Token: 0x060006C8 RID: 1736 RVA: 0x00020C74 File Offset: 0x0001EE74
	private void Awake()
	{
	}

	// Token: 0x060006C9 RID: 1737 RVA: 0x00020C78 File Offset: 0x0001EE78
	public void shoot()
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(Game.instance.bullets[this.bulletId]);
		Bullet component = gameObject.GetComponent<Bullet>();
		component.damage = this.damage;
		component.team = base.transform.parent.GetComponent<Base>().team;
		if (base.transform.parent.GetComponent<Base>().team == 1)
		{
			component.transform.localEulerAngles = new Vector3(0f, 0f, 180f - base.transform.localEulerAngles.z);
		}
		else
		{
			component.transform.localEulerAngles = new Vector3(0f, 0f, base.transform.localEulerAngles.z);
		}
		component.transform.position = base.transform.position;
		component.init();
	}

	// Token: 0x060006CA RID: 1738 RVA: 0x00020D68 File Offset: 0x0001EF68
	private void FixedUpdate()
	{
		this.c += Time.deltaTime;
		if (this.c >= 0.25f)
		{
			this.ed = 100000f;
			foreach (object obj in Game.units)
			{
				Unit unit = (Unit)obj;
				if (unit.team != base.transform.parent.GetComponent<Base>().team && unit.isAlive())
				{
					float magnitude = (unit.transform.position - base.transform.position).magnitude;
					if (magnitude < this.ed)
					{
						this.ed = magnitude;
						this.ed_h = unit.GetComponent<Collider2D>().bounds.center.y;
						this.enemy = unit;
					}
				}
			}
			this.c = 0f;
		}
		bool flag = false;
		if (this.ed < this.range * Game.P2U)
		{
			if (this.enemy && this.enemy.isAlive() && this.id != 5)
			{
				Vector3 center = this.enemy.GetComponent<Collider2D>().bounds.center;
				center.y = this.enemy.GetComponent<Collider2D>().bounds.max.y;
				Vector2 vector = center - base.transform.position;
				float num = Mathf.Atan2(vector.y, vector.x);
				if (base.transform.parent.GetComponent<Base>().team == 1)
				{
					num = -num + 3.1415927f;
				}
				base.transform.localEulerAngles = new Vector3(0f, 0f, num * 180f / 3.1415927f);
			}
			if ((float)this.st >= this.shot_speed && base.gameObject.GetComponentInChildren<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime >= 1f)
			{
				base.gameObject.GetComponentInChildren<Animator>().Play(this.turretAnimation, 0, 0f);
				base.gameObject.GetComponentInChildren<Animator>().speed = 1f;
				this.st = 0;
			}
			if (base.gameObject.GetComponentInChildren<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime < 1f)
			{
				base.gameObject.GetComponentInChildren<Animator>().speed = 1f;
			}
			else
			{
				base.gameObject.GetComponentInChildren<Animator>().speed = 0f;
			}
		}
		else if (base.gameObject.GetComponentInChildren<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime >= 1f || base.gameObject.GetComponentInChildren<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime == 0f)
		{
			if (this.id == 14)
			{
				base.gameObject.GetComponentInChildren<Animator>().Play(this.turretAnimation + "stop", 0, 0f);
				base.gameObject.GetComponentInChildren<Animator>().speed = 1f;
				flag = true;
			}
			else if (this.id == 13)
			{
				base.gameObject.GetComponentInChildren<Animator>().Play(this.turretAnimation + "stop", 0, 0f);
				base.gameObject.GetComponentInChildren<Animator>().speed = 1f;
				flag = true;
			}
		}
		this.st++;
		if (((float)this.st >= this.shot_speed || this.st == 0) && base.gameObject.GetComponentInChildren<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime >= 1f && !flag)
		{
			base.gameObject.GetComponentInChildren<Animator>().Play(this.turretAnimation, 0, 1f);
			base.gameObject.GetComponentInChildren<Animator>().speed = 0f;
		}
	}

	// Token: 0x0400045E RID: 1118
	public Animator[] turretData;

	// Token: 0x0400045F RID: 1119
	private float range;

	// Token: 0x04000460 RID: 1120
	private float shot_speed;

	// Token: 0x04000461 RID: 1121
	private int damage;

	// Token: 0x04000462 RID: 1122
	private int st;

	// Token: 0x04000463 RID: 1123
	private float c;

	// Token: 0x04000464 RID: 1124
	private float ed = 10000f;

	// Token: 0x04000465 RID: 1125
	private float ed_h;

	// Token: 0x04000466 RID: 1126
	private Unit enemy;

	// Token: 0x04000467 RID: 1127
	private int bulletId;

	// Token: 0x04000468 RID: 1128
	private string turretAnimation = "Turret1";

	// Token: 0x04000469 RID: 1129
	private int id;
}
