using System;
using System.Collections.Generic;
using OnePF;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000DA RID: 218
public class GameState
{
	// Token: 0x0600061D RID: 1565 RVA: 0x000147D4 File Offset: 0x000129D4
	private static void OnBillingSupportedEvent()
	{
		
	}

	// Token: 0x0600061E RID: 1566 RVA: 0x00014804 File Offset: 0x00012A04
	private static void OnBillingNotSupportedEvent(string obj)
	{
		Debug.Log("Billing not supported");
	}

	// Token: 0x0600061F RID: 1567 RVA: 0x00014810 File Offset: 0x00012A10
	private static void OnQueryInventorySucceededEvent(Inventory obj)
	{
		
	}

	// Token: 0x06000620 RID: 1568 RVA: 0x000149D4 File Offset: 0x00012BD4
	private static void OnQueryInventoryFailedEvent(string obj)
	{
	}

	// Token: 0x06000621 RID: 1569 RVA: 0x000149D8 File Offset: 0x00012BD8
	private static void OnPurchaseSucceededEvent(Purchase purchase)
	{
		
	}

	// Token: 0x06000622 RID: 1570 RVA: 0x00014AB4 File Offset: 0x00012CB4
	private static void OnPurchaseFailedEvent(int arg1, string arg2)
	{
		
	}

	// Token: 0x06000623 RID: 1571 RVA: 0x00014AE4 File Offset: 0x00012CE4
	private static void OnConsumeSucceededEvent(Purchase obj)
	{
	}

	// Token: 0x06000624 RID: 1572 RVA: 0x00014AE8 File Offset: 0x00012CE8
	private static void OnConsumeFailedEvent(string obj)
	{
	}

	// Token: 0x06000625 RID: 1573 RVA: 0x00014AEC File Offset: 0x00012CEC
	public static void initPayments()
	{
		
	}

