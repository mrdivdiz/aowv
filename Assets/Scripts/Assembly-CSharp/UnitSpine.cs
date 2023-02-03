using System;
using Spine;
using UnityEngine;

// Token: 0x02000100 RID: 256
public class UnitSpine : Unit
{
	// Token: 0x060006E5 RID: 1765 RVA: 0x0002268C File Offset: 0x0002088C
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
		base.MaxHealth *= num;
		this.weaponDamage *= num;
		this.rangedWeaponDamage *= num;
		this.skeletonAnimation = base.GetComponentInChildren<SkeletonAnimation>();
		this.skeletonAnimation.state.Event += this.Event;
	}

	// Token: 0x060006E6 RID: 1766 RVA: 0x00022900 File Offset: 0x00020B00
	public override void damage(float amount)
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
			if (this.aura != null)
			{
				this.aura.SetActive(false);
			}
			else
			{
				MonoBehaviour.print("NO AURA");
			}
			base.GetComponentInChildren<SkeletonAnimation>().state.SetAnimation(0, this.getDeathAnimationName(), false);
			UnityEngine.Object.Destroy(base.gameObject, 5f);
			base.gameObject.GetComponent<Collider2D>().enabled = false;
			UnityEngine.Object.Destroy(base.gameObject.GetComponent<Rigidbody2D>());
			if (this.team == Unit.T_BAD)
			{
				if (this.mreward > 0)
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(PrefabCache.Coin);
					gameObject.transform.position = new Vector3(base.GetComponent<Collider2D>().bounds.center.x, base.GetComponent<Collider2D>().bounds.min.y + 1.5f, 0f);
					TextMesh[] componentsInChildren = gameObject.GetComponentsInChildren<TextMesh>();
					foreach (TextMesh textMesh in componentsInChildren)
					{
						textMesh.text = "+" + this.mreward;
					}
					Game.instance.Coins += this.mreward;
					Game.instance.Exp += 2 * this.mreward;
					Game.instance.Exp = Mathf.Min(Game.instance.Exp, 999999);
				}
			}
			else
			{
				Game.instance.E_coins += this.mreward;
				Game.instance.Exp += (int)Mathf.Round((float)(this.mreward / 2));
				Game.instance.Exp = Mathf.Min(Game.instance.Exp, 999999);
			}
		}
	}

	// Token: 0x060006E7 RID: 1767 RVA: 0x00022C00 File Offset: 0x00020E00
	private void FixedUpdate()
	{
		if (Game.instance.IsPaused || Game.instance.isGameOver)
		{
			return;
		}
		if (base.isAlive())
		{
			if (this.isSpecialHealing)
			{
				this.health += 1f;
				if (this.health > base.MaxHealth)
				{
					this.health = base.MaxHealth;
				}
			}
			string text = string.Empty;
			TrackEntry current = this.skeletonAnimation.state.GetCurrent(0);
			if (current != null)
			{
				float num = current.Time / current.EndTime;
				text = current.Animation.Name;
			}
			if (this.c % 5 == this.id % 5)
			{
				this.enemy = base.getClosestEnemy();
				this.friend = base.getClosestFriend();
			}
			this.c++;
			float num2 = float.PositiveInfinity;
			if (this.enemy != null)
			{
				num2 = Mathf.Min(Mathf.Abs(this.enemy.GetComponent<Collider2D>().bounds.max.x - base.GetComponent<Collider2D>().bounds.center.x), Mathf.Abs(this.enemy.GetComponent<Collider2D>().bounds.min.x - base.GetComponent<Collider2D>().bounds.center.x));
				if (this.enemy is Base)
				{
					num2 = Mathf.Min(Mathf.Abs(this.enemy.GetComponent<Collider2D>().bounds.max.x - base.GetComponent<Collider2D>().bounds.center.x), Mathf.Abs(this.enemy.GetComponent<Collider2D>().bounds.min.x - base.GetComponent<Collider2D>().bounds.center.x));
				}
			}
			bool flag = true;
			bool flag2;
			bool flag3;
			if (num2 < this.weaponRange * Game.P2U)
			{
				flag2 = true;
				flag3 = false;
				flag = false;
			}
			else if (num2 < this.rangedWeaponRange * Game.P2U)
			{
				flag2 = false;
				flag3 = true;
			}
			else
			{
				flag2 = false;
				flag3 = false;
			}
			if (this.friend != null)
			{
				Bounds bounds = new Bounds(base.GetComponent<Collider2D>().bounds.center, base.GetComponent<Collider2D>().bounds.size + new Vector3(Game.P2U * 25f, 0f, 0f));
				if (this.friend.GetComponent<Collider2D>().bounds.Intersects(bounds))
				{
					flag = false;
				}
			}
			string text2 = text;
			bool loop = false;
			if (flag3)
			{
				if (!this.isInShoot(text))
				{
					string text3 = this.shootAnimation;
					if (flag)
					{
						text3 = this.walkShootAnimation;
					}
					text2 = text3;
					loop = false;
				}
			}
			else if (flag2 && !this.isInAttack(text))
			{
				text2 = this.getAttackAnimationName();
				loop = false;
			}
			if (flag && !flag2)
			{
				if (text != this.shootAnimation)
				{
					base.transform.Translate(new Vector3((float)this.direction * this.speed * Game.P2U * Time.deltaTime * 40f, 0f));
				}
				if (!flag3)
				{
					text2 = this.walkAnimation;
					loop = true;
				}
			}
			else if (!flag2 && !flag3)
			{
				text2 = this.getIdleAnimationName();
				loop = true;
			}
			if (text2 != text)
			{
				this.skeletonAnimation.state.SetAnimation(0, text2, loop);
				this.skeletonAnimation.skeleton.SetToSetupPose();
			}
		}
		base.GetComponentInChildren<SkeletonAnimation>().Update(Time.fixedDeltaTime);
	}

	// Token: 0x060006E8 RID: 1768 RVA: 0x00023020 File Offset: 0x00021220
	public void Event(Spine.AnimationState state, int trackIndex, Spine.Event e)
	{
		if (e.Data.Name == "attack")
		{
			base.attack();
			Bone bone = this.skeletonAnimation.skeleton.Bones.Find(new Predicate<Bone>(this.isName));
			if (this.attackParticle)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.attackParticle);
				gameObject.transform.position = new Vector3((float)((this.team != 1) ? 1 : -1) * bone.worldX * this.skeletonAnimation.transform.localScale.x + this.skeletonAnimation.transform.position.x, bone.worldY * this.skeletonAnimation.transform.localScale.y + this.skeletonAnimation.transform.position.y, 0f);
			}
		}
		else if (e.Data.Name == "shoot")
		{
			base.rangedAttack();
			Bone bone2 = this.skeletonAnimation.skeleton.Bones.Find(new Predicate<Bone>(this.isName));
			if (this.shootParticle)
			{
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.shootParticle);
				gameObject2.transform.position = new Vector3((float)((this.team != 1) ? 1 : -1) * bone2.worldX * this.skeletonAnimation.transform.localScale.x + this.skeletonAnimation.transform.position.x, bone2.worldY * this.skeletonAnimation.transform.localScale.y + this.skeletonAnimation.transform.position.y, 0f);
			}
		}
		else if (e.Data.Name == "1")
		{
			AudioSource.PlayClipAtPoint(base.GetComponentInParent<UnitSpine>().sounds[0], Camera.main.transform.position, Game.EFFECT_VOLUME);
		}
		else if (e.Data.Name == "2")
		{
			AudioSource.PlayClipAtPoint(base.GetComponentInParent<UnitSpine>().sounds[1], Camera.main.transform.position, Game.EFFECT_VOLUME);
		}
		else if (e.Data.Name == "3")
		{
			AudioSource.PlayClipAtPoint(base.GetComponentInParent<UnitSpine>().sounds[2], Camera.main.transform.position, Game.EFFECT_VOLUME);
		}
		else if (e.Data.Name == "4")
		{
			AudioSource.PlayClipAtPoint(base.GetComponentInParent<UnitSpine>().sounds[3], Camera.main.transform.position, Game.EFFECT_VOLUME);
		}
	}

	// Token: 0x060006E9 RID: 1769 RVA: 0x00023340 File Offset: 0x00021540
	private bool isName(Bone bone)
	{
		return bone.Data.Name == "smokebone";
	}

	// Token: 0x060006EA RID: 1770 RVA: 0x00023358 File Offset: 0x00021558
	private string getIdleAnimationName()
	{
		if (this.idleAnimation == null)
		{
			return "idle";
		}
		return this.idleAnimation;
	}

	// Token: 0x060006EB RID: 1771 RVA: 0x00023374 File Offset: 0x00021574
	private string getAttackAnimationName()
	{
		if (this.attackAnimations.Length == 0)
		{
			return "attack";
		}
		return this.attackAnimations[UnityEngine.Random.Range(0, this.attackAnimations.Length)];
	}

	// Token: 0x060006EC RID: 1772 RVA: 0x000233AC File Offset: 0x000215AC
	private bool isInAttack(string currentAnimationName)
	{
		if (this.attackAnimations.Length == 0)
		{
			return currentAnimationName == "attack";
		}
		foreach (string a in this.attackAnimations)
		{
			if (a == currentAnimationName)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060006ED RID: 1773 RVA: 0x00023400 File Offset: 0x00021600
	private bool isInShoot(string currentAnimationName)
	{
		return currentAnimationName == this.shootAnimation || currentAnimationName == this.walkShootAnimation;
	}

	// Token: 0x060006EE RID: 1774 RVA: 0x00023430 File Offset: 0x00021630
	private string getDeathAnimationName()
	{
		if (this.deathAnimations.Length == 0)
		{
			return "death";
		}
		return this.deathAnimations[UnityEngine.Random.Range(0, this.deathAnimations.Length)];
	}

	// Token: 0x04000494 RID: 1172
	public AudioClip[] sounds;

	// Token: 0x04000495 RID: 1173
	private SkeletonAnimation skeletonAnimation;

	// Token: 0x04000496 RID: 1174
	public string[] attackAnimations;

	// Token: 0x04000497 RID: 1175
	public string idleAnimation = "idle";

	// Token: 0x04000498 RID: 1176
	public string[] deathAnimations = new string[]
	{
		"death",
		"death2",
		"death3"
	};

	// Token: 0x04000499 RID: 1177
	public string walkAnimation = "walk";

	// Token: 0x0400049A RID: 1178
	public string shootAnimation = "shoot";

	// Token: 0x0400049B RID: 1179
	public string walkShootAnimation = "walkShoot";

	// Token: 0x0400049C RID: 1180
	public GameObject shootParticle;

	// Token: 0x0400049D RID: 1181
	public GameObject attackParticle;

	// Token: 0x0400049E RID: 1182
	private Unit enemy;

	// Token: 0x0400049F RID: 1183
	private Unit friend;

	// Token: 0x040004A0 RID: 1184
	private int c;
}
