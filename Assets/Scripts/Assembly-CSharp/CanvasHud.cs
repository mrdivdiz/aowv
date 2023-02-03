using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000D0 RID: 208
public class CanvasHud : MonoBehaviour
{
	// Token: 0x060005D6 RID: 1494 RVA: 0x00011028 File Offset: 0x0000F228
	private void Start()
	{
		this.switchToMenu(CanvasHud.M_ROOT);
		this.defeatMenu.gameObject.SetActive(false);
		this.victoryMenu.gameObject.SetActive(false);
	}

	// Token: 0x060005D7 RID: 1495 RVA: 0x00011064 File Offset: 0x0000F264
	public void refreshMenu()
	{
		this.switchToMenu(this.currentMenu);
	}

	// Token: 0x060005D8 RID: 1496 RVA: 0x00011074 File Offset: 0x0000F274
	public void switchToMenu(int menu)
	{
		this.currentMenu = menu;
		this.button5.color = new Color(1f, 1f, 1f);
		this.button4.color = new Color(1f, 1f, 1f);
		if (this.currentMenu == CanvasHud.M_ROOT)
		{
			this.button1.sprite = this.rootSprites[0];
			this.button2.sprite = this.rootSprites[1];
			this.button3.sprite = this.rootSprites[2];
			this.button4.sprite = this.rootSprites[3];
			this.button4.enabled = true;
			if (Game.instance && Game.instance.baseFriendly.expansionLevel >= 3)
			{
				this.button4.color = new Color(0.5f, 0.5f, 0.5f);
			}
			this.button5.sprite = this.rootSprites[4];
			if (Game.instance != null && Game.instance.age == Game.AGE_FUTURE)
			{
				this.button5.color = new Color(0.5f, 0.5f, 0.5f);
			}
		}
		else if (this.currentMenu == CanvasHud.M_UNIT)
		{
			Sprite[] ageUnitSprites = this.getAgeUnitSprites(Game.instance.age);
			this.button1.sprite = ageUnitSprites[0];
			this.button2.sprite = ageUnitSprites[1];
			this.button3.sprite = ageUnitSprites[2];
			this.button4.enabled = false;
			this.button4.sprite = null;
			if (Game.instance.age == Game.AGE_FUTURE)
			{
				this.button4.enabled = true;
				this.button4.sprite = ageUnitSprites[3];
			}
			this.button5.sprite = ageUnitSprites[4];
		}
		else if (this.currentMenu == CanvasHud.M_TURRET)
		{
			Sprite[] ageTurretSprites = this.getAgeTurretSprites(Game.instance.age);
			this.button1.sprite = ageTurretSprites[0];
			this.button2.sprite = ageTurretSprites[1];
			this.button3.sprite = ageTurretSprites[2];
			this.button4.enabled = false;
			this.button4.sprite = null;
			this.button5.sprite = ageTurretSprites[4];
		}
	}

	// Token: 0x060005D9 RID: 1497 RVA: 0x000112E4 File Offset: 0x0000F4E4
	private Sprite[] getAgeUnitSprites(int age)
	{
		if (age == Game.AGE_CAVEMAN)
		{
			return this.age1Sprites;
		}
		if (age == Game.AGE_MEDIEVAL)
		{
			return this.age2Sprites;
		}
		if (age == Game.AGE_RENAISSANCE)
		{
			return this.age3Sprites;
		}
		if (age == Game.AGE_WW2)
		{
			return this.age4Sprites;
		}
		if (age == Game.AGE_FUTURE)
		{
			return this.age5Sprites;
		}
		return null;
	}

	// Token: 0x060005DA RID: 1498 RVA: 0x0001134C File Offset: 0x0000F54C
	private Sprite[] getAgeTurretSprites(int age)
	{
		if (age == Game.AGE_CAVEMAN)
		{
			return this.age1TurretSprites;
		}
		if (age == Game.AGE_MEDIEVAL)
		{
			return this.age2TurretSprites;
		}
		if (age == Game.AGE_RENAISSANCE)
		{
			return this.age3TurretSprites;
		}
		if (age == Game.AGE_WW2)
		{
			return this.age4TurretSprites;
		}
		if (age == Game.AGE_FUTURE)
		{
			return this.age5TurretSprites;
		}
		return null;
	}