	// Token: 0x06000626 RID: 1574 RVA: 0x00014C14 File Offset: 0x00012E14
	public static void init()
	{
		if (GameState.achievements != null)
		{
			return;
		}
		Debug.Log("INIT");
		GameState.generalsCompleted = new Dictionary<string, int>();
		GameState.initPayments();
		//GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("GAv3"));
		//GameState.analytics = gameObject.GetComponent<GoogleAnalyticsV3>();
		//UnityEngine.Object.DontDestroyOnLoad(gameObject);
		GameState.unitsBuilt = new Dictionary<int, bool>();
		GameState.turretsBuilt = new Dictionary<int, bool>();
		GameState.achievements = new Dictionary<int, GameState.Achievement>();
		GameState.achievements[GameState.A_FINISH_ON_IMPOSSIBLE] = new GameState.Achievement(GameState.A_FINISH_ON_IMPOSSIBLE, "Finish on Impossible", null, "CgkIuLudmpkHEAIQAQ", string.Empty);
		GameState.achievements[GameState.A_FINISH_ON_HARD] = new GameState.Achievement(GameState.A_FINISH_ON_HARD, "Finish on Hard", null, "CgkIuLudmpkHEAIQAg", string.Empty);
		GameState.achievements[GameState.A_FINISH_ON_NORMAL] = new GameState.Achievement(GameState.A_FINISH_ON_NORMAL, "Finish on Normal", null, "CgkIuLudmpkHEAIQAw", string.Empty);
		GameState.achievements[GameState.A_ATTACK_10] = new GameState.Achievement(GameState.A_ATTACK_10, "Attack with 10 or more units at once", null, "CgkIuLudmpkHEAIQBA", string.Empty);
		GameState.achievements[GameState.A_ONLY_RANGED] = new GameState.Achievement(GameState.A_ONLY_RANGED, "Win with only ranged units", null, "CgkIuLudmpkHEAIQBQ", string.Empty);
		GameState.achievements[GameState.A_ONLY_MEELE] = new GameState.Achievement(GameState.A_ONLY_MEELE, "Win with only meele units", null, "CgkIuLudmpkHEAIQBg", string.Empty);
		GameState.achievements[GameState.A_SELL_TURRET] = new GameState.Achievement(GameState.A_SELL_TURRET, "Sell a turret", null, "CgkIuLudmpkHEAIQBw", string.Empty);
		GameState.achievements[GameState.A_ALL_SLOTS] = new GameState.Achievement(GameState.A_ALL_SLOTS, "Buy and fill all turret spots", null, "CgkIuLudmpkHEAIQCA", string.Empty);
		GameState.achievements[GameState.A_SUPER_KILL_CAVEMAN] = new GameState.Achievement(GameState.A_SUPER_KILL_CAVEMAN, "Kill Caveman with Super Soldier", null, "CgkIuLudmpkHEAIQCg", string.Empty);
		GameState.achievements[GameState.A_FIRST_SUPER] = new GameState.Achievement(GameState.A_FIRST_SUPER, "Build Super Soldier", null, "CgkIuLudmpkHEAIQCw", string.Empty);
		GameState.achievements[GameState.A_NO_SPELLS] = new GameState.Achievement(GameState.A_NO_SPELLS, "No Spells", null, "CgkIuLudmpkHEAIQDQ", string.Empty);
		GameState.achievements[GameState.A_MODERN_AGE_WIN] = new GameState.Achievement(GameState.A_MODERN_AGE_WIN, "Win in the Modern age on normal difficulty", null, "CgkIuLudmpkHEAIQDg", string.Empty);
		GameState.achievements[GameState.A_BUILD_EVERY_UNIT] = new GameState.Achievement(GameState.A_BUILD_EVERY_UNIT, "Build every unit", null, "CgkIuLudmpkHEAIQDw", string.Empty);
		GameState.achievements[GameState.A_BUILD_EVERY_TURRET] = new GameState.Achievement(GameState.A_BUILD_EVERY_TURRET, "Build every turret", null, "CgkIuLudmpkHEAIQEA", string.Empty);
		GameState.achievements[GameState.A_G_BROM] = new GameState.Achievement(GameState.A_G_BROM, "Brom the Basher", null, "CgkIuLudmpkHEAIQEQ", string.Empty);
		GameState.achievements[GameState.A_G_RAMSES] = new GameState.Achievement(GameState.A_G_RAMSES, "Ramnificant the Glorious", null, "CgkIuLudmpkHEAIQEg", string.Empty);
		GameState.achievements[GameState.A_G_ALEX] = new GameState.Achievement(GameState.A_G_ALEX, "Zander The Great", null, "CgkIuLudmpkHEAIQEw", string.Empty);
		GameState.achievements[GameState.A_G_CEASER] = new GameState.Achievement(GameState.A_G_CEASER, "Julian the Jubilant", null, "CgkIuLudmpkHEAIQFA", string.Empty);
		GameState.achievements[GameState.A_G_TZU] = new GameState.Achievement(GameState.A_G_TZU, "Changwu the Sun Master", null, "CgkIuLudmpkHEAIQFQ", string.Empty);
		GameState.achievements[GameState.A_G_KHAN] = new GameState.Achievement(GameState.A_G_KHAN, "Gongas Kang the Emperor", null, "CgkIuLudmpkHEAIQFg", string.Empty);
		GameState.achievements[GameState.A_G_LEON] = new GameState.Achievement(GameState.A_G_LEON, "Leon the Lord", null, "CgkIuLudmpkHEAIQFw", string.Empty);
		GameState.achievements[GameState.A_G_HITLER] = new GameState.Achievement(GameState.A_G_HITLER, "Hizdim the Horrible", null, "CgkIuLudmpkHEAIQGA", string.Empty);
		GameState.achievements[GameState.A_G_STALIN] = new GameState.Achievement(GameState.A_G_STALIN, "Stalisov the Supreme", null, "CgkIuLudmpkHEAIQGQ", string.Empty);
		GameState.achievements[GameState.A_G_ROBOT] = new GameState.Achievement(GameState.A_G_ROBOT, "Voltornator the Vicious", null, "CgkIuLudmpkHEAIQGg", string.Empty);
		GameState.load();
	}

