using System;
using UnityEngine;

// Token: 0x020000C1 RID: 193
public class Base : Unit
{
	// Token: 0x17000060 RID: 96
	// (get) Token: 0x06000599 RID: 1433 RVA: 0x0000E774 File Offset: 0x0000C974
	// (set) Token: 0x0600059A RID: 1434 RVA: 0x0000E77C File Offset: 0x0000C97C
	public TurretAnimated[] Turrets
	{
		get
		{
			return this.turrets;
		}
		set
		{
			this.turrets = value;
		}
	}

	// Token: 0x0600059B RID: 1435 RVA: 0x0000E788 File Offset: 0x0000C988
	private void Start()
	{
		this.turrets = new TurretAnimated[4];
		this.extend1.SetActive(false);
		this.extend2.SetActive(false);
		this.extend3.SetActive(false);
		foreach (GameObject gameObject in this.buildSpots)
		{
			gameObject.SetActive(false);
		}
		base.MaxHealth = 500f;
		this.health = base.MaxHealth;
		this.disableSellMode();
		this.lastSpecialTime = Base.SPECIAL_COOLDOWN;
	}

	// Token: 0x0600059C RID: 1436 RVA: 0x0000E814 File Offset: 0x0000CA14
	public void UpgradeAge()
	{
		this.age++;
		this.health += (float)(300 * (this.age + 1));
		base.MaxHealth += (float)(300 * (this.age + 1));
		this.baseObject.GetComponent<SpriteRenderer>().sprite = this.baseAgeSprites[this.age];
		this.extend1.GetComponent<SpriteRenderer>().sprite = this.extenders1[this.age];
		this.extend2.GetComponent<SpriteRenderer>().sprite = this.extenders2[this.age];
		this.extend3.GetComponent<SpriteRenderer>().sprite = this.extenders3[this.age];
	}

	// Token: 0x0600059D RID: 1437 RVA: 0x0000E8DC File Offset: 0x0000CADC
	public void destroyTurret(int pos)
	{
		if (this.Turrets[pos] != null)
		{
			UnityEngine.Object.Destroy(this.Turrets[pos].gameObject);
			this.Turrets[pos] = null;
		}
	}

	// Token: 0x0600059E RID: 1438 RVA: 0x0000E918 File Offset: 0x0000CB18
	public void setUpTurret(int pos, int type)
	{
		if (this.Turrets[pos] != null)
		{
			this.destroyTurret(pos);
		}
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(Game.instance.turrets[type].prefab);
		gameObject.transform.position = this.buildSpots[pos].transform.position;
		this.turrets[pos] = gameObject.GetComponentInChildren<TurretAnimated>();
		gameObject.transform.parent = base.transform;
		this.turrets[pos].setUpTurret(type);
		if (this.team == 1)
		{
			this.FixUpExpansions(pos);
		}
	}

	// Token: 0x0600059F RID: 1439 RVA: 0x0000E9B8 File Offset: 0x0000CBB8
	private void FixUpExpansions(int pos)
	{
		if (pos > this.expansionLevel)
		{
			this.addExpansion();
		}
	}

	// Token: 0x060005A0 RID: 1440 RVA: 0x0000E9CC File Offset: 0x0000CBCC
	public void special()
	{
		if (this.lastSpecialTime > Base.SPECIAL_COOLDOWN)
		{
			this.lastSpecialTime = 0f;
			if (this.team == 0)
			{
				Game.instance.NumGlobalSpellsUsed++;
			}
			else
			{
				Game.instance.ShowSuperMessage();
			}
			if (this.age == Game.AGE_CAVEMAN)
			{
				UnityEngine.Object.Instantiate<GameObject>(PrefabCache.SpecialsComet).GetComponent<SpecialComets>().team = this.team;
			}
			else if (this.age == Game.AGE_RENAISSANCE)
			{
				UnityEngine.Object.Instantiate<GameObject>(PrefabCache.SpecialsHeal).GetComponent<SpecialHeal>().team = this.team;
			}
			else if (this.age == Game.AGE_WW2)
			{
				UnityEngine.Object.Instantiate<GameObject>(PrefabCache.SpecialsBomber).GetComponent<SpecialBomber>().team = this.team;
			}
			else if (this.age == Game.AGE_FUTURE)
			{
				UnityEngine.Object.Instantiate<GameObject>(PrefabCache.SpecialsBeam).GetComponent<SpecialBeam>().team = this.team;
			}
			else
			{
				UnityEngine.Object.Instantiate<GameObject>(PrefabCache.SpecialsArrow).GetComponent<SpecialArrows>().team = this.team;
			}
		}
	}

	// Token: 0x060005A1 RID: 1441 RVA: 0x0000EAF8 File Offset: 0x0000CCF8
	public void enableSellMode()
	{
		for (int i = 0; i < 4; i++)
		{
			if (this.turrets[i] != null)
			{
				this.sellSpots[i].SetActive(true);
			}
		}
	}

