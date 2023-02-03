using System;
using System.Collections;
using OnePF;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;

// Token: 0x020000EC RID: 236
public class MainMenu : MonoBehaviour
{
	// Token: 0x06000673 RID: 1651 RVA: 0x0001C9B4 File Offset: 0x0001ABB4
	private void Start()
	{
		this.googlePlayButton.SetActive(false);
		this.gamecenterButton.SetActive(false);
		this.loadingSplash.gameObject.SetActive(true);
		PrefabCache.init();
		MainMenu.instance = this;
		Time.timeScale = 1f;
		base.Invoke("setUpNewUnit", 1f);
		this.difficultySelect.SetActive(true);
		this.gameTypeSelect.SetActive(true);
		this.mainMenu.SetActive(true);
		this.credits.SetActive(true);
		this.achievementsMenu.SetActive(true);
		this.storeMenu.SetActive(true);
		GameState.init();
		this.googlePlayButton.SetActive(true);
		if (!MainMenu.hasActivatedSocialPlatform && !GameState.noMoreSocialLogin)
		{
			this.activateSocialPlatform();
		}
		else if (MainMenu.hasActivatedSocialPlatform)
		{
			this.googlePlayButton.SetActive(false);
			this.gamecenterButton.SetActive(false);
		}
		this.initAchievements();
		this.SetVisibility(this.gameTypeSelect.transform, -100f);
		this.SetVisibility(this.generalsSelect.transform, -100f);
		this.SetVisibility(this.difficultySelect.transform, -100f);
		this.SetVisibility(this.mainMenu.transform, 100f);
		this.SetVisibility(this.credits.transform, -100f);
		this.SetVisibility(this.achievementsMenu.transform, -100f);
		this.SetVisibility(this.storeMenu.transform, -100f);
		this.selectedGeneral = this.generals[0].button;
		foreach (MainMenu.GeneralData generalData in this.generals)
		{
			generalData.card.checkImage.enabled = false;
			generalData.card.lockImage.enabled = false;
		}
		this.UpdateHighlightedGeneral();
		if (MainMenu.loadGeneralsMenu)
		{
			this.switchToGeneralsSelect();
			MainMenu.loadGeneralsMenu = false;
		}
		this.StartGeneral(this.generals[0].button);
	}

	// Token: 0x06000674 RID: 1652 RVA: 0x0001CBCC File Offset: 0x0001ADCC
	public void activateSocialPlatform()
	{
		Social.localUser.Authenticate(new Action<bool>(this.ProcessAuthentication));
	}

	// Token: 0x06000675 RID: 1653 RVA: 0x0001CBE4 File Offset: 0x0001ADE4
	public void ProcessAuthentication(bool success)
	{
		if (success)
		{
			MainMenu.hasActivatedSocialPlatform = true;
			this.gamecenterButton.SetActive(false);
			GameState.noMoreSocialLogin = false;
			Debug.Log("Authenticated at start: " + Social.localUser.authenticated);
		}
		else
		{
			Debug.Log("Failed to authenticate");
			GameState.noMoreSocialLogin = true;
			GameState.save();
		}
	}

	// Token: 0x06000676 RID: 1654 RVA: 0x0001CC48 File Offset: 0x0001AE48
	private void AchievementsLoaded(IAchievementDescription[] achievements)
	{
		Debug.Log("Achievements loaded");
		foreach (IAchievementDescription achievementDescription in achievements)
		{
			Debug.Log("Achievement: " + achievementDescription.id + " " + achievementDescription.achievedDescription);
			foreach (GameState.Achievement achievement in GameState.achievements.Values)
			{
				if (achievement.playId == achievementDescription.id)
				{
					Debug.Log("Match");
				}
			}
		}
	}

	// Token: 0x06000677 RID: 1655 RVA: 0x0001CD14 File Offset: 0x0001AF14
	private void OnDestory()
	{
		foreach (GameState.Achievement achievement in GameState.achievements.Values)
		{
			achievement.menuImage = null;
			UnityEngine.Object.Destroy(achievement.menuImage);
			Resources.UnloadUnusedAssets();
		}
	}

