using System;
using System.Collections.Generic;
using System.Net;
using UnityEngine.Advertisements.Optional;

namespace UnityEngine.Advertisements
{
	// Token: 0x02000037 RID: 55
	internal class UnityAds : MonoBehaviour
	{
		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000220 RID: 544 RVA: 0x000094B8 File Offset: 0x000076B8
		public static UnityAds SharedInstance
		{
			get
			{
				if (!UnityAds.sharedInstance)
				{
					UnityAds.sharedInstance = (UnityAds)Object.FindObjectOfType(typeof(UnityAds));
				}
				if (!UnityAds.sharedInstance)
				{
					GameObject gameObject = new GameObject
					{
						hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector)
					};
					UnityAds.sharedInstance = gameObject.AddComponent<UnityAds>();
					gameObject.name = "UnityAdsPluginBridgeObject";
					Object.DontDestroyOnLoad(gameObject);
				}
				return UnityAds.sharedInstance;
			}
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0000952C File Offset: 0x0000772C
		public void Init(string gameId, bool testModeEnabled)
		{
			if (UnityAds.initCalled)
			{
				return;
			}
			UnityAds.initCalled = true;
			try
			{
				if (Application.internetReachability == NetworkReachability.NotReachable)
				{
					Utils.LogError("Internet not reachable, can't initialize ads");
					return;
				}
				IPHostEntry hostEntry = Dns.GetHostEntry("impact.applifier.com");
				if (hostEntry.AddressList.Length == 1 && hostEntry.AddressList[0].Equals(new IPAddress(new byte[]
				{
					127,
					0,
					0,
					1
				})))
				{
					Utils.LogError("Video ad server resolves to localhost (due to ad blocker?), can't initialize ads");
					return;
				}
			}
			catch (Exception ex)
			{
				Utils.LogDebug("Exception during connectivity check: " + ex.Message);
				return;
			}
			UnityAdsExternal.init(gameId, testModeEnabled, UnityAds.SharedInstance.gameObject.name, UnityAds._versionString);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00009610 File Offset: 0x00007810
		public void Awake()
		{
			if (base.gameObject == UnityAds.SharedInstance.gameObject)
			{
				Object.DontDestroyOnLoad(base.gameObject);
			}
			else
			{
				Object.Destroy(base.gameObject);
			}
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00009654 File Offset: 0x00007854
		public static bool isSupported()
		{
			return UnityAdsExternal.isSupported();
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0000965C File Offset: 0x0000785C
		public static string getSDKVersion()
		{
			return UnityAdsExternal.getSDKVersion();
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00009664 File Offset: 0x00007864
		public static void setLogLevel(Advertisement.DebugLevel logLevel)
		{
			UnityAdsExternal.setLogLevel(logLevel);
		}

		// Token: 0x06000226 RID: 550 RVA: 0x0000966C File Offset: 0x0000786C
		public static bool canShowZone(string zone)
		{
			return UnityAds.isInitialized && !UnityAds.isShowing && UnityAdsExternal.canShowZone(zone);
		}

		// Token: 0x06000227 RID: 551 RVA: 0x0000968C File Offset: 0x0000788C
		public static bool hasMultipleRewardItems()
		{
			return UnityAdsExternal.hasMultipleRewardItems();
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00009694 File Offset: 0x00007894
		public static List<string> getRewardItemKeys()
		{
			List<string> list = new List<string>();
			string rewardItemKeys = UnityAdsExternal.getRewardItemKeys();
			return new List<string>(rewardItemKeys.Split(new char[]
			{
				';'
			}));
		}

		// Token: 0x06000229 RID: 553 RVA: 0x000096C8 File Offset: 0x000078C8
		public static string getDefaultRewardItemKey()
		{
			return UnityAdsExternal.getDefaultRewardItemKey();
		}

		// Token: 0x0600022A RID: 554 RVA: 0x000096D0 File Offset: 0x000078D0
		public static string getCurrentRewardItemKey()
		{
			return UnityAdsExternal.getCurrentRewardItemKey();
		}

		// Token: 0x0600022B RID: 555 RVA: 0x000096D8 File Offset: 0x000078D8
		public static bool setRewardItemKey(string rewardItemKey)
		{
			return UnityAdsExternal.setRewardItemKey(rewardItemKey);
		}

		// Token: 0x0600022C RID: 556 RVA: 0x000096E0 File Offset: 0x000078E0
		public static void setDefaultRewardItemAsRewardItem()
		{
			UnityAdsExternal.setDefaultRewardItemAsRewardItem();
		}

		// Token: 0x0600022D RID: 557 RVA: 0x000096E8 File Offset: 0x000078E8
		public static string getRewardItemNameKey()
		{
			if (UnityAds._rewardItemNameKey == null || UnityAds._rewardItemNameKey.Length == 0)
			{
				UnityAds.fillRewardItemKeyData();
			}
			return UnityAds._rewardItemNameKey;
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00009710 File Offset: 0x00007910
		public static string getRewardItemPictureKey()
		{
			if (UnityAds._rewardItemPictureKey == null || UnityAds._rewardItemPictureKey.Length == 0)
			{
				UnityAds.fillRewardItemKeyData();
			}
			return UnityAds._rewardItemPictureKey;
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00009738 File Offset: 0x00007938
		public static Dictionary<string, string> getRewardItemDetailsWithKey(string rewardItemKey)
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			string text = string.Empty;
			text = UnityAdsExternal.getRewardItemDetailsWithKey(rewardItemKey);
			if (text != null)
			{
				List<string> list = new List<string>(text.Split(new char[]
				{
					';'
				}));
				Utils.LogDebug("UnityAndroid: getRewardItemDetailsWithKey() rewardItemDataString=" + text);
				if (list.Count == 2)
				{
					dictionary.Add(UnityAds.getRewardItemNameKey(), list.ToArray().GetValue(0).ToString());
					dictionary.Add(UnityAds.getRewardItemPictureKey(), list.ToArray().GetValue(1).ToString());
				}
			}
			return dictionary;
		}

		// Token: 0x06000230 RID: 560 RVA: 0x000097CC File Offset: 0x000079CC
		public void Show(string zoneId = null, ShowOptions options = null)
		{
			string text = null;
			UnityAds._resultDelivered = false;
			if (options != null)
			{
				if (options.resultCallback != null)
				{
					UnityAds.resultCallback = options.resultCallback;
				}
				ShowOptionsExtended showOptionsExtended = options as ShowOptionsExtended;
				if (showOptionsExtended != null && showOptionsExtended.gamerSid != null && showOptionsExtended.gamerSid.Length > 0)
				{
					text = showOptionsExtended.gamerSid;
				}
			}
			if (!UnityAds.isInitialized || UnityAds.isShowing)
			{
				UnityAds.deliverCallback(ShowResult.Failed);
				return;
			}
			if (text != null)
			{
				if (!UnityAds.show(zoneId, string.Empty, new Dictionary<string, string>
				{
					{
						"sid",
						text
					}
				}))
				{
					UnityAds.deliverCallback(ShowResult.Failed);
				}
			}
			else if (!UnityAds.show(zoneId))
			{
				UnityAds.deliverCallback(ShowResult.Failed);
			}
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00009890 File Offset: 0x00007A90
		public static bool show(string zoneId = null)
		{
			return UnityAds.show(zoneId, string.Empty, null);
		}

		// Token: 0x06000232 RID: 562 RVA: 0x000098A0 File Offset: 0x00007AA0
		public static bool show(string zoneId, string rewardItemKey)
		{
			return UnityAds.show(zoneId, rewardItemKey, null);
		}

		// Token: 0x06000233 RID: 563 RVA: 0x000098AC File Offset: 0x00007AAC
		public static bool show(string zoneId, string rewardItemKey, Dictionary<string, string> options)
		{
			if (!UnityAds.isShowing)
			{
				UnityAds.isShowing = true;
				if (UnityAds.SharedInstance)
				{
					string options2 = UnityAds.parseOptionsDictionary(options);
					if (UnityAdsExternal.show(zoneId, rewardItemKey, options2))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x000098F0 File Offset: 0x00007AF0
		private static void deliverCallback(ShowResult result)
		{
			UnityAds.isShowing = false;
			if (UnityAds.resultCallback != null && !UnityAds._resultDelivered)
			{
				UnityAds._resultDelivered = true;
				UnityAds.resultCallback(result);
				UnityAds.resultCallback = null;
			}
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00009924 File Offset: 0x00007B24
		public static void hide()
		{
			if (UnityAds.isShowing)
			{
				UnityAdsExternal.hide();
			}
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00009938 File Offset: 0x00007B38
		private static void fillRewardItemKeyData()
		{
			string rewardItemDetailsKeys = UnityAdsExternal.getRewardItemDetailsKeys();
			if (rewardItemDetailsKeys != null && rewardItemDetailsKeys.Length > 2)
			{
				List<string> list = new List<string>(rewardItemDetailsKeys.Split(new char[]
				{
					';'
				}));
				UnityAds._rewardItemNameKey = list.ToArray().GetValue(0).ToString();
				UnityAds._rewardItemPictureKey = list.ToArray().GetValue(1).ToString();
			}
		}

		// Token: 0x06000237 RID: 567 RVA: 0x000099A0 File Offset: 0x00007BA0
		private static string parseOptionsDictionary(Dictionary<string, string> options)
		{
			string text = string.Empty;
			if (options != null)
			{
				bool flag = false;
				if (options.ContainsKey("noOfferScreen"))
				{
					text = text + ((!flag) ? string.Empty : ",") + "noOfferScreen:" + options["noOfferScreen"];
					flag = true;
				}
				if (options.ContainsKey("openAnimated"))
				{
					text = text + ((!flag) ? string.Empty : ",") + "openAnimated:" + options["openAnimated"];
					flag = true;
				}
				if (options.ContainsKey("sid"))
				{
					text = text + ((!flag) ? string.Empty : ",") + "sid:" + options["sid"];
					flag = true;
				}
				if (options.ContainsKey("muteVideoSounds"))
				{
					text = text + ((!flag) ? string.Empty : ",") + "muteVideoSounds:" + options["muteVideoSounds"];
					flag = true;
				}
				if (options.ContainsKey("useDeviceOrientationForVideo"))
				{
					text = text + ((!flag) ? string.Empty : ",") + "useDeviceOrientationForVideo:" + options["useDeviceOrientationForVideo"];
				}
			}
			return text;
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00009AF4 File Offset: 0x00007CF4
		public void onHide()
		{
			UnityAds.isShowing = false;
			UnityAds.deliverCallback(ShowResult.Skipped);
			Utils.LogDebug("onHide");
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00009B0C File Offset: 0x00007D0C
		public void onShow()
		{
			Utils.LogDebug("onShow");
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00009B18 File Offset: 0x00007D18
		public void onVideoStarted()
		{
			Utils.LogDebug("onVideoStarted");
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00009B24 File Offset: 0x00007D24
		public void onVideoCompleted(string parameters)
		{
			if (parameters != null)
			{
				List<string> list = new List<string>(parameters.Split(new char[]
				{
					';'
				}));
				string text = list.ToArray().GetValue(0).ToString();
				bool flag = list.ToArray().GetValue(1).ToString() == "true";
				Utils.LogDebug(string.Concat(new object[]
				{
					"onVideoCompleted: ",
					text,
					" - ",
					flag
				}));
				if (flag)
				{
					UnityAds.deliverCallback(ShowResult.Skipped);
				}
				else
				{
					UnityAds.deliverCallback(ShowResult.Finished);
				}
			}
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00009BCC File Offset: 0x00007DCC
		public void onFetchCompleted()
		{
			UnityAds.isInitialized = true;
			Utils.LogDebug("onFetchCompleted");
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00009BE0 File Offset: 0x00007DE0
		public void onFetchFailed()
		{
			Utils.LogDebug("onFetchFailed");
		}

		// Token: 0x0400011A RID: 282
		public static bool isShowing = false;

		// Token: 0x0400011B RID: 283
		public static bool isInitialized = false;

		// Token: 0x0400011C RID: 284
		public static bool allowPrecache = true;

		// Token: 0x0400011D RID: 285
		private static bool initCalled = false;

		// Token: 0x0400011E RID: 286
		private static UnityAds sharedInstance;

		// Token: 0x0400011F RID: 287
		private static string _rewardItemNameKey = string.Empty;

		// Token: 0x04000120 RID: 288
		private static string _rewardItemPictureKey = string.Empty;

		// Token: 0x04000121 RID: 289
		private static bool _resultDelivered = false;

		// Token: 0x04000122 RID: 290
		private static Action<ShowResult> resultCallback = null;

		// Token: 0x04000123 RID: 291
		private static string _versionString = Application.unityVersion + "_" + Advertisement.version;
	}
}