	// Token: 0x060005A2 RID: 1442 RVA: 0x0000EB38 File Offset: 0x0000CD38
	public void disableSellMode()
	{
		foreach (GameObject gameObject in this.sellSpots)
		{
			gameObject.SetActive(false);
		}
	}

	// Token: 0x060005A3 RID: 1443 RVA: 0x0000EB6C File Offset: 0x0000CD6C
	public bool enableBuildMode()
	{
		int num = 0;
		for (int i = 0; i < 4; i++)
		{
			MonoBehaviour.print(i + " " + this.turrets[i]);
			if (i <= this.expansionLevel && this.turrets[i] == null)
			{
				this.buildSpots[i].SetActive(true);
				num++;
			}
		}
		return num > 0;
	}

	// Token: 0x060005A4 RID: 1444 RVA: 0x0000EBE0 File Offset: 0x0000CDE0
	public void disableBuildMode()
	{
		foreach (GameObject gameObject in this.buildSpots)
		{
			gameObject.SetActive(false);
		}
	}

	// Token: 0x060005A5 RID: 1445 RVA: 0x0000EC14 File Offset: 0x0000CE14
	public new bool isAlive()
	{
		return this.health > 0f;
	}

	// Token: 0x060005A6 RID: 1446 RVA: 0x0000EC24 File Offset: 0x0000CE24
	public void addExpansion()
	{
		int num = 1000;
		if (this.expansionLevel == 1)
		{
			num = 3000;
		}
		else if (this.expansionLevel == 2)
		{
			num = 7500;
		}
		if (Game.instance.Coins > num || Game.isHack || this.team == 1)
		{
			if (!Game.isHack && this.team == 0 && this.expansionLevel < 3)
			{
				Game.instance.Coins -= num;
			}
			this.expansionLevel++;
			if (this.expansionLevel > 3)
			{
				this.expansionLevel = 3;
			}
			else if (this.expansionLevel == 1)
			{
				this.extend1.SetActive(true);
				if (this.team == 0)
				{
					AudioSource.PlayClipAtPoint(PrefabCache.buildTurretSound, Camera.main.transform.position);
				}
			}
			else if (this.expansionLevel == 2)
			{
				this.extend2.SetActive(true);
				if (this.team == 0)
				{
					AudioSource.PlayClipAtPoint(PrefabCache.buildTurretSound, Camera.main.transform.position);
				}
			}
			else if (this.expansionLevel == 3)
			{
				this.extend3.SetActive(true);
				if (this.team == 0)
				{
					AudioSource.PlayClipAtPoint(PrefabCache.buildTurretSound, Camera.main.transform.position);
				}
			}
		}
		else
		{
			Game.instance.canvasHud.showTip(num + " coins are required to build a new turret slot", 2f);
		}
		if (this.team == 0)
		{
			Game.instance.canvasHud.refreshMenu();
		}
	}

	// Token: 0x060005A7 RID: 1447 RVA: 0x0000EDE0 File Offset: 0x0000CFE0
	public override void damage(float amount)
	{
		this.health -= amount;
		if (this.health <= 0f)
		{
		}
	}

	// Token: 0x060005A8 RID: 1448 RVA: 0x0000EE00 File Offset: 0x0000D000
	private void FixedUpdate()
	{
		if (Game.instance.IsPaused)
		{
			return;
		}
		this.lastSpecialTime += Time.fixedDeltaTime;
		if (this.health < 0f)
		{
			this.health = 0f;
		}
		this.healthBar.transform.localScale = new Vector3(Mathf.Lerp(this.healthBar.transform.localScale.x, this.health / base.MaxHealth * 1.2f, 0.2f), this.healthBar.transform.localScale.y, this.healthBar.transform.localScale.z);
	}

	// Token: 0x04000212 RID: 530
	private TurretAnimated[] turrets;

	// Token: 0x04000213 RID: 531
	public GameObject extend1;

	// Token: 0x04000214 RID: 532
	public GameObject extend2;

	// Token: 0x04000215 RID: 533
	public GameObject extend3;

	// Token: 0x04000216 RID: 534
	public GameObject baseObject;

	// Token: 0x04000217 RID: 535
	public GameObject[] buildSpots;

	// Token: 0x04000218 RID: 536
	public GameObject[] sellSpots;

	// Token: 0x04000219 RID: 537
	public Sprite[] extenders1;

	// Token: 0x0400021A RID: 538
	public Sprite[] extenders2;

	// Token: 0x0400021B RID: 539
	public Sprite[] extenders3;

	// Token: 0x0400021C RID: 540
	public Sprite[] baseAgeSprites;

	// Token: 0x0400021D RID: 541
	public GameObject healthBar;

	// Token: 0x0400021E RID: 542
	public int expansionLevel;

	// Token: 0x0400021F RID: 543
	public static int[] ageRequirements = new int[]
	{
		500,
		4000,
		14000,
		45000,
		200000
	};

	// Token: 0x04000220 RID: 544
	public static float SPECIAL_COOLDOWN = 50f;

	// Token: 0x04000221 RID: 545
	public float lastSpecialTime;

	// Token: 0x04000222 RID: 546
	public int age;
}
