using System;
using System.Collections;
using UnityEngine;

// Token: 0x020000E8 RID: 232
public class Hud : MonoBehaviour
{
	// Token: 0x0600065F RID: 1631 RVA: 0x0001AFE4 File Offset: 0x000191E4
	private void Start()
	{
		this.buttons = new ArrayList();
		this.buttons.Add(new Hud.UnitButton(this.clubmanButton, 0, Game.AGE_CAVEMAN));
		this.buttons.Add(new Hud.UnitButton(this.slingshotButton, 1, Game.AGE_CAVEMAN));
		this.buttons.Add(new Hud.UnitButton(this.dinoriderButton, 2, Game.AGE_CAVEMAN));
		this.buttons.Add(new Hud.UnitButton(this.swordmanButton, 3, Game.AGE_MEDIEVAL));
		this.buttons.Add(new Hud.UnitButton(this.archerButton, 4, Game.AGE_MEDIEVAL));
		this.buttons.Add(new Hud.UnitButton(this.knightButton, 5, Game.AGE_MEDIEVAL));
		this.buttons.Add(new Hud.UnitButton(this.duelerButton, 6, Game.AGE_RENAISSANCE));
		this.buttons.Add(new Hud.UnitButton(this.mousquettereButton, 7, Game.AGE_RENAISSANCE));
		this.buttons.Add(new Hud.UnitButton(this.canoneerButton, 8, Game.AGE_RENAISSANCE));
		this.buttons.Add(new Hud.UnitButton(this.meleeInfantryButton, 9, Game.AGE_WW2));
		this.buttons.Add(new Hud.UnitButton(this.infantryButton, 10, Game.AGE_WW2));
		this.buttons.Add(new Hud.UnitButton(this.tankButton, 11, Game.AGE_WW2));
		this.buttons.Add(new Hud.UnitButton(this.godsBladeButton, 12, Game.AGE_FUTURE));
		this.buttons.Add(new Hud.UnitButton(this.blasterButton, 13, Game.AGE_FUTURE));
		this.buttons.Add(new Hud.UnitButton(this.warMachineButton, 14, Game.AGE_FUTURE));
		this.buttons.Add(new Hud.UnitButton(this.superSoldierButton, 15, Game.AGE_FUTURE));
		this.t_buttons = new ArrayList();
		this.t_buttons.Add(new Hud.UnitButton(this.t_slingButton, 0, Game.AGE_CAVEMAN));
		this.t_buttons.Add(new Hud.UnitButton(this.t_eggButton, 1, Game.AGE_CAVEMAN));
		this.t_buttons.Add(new Hud.UnitButton(this.t_catapultButton, 2, Game.AGE_CAVEMAN));
		this.t_buttons.Add(new Hud.UnitButton(this.t_betterCatapultButton, 3, Game.AGE_MEDIEVAL));
		this.t_buttons.Add(new Hud.UnitButton(this.t_fireCatapultButton, 4, Game.AGE_MEDIEVAL));
		this.t_buttons.Add(new Hud.UnitButton(this.t_oilButton, 5, Game.AGE_MEDIEVAL));
		this.t_buttons.Add(new Hud.UnitButton(this.t_smallCannonButton, 6, Game.AGE_RENAISSANCE));
		this.t_buttons.Add(new Hud.UnitButton(this.t_largeCannonButton, 7, Game.AGE_RENAISSANCE));
		this.t_buttons.Add(new Hud.UnitButton(this.t_explosivesCannonButton, 8, Game.AGE_RENAISSANCE));
		this.t_buttons.Add(new Hud.UnitButton(this.t_singleTurretButton, 9, Game.AGE_WW2));
		this.t_buttons.Add(new Hud.UnitButton(this.t_rocketTurretButton, 10, Game.AGE_WW2));
		this.t_buttons.Add(new Hud.UnitButton(this.t_doubleTurretButton, 11, Game.AGE_WW2));
		this.t_buttons.Add(new Hud.UnitButton(this.t_titaniumShooterButton, 12, Game.AGE_FUTURE));
		this.t_buttons.Add(new Hud.UnitButton(this.t_lazerCanonButton, 13, Game.AGE_FUTURE));
		this.t_buttons.Add(new Hud.UnitButton(this.t_ionRayButton, 14, Game.AGE_FUTURE));
		this.backButton.SetActive(false);
		this.endGameScreen.SetActive(false);
		this.cancelButton.SetActive(false);
		this.isCancelMode = false;
	}