	// Token: 0x06000678 RID: 1656 RVA: 0x0001CD90 File Offset: 0x0001AF90
	private void initAchievements()
	{
		int num = 0;
		float num2 = 0f;
		foreach (int num3 in GameState.achievements.Keys)
		{
			if (num == 0)
			{
				this.achievement.GetComponentsInChildren<Text>(true)[0].text = GameState.achievements[num3].name;
				this.achievement.GetComponentsInChildren<Image>(true)[0].sprite = this.achievements[num];
				GameState.achievements[num3].menuImage = this.achievement.GetComponentInChildren<Image>();
			}
			else
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.achievement);
				gameObject.transform.SetParent(this.achievementsCanvas.transform);
				float width = this.achievement.GetComponentsInChildren<Image>(true)[0].rectTransform.rect.width;
				gameObject.GetComponentInChildren<RectTransform>().localPosition = this.achievement.GetComponentInChildren<RectTransform>().localPosition + Vector3.right * width * 1.4f * (float)num;
				gameObject.GetComponentInChildren<Text>().text = GameState.achievements[num3].name;
				float x = this.achievement.GetComponentInChildren<RectTransform>().localPosition.x;
				num2 = gameObject.GetComponentInChildren<RectTransform>().localPosition.x - this.achievement.GetComponentInChildren<RectTransform>().localPosition.x;
				gameObject.GetComponentsInChildren<Image>(true)[0].sprite = this.achievements[num3];
				gameObject.GetComponentInChildren<RectTransform>().localScale = this.achievement.GetComponentInChildren<RectTransform>().localScale;
				if (GameState.achievements[num3].progress == 0f)
				{
					Color color = this.achievement.GetComponentInChildren<Image>().color;
					color.a = 0.2f;
					this.achievement.GetComponentInChildren<Image>().color = color;
				}
				GameState.achievements[num3].menuImage = gameObject.GetComponentInChildren<Image>();
			}
			num++;
		}
		float width2 = this.achievement.GetComponentInChildren<Image>().rectTransform.rect.width;
		this.achievementsCanvas.GetComponentInChildren<RectTransform>().sizeDelta = new Vector2(num2 + width2, 100f);
		this.achievementsCanvas.transform.position = new Vector3(num2 / 2f, this.achievementsCanvas.transform.position.y, 0f);
	}

	// Token: 0x06000679 RID: 1657 RVA: 0x0001D05C File Offset: 0x0001B25C
	public void switchToGameTypeSelect()
	{
		AudioSource.PlayClipAtPoint(PrefabCache.buttonClip, Camera.main.transform.position);
		this.menu = MainMenu.M_GAME_TYPE_SELECT;
		this.switchTime = Time.time;
		//GameState.analytics.LogScreen("Game Type Select");
	}

	// Token: 0x0600067A RID: 1658 RVA: 0x0001D0A8 File Offset: 0x0001B2A8
	public void switchToGeneralsSelect()
	{
		AudioSource.PlayClipAtPoint(PrefabCache.buttonClip, Camera.main.transform.position);
		this.generalsAudio.time = 0f;
		if (GameState.isGeneralsUnlocked)
		{
			this.menu = MainMenu.M_GENERALS_SELECT;
			this.switchTime = Time.time;
			//GameState.analytics.LogScreen("Generals Select");
		}
		else
		{
			OpenIAB.purchaseProduct("com.maxgames.ageofwar.generals", string.Empty);
		}
	}

	// Token: 0x0600067B RID: 1659 RVA: 0x0001D124 File Offset: 0x0001B324
	public void switchToDifficutlySelect()
	{
		AudioSource.PlayClipAtPoint(PrefabCache.buttonClip, Camera.main.transform.position);
		this.menu = MainMenu.M_DIFFICULTY;
		this.switchTime = Time.time;
		//GameState.analytics.LogScreen("Difficulty Select");
	}

	// Token: 0x0600067C RID: 1660 RVA: 0x0001D170 File Offset: 0x0001B370
	public void switchToStoreMenu()
	{
		AudioSource.PlayClipAtPoint(PrefabCache.buttonClip, Camera.main.transform.position);
		this.menu = MainMenu.M_STORE;
		this.switchTime = Time.time;
		//GameState.analytics.LogScreen("Store");
	}

	// Token: 0x0600067D RID: 1661 RVA: 0x0001D1BC File Offset: 0x0001B3BC
	public void switchToCredits()
	{
		AudioSource.PlayClipAtPoint(PrefabCache.buttonClip, Camera.main.transform.position);
		this.menu = MainMenu.M_CREDITS;
		this.switchTime = Time.time;
		AudioSource.PlayClipAtPoint(PrefabCache.buttonClip, Camera.main.transform.position);
		//GameState.analytics.LogScreen("Credits");
	}

	// Token: 0x0600067E RID: 1662 RVA: 0x0001D220 File Offset: 0x0001B420
	public void switchToMainMenu()
	{
		this.menu = MainMenu.M_MAIN;
		this.switchTime = Time.time;
		AudioSource.PlayClipAtPoint(PrefabCache.buttonClip, Camera.main.transform.position);
		//GameState.analytics.LogScreen("Main Menu");
	}

	// Token: 0x0600067F RID: 1663 RVA: 0x0001D26C File Offset: 0x0001B46C
	public void moreGames()
	{
		AudioSource.PlayClipAtPoint(PrefabCache.buttonClip, Camera.main.transform.position);
		Application.OpenURL("market://search?q=pub:Max%20Games%20Studios");
	}

	// Token: 0x06000680 RID: 1664 RVA: 0x0001D294 File Offset: 0x0001B494
	public void returnToMainMenuButton()
	{
		if (this.menu == MainMenu.M_GENERALS_SELECT)
		{
			this.switchToGameTypeSelect();
		}
		else if (this.menu == MainMenu.M_DIFFICULTY)
		{
			this.switchToGameTypeSelect();
		}
		else
		{
			this.switchToMainMenu();
		}
	}

	// Token: 0x06000681 RID: 1665 RVA: 0x0001D2E0 File Offset: 0x0001B4E0
	public void switchToAchievements()
	{
		//GameState.analytics.LogScreen("Achievements");
		if (Social.localUser.authenticated)
		{
			Social.ShowAchievementsUI();
		}
		else
		{
			this.menu = MainMenu.M_ACHIEVEMENTS;
			this.switchTime = Time.time;
			AudioSource.PlayClipAtPoint(PrefabCache.buttonClip, Camera.main.transform.position);
		}
	}

	// Token: 0x06000682 RID: 1666 RVA: 0x0001D344 File Offset: 0x0001B544
	private void setAlpha(Transform transform, float alpha)
	{
		if (transform.GetComponent<Renderer>())
		{
			Color color = transform.GetComponent<Renderer>().material.color;
			color.a += alpha * Time.deltaTime;
			color.a = Mathf.Clamp01(color.a);
			transform.GetComponent<Renderer>().material.color = color;
		}
		else if (transform.gameObject.GetComponent<Image>())
		{
			Color color2 = transform.gameObject.GetComponent<Image>().color;
			color2.a += alpha * Time.deltaTime;
			color2.a = Mathf.Clamp01(color2.a);
			transform.gameObject.GetComponent<Image>().color = color2;
		}
		else if (transform.gameObject.GetComponent<Text>())
		{
			Color color3 = transform.gameObject.GetComponent<Text>().color;
			color3.a += alpha * Time.deltaTime;
			color3.a = Mathf.Clamp01(color3.a);
			transform.gameObject.GetComponent<Text>().color = color3;
		}
		for (int i = 0; i < transform.childCount; i++)
		{
			Transform child = transform.GetChild(i);
			this.setAlpha(child, alpha);
		}
	}

	// Token: 0x06000683 RID: 1667 RVA: 0x0001D49C File Offset: 0x0001B69C
	private void setUpNewUnit()
	{
		GameObject original = PrefabCache.prefabs[this.index];
		this.currentUnit = UnityEngine.Object.Instantiate<GameObject>(original);
		this.currentUnit.GetComponent<Unit>().enabled = false;
		Collider2D componentInChildren = this.currentUnit.GetComponentInChildren<Collider2D>();
		this.currentUnit.transform.position = new Vector3(Camera.main.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x - 1f, Game.GROUND_LEVEL, 5f);
		this.lastUnitChange = (double)Time.time;
		this.units.Add(this.currentUnit);
		this.index = (this.index + 1) % 15;
		base.Invoke("setUpNewUnit", 7f);
	}

	// Token: 0x06000684 RID: 1668 RVA: 0x0001D56C File Offset: 0x0001B76C
	public void BackButton()
	{
	}

	// Token: 0x06000685 RID: 1669 RVA: 0x0001D570 File Offset: 0x0001B770
	private void SetVisibility(Transform transform, float value)
	{
		if (value < 0f)
		{
			transform.gameObject.SetActive(false);
		}
		else
		{
			transform.gameObject.SetActive(true);
		}
	}

	// Token: 0x06000686 RID: 1670 RVA: 0x0001D5A8 File Offset: 0x0001B7A8
	private string getScreenNameFromName(string name)
	{
		foreach (MainMenu.GeneralData generalData in this.generals)
		{
			if (generalData.name == name)
			{
				return generalData.screenName;
			}
		}
		return string.Empty;
	}

	// Token: 0x06000687 RID: 1671 RVA: 0x0001D5F4 File Offset: 0x0001B7F4
	private void Update()
	{
		this.googlePlayButton.SetActive(!Social.localUser.authenticated);
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			this.returnToMainMenuButton();
		}
		foreach (MainMenu.GeneralData generalData in this.generals)
		{
			if (generalData.button == this.selectedGeneral)
			{
				this.playGeneralsButton.gameObject.SetActive(GameState.isAllUnlocked || generalData.requires == string.Empty || GameState.generalsCompleted.ContainsKey(generalData.requires));
				this.mustDefeatText.gameObject.SetActive(!GameState.isAllUnlocked && !(generalData.requires == string.Empty) && !GameState.generalsCompleted.ContainsKey(generalData.requires));
				this.mustDefeatText.text = "Must defeat " + this.getScreenNameFromName(generalData.requires) + " to unlock";
				this.selectedGeneralImage.rectTransform.position = generalData.button.image.rectTransform.position;
			}
			if (GameState.generalsCompleted.ContainsKey(generalData.name))
			{
				generalData.button.image.sprite = generalData.card.profile;
				generalData.card.lockImage.enabled = false;
				generalData.card.checkImage.enabled = true;
			}
			else if (!GameState.isAllUnlocked && generalData.requires != string.Empty && !GameState.generalsCompleted.ContainsKey(generalData.requires))
			{
				generalData.button.image.sprite = generalData.card.profileLocked;
				generalData.card.lockImage.enabled = true;
				generalData.card.checkImage.enabled = false;
			}
			else
			{
				generalData.button.image.sprite = generalData.card.profile;
				generalData.card.lockImage.enabled = false;
				generalData.card.checkImage.enabled = false;
			}
		}
		float num = Time.time - this.switchTime;
		num = 4f;
		if (this.menu == MainMenu.M_GENERALS_SELECT)
		{
			this.forestAudio.volume = Mathf.Lerp(this.forestAudio.volume, 0f, 0.03f);
			this.generalsAudio.volume = Mathf.Lerp(this.generalsAudio.volume, 1f, 0.03f);
		}
		else
		{
			this.forestAudio.volume = Mathf.Lerp(this.forestAudio.volume, 1f, 0.03f);
			this.generalsAudio.volume = Mathf.Lerp(this.generalsAudio.volume, 0f, 0.03f);
		}
		this.returnButtonCanvas.gameObject.SetActive(this.menu != MainMenu.M_MAIN);
		this.gameModifiersCanvas.gameObject.SetActive(this.menu == MainMenu.M_DIFFICULTY || this.menu == MainMenu.M_GENERALS_SELECT);
		if (this.isLoading)
		{
			this.isLoading = false;
			this.loadingSplash.gameObject.SetActive(false);
		}
		else if (this.menu == MainMenu.M_MAIN)
		{
			this.loadingSplash.gameObject.SetActive(false);
			this.SetVisibility(this.difficultySelect.transform, -num);
			this.SetVisibility(this.mainMenu.transform, num);
			this.SetVisibility(this.credits.transform, -num);
			this.SetVisibility(this.achievementsMenu.transform, -num);
			this.SetVisibility(this.storeMenu.transform, -num);
			this.SetVisibility(this.gameTypeSelect.transform, -num);
			this.SetVisibility(this.generalsSelect.transform, -num);
		}
		else if (this.menu == MainMenu.M_GENERALS_SELECT)
		{
			this.SetVisibility(this.generalsSelect.transform, num);
			this.SetVisibility(this.gameTypeSelect.transform, -num);
			this.SetVisibility(this.difficultySelect.transform, -num);
			this.SetVisibility(this.mainMenu.transform, -num);
			this.SetVisibility(this.credits.transform, -num);
			this.SetVisibility(this.achievementsMenu.transform, -num);
			this.SetVisibility(this.storeMenu.transform, -num);
		}
		else if (this.menu == MainMenu.M_GAME_TYPE_SELECT)
		{
			this.SetVisibility(this.generalsSelect.transform, -num);
			this.SetVisibility(this.gameTypeSelect.transform, num);
			this.SetVisibility(this.difficultySelect.transform, -num);
			this.SetVisibility(this.mainMenu.transform, -num);
			this.SetVisibility(this.credits.transform, -num);
			this.SetVisibility(this.achievementsMenu.transform, -num);
			this.SetVisibility(this.storeMenu.transform, -num);
		}
		else if (this.menu == MainMenu.M_DIFFICULTY)
		{
			this.SetVisibility(this.generalsSelect.transform, -num);
			this.SetVisibility(this.difficultySelect.transform, num);
			this.SetVisibility(this.mainMenu.transform, -num);
			this.SetVisibility(this.credits.transform, -num);
			this.SetVisibility(this.achievementsMenu.transform, -num);
			this.SetVisibility(this.storeMenu.transform, -num);
			this.SetVisibility(this.gameTypeSelect.transform, -num);
		}
		else if (this.menu == MainMenu.M_CREDITS)
		{
			this.SetVisibility(this.generalsSelect.transform, -num);
			this.SetVisibility(this.difficultySelect.transform, -num);
			this.SetVisibility(this.mainMenu.transform, -num);
			this.SetVisibility(this.credits.transform, num);
			this.SetVisibility(this.achievementsMenu.transform, -num);
			this.SetVisibility(this.storeMenu.transform, -num);
			this.SetVisibility(this.gameTypeSelect.transform, -num);
		}
		else if (this.menu == MainMenu.M_ACHIEVEMENTS)
		{
			this.SetVisibility(this.generalsSelect.transform, -num);
			this.SetVisibility(this.difficultySelect.transform, -num);
			this.SetVisibility(this.mainMenu.transform, -num);
			this.SetVisibility(this.credits.transform, -num);
			this.SetVisibility(this.achievementsMenu.transform, num);
			this.SetVisibility(this.storeMenu.transform, -num);
			this.SetVisibility(this.gameTypeSelect.transform, -num);
			Color color = new Color(1f, 1f, 1f, 1f);
			foreach (int key in GameState.achievements.Keys)
			{
				if (GameState.achievements[key].progress == 1f)
				{
					color.a = 1f;
					GameState.achievements[key].menuImage.color = color;
				}
				else
				{
					color.a = 0.2f;
					GameState.achievements[key].menuImage.color = color;
				}
			}
		}
		else if (this.menu == MainMenu.M_STORE)
		{
			this.SetVisibility(this.generalsSelect.transform, -num);
			this.SetVisibility(this.difficultySelect.transform, -num);
			this.SetVisibility(this.mainMenu.transform, -num);
			this.SetVisibility(this.credits.transform, -num);
			this.SetVisibility(this.achievementsMenu.transform, -num);
			this.SetVisibility(this.storeMenu.transform, num);
			this.SetVisibility(this.gameTypeSelect.transform, -num);
		}
		foreach (object obj in this.units)
		{
			GameObject gameObject = (GameObject)obj;
			if (gameObject.GetComponentInChildren<SkeletonAnimation>() != null)
			{
				if (gameObject.GetComponentInChildren<SkeletonAnimation>().state.GetCurrent(0).animation.name != gameObject.GetComponent<UnitSpine>().walkAnimation)
				{
					gameObject.GetComponentInChildren<SkeletonAnimation>().state.SetAnimation(0, gameObject.GetComponent<UnitSpine>().walkAnimation, true);
				}
				gameObject.GetComponentInChildren<SkeletonAnimation>().Update(Time.deltaTime);
			}
			else
			{
				gameObject.GetComponentInChildren<Animator>().Play("Walk");
			}
			gameObject.transform.Translate(new Vector3(0.7f * Game.P2U * Time.deltaTime * 40f, 0f));
			if (Camera.main.WorldToScreenPoint(gameObject.GetComponent<Collider2D>().bounds.min).x > (float)Screen.width)
			{
				UnityEngine.Object.Destroy(gameObject);
				this.toRemove.Add(gameObject);
			}
		}
		foreach (object obj2 in this.toRemove)
		{
			GameObject obj3 = (GameObject)obj2;
			this.units.Remove(obj3);
		}
		this.toRemove.Clear();
		if (this.menu == MainMenu.M_STORE)
		{
			if (GameState.isHackUnlocked)
			{
				this.hackedBuyButton.SetActive(false);
				this.hackedTick.SetActive(true);
			}
			else
			{
				this.hackedBuyButton.SetActive(true);
				this.hackedTick.SetActive(false);
			}
			if (GameState.isSoundtrackUnlocked)
			{
				this.soundtrackBuyButton.SetActive(false);
				this.soundtrackTick.SetActive(true);
			}
			else
			{
				this.soundtrackBuyButton.SetActive(true);
				this.soundtrackTick.SetActive(false);
			}
			if (GameState.isGeneralsUnlocked)
			{
				this.generalsBuyButton.SetActive(false);
				this.generalsTick.SetActive(true);
			}
			else
			{
				this.generalsBuyButton.SetActive(true);
				this.generalsTick.SetActive(false);
			}
		}
		this.gameTypeSelectGeneralsLocked.SetActive(!GameState.isGeneralsUnlocked);
		if (this.menu == MainMenu.M_MAIN || this.menu == MainMenu.M_CREDITS)
		{
		}
		this.hackedLock.SetActive(!GameState.isHackUnlocked);
		this.hackedBox.SetActive(GameState.isHackUnlocked);
		this.hackedModeCheck.SetActive(false);
		if (Game.isHack)
		{
			this.hackedModeCheck.SetActive(true);
			this.hackedLock.SetActive(false);
			this.hackedBox.SetActive(true);
		}
		else
		{
			this.hackedModeCheck.SetActive(false);
		}
		this.soundtrackLock.SetActive(!GameState.isSoundtrackUnlocked);
		this.soundtrackBox.SetActive(GameState.isSoundtrackUnlocked);
		this.gloriousMorning2Check.SetActive(false);
		if (Game.isSoundtrack)
		{
			this.gloriousMorning2Check.SetActive(true);
			this.soundtrackBox.SetActive(true);
			this.soundtrackLock.SetActive(false);
		}
		else
		{
			this.gloriousMorning2Check.SetActive(false);
		}
		Camera.main.transform.position = new Vector3(0f, 0f, Camera.main.transform.position.z);
		if (Input.GetMouseButtonDown(0) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
		{
			this.touchBeganMenu = this.menu;
		}
		if (Input.GetMouseButtonUp(0) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended))
		{
			Vector3 vector = Input.mousePosition;
			if (Input.touchCount > 0)
			{
				vector = Input.GetTouch(0).position;
			}
			vector = Camera.main.ScreenToWorldPoint(vector);
			if (this.menu == MainMenu.M_STORE)
			{
				if (!GameState.isHackUnlocked)
				{
					vector.z = this.hackedBuyButton.transform.position.z;
					if (this.hackedBuyButton.GetComponent<Renderer>().bounds.Contains(vector))
					{
						Debug.Log("Try to puchase hacked mode");
						OpenIAB.purchaseProduct("com.maxgames.ageofwar.hacked", string.Empty);
						AudioSource.PlayClipAtPoint(PrefabCache.buttonClip, Camera.main.transform.position);
					}
				}
				if (!GameState.isGeneralsUnlocked)
				{
					vector.z = this.hackedBuyButton.transform.position.z;
					if (this.generalsBuyButton.GetComponent<Renderer>().bounds.Contains(vector))
					{
						Debug.Log("Try to puchase generals mode");
						OpenIAB.purchaseProduct("com.maxgames.ageofwar.generals", string.Empty);
						AudioSource.PlayClipAtPoint(PrefabCache.buttonClip, Camera.main.transform.position);
					}
				}
				if (!GameState.isSoundtrackUnlocked)
				{
					vector.z = this.soundtrackBuyButton.transform.position.z;
					if (this.soundtrackBuyButton.GetComponent<Renderer>().bounds.Contains(vector))
					{
						Debug.Log("Try to puchase soundtrack");
						OpenIAB.purchaseProduct("com.maxgames.ageofwar.soundtrack", string.Empty);
						AudioSource.PlayClipAtPoint(PrefabCache.buttonClip, Camera.main.transform.position);
					}
				}
			}
		}
	}

	// Token: 0x06000688 RID: 1672 RVA: 0x0001E490 File Offset: 0x0001C690
	public void StartGame()
	{
		AudioSource.PlayClipAtPoint(PrefabCache.buttonClip, Camera.main.transform.position);
		Game.currentGeneral = string.Empty;
		GameState.enemyAi = new EnemyAi(null);
		GameState.enemyProfileSprite = null;
		base.StartCoroutine(LoadingScreen.LoadLevel("Game"));
		this.difficultySelect.SetActive(false);
	}

	// Token: 0x06000689 RID: 1673 RVA: 0x0001E4F0 File Offset: 0x0001C6F0
	public void NormalGame()
	{
		Game.difficulty = Game.D_NORMAL;
		//GameState.analytics.LogScreen("Loading Normal");
		this.StartGame();
	}

	// Token: 0x0600068A RID: 1674 RVA: 0x0001E514 File Offset: 0x0001C714
	public void HardGame()
	{
		Game.difficulty = Game.D_HARDER;
		//GameState.analytics.LogScreen("Loading Hard");
		this.StartGame();
	}

	// Token: 0x0600068B RID: 1675 RVA: 0x0001E538 File Offset: 0x0001C738
	public void ImpossibleGame()
	{
		Game.difficulty = Game.D_IMPOSSIBLE;
		//GameState.analytics.LogScreen("Loading Impossilbe");
		this.StartGame();
	}

	// Token: 0x0600068C RID: 1676 RVA: 0x0001E55C File Offset: 0x0001C75C
	public void hackedToggle()
	{
		if (GameState.isHackUnlocked || Game.isHack)
		{
			Game.isHack = !Game.isHack;
			AudioSource.PlayClipAtPoint(PrefabCache.buttonClip, Camera.main.transform.position);
		}
	}

	// Token: 0x0600068D RID: 1677 RVA: 0x0001E5A4 File Offset: 0x0001C7A4
	public void soundtrackToggle()
	{
		if (GameState.isSoundtrackUnlocked)
		{
			Game.isSoundtrack = !Game.isSoundtrack;
			AudioSource.PlayClipAtPoint(PrefabCache.buttonClip, Camera.main.transform.position);
		}
	}

	// Token: 0x0600068E RID: 1678 RVA: 0x0001E5E4 File Offset: 0x0001C7E4
	public void StartGeneral(Button button)
	{
		AudioSource.PlayClipAtPoint(PrefabCache.buttonClip, Camera.main.transform.position);
		foreach (MainMenu.GeneralData generalData in this.generals)
		{
			if (generalData.button == button)
			{
				this.generalDescription.text = generalData.description;
				this.generalName.text = generalData.screenName;
				this.selectedGeneral = generalData.button;
				//GameState.analytics.LogEvent("General", "Start", this.generalName.text, 0L);
				this.UpdateHighlightedGeneral();
			}
		}
	}

	// Token: 0x0600068F RID: 1679 RVA: 0x0001E690 File Offset: 0x0001C890
	public void LoadEngineWithGeneral()
	{
		AudioSource.PlayClipAtPoint(PrefabCache.buttonClip, Camera.main.transform.position);
		foreach (MainMenu.GeneralData generalData in this.generals)
		{
			if (generalData.button == this.selectedGeneral)
			{
				GameState.enemyProfileSprite = generalData.card.profile;
				Game.generalData = generalData;
				Game.currentGeneral = generalData.name;
				if (generalData.name == "Caveman")
				{
					Debug.Log("Loading Caveman Ai");
					Game.difficulty = Game.D_NORMAL;
					GameState.enemyAi = new CavemanAi(null);
					generalData.achievmentId = GameState.A_G_BROM;
				}
				else if (generalData.name == "Stalin")
				{
					Debug.Log("Loading Stalin Ai");
					Game.difficulty = Game.D_HARDER;
					GameState.enemyAi = new StalinAi(null);
					generalData.achievmentId = GameState.A_G_STALIN;
				}
				else if (generalData.name == "Caesar")
				{
					Debug.Log("Loading Caesar Ai");
					Game.difficulty = Game.D_NORMAL;
					GameState.enemyAi = new CaesarAi(null);
					generalData.achievmentId = GameState.A_G_CEASER;
				}
				else if (generalData.name == "Khan")
				{
					Debug.Log("Loading Khan Ai");
					Game.difficulty = Game.D_HARDER;
					GameState.enemyAi = new KhanAi(null);
					generalData.achievmentId = GameState.A_G_KHAN;
				}
				else if (generalData.name == "Napoleon")
				{
					Debug.Log("Loading Napoleon Ai");
					Game.difficulty = Game.D_HARDER;
					GameState.enemyAi = new NapoleonAi(null);
					generalData.achievmentId = GameState.A_G_LEON;
				}
				else if (generalData.name == "Tzu")
				{
					Debug.Log("Loading Tzu Ai");
					Game.difficulty = Game.D_NORMAL;
					GameState.enemyAi = new TzuAi(null);
					generalData.achievmentId = GameState.A_G_TZU;
				}
				else if (generalData.name == "Hitler")
				{
					Debug.Log("Loading Hitler Ai");
					Game.difficulty = Game.D_HARDER;
					GameState.enemyAi = new HitlerAi(null);
					generalData.achievmentId = GameState.A_G_HITLER;
				}
				else if (generalData.name == "Alexander")
				{
					Debug.Log("Loading Alexander Ai");
					Game.difficulty = Game.D_NORMAL;
					GameState.enemyAi = new AlexanderAi(null);
					generalData.achievmentId = GameState.A_G_ALEX;
				}
				else if (generalData.name == "Ramses")
				{
					Debug.Log("Loading Ramses Ai");
					Game.difficulty = Game.D_NORMAL;
					GameState.enemyAi = new RamsesAi(null);
					generalData.achievmentId = GameState.A_G_RAMSES;
				}
				else if (generalData.name == "Robot")
				{
					Debug.Log("Loading Robot Ai");
					Game.difficulty = Game.D_IMPOSSIBLE;
					GameState.enemyAi = new RobotAi(null);
					generalData.achievmentId = GameState.A_G_ROBOT;
				}
				else
				{
					GameState.enemyAi = new EnemyAi(null);
				}
				base.StartCoroutine(LoadingScreen.LoadLevel("Game"));
			}
		}
	}

	// Token: 0x06000690 RID: 1680 RVA: 0x0001E9D0 File Offset: 0x0001CBD0
	private void UpdateHighlightedGeneral()
	{
		foreach (MainMenu.GeneralData generalData in this.generals)
		{
			ColorBlock colors = generalData.button.colors;
			if (generalData.button == this.selectedGeneral)
			{
				this.selectedGeneralImage.rectTransform.position = generalData.button.image.rectTransform.position;
			}
		}
	}

	// Token: 0x06000691 RID: 1681 RVA: 0x0001EA48 File Offset: 0x0001CC48
	public void RestoreTransactions()
	{
		Debug.Log("Restore transactions");
		OpenIAB.restoreTransactions();
	}

	// Token: 0x040003A7 RID: 935
	private double lastUnitChange;

	// Token: 0x040003A8 RID: 936
	private bool isLoading = true;

	// Token: 0x040003A9 RID: 937
	private GameObject currentUnit;

	// Token: 0x040003AA RID: 938
	public static bool loadGeneralsMenu;

	// Token: 0x040003AB RID: 939
	public AudioSource forestAudio;

	// Token: 0x040003AC RID: 940
	public AudioSource generalsAudio;

	// Token: 0x040003AD RID: 941
	public static MainMenu instance;

	// Token: 0x040003AE RID: 942
	public GameObject normalButton;

	// Token: 0x040003AF RID: 943
	public GameObject harderButton;

	// Token: 0x040003B0 RID: 944
	public GameObject impossibleButton;

	// Token: 0x040003B1 RID: 945
	public GameObject mainMenuButton;

	// Token: 0x040003B2 RID: 946
	public GameObject creditsReturnButton;

	// Token: 0x040003B3 RID: 947
	public static bool hasActivatedSocialPlatform;

	// Token: 0x040003B4 RID: 948
	public GameObject mainMenu;

	// Token: 0x040003B5 RID: 949
	public GameObject difficultySelect;

	// Token: 0x040003B6 RID: 950
	public GameObject loadingSplash;

	// Token: 0x040003B7 RID: 951
	public GameObject gameTypeSelect;

	// Token: 0x040003B8 RID: 952
	public GameObject generalsSelect;

	// Token: 0x040003B9 RID: 953
	public GameObject credits;

	// Token: 0x040003BA RID: 954
	public GameObject hackedModeCheck;

	// Token: 0x040003BB RID: 955
	public GameObject gloriousMorning2Check;

	// Token: 0x040003BC RID: 956
	public GameObject gloriusButton;

	// Token: 0x040003BD RID: 957
	public GameObject hackedButton;

	// Token: 0x040003BE RID: 958
	public GameObject achievementsMenu;

	// Token: 0x040003BF RID: 959
	public GameObject achievement;

	// Token: 0x040003C0 RID: 960
	public GameObject achievementsCanvas;

	// Token: 0x040003C1 RID: 961
	public GameObject storeMenu;

	// Token: 0x040003C2 RID: 962
	public GameObject storeCanvas;

	// Token: 0x040003C3 RID: 963
	public GameObject returnButtonCanvas;

	// Token: 0x040003C4 RID: 964
	public GameObject gameModifiersCanvas;

	// Token: 0x040003C5 RID: 965
	public Sprite[] achievements;

	// Token: 0x040003C6 RID: 966
	public GameObject googlePlayButton;

	// Token: 0x040003C7 RID: 967
	public GameObject gamecenterButton;

	// Token: 0x040003C8 RID: 968
	public Material unitMaterial;

	// Token: 0x040003C9 RID: 969
	public GameObject hackedBuyButton;

	// Token: 0x040003CA RID: 970
	public GameObject soundtrackBuyButton;

	// Token: 0x040003CB RID: 971
	public GameObject generalsBuyButton;

	// Token: 0x040003CC RID: 972
	public GameObject generalsTick;

	// Token: 0x040003CD RID: 973
	public GameObject hackedTick;

	// Token: 0x040003CE RID: 974
	public GameObject soundtrackTick;

	// Token: 0x040003CF RID: 975
	public GameObject hackedLock;

	// Token: 0x040003D0 RID: 976
	public GameObject soundtrackLock;

	// Token: 0x040003D1 RID: 977
	public GameObject hackedBox;

	// Token: 0x040003D2 RID: 978
	public GameObject soundtrackBox;

	// Token: 0x040003D3 RID: 979
	public GameObject gameTypeSelectGeneralsLocked;

	// Token: 0x040003D4 RID: 980
	public Text mustDefeatText;

	// Token: 0x040003D5 RID: 981
	public MainMenu.GeneralData[] generals;

	// Token: 0x040003D6 RID: 982
	public Text generalDescription;

	// Token: 0x040003D7 RID: 983
	public Text generalName;

	// Token: 0x040003D8 RID: 984
	public Button selectedGeneral;

	// Token: 0x040003D9 RID: 985
	private int index;

	// Token: 0x040003DA RID: 986
	public static int M_MAIN;

	// Token: 0x040003DB RID: 987
	public static int M_DIFFICULTY = 1;

	// Token: 0x040003DC RID: 988
	public static int M_CREDITS = 2;

	// Token: 0x040003DD RID: 989
	public static int M_ACHIEVEMENTS = 3;

	// Token: 0x040003DE RID: 990
	public static int M_STORE = 4;

	// Token: 0x040003DF RID: 991
	public static int M_GAME_TYPE_SELECT = 5;

	// Token: 0x040003E0 RID: 992
	public static int M_GENERALS_SELECT = 6;

	// Token: 0x040003E1 RID: 993
	public Button playGeneralsButton;

	// Token: 0x040003E2 RID: 994
	public Image selectedGeneralImage;

	// Token: 0x040003E3 RID: 995
	private int touchBeganMenu;

	// Token: 0x040003E4 RID: 996
	public int menu = MainMenu.M_MAIN;

	// Token: 0x040003E5 RID: 997
	private float switchTime = -100f;

	// Token: 0x040003E6 RID: 998
	private ArrayList toRemove = new ArrayList();

	// Token: 0x040003E7 RID: 999
	private ArrayList units = new ArrayList();

	// Token: 0x020000ED RID: 237
	[Serializable]
	public class GeneralData
	{
		// Token: 0x040003E8 RID: 1000
		public string name;

		// Token: 0x040003E9 RID: 1001
		public string screenName;

		// Token: 0x040003EA RID: 1002
		[Multiline]
		public string description;

		// Token: 0x040003EB RID: 1003
		public Button button;

		// Token: 0x040003EC RID: 1004
		public GeneralCard card;

		// Token: 0x040003ED RID: 1005
		public string requires;

		// Token: 0x040003EE RID: 1006
		public string saying;

		// Token: 0x040003EF RID: 1007
		public string superQuote;

		// Token: 0x040003F0 RID: 1008
		public string superQuote2;

		// Token: 0x040003F1 RID: 1009
		public string superQuote3 = "Hahahahahahaha!";

		// Token: 0x040003F2 RID: 1010
		public string losingQuote;

		// Token: 0x040003F3 RID: 1011
		public string winingQuote;

		// Token: 0x040003F4 RID: 1012
		public int achievmentId;
	}
}