	// Token: 0x06000627 RID: 1575 RVA: 0x00015068 File Offset: 0x00013268
	public static void unlockAchievement(int id)
	{
		GameState.Achievement achievement = GameState.achievements[id];
		if (achievement.progress == 0f)
		{
			//GameState.analytics.LogEvent("Achievement", "Unlocked", achievement.name, 1L);
			achievement.progress = 1f;
			//if (!Social.localUser.authenticated)
			//{
				Debug.Log("SHOW ACHIEVEMENT: " + achievement.name);
				Game.instance.addAchievementToShow(achievement.name);
			//}
			//if (Social.localUser.authenticated)
			//{
			//	Social.Active.ReportProgress(achievement.playId, 100.0, new Action<bool>(GameState.unlockResult));
			//}
			GameState.save();
		}
	}

	// Token: 0x06000628 RID: 1576 RVA: 0x00015128 File Offset: 0x00013328
	public static void unlockResult(bool result)
	{
		Debug.Log("Unlock result: " + result);
	}

	// Token: 0x06000629 RID: 1577 RVA: 0x00015140 File Offset: 0x00013340
	public static void load()
	{
		Debug.Log("LOAD:  " + PlayerPrefs.HasKey("saveGame"));
		if (PlayerPrefs.HasKey("saveGame"))
		{
			string @string = PlayerPrefs.GetString("saveGame");
			Debug.Log(@string);
			JSONObject jsonobject = new JSONObject(@string, -2, false, false);
			if (jsonobject.HasField("isHack"))
			{
				Game.isHack = (jsonobject["isHack"].str == "True");
			}
			if (jsonobject.HasField("volumeControl") && (jsonobject["volumeControl"].str == "1" || jsonobject["volumeControl"].str == "2" || jsonobject["volumeControl"].str == "0"))
			{
				GameState.volumeControl = int.Parse(jsonobject["volumeControl"].str);
			}
			if (jsonobject.HasField("noMoreSocialLogin"))
			{
				GameState.noMoreSocialLogin = (jsonobject["noMoreSocialLogin"].str == "True");
			}
			if (jsonobject.HasField("unitsBuilt"))
			{
				JSONObject jsonobject2 = jsonobject["unitsBuilt"];
				foreach (string s in jsonobject2.keys)
				{
					GameState.unitsBuilt[int.Parse(s)] = true;
				}
			}
			if (jsonobject.HasField("turretsBuilt"))
			{
				JSONObject jsonobject3 = jsonobject["turretsBuilt"];
				foreach (string s2 in jsonobject3.keys)
				{
					GameState.turretsBuilt[int.Parse(s2)] = true;
				}
			}
			if (jsonobject.HasField("achievements"))
			{
				JSONObject jsonobject4 = jsonobject["achievements"];
				foreach (string text in jsonobject4.keys)
				{
					if (GameState.achievements.ContainsKey(int.Parse(text)))
					{
						GameState.achievements[int.Parse(text)].progress = jsonobject4[text].n;
					}
				}
			}
			if (jsonobject.HasField("generals"))
			{
				JSONObject jsonobject5 = jsonobject["generals"];
				foreach (string key in jsonobject5.keys)
				{
					GameState.generalsCompleted[key] = 1;
				}
			}
			if (jsonobject.HasField("isHackUnlocked"))
			{
				GameState.isHackUnlocked = (jsonobject["isHackUnlocked"].str == "True");
			}
			if (jsonobject.HasField("isSoundtrackUnlocked"))
			{
				GameState.isSoundtrackUnlocked = (jsonobject["isSoundtrackUnlocked"].str == "True");
			}
			if (jsonobject.HasField("isGeneralsUnlocked"))
			{
				GameState.isGeneralsUnlocked = (jsonobject["isGeneralsUnlocked"].str == "True");
			}
			Debug.Log("DEBUG GENERALS");
		}
	}

