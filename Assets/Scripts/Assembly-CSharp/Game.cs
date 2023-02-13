using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000D5 RID: 213
public class Game : MonoBehaviour
{
	// Token: 0x17000061 RID: 97
	// (get) Token: 0x060005FA RID: 1530 RVA: 0x00012A78 File Offset: 0x00010C78
	public float TopOfTheScreen
	{
		get
		{
			return this.topOfTheScreen;
		}
	}

	// Token: 0x17000062 RID: 98
	// (get) Token: 0x060005FB RID: 1531 RVA: 0x00012A80 File Offset: 0x00010C80
	// (set) Token: 0x060005FC RID: 1532 RVA: 0x00012A88 File Offset: 0x00010C88
	public int Coins
	{
		get
		{
			return this.coins;
		}
		set
		{
			this.coins = value;
		}
	}

	// Token: 0x17000063 RID: 99
	// (get) Token: 0x060005FD RID: 1533 RVA: 0x00012A94 File Offset: 0x00010C94
	// (set) Token: 0x060005FE RID: 1534 RVA: 0x00012A9C File Offset: 0x00010C9C
	public int Exp
	{
		get
		{
			return this.exp;
		}
		set
		{
			this.exp = value;
		}
	}

	// Token: 0x17000064 RID: 100
	// (get) Token: 0x060005FF RID: 1535 RVA: 0x00012AA8 File Offset: 0x00010CA8
	// (set) Token: 0x06000600 RID: 1536 RVA: 0x00012AB0 File Offset: 0x00010CB0
	public int E_coins
	{
		get
		{
			return this.e_coins;
		}
		set
		{
			this.e_coins = value;
		}
	}

	// Token: 0x17000065 RID: 101
	// (get) Token: 0x06000601 RID: 1537 RVA: 0x00012ABC File Offset: 0x00010CBC
	// (set) Token: 0x06000602 RID: 1538 RVA: 0x00012AC4 File Offset: 0x00010CC4
	public int NumGlobalSpellsUsed
	{
		get
		{
			return this.numGlobalSpellsUsed;
		}
		set
		{
			this.numGlobalSpellsUsed = value;
		}
	}

	// Token: 0x06000603 RID: 1539 RVA: 0x00012AD0 File Offset: 0x00010CD0
	private void Start()
	{
		this.hasShownWiningImage = false;
		this.hasShownLosingImage = false;
		this.isGameOver = false;
		Time.timeScale = 1f;
		this.isPaused = false;
		Game.instance = this;
		this.currentId = 0;
		Game.units = new ArrayList();
		this.baseFriendly.Id = this.currentId++;
		this.baseEnemy.Id = this.currentId++;
		Game.units.Add(this.baseFriendly);
		Game.units.Add(this.baseEnemy);
		this.enemyAi = GameState.enemyAi;
		if (this.enemyAi == null)
		{
			Application.LoadLevel("MainMenu");
			return;
		}
		this.enemyAi.game = this;
		this.enemyAi.init();
		this.numGlobalSpellsUsed = 0;
		GameState.init();
		PrefabCache.init();
		this.frame = 0;
		this.topOfTheScreen = Camera.main.ScreenToWorldPoint(new Vector3(0f, (float)Screen.height, 0f)).y;
		this.lastCameraShakeTime = -Game.CAMERA_SHAKE_LENGTH;
		this.cameraPosition = Camera.main.transform.position;
		Game.LEVEL_LENGTH = Game.instance.baseEnemy.GetComponent<Collider2D>().bounds.center.x - Game.instance.baseFriendly.GetComponent<Collider2D>().bounds.center.x;
		this.canvasHud.pauseMenu.gameObject.SetActive(false);
		this.canvasHud.topOfHud.SetActive(true);
		//GameState.analytics.LogScreen("Game");
		base.GetComponent<AudioSource>().enabled = true;
		if (Game.isSoundtrack)
		{
			base.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>("Music/glorious2");
			base.GetComponent<AudioSource>().volume = 1.3f;
		}
		if (base.GetComponent<AudioSource>().enabled)
		{
			base.GetComponent<AudioSource>().Play();
		}
		this.achievementsToShow = new ArrayList();
		this.achievementPopDownOrigin = this.achievementPopdown.transform.position;
		this.achievementPopdown.transform.position = new Vector3(this.achievementPopdown.transform.position.x, (float)(Screen.height + 100), 0f);
		this.updateVolumeControl();
		if (GameState.enemyProfileSprite == null)
		{
			this.enemyProfile.gameObject.SetActive(false);
		}
		else
		{
			this.enemyProfile.gameObject.SetActive(true);
			this.enemyProfile.sprite = GameState.enemyProfileSprite;
			this.enemyProfileSuperFlashing.sprite = GameState.enemyProfileSprite;
		}
		this.enemyProfileSuperFlashing.gameObject.SetActive(false);
		this.canvasHud.generalMessage.SetActive(false);
		if (Game.currentGeneral != string.Empty)
		{
			base.Invoke("ShowWelcomeMessage", 1.5f);
			base.GetComponentInChildren<AudioSource>().Stop();
		}
	}

