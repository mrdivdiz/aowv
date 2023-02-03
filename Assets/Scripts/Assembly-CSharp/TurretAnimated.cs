using System;
using UnityEngine;

// Token: 0x020000FE RID: 254
public class TurretAnimated : MonoBehaviour
{
	// Token: 0x060006CC RID: 1740 RVA: 0x000211EC File Offset: 0x0001F3EC
	private void Start()
	{
		base.gameObject.GetComponentInChildren<Animator>().speed = 0f;
	}

	// Token: 0x060006CD RID: 1741 RVA: 0x00021204 File Offset: 0x0001F404
	public void setUpTurret(int id)
	{
		base.gameObject.SetActive(true);
		this.range = (float)Game.instance.turrets[id].range;
		this.shot_speed = (float)Game.instance.turrets[id].shotSpeed;
		this.damage = Game.instance.turrets[id].damage;
		this.bulletId = Game.instance.turrets[id].bulletId;
		base.gameObject.GetComponentInChildren<Animator>().speed = 0f;
		this.id = id;
		this.turretAnimation = "shoot";
		if (base.transform.parent.GetComponent<Base>().team == 1)
		{
			base.gameObject.transform.localScale = new Vector3(base.gameObject.transform.localScale.x * -1f, base.gameObject.transform.localScale.y, base.gameObject.transform.localScale.z);
			base.gameObject.GetComponentInChildren<Animator>().Play(this.turretAnimation, 0, 1f);
		}
	}

	// Token: 0x060006CE RID: 1742 RVA: 0x0002134C File Offset: 0x0001F54C
	private void Awake()
	{
	}

	// Token: 0x060006CF RID: 1743 RVA: 0x00021350 File Offset: 0x0001F550
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

	// Token: 0x060006D0 RID: 1744 RVA: 0x00021440 File Offset: 0x0001F640
	private void FixedUpdate()
	{
		if (Game.instance.IsPaused || Game.instance.isGameOver)
		{
			return;
		}
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
				base.gameObject.GetComponentInChildren<Animator>().Play("idle", 0, 0f);
				base.gameObject.GetComponentInChildren<Animator>().speed = 1f;
				flag = true;
			}
			else if (this.id == 13)
			{
				base.gameObject.GetComponentInChildren<Animator>().Play("idle", 0, 0f);
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

	// Token: 0x060006D1 RID: 1745 RVA: 0x000218AC File Offset: 0x0001FAAC
	public void playSound()
	{
		if (this.id == 1)
		{
			AudioSource.PlayClipAtPoint(Game.instance.turrets[this.id].clip, Camera.main.transform.position, 0.5f);
		}
		else
		{
			AudioSource.PlayClipAtPoint(Game.instance.turrets[this.id].clip, Camera.main.transform.position);
		}
	}

	// Token: 0x0400046A RID: 1130
	private float range;

	// Token: 0x0400046B RID: 1131
	private float shot_speed;

	// Token: 0x0400046C RID: 1132
	private int damage;

	// Token: 0x0400046D RID: 1133
	private int st;

	// Token: 0x0400046E RID: 1134
	private float c;

	// Token: 0x0400046F RID: 1135
	private float ed = 10000f;

	// Token: 0x04000470 RID: 1136
	private float ed_h;

	// Token: 0x04000471 RID: 1137
	private Unit enemy;

	// Token: 0x04000472 RID: 1138
	private int bulletId;

	// Token: 0x04000473 RID: 1139
	private string turretAnimation = "shoot";

	// Token: 0x04000474 RID: 1140
	public int id;
}