	// Token: 0x0600062A RID: 1578 RVA: 0x00015568 File Offset: 0x00013768
	public static void save()
	{
		JSONObject jsonobject = new JSONObject(JSONObject.Type.OBJECT);
		JSONObject jsonobject2 = new JSONObject(JSONObject.Type.OBJECT);
		foreach (int num in GameState.unitsBuilt.Keys)
		{
			jsonobject2.AddField(string.Empty + num, "True");
		}
		jsonobject.AddField("unitsBuilt", jsonobject2);
		JSONObject jsonobject3 = new JSONObject(JSONObject.Type.OBJECT);
		foreach (int num2 in GameState.turretsBuilt.Keys)
		{
			jsonobject3.AddField(string.Empty + num2, "True");
		}
		jsonobject.AddField("turretsBuilt", jsonobject3);
		JSONObject jsonobject4 = new JSONObject(JSONObject.Type.OBJECT);
		foreach (int num3 in GameState.achievements.Keys)
		{
			if (GameState.achievements[num3].progress > 0f)
			{
				jsonobject4.AddField(string.Empty + num3, GameState.achievements[num3].progress);
			}
		}
		jsonobject.AddField("achievements", jsonobject4);
		JSONObject jsonobject5 = new JSONObject(JSONObject.Type.OBJECT);
		foreach (string str in GameState.generalsCompleted.Keys)
		{
			jsonobject5.AddField(string.Empty + str, 1);
		}
		jsonobject.AddField("generals", jsonobject5);
		jsonobject.AddField("isHack", (!Game.isHack) ? "False" : "True");
		jsonobject.AddField("volumeControl", GameState.volumeControl);
		jsonobject.AddField("noMoreSocialLogin", (!GameState.noMoreSocialLogin) ? "False" : "True");
		jsonobject.AddField("isHackUnlocked", (!GameState.isHackUnlocked) ? "False" : "True");
		jsonobject.AddField("isSoundtrackUnlocked", (!GameState.isSoundtrackUnlocked) ? "False" : "True");
		jsonobject.AddField("isGeneralsUnlocked", (!GameState.isGeneralsUnlocked) ? "False" : "True");
		PlayerPrefs.SetString("saveGame", jsonobject.Print(false));
		Debug.Log(jsonobject.Print(true));
	}

	// Token: 0x0600062B RID: 1579 RVA: 0x00015894 File Offset: 0x00013A94
	public static void toggleSound(int value)
	{
		GameState.volumeControl = value % 3;
		Game.instance.updateVolumeControl();
	}

	// Token: 0x040002FE RID: 766
	public const string SKU_SOUNDTRACK = "com.maxgames.ageofwar.soundtrack";

	// Token: 0x040002FF RID: 767
	public const string SKU_HACKED = "com.maxgames.ageofwar.hacked";

	// Token: 0x04000300 RID: 768
	public const string SKU_GENERALS = "com.maxgames.ageofwar.generals";

	// Token: 0x04000301 RID: 769
	public static bool isAllUnlocked;

	// Token: 0x04000302 RID: 770
	public static int A_FINISH_ON_IMPOSSIBLE;

	// Token: 0x04000303 RID: 771
	public static int A_FINISH_ON_HARD = 1;

	// Token: 0x04000304 RID: 772
	public static int A_FINISH_ON_NORMAL = 2;

	// Token: 0x04000305 RID: 773
	public static int A_ATTACK_10 = 3;

	// Token: 0x04000306 RID: 774
	public static int A_ONLY_RANGED = 4;

	// Token: 0x04000307 RID: 775
	public static int A_ONLY_MEELE = 5;