	// Token: 0x06000604 RID: 1540 RVA: 0x00012DFC File Offset: 0x00010FFC
	public void SpawnGold()
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(PrefabCache.GoldDrop);
	}

	// Token: 0x06000605 RID: 1541 RVA: 0x00012E14 File Offset: 0x00011014
	public void SpawnExp()
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(PrefabCache.ExpDrop);
	}

	// Token: 0x06000606 RID: 1542 RVA: 0x00012E2C File Offset: 0x0001102C
	public void toggleSound(int value)
	{
		GameState.toggleSound(value + 1);
	}

	// Token: 0x06000607 RID: 1543 RVA: 0x00012E38 File Offset: 0x00011038
	public void ShowEnemyLosingMessage()
	{
		if (!this.hasShownLosingImage)
		{
			this.hasShownLosingImage = true;
			this.ShowGeneralMessage(Game.generalData.winingQuote);
		}
	}

	// Token: 0x06000608 RID: 1544 RVA: 0x00012E68 File Offset: 0x00011068
	public void ShowEnemyWinningMessage()
	{
		if (!this.hasShownWiningImage)
		{
			this.hasShownWiningImage = true;
			this.ShowGeneralMessage(Game.generalData.losingQuote);
		}
	}

	// Token: 0x06000609 RID: 1545 RVA: 0x00012E98 File Offset: 0x00011098
	public void ShowSuperMessage()
	{
		float value = UnityEngine.Random.value;
		if (value < 0.33f)
		{
			this.ShowGeneralMessage(Game.generalData.superQuote);
		}
		else if (value < 0.66f)
		{
			this.ShowGeneralMessage(Game.generalData.superQuote2);
		}
		else
		{
			this.ShowGeneralMessage(Game.generalData.superQuote3);
		}
	}

	// Token: 0x0600060A RID: 1546 RVA: 0x00012EFC File Offset: 0x000110FC
	public void ShowWelcomeMessage()
	{
		AudioSource.PlayClipAtPoint(this.dramaticRevealSound, Vector3.zero, 1.5f);
		base.GetComponentInChildren<AudioSource>().PlayDelayed(4f);
		this.ShowGeneralMessage(Game.generalData.saying);
	}

	// Token: 0x0600060B RID: 1547 RVA: 0x00012F40 File Offset: 0x00011140
	public void ShowGeneralMessage(string message)
	{
		this.canvasHud.generalMessage.SetActive(true);
		this.canvasHud.generalMessage.GetComponentInChildren<Text>().text = message;
		foreach (Image image in this.canvasHud.generalMessage.GetComponentsInChildren<Image>())
		{
			if (image.gameObject.name == "EnemyProfile")
			{
				image.sprite = GameState.enemyProfileSprite;
			}
		}
		base.Invoke("HideGeneralMessage", 6.5f);
	}

	// Token: 0x0600060C RID: 1548 RVA: 0x00012FD4 File Offset: 0x000111D4
	public void HideGeneralMessage()
	{
		this.canvasHud.generalMessage.SetActive(false);
	}

	// Token: 0x0600060D RID: 1549 RVA: 0x00012FE8 File Offset: 0x000111E8
	public void updateVolumeControl()
	{
		if (GameState.volumeControl == GameState.V_OFF)
		{
			AudioListener.volume = 0f;
		}
		else if (GameState.volumeControl == GameState.V_ON)
		{
			AudioListener.volume = 1f;
			base.GetComponent<AudioSource>().enabled = true;
			base.GetComponent<AudioSource>().Play();
		}
		else
		{
			AudioListener.volume = 1f;
			base.GetComponent<AudioSource>().enabled = false;
		}
		this.musicOffButton.SetActive(false);
		this.soundOnButton.SetActive(false);
		this.soundOffButton.SetActive(false);
		if (GameState.volumeControl == GameState.V_OFF)
		{
			this.soundOffButton.SetActive(true);
		}
		else if (GameState.volumeControl == GameState.V_ON)
		{
			this.soundOnButton.SetActive(true);
		}
		else if (GameState.volumeControl == GameState.V_NO_MUSIC)
		{
			this.musicOffButton.SetActive(true);
		}
	}

	// Token: 0x0600060E RID: 1550 RVA: 0x000130E0 File Offset: 0x000112E0
	public void addAchievementToShow(string achievement)
	{
		this.achievementsToShow.Add(achievement);
	}

	// Token: 0x0600060F RID: 1551 RVA: 0x000130F0 File Offset: 0x000112F0
	public static GameObject prefabFromType(int type)
	{
		return PrefabCache.prefabs[type];
	}

	// Token: 0x06000610 RID: 1552 RVA: 0x000130FC File Offset: 0x000112FC
	public void queueUnit(int type, int team)
	{
		if (this.unitProductionQueue.Count >= 5)
		{
			this.canvasHud.showTip("Your production queue is full", 2f);
			return;
		}
		if (Game.instance.unitData[type].cost <= this.coins || Game.isHack)
		{
			if (!Game.isHack)
			{
				this.coins -= Game.instance.unitData[type].cost;
			}
			Game.QueuedUnit queuedUnit = default(Game.QueuedUnit);
			queuedUnit.unitType = type;
			queuedUnit.buildTime = (float)Game.instance.unitData[type].buildTime / 40f;
			queuedUnit.timeQueued = 0f;
			this.unitProductionQueue.Add(queuedUnit);
		}
		else
		{
			this.canvasHud.showTip("You need more coins to train this unit", 2f);
		}
	}

	// Token: 0x06000611 RID: 1553 RVA: 0x000131F4 File Offset: 0x000113F4
	public void spawnUnit(int type, int team)
	{
		GameObject original = Game.prefabFromType(type);
		Vector3 position = new Vector3(this.baseFriendly.GetComponent<Collider2D>().bounds.max.x - 0.2f, Game.GROUND_LEVEL, 0f);
		if (team == Unit.T_BAD)
		{
			position = new Vector3(this.baseEnemy.GetComponent<Collider2D>().bounds.min.x + 0.2f, Game.GROUND_LEVEL, 0f);
		}
		GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(original, position, Quaternion.identity);
		float num = Game.GROUND_LEVEL - gameObject.GetComponent<Collider2D>().bounds.min.y;
		gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + num, gameObject.transform.position.z);
		gameObject.GetComponent<Unit>().team = team;
		Game.units.Add(gameObject.GetComponent<Unit>());
		gameObject.GetComponent<Unit>().Id = this.currentId;
		gameObject.name = "Unit_" + this.currentId;
		gameObject.GetComponent<Unit>().typeId = type;
		this.currentId++;
		if (team == Unit.T_GOOD)
		{
			if (type % 3 == 1 || type == 15)
			{
				this.rangedUnitsBuilt++;
			}
			else
			{
				this.meeleUnitsBuild++;
			}
			GameState.unitsBuilt[type] = true;
			if (GameState.unitsBuilt.Count == 16)
			{
				GameState.unlockAchievement(GameState.A_BUILD_EVERY_UNIT);
			}
			this.numFriendlyUnits = 0;
			foreach (object obj in Game.units)
			{
				Unit unit = (Unit)obj;
				if (unit.team == 0)
				{
					this.numFriendlyUnits++;
				}
			}
			if (this.numFriendlyUnits >= 10)
			{
				GameState.unlockAchievement(GameState.A_ATTACK_10);
			}
			if (type == 15)
			{
				GameState.unlockAchievement(GameState.A_FIRST_SUPER);
			}
		}
	}

	// Token: 0x06000612 RID: 1554 RVA: 0x00013480 File Offset: 0x00011680
	private void Update()
	{
		if (Time.time - this.lastAchievementShowTime > 5f)
		{
			if (this.achievementsToShow != null && this.achievementsToShow.Count > 0)
			{
				string text = (string)this.achievementsToShow[0];
				this.achievementsToShow.RemoveAt(0);
				this.achievementPopdown.GetComponentsInChildren<Text>(true)[0].text = text;
				this.achievementPopdown.GetComponent<AudioSource>().Play();
				this.lastAchievementShowTime = Time.time;
			}
		}
		else if (Time.time - this.lastAchievementShowTime > 3f)
		{
			Vector3 to = new Vector3(this.achievementPopDownOrigin.x, (float)(Screen.height + 100), 0f);
			this.achievementPopdown.transform.position = Vector3.Lerp(this.achievementPopdown.transform.position, to, 0.1f);
		}
		else
		{
			this.achievementPopdown.transform.position = Vector3.Lerp(this.achievementPopdown.transform.position, this.achievementPopDownOrigin, 0.1f);
		}
		if (Game.currentGeneral != string.Empty)
		{
			if (this.baseEnemy.health / this.baseEnemy.MaxHealth < 0.4f)
			{
				this.ShowEnemyLosingMessage();
			}
			if (this.baseFriendly.health / this.baseFriendly.MaxHealth < 0.4f)
			{
				this.ShowEnemyWinningMessage();
			}
		}
		if (this.isGameOver && Time.time - this.gameOverTime > 1.5f && !this.pressedAfterGameOverMenu && this.canvasHud.victoryMenu.gameObject.activeInHierarchy && (Input.GetMouseButtonDown(0) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)))
		{
			this.pressedAfterGameOverMenu = true;
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
		}
		if (Game.instance.IsPaused || this.isGameOver)
		{
			return;
		}
		if (this.baseFriendly.health <= 0f || this.baseEnemy.health <= 0f)
		{
			GameState.save();
			this.isGameOver = true;
			this.gameOverTime = Time.time;
			this.canvasHud.topOfHud.SetActive(false);
			if (this.baseFriendly.health > 0f)
			{
				base.GetComponentInChildren<AudioSource>().Stop();
				AudioSource.PlayClipAtPoint(this.victorySound, Vector3.zero, 1.5f);
				this.canvasHud.victoryMenu.gameObject.SetActive(true);
				this.canvasHud.victoryProfile.sprite = null;
				this.canvasHud.victoryProfile.sprite = GameState.enemyProfileSprite;
				if (Game.generalData != null)
				{
					this.canvasHud.vicotoryName.text = Game.generalData.screenName;
					GameState.unlockAchievement(Game.generalData.achievmentId);
					GameState.analytics.LogEvent("General", "Finish", Game.generalData.screenName, 0L);
				}
				this.enemyProfile.gameObject.SetActive(false);
				if (this.rangedUnitsBuilt == 0)
				{
					GameState.unlockAchievement(GameState.A_ONLY_MEELE);
				}
				if (this.meeleUnitsBuild == 0)
				{
					GameState.unlockAchievement(GameState.A_ONLY_RANGED);
				}
				if (Game.instance.NumGlobalSpellsUsed == 0)
				{
					GameState.unlockAchievement(GameState.A_NO_SPELLS);
				}
				if (Game.difficulty == Game.D_NORMAL)
				{
					GameState.unlockAchievement(GameState.A_FINISH_ON_NORMAL);
					if (this.canvasHud.victoryProfile.sprite == null)
					{
						this.canvasHud.victoryProfile.sprite = this.normalImage;
						this.canvasHud.vicotoryName.text = "Normal";
					}
				}
				else if (Game.difficulty == Game.D_HARDER)
				{
					GameState.unlockAchievement(GameState.A_FINISH_ON_HARD);
					if (this.canvasHud.victoryProfile.sprite == null)
					{
						this.canvasHud.victoryProfile.sprite = this.harderImage;
						this.canvasHud.vicotoryName.text = "Harder";
					}
				}
				else if (Game.difficulty == Game.D_IMPOSSIBLE)
				{
					GameState.unlockAchievement(GameState.A_FINISH_ON_IMPOSSIBLE);
					if (this.canvasHud.victoryProfile.sprite == null)
					{
						this.canvasHud.victoryProfile.sprite = this.impossibleImage;
						this.canvasHud.vicotoryName.text = "Impossible";
					}
				}
				GameState.generalsCompleted[Game.currentGeneral] = 1;
				GameState.save();
				if (this.age == 3)
				{
					GameState.unlockAchievement(GameState.A_MODERN_AGE_WIN);
				}
				this.fireworks = UnityEngine.Object.Instantiate<GameObject>((GameObject)Resources.Load("Fireworks Launcher"));
				this.fireworks.transform.position = new Vector3(Camera.main.transform.position.x, this.fireworks.transform.position.y, 0f);
			}
			else
			{
				this.canvasHud.defeatMenu.gameObject.SetActive(true);
				GameState.analytics.LogScreen("Defeat");
				GameState.analytics.LogEvent("General", "Defeat", Game.generalData.screenName, 0L);
			}
		}
	}

	// Token: 0x06000613 RID: 1555 RVA: 0x00013A78 File Offset: 0x00011C78
	public bool upgradeAge()
	{
		if (this.age == Game.AGE_FUTURE)
		{
			this.canvasHud.showTip("Already at the final age!", 2f);
			return false;
		}
		if (this.exp > Base.ageRequirements[this.age + 1] || Game.isHack)
		{
			if (this.age == Game.AGE_FUTURE - 1)
			{
				AudioSource.PlayClipAtPoint(PrefabCache.finalUpgrade, Camera.main.transform.position);
			}
			else
			{
				AudioSource.PlayClipAtPoint(this.upgradeAgeSound, Camera.main.transform.position);
			}
			//GameState.analytics.LogEvent("Game", "Age", string.Empty + this.age, 1L);
			this.age++;
			this.baseFriendly.UpgradeAge();
			this.canvasHud.specialButtonImage.sprite = this.specialsSprites[this.age];
			this.canvasHud.switchToMenu(CanvasHud.M_ROOT);
			return true;
		}
		this.canvasHud.showTip(Base.ageRequirements[this.age + 1] + " experience required to upgrade to the next age!", 2f);
		return false;
	}

	// Token: 0x06000614 RID: 1556 RVA: 0x00013BBC File Offset: 0x00011DBC
	private void FixedUpdate()
	{
		if (this.isPaused || this.isGameOver)
		{
			return;
		}
		this.cameraVelocity.x = this.cameraVelocity.x * 0.945f;
		if (this.enemyAi != null)
		{
			this.baseEnemy.age = this.enemyAi.techLevel - 1;
			this.enemyAi.update();
		}
		if (Game.currentGeneral != string.Empty)
		{
			if (this.frame % 600 == 0)
			{
				this.SpawnGold();
			}
			else if ((this.frame + 300) % 600 == 0)
			{
				this.SpawnExp();
			}
		}
		this.frame++;
	}

	// Token: 0x06000615 RID: 1557 RVA: 0x00013C80 File Offset: 0x00011E80
	private void LateUpdate()
	{
		if (this.isPaused || this.isGameOver)
		{
			this.enemyProfileSuperFlashing.gameObject.SetActive(false);
			return;
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
			this.unitSelected = null;
			foreach (object obj in Game.units)
			{
				Unit unit = (Unit)obj;
				if (unit.GetComponentInChildren<Collider2D>().bounds.Contains(vector) && !(unit is Base))
				{
					this.unitSelected = unit;
				}
			}
		}
		if (this.unitSelected == null)
		{
			this.healthBar.SetActive(false);
		}
		else if (!this.unitSelected.isAlive())
		{
			this.unitSelected = null;
		}
		else
		{
			this.healthBar.SetActive(true);
			this.healthBarBar.transform.localScale = new Vector3(this.unitSelected.health / this.unitSelected.MaxHealth * 1.5f, this.healthBarBar.transform.localScale.y, this.healthBarBar.transform.localScale.z);
			this.healthBar.transform.position = new Vector3(this.unitSelected.GetComponentInChildren<Collider2D>().bounds.center.x, this.unitSelected.GetComponentInChildren<Collider2D>().bounds.max.y + 0.2f, 0f);
		}
		if (Game.isHack)
		{
			this.canvasHud.coinsText.text = "∞";
			this.canvasHud.expText.text = "∞";
		}
		else
		{
			this.canvasHud.coinsText.text = string.Empty + this.coins;
			this.canvasHud.expText.text = string.Empty + this.exp;
		}
		if (this.canvasHud.isBuildingTurret() || this.canvasHud.isSellingTurret())
		{
			this.cameraVelocity = Vector2.Lerp(this.cameraVelocity, new Vector2(-12f / Time.deltaTime * 0.03f, 0f), 0.2f);
		}
		else if (Input.touchCount > 0)
		{
			Touch touch = Input.GetTouch(0);
			Vector3 vector2 = Camera.main.ScreenToWorldPoint(new Vector3(touch.deltaPosition.x, 0f, 0f)) - Camera.main.ScreenToWorldPoint(new Vector3(0f, 0f, 0f));
			if (Time.deltaTime != 0f && touch.position.y < (float)Screen.height * 0.8f)
			{
				if (touch.phase != TouchPhase.Ended)
				{
					Vector3 position = touch.deltaPosition;
					position = Camera.main.ScreenToWorldPoint(position) - Camera.main.ScreenToWorldPoint(Vector3.zero);
					if (touch.deltaTime != 0f)
					{
						this.cameraVelocity = Vector2.Lerp(this.cameraVelocity, new Vector2(-position.x / touch.deltaTime, 0f), 0.5f);
					}
				}
				else
				{
					Vector3 position2 = touch.deltaPosition;
					position2 = Camera.main.ScreenToWorldPoint(position2) - Camera.main.ScreenToWorldPoint(Vector3.zero);
					if (touch.deltaTime != 0f)
					{
						this.cameraVelocity = Vector2.Lerp(this.cameraVelocity, new Vector2(-position2.x / touch.deltaTime, 0f), 0.1f);
					}
				}
			}
		}
		else if (!Application.isMobilePlatform && Input.mousePosition.y < (float)Screen.height * 0.68f)
		{
			if (Input.mousePosition.x > (float)Screen.width * 0.9f)
			{
				this.cameraVelocity = Vector2.Lerp(this.cameraVelocity, new Vector2(10f, 0f), 0.5f);
			}
			if (Input.mousePosition.x < (float)Screen.width * 0.1f)
			{
				this.cameraVelocity = Vector2.Lerp(this.cameraVelocity, new Vector2(-10f, 0f), 0.5f);
			}
		}
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			this.cameraVelocity.x = this.cameraVelocity.x + -1f;
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			this.cameraVelocity.x = this.cameraVelocity.x + 1f;
		}
		Camera.main.transform.position = this.cameraPosition + new Vector3(this.cameraVelocity.x, this.cameraVelocity.y, 0f) * Time.smoothDeltaTime;
		Vector3 vector3 = Camera.main.ScreenToWorldPoint(new Vector3(0f, 0f, 0f));
		Vector3 vector4 = Camera.main.ScreenToWorldPoint(new Vector3((float)Screen.width, 0f, 0f));
		float num = this.baseFriendly.GetComponentInChildren<Collider2D>().bounds.min.x + this.baseFriendly.GetComponentInChildren<Collider2D>().bounds.extents.x * 0.125f;
		if (num - this.cameraVelocity.x * Time.deltaTime > vector3.x)
		{
			Camera.main.transform.position = new Vector3(num + Camera.main.orthographicSize * Camera.main.aspect, this.cameraPosition.y, -10f);
			this.cameraVelocity = Vector2.zero;
		}
		float num2 = this.baseEnemy.GetComponentInChildren<Collider2D>().bounds.max.x - this.baseEnemy.GetComponentInChildren<Collider2D>().bounds.extents.x * 0.125f;
		if (num2 - this.cameraVelocity.x * Time.deltaTime < vector4.x)
		{
			Camera.main.transform.position = new Vector3(num2 - Camera.main.orthographicSize * Camera.main.aspect, this.cameraPosition.y, -10f);
			this.cameraVelocity = Vector2.zero;
		}
		this.cameraPosition = Camera.main.transform.position;
		if (Time.time - this.lastCameraShakeTime < Game.CAMERA_SHAKE_LENGTH)
		{
			Camera.main.transform.position = this.cameraPosition + UnityEngine.Random.insideUnitSphere / 20f;
		}
		Vector3 localScale = this.canvasHud.fill.rectTransform.localScale;
		localScale.x = 0f;
		this.canvasHud.fill.rectTransform.localScale = localScale;
		if (this.unitProductionQueue.Count > 0)
		{
			Game.QueuedUnit queuedUnit = (Game.QueuedUnit)this.unitProductionQueue[0];
			if (queuedUnit.timeQueued > queuedUnit.buildTime || Game.isHack)
			{
				this.spawnUnit(queuedUnit.unitType, Unit.T_GOOD);
				Game.QueuedUnit queuedUnit2 = (Game.QueuedUnit)this.unitProductionQueue[0];
				this.unitProductionQueue.RemoveAt(0);
				if (this.unitProductionQueue.Count > 0)
				{
					queuedUnit = (Game.QueuedUnit)this.unitProductionQueue[0];
					queuedUnit.timeQueued = 0f;
					this.unitProductionQueue[0] = queuedUnit;
				}
			}
			else
			{
				this.canvasHud.buildText.text = "Training " + this.unitData[queuedUnit.unitType].name;
				queuedUnit.timeQueued += Time.deltaTime;
				this.unitProductionQueue[0] = queuedUnit;
				localScale.x = queuedUnit.timeQueued / queuedUnit.buildTime;
				this.canvasHud.fill.rectTransform.localScale = localScale;
			}
		}
		else
		{
			this.canvasHud.buildText.text = string.Empty;
		}
		for (int i = 0; i < 5; i++)
		{
			if (this.unitProductionQueue.Count > i)
			{
				Game.QueuedUnit queuedUnit3 = (Game.QueuedUnit)this.unitProductionQueue[i];
				this.canvasHud.queueSprites[i].sprite = this.canvasHud.queueUnitSprites[queuedUnit3.unitType];
			}
			else
			{
				this.canvasHud.queueSprites[i].sprite = this.canvasHud.box;
			}
		}
		if (LoadingScreen.instance)
		{
			LoadingScreen.instance.fixToCamera();
		}
	}

	// Token: 0x06000616 RID: 1558 RVA: 0x00014690 File Offset: 0x00012890
	public void shakeCamera()
	{
		this.lastCameraShakeTime = Time.time;
	}

	// Token: 0x17000066 RID: 102
	// (get) Token: 0x06000617 RID: 1559 RVA: 0x000146A0 File Offset: 0x000128A0
	// (set) Token: 0x06000618 RID: 1560 RVA: 0x000146A8 File Offset: 0x000128A8
	public bool IsPaused
	{
		get
		{
			return this.isPaused;
		}
		set
		{
			this.canvasHud.pauseMenu.gameObject.SetActive(value);
			this.canvasHud.topOfHud.SetActive(!value);
			this.isPaused = value;
			if (this.isPaused)
			{
			}
		}
	}

	// Token: 0x040002A4 RID: 676
	public SpriteRenderer enemyProfile;

	// Token: 0x040002A5 RID: 677
	public Image enemyProfileSuperFlashing;

	// Token: 0x040002A6 RID: 678
	private int coins = 175;

	// Token: 0x040002A7 RID: 679
	private int e_coins = 175;

	// Token: 0x040002A8 RID: 680
	private int exp;

	// Token: 0x040002A9 RID: 681
	public static float GROUND_LEVEL = -3.85f;

	// Token: 0x040002AA RID: 682
	public static float LEVEL_LENGTH = 20f;

	// Token: 0x040002AB RID: 683
	private float topOfTheScreen;

	// Token: 0x040002AC RID: 684
	private Vector3 cameraPosition = Vector3.zero;

	// Token: 0x040002AD RID: 685
	private static float CAMERA_SHAKE_LENGTH = 1f;

	// Token: 0x040002AE RID: 686
	private float lastCameraShakeTime = float.MinValue;

	// Token: 0x040002AF RID: 687
	private bool isPaused;

	// Token: 0x040002B0 RID: 688
	public static int difficulty;

	// Token: 0x040002B1 RID: 689
	public static string currentGeneral = string.Empty;

	// Token: 0x040002B2 RID: 690
	public static MainMenu.GeneralData generalData;

	// Token: 0x040002B3 RID: 691
	public static bool isHack;

	// Token: 0x040002B4 RID: 692
	public static bool isSoundtrack;

	// Token: 0x040002B5 RID: 693
	public static int D_NORMAL;

	// Token: 0x040002B6 RID: 694
	public static int D_HARDER = 1;

	// Token: 0x040002B7 RID: 695
	public static int D_IMPOSSIBLE = 2;

	// Token: 0x040002B8 RID: 696
	private bool pressedAfterGameOverMenu;

	// Token: 0x040002B9 RID: 697
	public int numFriendlyUnits;

	// Token: 0x040002BA RID: 698
	private GameObject fireworks;

	// Token: 0x040002BB RID: 699
	private bool attackedWithMoreThan10;

	// Token: 0x040002BC RID: 700
	private int rangedUnitsBuilt;

	// Token: 0x040002BD RID: 701
	private int meeleUnitsBuild;

	// Token: 0x040002BE RID: 702
	private ArrayList achievementsToShow;

	// Token: 0x040002BF RID: 703
	private float lastAchievementShowTime = -1000f;

	// Token: 0x040002C0 RID: 704
	private Vector3 achievementPopDownOrigin;

	// Token: 0x040002C1 RID: 705
	public AudioClip upgradeAgeSound;

	// Token: 0x040002C2 RID: 706
	public AudioClip victorySound;

	// Token: 0x040002C3 RID: 707
	public AudioClip dramaticRevealSound;

	// Token: 0x040002C4 RID: 708
	public Sprite normalImage;

	// Token: 0x040002C5 RID: 709
	public Sprite harderImage;

	// Token: 0x040002C6 RID: 710
	public Sprite impossibleImage;

	// Token: 0x040002C7 RID: 711
	public static float P2U = 0.025f;

	// Token: 0x040002C8 RID: 712
	public static int AGE_CAVEMAN;

	// Token: 0x040002C9 RID: 713
	public static int AGE_MEDIEVAL = 1;

	// Token: 0x040002CA RID: 714
	public static int AGE_RENAISSANCE = 2;

	// Token: 0x040002CB RID: 715
	public static int AGE_WW2 = 3;

	// Token: 0x040002CC RID: 716
	public static int AGE_FUTURE = 4;

	// Token: 0x040002CD RID: 717
	public int age = Game.AGE_CAVEMAN;

	// Token: 0x040002CE RID: 718
	public GameObject healthBar;

	// Token: 0x040002CF RID: 719
	public GameObject healthBarBar;

	// Token: 0x040002D0 RID: 720
	public GameObject background;

	// Token: 0x040002D1 RID: 721
	public Base baseFriendly;

	// Token: 0x040002D2 RID: 722
	public Base baseEnemy;

	// Token: 0x040002D3 RID: 723
	public Hud hud;

	// Token: 0x040002D4 RID: 724
	public CanvasHud canvasHud;

	// Token: 0x040002D5 RID: 725
	public ParticleSystem blood;

	// Token: 0x040002D6 RID: 726
	public static ArrayList units;

	// Token: 0x040002D7 RID: 727
	public Game.TurretData[] turrets;

	// Token: 0x040002D8 RID: 728
	private int frame;

	// Token: 0x040002D9 RID: 729
	private float gameOverTime;

	// Token: 0x040002DA RID: 730
	public GameObject[] bullets;

	// Token: 0x040002DB RID: 731
	public Sprite[] specialsSprites;

	// Token: 0x040002DC RID: 732
	public bool specialH;

	// Token: 0x040002DD RID: 733
	private int currentId;

	// Token: 0x040002DE RID: 734
	public static Game instance;

	// Token: 0x040002DF RID: 735
	public EnemyAi enemyAi;

	// Token: 0x040002E0 RID: 736
	public static GameObject[] prefabs;

	// Token: 0x040002E1 RID: 737
	private Unit unitSelected;

	// Token: 0x040002E2 RID: 738
	private ArrayList unitProductionQueue = new ArrayList();

	// Token: 0x040002E3 RID: 739
	public bool isGameOver;

	// Token: 0x040002E4 RID: 740
	private Vector2 cameraVelocity;

	// Token: 0x040002E5 RID: 741
	public static float EFFECT_VOLUME = 0.6f;

	// Token: 0x040002E6 RID: 742
	public GameObject achievementPopdown;

	// Token: 0x040002E7 RID: 743
	private int numGlobalSpellsUsed;

	// Token: 0x040002E8 RID: 744
	private bool hasShownLosingImage;

	// Token: 0x040002E9 RID: 745
	private bool hasShownWiningImage;

	// Token: 0x040002EA RID: 746
	public Game.UnitData[] unitData = new Game.UnitData[]
	{
		new Game.UnitData("Clubman", 15, 40),
		new Game.UnitData("Slingshot Man", 25, 40),
		new Game.UnitData("Dino Rider", 100, 100),
		new Game.UnitData("Swordman", 50, 70),
		new Game.UnitData("Archer", 75, 50),
		new Game.UnitData("Knight", 500, 100),
		new Game.UnitData("Dueler", 200, 100),
		new Game.UnitData("Mousquettere", 400, 100),
		new Game.UnitData("Canoneer", 1000, 200),
		new Game.UnitData("Melee Infantry", 1500, 100),
		new Game.UnitData("Infantry", 2000, 100),
		new Game.UnitData("Tank", 7000, 300),
		new Game.UnitData("God's Blade", 5000, 100),
		new Game.UnitData("Blaster", 6000, 100),
		new Game.UnitData("War Machine", 20000, 300),
		new Game.UnitData("Super Solider", 150000, 100)
	};

	// Token: 0x040002EB RID: 747
	public GameObject musicOffButton;

	// Token: 0x040002EC RID: 748
	public GameObject soundOffButton;

	// Token: 0x040002ED RID: 749
	public GameObject soundOnButton;

	// Token: 0x020000D6 RID: 214
	private struct QueuedUnit
	{
		// Token: 0x040002EE RID: 750
		public int unitType;

		// Token: 0x040002EF RID: 751
		public float timeQueued;

		// Token: 0x040002F0 RID: 752
		public float buildTime;

		// Token: 0x040002F1 RID: 753
		public GameObject queueImage;
	}

	// Token: 0x020000D7 RID: 215
	[Serializable]
	public struct TurretData
	{
		// Token: 0x040002F2 RID: 754
		public int shotSpeed;

		// Token: 0x040002F3 RID: 755
		public int bulletId;

		// Token: 0x040002F4 RID: 756
		public int damage;

		// Token: 0x040002F5 RID: 757
		public int range;

		// Token: 0x040002F6 RID: 758
		public string name;

		// Token: 0x040002F7 RID: 759
		public int cost;

		// Token: 0x040002F8 RID: 760
		public int unknown;

		// Token: 0x040002F9 RID: 761
		public AudioClip clip;

		// Token: 0x040002FA RID: 762
		public GameObject prefab;
	}

	// Token: 0x020000D8 RID: 216
	public struct UnitData
	{
		// Token: 0x06000619 RID: 1561 RVA: 0x000146F8 File Offset: 0x000128F8
		public UnitData(string name, int cost, int buildTime)
		{
			this.name = name;
			this.cost = cost;
			this.buildTime = buildTime;
		}

		// Token: 0x040002FB RID: 763
		public string name;

		// Token: 0x040002FC RID: 764
		public int cost;

		// Token: 0x040002FD RID: 765
		public int buildTime;
	}
}