	// Token: 0x060005DB RID: 1499 RVA: 0x000113B4 File Offset: 0x0000F5B4
	private void FixedUpdate()
	{
		if (Time.time < this.timeToEraseTip)
		{
			this.tipText.rectTransform.localScale = Vector3.Lerp(this.tipText.rectTransform.localScale, new Vector3(1f, 1f, 1f), 0.3f);
		}
		else if (this.tipText.enabled)
		{
			this.tipText.enabled = false;
		}
	}

	// Token: 0x060005DC RID: 1500 RVA: 0x00011430 File Offset: 0x0000F630
	private void Update()
	{
		if (Game.instance.IsPaused || Game.instance.isGameOver)
		{
			return;
		}
		if (Game.instance.age != Game.AGE_FUTURE && Base.ageRequirements[Game.instance.age + 1] <= Game.instance.Exp && Time.time - this.lastUpgradeAnimationChange > 0.1f)
		{
			if (this.currentMenu == CanvasHud.M_ROOT)
			{
				this.button5.sprite = this.upgradeAnimation[this.upgradeAnimationIndex % this.upgradeAnimation.Length];
			}
			else
			{
				this.button4.sprite = this.upgradeAnimation[this.upgradeAnimationIndex % this.upgradeAnimation.Length];
				this.button4.enabled = true;
			}
			this.lastUpgradeAnimationChange = Time.time;
			this.upgradeAnimationIndex++;
		}
		if (Game.instance.baseFriendly.lastSpecialTime > Base.SPECIAL_COOLDOWN)
		{
			this.specialCooldown.enabled = false;
		}
		else
		{
			this.specialCooldown.enabled = true;
			this.specialCooldown.material.SetFloat("_CutOff", Mathf.Min(Game.instance.baseFriendly.lastSpecialTime / Base.SPECIAL_COOLDOWN, 0.99f));
		}
		if (this.isSellMode && (Input.GetMouseButtonDown(0) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)))
		{
			Vector3 vector = Input.mousePosition;
			if (Input.touchCount > 0)
			{
				vector = Input.GetTouch(0).position;
			}
			vector = Camera.main.ScreenToWorldPoint(vector);
			vector.z = 0f;
			int num = 0;
			int num2 = -1;
			foreach (GameObject gameObject in Game.instance.baseFriendly.sellSpots)
			{
				if (gameObject.activeInHierarchy && (gameObject.transform.position - vector).magnitude < 1f && (num2 == -1 || (Game.instance.baseFriendly.buildSpots[num2].transform.position - vector).magnitude > (gameObject.transform.position - vector).magnitude))
				{
					num2 = num;
				}
				num++;
			}
			if (num2 != -1)
			{
				Game.instance.Coins += Game.instance.turrets[Game.instance.baseFriendly.Turrets[num2].id].cost / 2;
				UnityEngine.Object.Destroy(Game.instance.baseFriendly.Turrets[num2].gameObject);
				GameState.unlockAchievement(GameState.A_SELL_TURRET);
				this.switchToMenu(CanvasHud.M_ROOT);
				Game.instance.baseFriendly.disableSellMode();
				this.isSellMode = false;
			}
			else
			{
				this.isSellMode = false;
				this.showTip("Tap on sell slot to sell turret", 2f);
				Game.instance.baseFriendly.disableSellMode();
			}
		}
		if (this.isBuildMode && (Input.GetMouseButtonDown(0) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)))
		{
			Vector3 vector2 = Input.mousePosition;
			if (Input.touchCount > 0)
			{
				vector2 = Input.GetTouch(0).position;
			}
			vector2 = Camera.main.ScreenToWorldPoint(vector2);
			vector2.z = 0f;
			int num3 = 0;
			int num4 = -1;
			foreach (GameObject gameObject2 in Game.instance.baseFriendly.buildSpots)
			{
				if (gameObject2.activeInHierarchy && (gameObject2.transform.position - vector2).magnitude < 1f && (num4 == -1 || (Game.instance.baseFriendly.buildSpots[num4].transform.position - vector2).magnitude > (gameObject2.transform.position - vector2).magnitude))
				{
					num4 = num3;
				}
				num3++;
			}
			if (num4 != -1)
			{
				this.switchToMenu(CanvasHud.M_ROOT);
				if (Game.instance.Coins >= Game.instance.turrets[this.turretToBuildId].cost || Game.isHack)
				{
					if (!Game.isHack)
					{
						Game.instance.Coins -= Game.instance.turrets[this.turretToBuildId].cost;
					}
					AudioSource.PlayClipAtPoint(PrefabCache.buildTurretSound, Camera.main.transform.position);
					Game.instance.baseFriendly.setUpTurret(num4, this.turretToBuildId);
					int num5 = 0;
					foreach (TurretAnimated x in Game.instance.baseFriendly.Turrets)
					{
						if (x != null)
						{
							num5++;
						}
					}
					if (num5 == 4)
					{
						GameState.unlockAchievement(GameState.A_ALL_SLOTS);
					}
					GameState.turretsBuilt[this.turretToBuildId] = true;
					if (GameState.turretsBuilt.Count == 15)
					{
						GameState.unlockAchievement(GameState.A_BUILD_EVERY_TURRET);
					}
				}
				else
				{
					this.showTip("You need more coins to construct this turret!", 2f);
				}
				Game.instance.baseFriendly.disableBuildMode();
				this.isBuildMode = false;
			}
			else
			{
				this.showTip("Tap on build slot to create turret", 2f);
				this.isBuildMode = false;
				Game.instance.baseFriendly.disableBuildMode();
			}
		}
		if (this.currentMenu == CanvasHud.M_UNIT)
		{
			int l = 0;
			int num6 = 3;
			if (Game.instance.age == Game.AGE_FUTURE)
			{
				num6 = 4;
			}
			int num7 = 0;
			while (l < num6)
			{
				GameObject gameObject3 = this.costs[l];
				gameObject3.SetActive(true);
				gameObject3.GetComponentInChildren<Text>().text = string.Empty + this.minimizeCost(Game.instance.unitData[Game.instance.age * 3 + num7].cost);
				l++;
				num7++;
			}
		}
		else if (this.currentMenu == CanvasHud.M_TURRET)
		{
			int m = 0;
			int num8 = 0;
			while (m < 3)
			{
				GameObject gameObject4 = this.costs[m];
				gameObject4.SetActive(true);
				gameObject4.GetComponentInChildren<Text>().text = string.Empty + this.minimizeCost(Game.instance.turrets[Game.instance.age * 3 + num8].cost);
				m++;
				num8++;
			}
		}
		else
		{
			for (int n = 0; n < 4; n++)
			{
				GameObject gameObject5 = this.costs[n];
				gameObject5.SetActive(false);
			}
		}
	}

	// Token: 0x060005DD RID: 1501 RVA: 0x00011B84 File Offset: 0x0000FD84
	private string minimizeCost(int cost)
	{
		string result = string.Empty;
		if (cost >= 1000)
		{
			float num = (float)cost / 1000f;
			result = Mathf.Round(num * 10f) / 10f + "k";
		}
		else
		{
			result = cost + string.Empty;
		}
		return result;
	}

	// Token: 0x060005DE RID: 1502 RVA: 0x00011BE4 File Offset: 0x0000FDE4
	public void buttonPress(int index)
	{
		AudioSource.PlayClipAtPoint(PrefabCache.buttonClip, Camera.main.transform.position);
		if (this.currentMenu == CanvasHud.M_ROOT)
		{
			this.rootMenuPress(index);
		}
		else if (this.currentMenu == CanvasHud.M_UNIT)
		{
			this.unitMenuPress(index);
		}
		else if (this.currentMenu == CanvasHud.M_TURRET)
		{
			this.turretMenuPress(index);
		}
	}

	// Token: 0x060005DF RID: 1503 RVA: 0x00011C5C File Offset: 0x0000FE5C
	private void rootMenuPress(int index)
	{
		if (index == 1)
		{
			this.switchToMenu(CanvasHud.M_UNIT);
		}
		else if (index == 2)
		{
			this.switchToMenu(CanvasHud.M_TURRET);
		}
		else if (index == 3)
		{
			int num = 0;
			foreach (TurretAnimated x in Game.instance.baseFriendly.Turrets)
			{
				if (x != null)
				{
					num++;
				}
			}
			if (num == 0)
			{
				this.showTip("No turrets to sell!", 2f);
			}
			else
			{
				Game.instance.baseFriendly.enableSellMode();
				this.isSellMode = true;
			}
		}
		else if (index == 4)
		{
			Game.instance.baseFriendly.addExpansion();
		}
		else if (index == 5)
		{
			Game.instance.upgradeAge();
		}
	}

	// Token: 0x060005E0 RID: 1504 RVA: 0x00011D3C File Offset: 0x0000FF3C
	private void unitMenuPress(int index)
	{
		if (index < 4 || (Game.instance.age == Game.AGE_FUTURE && index == 4))
		{
			Game.instance.queueUnit(index - 1 + Game.instance.age * 3, 0);
		}
		else if (index == 5)
		{
			this.switchToMenu(CanvasHud.M_ROOT);
		}
		else if (index == 4 && Game.instance.age != Game.AGE_FUTURE && Base.ageRequirements[Game.instance.age + 1] <= Game.instance.Exp)
		{
			Game.instance.upgradeAge();
		}
	}

	// Token: 0x060005E1 RID: 1505 RVA: 0x00011DEC File Offset: 0x0000FFEC
	public void specialButton()
	{
		Game.instance.baseFriendly.special();
	}

	// Token: 0x060005E2 RID: 1506 RVA: 0x00011E00 File Offset: 0x00010000
	private void turretMenuPress(int index)
	{
		if (index < 4)
		{
			this.turretToBuildId = index - 1 + Game.instance.age * 3;
			if (Game.instance.Coins >= Game.instance.turrets[this.turretToBuildId].cost || Game.isHack)
			{
				bool flag = Game.instance.baseFriendly.enableBuildMode();
				if (flag)
				{
					this.isBuildMode = true;
				}
				else
				{
					this.showTip("All turret slots are full. Extend your base to build more", 2f);
				}
			}
			else
			{
				this.showTip("You need more coins to build this turret", 2f);
			}
		}
		else if (index == 5)
		{
			this.switchToMenu(CanvasHud.M_ROOT);
		}
		else if (index == 4 && Game.instance.age != Game.AGE_FUTURE && Base.ageRequirements[Game.instance.age + 1] <= Game.instance.Exp)
		{
			Game.instance.upgradeAge();
		}
	}

	// Token: 0x060005E3 RID: 1507 RVA: 0x00011F08 File Offset: 0x00010108
	public void settings()
	{
		if (!Game.instance.isGameOver)
		{
			AudioSource.PlayClipAtPoint(PrefabCache.buttonClip, Camera.main.transform.position);
			Game.instance.IsPaused = true;
		}
	}

	// Token: 0x060005E4 RID: 1508 RVA: 0x00011F48 File Offset: 0x00010148
	public void restartButton()
	{
		if (this.pauseMenu.activeInHierarchy || this.defeatMenu.enabled)
		{
			GameState.save();
			AdManager.instance.ShowAd();
			base.StartCoroutine(LoadingScreen.LoadLevel("Game"));
			this.pauseMenu.SetActive(false);
			this.defeatMenu.gameObject.SetActive(false);
			this.topOfHud.SetActive(false);
			AudioSource.PlayClipAtPoint(PrefabCache.buttonClip, Camera.main.transform.position);
		}
	}

	// Token: 0x060005E5 RID: 1509 RVA: 0x00011FD8 File Offset: 0x000101D8
	public void quitButton()
	{
		if (this.pauseMenu.activeInHierarchy)
		{
			GameState.save();
			if (Game.currentGeneral != string.Empty)
			{
				MainMenu.loadGeneralsMenu = true;
				AdManager.instance.ShowAd();
				base.StartCoroutine(LoadingScreen.LoadLevel("MainMenu"));
			}
			else
			{
				AdManager.instance.ShowAd();
				base.StartCoroutine(LoadingScreen.LoadLevel("MainMenu"));
			}
			this.pauseMenu.SetActive(false);
			this.defeatMenu.gameObject.SetActive(false);
			this.topOfHud.SetActive(false);
			AudioSource.PlayClipAtPoint(PrefabCache.buttonClip, Camera.main.transform.position);
		}
	}

	// Token: 0x060005E6 RID: 1510 RVA: 0x00012094 File Offset: 0x00010294
	public void resumeButton()
	{
		if (this.pauseMenu.activeInHierarchy)
		{
			Game.instance.IsPaused = false;
			AudioSource.PlayClipAtPoint(PrefabCache.buttonClip, Camera.main.transform.position);
		}
	}

	// Token: 0x060005E7 RID: 1511 RVA: 0x000120D8 File Offset: 0x000102D8
	public bool isBuildingTurret()
	{
		return this.isBuildMode;
	}

	// Token: 0x060005E8 RID: 1512 RVA: 0x000120E0 File Offset: 0x000102E0
	public bool isSellingTurret()
	{
		return this.isSellMode;
	}

	// Token: 0x060005E9 RID: 1513 RVA: 0x000120E8 File Offset: 0x000102E8
	public void showTip(string text, float time = 2f)
	{
		this.tipText.text = text;
		this.timeToEraseTip = Time.time + time;
		this.tipText.rectTransform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
		this.tipText.enabled = true;
	}

	// Token: 0x04000268 RID: 616
	public Image button1;

	// Token: 0x04000269 RID: 617
	public Image button2;

	// Token: 0x0400026A RID: 618
	public Image button3;

	// Token: 0x0400026B RID: 619
	public Image button4;

	// Token: 0x0400026C RID: 620
	public Image button5;

	// Token: 0x0400026D RID: 621
	public Sprite[] rootSprites;

	// Token: 0x0400026E RID: 622
	public Sprite[] age1Sprites;

	// Token: 0x0400026F RID: 623
	public Sprite[] age2Sprites;

	// Token: 0x04000270 RID: 624
	public Sprite[] age3Sprites;

	// Token: 0x04000271 RID: 625
	public Sprite[] age4Sprites;

	// Token: 0x04000272 RID: 626
	public Sprite[] age5Sprites;

	// Token: 0x04000273 RID: 627
	public Sprite[] age1TurretSprites;

	// Token: 0x04000274 RID: 628
	public Sprite[] age2TurretSprites;

	// Token: 0x04000275 RID: 629
	public Sprite[] age3TurretSprites;

	// Token: 0x04000276 RID: 630
	public Sprite[] age4TurretSprites;

	// Token: 0x04000277 RID: 631
	public Sprite[] age5TurretSprites;

	// Token: 0x04000278 RID: 632
	public Sprite[] specialSprites;

	// Token: 0x04000279 RID: 633
	public Image[] queueSprites;

	// Token: 0x0400027A RID: 634
	public Image fill;

	// Token: 0x0400027B RID: 635
	public Image specialCooldown;

	// Token: 0x0400027C RID: 636
	public Image specialButtonImage;

	// Token: 0x0400027D RID: 637
	public GameObject[] costs;

	// Token: 0x0400027E RID: 638
	public Sprite[] queueUnitSprites;

	// Token: 0x0400027F RID: 639
	public Sprite box;

	// Token: 0x04000280 RID: 640
	public GameObject pauseMenu;

	// Token: 0x04000281 RID: 641
	public Image defeatMenu;

	// Token: 0x04000282 RID: 642
	public Image victoryMenu;

	// Token: 0x04000283 RID: 643
	public Text vicotryDescription;

	// Token: 0x04000284 RID: 644
	public Text vicotoryName;

	// Token: 0x04000285 RID: 645
	public Image victoryProfile;

	// Token: 0x04000286 RID: 646
	public Text coinsText;

	// Token: 0x04000287 RID: 647
	public Text expText;

	// Token: 0x04000288 RID: 648
	public GameObject topOfHud;

	// Token: 0x04000289 RID: 649
	public Text buildText;

	// Token: 0x0400028A RID: 650
	public Text tipText;

	// Token: 0x0400028B RID: 651
	public Sprite[] upgradeAnimation;

	// Token: 0x0400028C RID: 652
	private int currentMenu;

	// Token: 0x0400028D RID: 653
	public static int M_ROOT;

	// Token: 0x0400028E RID: 654
	public static int M_UNIT = 1;

	// Token: 0x0400028F RID: 655
	public static int M_TURRET = 2;

	// Token: 0x04000290 RID: 656
	private int turretToBuildId;

	// Token: 0x04000291 RID: 657
	private bool isBuildMode;

	// Token: 0x04000292 RID: 658
	private bool isSellMode;

	// Token: 0x04000293 RID: 659
	private float timeToEraseTip;

	// Token: 0x04000294 RID: 660
	private float lastUpgradeAnimationChange;

	// Token: 0x04000295 RID: 661
	private int upgradeAnimationIndex;

	// Token: 0x04000296 RID: 662
	public GameObject generalMessage;
}