	// Token: 0x04000308 RID: 776
	public static int A_SELL_TURRET = 6;

	// Token: 0x04000309 RID: 777
	public static int A_ALL_SLOTS = 7;

	// Token: 0x0400030A RID: 778
	public static int A_SUPER_KILL_CAVEMAN = 8;

	// Token: 0x0400030B RID: 779
	public static int A_FIRST_SUPER = 9;

	// Token: 0x0400030C RID: 780
	public static int A_NO_SPELLS = 11;

	// Token: 0x0400030D RID: 781
	public static int A_MODERN_AGE_WIN = 12;

	// Token: 0x0400030E RID: 782
	public static int A_BUILD_EVERY_UNIT = 13;

	// Token: 0x0400030F RID: 783
	public static int A_BUILD_EVERY_TURRET = 14;

	// Token: 0x04000310 RID: 784
	public static int A_G_BROM = 15;

	// Token: 0x04000311 RID: 785
	public static int A_G_RAMSES = 16;

	// Token: 0x04000312 RID: 786
	public static int A_G_ALEX = 17;

	// Token: 0x04000313 RID: 787
	public static int A_G_CEASER = 18;

	// Token: 0x04000314 RID: 788
	public static int A_G_TZU = 19;

	// Token: 0x04000315 RID: 789
	public static int A_G_KHAN = 20;

	// Token: 0x04000316 RID: 790
	public static int A_G_LEON = 21;

	// Token: 0x04000317 RID: 791
	public static int A_G_HITLER = 22;

	// Token: 0x04000318 RID: 792
	public static int A_G_STALIN = 23;

	// Token: 0x04000319 RID: 793
	public static int A_G_ROBOT = 24;

	// Token: 0x0400031A RID: 794
	public static GoogleAnalyticsV3 analytics;

	// Token: 0x0400031B RID: 795
	public static bool isHackUnlocked;

	// Token: 0x0400031C RID: 796
	public static bool isGeneralsUnlocked;

	// Token: 0x0400031D RID: 797
	public static bool isSoundtrackUnlocked;

	// Token: 0x0400031E RID: 798
	public static int volumeControl;

	// Token: 0x0400031F RID: 799
	public static int V_ON;

	// Token: 0x04000320 RID: 800
	public static int V_NO_MUSIC = 1;

	// Token: 0x04000321 RID: 801
	public static int V_OFF = 2;

	// Token: 0x04000322 RID: 802
	public static EnemyAi enemyAi;

	// Token: 0x04000323 RID: 803
	public static Sprite enemyProfileSprite;

	// Token: 0x04000324 RID: 804
	public static Dictionary<int, bool> unitsBuilt;

	// Token: 0x04000325 RID: 805
	public static Dictionary<int, bool> turretsBuilt;

	// Token: 0x04000326 RID: 806
	public static Dictionary<int, GameState.Achievement> achievements;

	// Token: 0x04000327 RID: 807
	public static bool noMoreSocialLogin;

	// Token: 0x04000328 RID: 808
	public static Dictionary<string, int> generalsCompleted;

	// Token: 0x020000DB RID: 219
	public class Achievement
	{
		// Token: 0x0600062C RID: 1580 RVA: 0x000158A8 File Offset: 0x00013AA8
		public Achievement(int id, string name, GameObject image, string playId, string appleId)
		{
			this.id = id;
			this.name = name;
			this.image = image;
			this.playId = playId;
			this.appleId = appleId;
			this.progress = 0f;
		}

		// Token: 0x0400032B RID: 811
		public int id;

		// Token: 0x0400032C RID: 812
		public string name;

		// Token: 0x0400032D RID: 813
		public GameObject image;

		// Token: 0x0400032E RID: 814
		public string playId;

		// Token: 0x0400032F RID: 815
		public string appleId;

		// Token: 0x04000330 RID: 816
		public float progress;

		// Token: 0x04000331 RID: 817
		public Image menuImage;
	}
}