	// Token: 0x06000660 RID: 1632 RVA: 0x0001B460 File Offset: 0x00019660
	public void showTip(string text, float time)
	{
		this.tipText.text = text;
		this.timeToEraseTip = Time.time + time;
	}

	// Token: 0x06000661 RID: 1633 RVA: 0x0001B47C File Offset: 0x0001967C
	private void Update()
	{
		if (Time.time > this.timeToEraseTip)
		{
			this.tipText.text = string.Empty;
		}
		float num = (Time.time - Game.instance.baseFriendly.lastSpecialTime) / Base.SPECIAL_COOLDOWN;
		if (Game.isHack)
		{
			num = 0f;
		}
		if (num >= 1f)
		{
			this.specialTimer.gameObject.SetActive(false);
		}
		else
		{
			this.specialTimer.gameObject.SetActive(true);
			this.specialTimer.material.SetFloat("_CutOff", Mathf.Min((Time.time - Game.instance.baseFriendly.lastSpecialTime) / Base.SPECIAL_COOLDOWN, 0.99f));
		}
		if (!Game.instance.IsPaused)
		{
			this.top.SetActive(true);
			bool flag = false;
			bool flag2 = false;
			if (this.isCancelMode)
			{
				foreach (GameObject gameObject in Game.instance.baseFriendly.buildSpots)
				{
					if (gameObject.activeInHierarchy)
					{
						this.showTip("Tap on build spot to construct " + Game.instance.turrets[this.turretToBuildId].name, 0.1f);
					}
				}
				foreach (GameObject gameObject2 in this.priceDisplays)
				{
					gameObject2.SetActive(false);
				}
				this.cancelButton.SetActive(true);
				this.backButton.SetActive(false);
				this.upgradeButton.SetActive(false);
				this.rootGroup.SetActive(false);
				this.backButton.SetActive(false);
				this.cavemanGroup.SetActive(false);
				this.medievalGroup.SetActive(false);
				this.renaissanceGroup.SetActive(false);
				this.ww2Group.SetActive(false);
				this.futureGroup.SetActive(false);
				this.t_cavemanGroup.SetActive(false);
				this.t_medievalGroup.SetActive(false);
				this.t_renaissanceGroup.SetActive(false);
				this.t_ww2Group.SetActive(false);
				this.t_futureGroup.SetActive(false);
			}
			else if (this.currentMenu == Hud.M_UNIT)
			{
				int k = 1;
				if (Game.instance.age == Game.AGE_FUTURE)
				{
					k = 0;
				}
				int num2 = 0;
				while (k < this.priceDisplays.Length)
				{
					GameObject gameObject3 = this.priceDisplays[k];
					gameObject3.SetActive(true);
					gameObject3.GetComponentInChildren<TextMesh>().text = string.Empty + Game.instance.unitData[Game.instance.age * 3 + num2].cost;
					k++;
					num2++;
				}
			}
			else if (this.currentMenu == Hud.M_TURRET)
			{
				int l = 1;
				int num3 = 0;
				while (l < this.priceDisplays.Length)
				{
					GameObject gameObject4 = this.priceDisplays[l];
					gameObject4.SetActive(true);
					gameObject4.GetComponentInChildren<TextMesh>().text = string.Empty + Game.instance.turrets[Game.instance.age * 3 + num3].cost;
					l++;
					num3++;
				}
			}
			else
			{
				foreach (GameObject gameObject5 in this.priceDisplays)
				{
					gameObject5.SetActive(false);
				}
			}
			if (Input.GetMouseButtonDown(0) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
			{
				Vector3 vector = Input.mousePosition;
				if (Input.touchCount > 0)
				{
					vector = Input.GetTouch(0).position;
				}
				vector = Camera.main.ScreenToWorldPoint(vector);
				vector.z = 0f;
				if ((this.specialButton.transform.position - vector).magnitude < 1f)
				{
					Game.instance.baseFriendly.special();
				}
				vector.z = this.settingsButton.transform.position.z;
				if ((this.settingsButton.transform.position - vector).magnitude < 1f)
				{
					AudioSource.PlayClipAtPoint(PrefabCache.buttonClip, Camera.main.transform.position);
					Game.instance.IsPaused = true;
				}
				vector.z = 0f;
				if (this.isCancelMode && (this.cancelButton.transform.position - vector).magnitude < 2f)
				{
					this.backToRootMenu();
				}
				else if (this.currentMenu == Hud.M_UNIT)
				{
					foreach (object obj in this.buttons)
					{
						Hud.UnitButton unitButton = (Hud.UnitButton)obj;
						if (unitButton.age == Game.instance.age && (unitButton.button.transform.position - vector).magnitude < 1f)
						{
							this.game.queueUnit(unitButton.unitId, Unit.T_GOOD);
						}
					}
					if ((this.backButton.transform.position - vector).magnitude < 1f)
					{
						this.rootGroup.SetActive(true);
						this.backButton.SetActive(false);
						this.cavemanGroup.SetActive(false);
						this.medievalGroup.SetActive(false);
						this.renaissanceGroup.SetActive(false);
						this.ww2Group.SetActive(false);
						this.futureGroup.SetActive(false);
						this.t_cavemanGroup.SetActive(false);
						this.t_medievalGroup.SetActive(false);
						this.t_renaissanceGroup.SetActive(false);
						this.t_ww2Group.SetActive(false);
						this.t_futureGroup.SetActive(false);
						this.currentMenu = Hud.M_ROOT;
					}
				}
				else if (this.currentMenu == Hud.M_TURRET)
				{
					foreach (object obj2 in this.t_buttons)
					{
						Hud.UnitButton unitButton2 = (Hud.UnitButton)obj2;
						if (unitButton2.age == Game.instance.age && (unitButton2.button.transform.position - vector).magnitude < 1f)
						{
							if (Game.instance.Coins >= Game.instance.turrets[unitButton2.unitId].cost || Game.isHack)
							{
								this.turretToBuildId = unitButton2.unitId;
								this.isCancelMode = true;
								Game.instance.baseFriendly.enableBuildMode();
							}
							else
							{
								this.backToRootMenu();
							}
						}
					}
					int num4 = 0;
					int num5 = -1;
					foreach (GameObject gameObject6 in Game.instance.baseFriendly.buildSpots)
					{
						if (gameObject6.activeInHierarchy && (gameObject6.transform.position - vector).magnitude < 1f && (num5 == -1 || (Game.instance.baseFriendly.buildSpots[num5].transform.position - vector).magnitude > (gameObject6.transform.position - vector).magnitude))
						{
							num5 = num4;
						}
						num4++;
					}
					if (num5 != -1)
					{
						this.backToRootMenu();
						if (Game.instance.Coins >= Game.instance.turrets[this.turretToBuildId].cost || Game.isHack)
						{
							if (!Game.isHack)
							{
								Game.instance.Coins -= Game.instance.turrets[this.turretToBuildId].cost;
							}
							Game.instance.baseFriendly.setUpTurret(num5, this.turretToBuildId);
							int num6 = 0;
							foreach (TurretAnimated x in Game.instance.baseFriendly.Turrets)
							{
								if (x != null)
								{
									num6++;
								}
							}
							if (num6 == 4)
							{
								GameState.unlockAchievement(GameState.A_ALL_SLOTS);
							}
							GameState.turretsBuilt[this.turretToBuildId] = true;
							if (GameState.turretsBuilt.Count == 15)
							{
								GameState.unlockAchievement(GameState.A_BUILD_EVERY_TURRET);
							}
						}
						Game.instance.baseFriendly.disableBuildMode();
					}
					if ((this.backButton.transform.position - vector).magnitude < 1f)
					{
						this.rootGroup.SetActive(true);
						this.backButton.SetActive(false);
						this.cavemanGroup.SetActive(false);
						this.medievalGroup.SetActive(false);
						this.renaissanceGroup.SetActive(false);
						this.ww2Group.SetActive(false);
						this.futureGroup.SetActive(false);
						this.t_cavemanGroup.SetActive(false);
						this.t_medievalGroup.SetActive(false);
						this.t_renaissanceGroup.SetActive(false);
						this.t_ww2Group.SetActive(false);
						this.t_futureGroup.SetActive(false);
						this.currentMenu = Hud.M_ROOT;
					}
				}
				else if (this.currentMenu == Hud.M_ROOT)
				{
					int num8 = 0;
					int num9 = -1;
					foreach (GameObject gameObject7 in Game.instance.baseFriendly.sellSpots)
					{
						if (gameObject7.activeInHierarchy && (gameObject7.transform.position - vector).magnitude < 1f && (num9 == -1 || (Game.instance.baseFriendly.buildSpots[num9].transform.position - vector).magnitude > (gameObject7.transform.position - vector).magnitude))
						{
							num9 = num8;
						}
						num8++;
					}
					if (num9 != -1)
					{
						Game.instance.Coins += Game.instance.turrets[Game.instance.baseFriendly.Turrets[num9].id].cost / 2;
						Game.instance.baseFriendly.destroyTurret(num9);
						GameState.unlockAchievement(GameState.A_SELL_TURRET);
						this.isCancelMode = false;
						this.backToRootMenu();
						Game.instance.baseFriendly.disableSellMode();
					}
					if ((this.sellTurretsButton.transform.position - vector).magnitude < 1f)
					{
						this.isCancelMode = true;
						Game.instance.baseFriendly.enableSellMode();
					}
					if ((this.unitsButton.transform.position - vector).magnitude < 1f)
					{
						this.rootGroup.SetActive(false);
						this.backButton.SetActive(true);
						this.currentMenu = Hud.M_UNIT;
						flag = true;
					}
					if ((this.turretsButton.transform.position - vector).magnitude < 1f)
					{
						this.rootGroup.SetActive(false);
						this.backButton.SetActive(true);
						this.currentMenu = Hud.M_TURRET;
						flag2 = true;
					}
					if ((this.upgradeButton.transform.position - vector).magnitude < 1f)
					{
						Game.instance.upgradeAge();
					}
					if ((this.addTurretSlotButton.transform.position - vector).magnitude < 1f)
					{
						Game.instance.baseFriendly.addExpansion();
					}
				}
			}
			if (flag)
			{
				this.cancelButton.SetActive(false);
				this.cavemanGroup.SetActive(false);
				this.medievalGroup.SetActive(false);
				this.renaissanceGroup.SetActive(false);
				this.ww2Group.SetActive(false);
				this.futureGroup.SetActive(false);
				if (Game.instance.age == Game.AGE_CAVEMAN)
				{
					this.cavemanGroup.SetActive(true);
				}
				else if (Game.instance.age == Game.AGE_MEDIEVAL)
				{
					this.medievalGroup.SetActive(true);
				}
				else if (Game.instance.age == Game.AGE_RENAISSANCE)
				{
					this.renaissanceGroup.SetActive(true);
				}
				else if (Game.instance.age == Game.AGE_WW2)
				{
					this.ww2Group.SetActive(true);
				}
				else if (Game.instance.age == Game.AGE_FUTURE)
				{
					this.futureGroup.SetActive(true);
				}
			}
			if (flag2)
			{
				this.t_cavemanGroup.SetActive(false);
				this.t_medievalGroup.SetActive(false);
				this.t_renaissanceGroup.SetActive(false);
				this.t_ww2Group.SetActive(false);
				this.t_futureGroup.SetActive(false);
				if (Game.instance.age == Game.AGE_CAVEMAN)
				{
					this.t_cavemanGroup.SetActive(true);
				}
				else if (Game.instance.age == Game.AGE_MEDIEVAL)
				{
					this.t_medievalGroup.SetActive(true);
				}
				else if (Game.instance.age == Game.AGE_RENAISSANCE)
				{
					this.t_renaissanceGroup.SetActive(true);
				}
				else if (Game.instance.age == Game.AGE_WW2)
				{
					this.t_ww2Group.SetActive(true);
				}
				else if (Game.instance.age == Game.AGE_FUTURE)
				{
					this.t_futureGroup.SetActive(true);
				}
			}
		}
		else
		{
			this.top.SetActive(false);
			if (Input.GetMouseButtonDown(0) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
			{
				Vector3 vector2 = Input.mousePosition;
				if (Input.touchCount > 0)
				{
					vector2 = Input.GetTouch(0).position;
				}
				vector2 = Camera.main.ScreenToWorldPoint(vector2);
				vector2.z = 0f;
				if ((this.resumeButton.transform.position - vector2).magnitude < 1f)
				{
					Game.instance.IsPaused = false;
					AudioSource.PlayClipAtPoint(PrefabCache.buttonClip, Camera.main.transform.position);
				}
				if ((this.restartButton.transform.position - vector2).magnitude < 1f)
				{
					base.StartCoroutine(LoadingScreen.LoadLevel("Game"));
					AudioSource.PlayClipAtPoint(PrefabCache.buttonClip, Camera.main.transform.position);
				}
				if ((this.exitToMainMenuButton.transform.position - vector2).magnitude < 1f)
				{
					base.StartCoroutine(LoadingScreen.LoadLevel("MainMenu"));
					AudioSource.PlayClipAtPoint(PrefabCache.buttonClip, Camera.main.transform.position);
				}
			}
		}
	}

	// Token: 0x06000662 RID: 1634 RVA: 0x0001C4E8 File Offset: 0x0001A6E8
	private void backToRootMenu()
	{
		this.currentMenu = Hud.M_ROOT;
		this.isCancelMode = false;
		Game.instance.baseFriendly.disableSellMode();
		Game.instance.baseFriendly.disableBuildMode();
		this.currentMenu = Hud.M_ROOT;
		this.cancelButton.SetActive(false);
		this.backButton.SetActive(false);
		this.upgradeButton.SetActive(true);
		this.rootGroup.SetActive(true);
		this.backButton.SetActive(false);
		this.cavemanGroup.SetActive(false);
		this.medievalGroup.SetActive(false);
		this.renaissanceGroup.SetActive(false);
		this.ww2Group.SetActive(false);
		this.futureGroup.SetActive(false);
		this.t_cavemanGroup.SetActive(false);
		this.t_medievalGroup.SetActive(false);
		this.t_renaissanceGroup.SetActive(false);
		this.t_ww2Group.SetActive(false);
		this.t_futureGroup.SetActive(false);
	}

	// Token: 0x04000351 RID: 849
	public Game game;

	// Token: 0x04000352 RID: 850
	public TextMesh tipText;

	// Token: 0x04000353 RID: 851
	public GameObject top;

	// Token: 0x04000354 RID: 852
	public GameObject settingsButton;

	// Token: 0x04000355 RID: 853
	public GameObject upgradeButton;

	// Token: 0x04000356 RID: 854
	public GameObject backButton;

	// Token: 0x04000357 RID: 855
	public GameObject rootGroup;

	// Token: 0x04000358 RID: 856
	public GameObject cavemanGroup;

	// Token: 0x04000359 RID: 857
	public GameObject medievalGroup;

	// Token: 0x0400035A RID: 858
	public GameObject renaissanceGroup;

	// Token: 0x0400035B RID: 859
	public GameObject ww2Group;

	// Token: 0x0400035C RID: 860
	public GameObject futureGroup;

	// Token: 0x0400035D RID: 861
	public GameObject t_cavemanGroup;

	// Token: 0x0400035E RID: 862
	public GameObject t_medievalGroup;

	// Token: 0x0400035F RID: 863
	public GameObject t_renaissanceGroup;

	// Token: 0x04000360 RID: 864
	public GameObject t_ww2Group;

	// Token: 0x04000361 RID: 865
	public GameObject t_futureGroup;

	// Token: 0x04000362 RID: 866
	public GameObject clubmanButton;

	// Token: 0x04000363 RID: 867
	public GameObject slingshotButton;

	// Token: 0x04000364 RID: 868
	public GameObject dinoriderButton;

	// Token: 0x04000365 RID: 869
	public GameObject swordmanButton;

	// Token: 0x04000366 RID: 870
	public GameObject archerButton;

	// Token: 0x04000367 RID: 871
	public GameObject knightButton;

	// Token: 0x04000368 RID: 872
	public GameObject duelerButton;

	// Token: 0x04000369 RID: 873
	public GameObject mousquettereButton;

	// Token: 0x0400036A RID: 874
	public GameObject canoneerButton;

	// Token: 0x0400036B RID: 875
	public GameObject meleeInfantryButton;

	// Token: 0x0400036C RID: 876
	public GameObject infantryButton;

	// Token: 0x0400036D RID: 877
	public GameObject tankButton;

	// Token: 0x0400036E RID: 878
	public GameObject godsBladeButton;

	// Token: 0x0400036F RID: 879
	public GameObject blasterButton;

	// Token: 0x04000370 RID: 880
	public GameObject warMachineButton;

	// Token: 0x04000371 RID: 881
	public GameObject superSoldierButton;

	// Token: 0x04000372 RID: 882
	public GameObject unitsButton;

	// Token: 0x04000373 RID: 883
	public GameObject turretsButton;

	// Token: 0x04000374 RID: 884
	public GameObject sellTurretsButton;

	// Token: 0x04000375 RID: 885
	public GameObject addTurretSlotButton;

	// Token: 0x04000376 RID: 886
	public GameObject t_slingButton;

	// Token: 0x04000377 RID: 887
	public GameObject t_eggButton;

	// Token: 0x04000378 RID: 888
	public GameObject t_catapultButton;

	// Token: 0x04000379 RID: 889
	public GameObject t_betterCatapultButton;

	// Token: 0x0400037A RID: 890
	public GameObject t_fireCatapultButton;

	// Token: 0x0400037B RID: 891
	public GameObject t_oilButton;

	// Token: 0x0400037C RID: 892
	public GameObject t_smallCannonButton;

	// Token: 0x0400037D RID: 893
	public GameObject t_largeCannonButton;

	// Token: 0x0400037E RID: 894
	public GameObject t_explosivesCannonButton;

	// Token: 0x0400037F RID: 895
	public GameObject t_singleTurretButton;

	// Token: 0x04000380 RID: 896
	public GameObject t_rocketTurretButton;

	// Token: 0x04000381 RID: 897
	public GameObject t_doubleTurretButton;

	// Token: 0x04000382 RID: 898
	public GameObject t_titaniumShooterButton;

	// Token: 0x04000383 RID: 899
	public GameObject t_lazerCanonButton;

	// Token: 0x04000384 RID: 900
	public GameObject t_ionRayButton;

	// Token: 0x04000385 RID: 901
	public GameObject[] priceDisplays;

	// Token: 0x04000386 RID: 902
	public GameObject[] unitQueue;

	// Token: 0x04000387 RID: 903
	public GameObject progressBar;

	// Token: 0x04000388 RID: 904
	public GameObject specialButton;

	// Token: 0x04000389 RID: 905
	public SpriteRenderer specialTimer;

	// Token: 0x0400038A RID: 906
	public GameObject cancelButton;

	// Token: 0x0400038B RID: 907
	private float timeToEraseTip;

	// Token: 0x0400038C RID: 908
	private int currentMenu;

	// Token: 0x0400038D RID: 909
	public static int M_ROOT;

	// Token: 0x0400038E RID: 910
	public static int M_UNIT = 1;

	// Token: 0x0400038F RID: 911
	public static int M_TURRET = 2;

	// Token: 0x04000390 RID: 912
	public AudioClip buttonSound;

	// Token: 0x04000391 RID: 913
	public TextMesh coinText;

	// Token: 0x04000392 RID: 914
	public TextMesh expText;

	// Token: 0x04000393 RID: 915
	private ArrayList t_buttons;

	// Token: 0x04000394 RID: 916
	public ArrayList buttons;

	// Token: 0x04000395 RID: 917
	private int turretToBuildId = -1;

	// Token: 0x04000396 RID: 918
	public GameObject resumeButton;

	// Token: 0x04000397 RID: 919
	public GameObject restartButton;

	// Token: 0x04000398 RID: 920
	public GameObject exitToMainMenuButton;

	// Token: 0x04000399 RID: 921
	public GameObject endGameScreen;

	// Token: 0x0400039A RID: 922
	private bool isCancelMode;

	// Token: 0x020000E9 RID: 233
	public struct UnitButton
	{
		// Token: 0x06000663 RID: 1635 RVA: 0x0001C5E4 File Offset: 0x0001A7E4
		public UnitButton(GameObject button, int unitId, int age)
		{
			this.button = button;
			this.unitId = unitId;
			this.age = age;
		}

		// Token: 0x0400039B RID: 923
		public GameObject button;

		// Token: 0x0400039C RID: 924
		public int unitId;

		// Token: 0x0400039D RID: 925
		public int age;
	}
}
