using System;

namespace UnityEngine.Advertisements
{
	// Token: 0x02000038 RID: 56
	internal class UnityAdsAndroid : UnityAdsPlatform
	{
		// Token: 0x06000240 RID: 576 RVA: 0x00009BF8 File Offset: 0x00007DF8
		private AndroidJavaObject getAndroidWrapper()
		{
			if (!UnityAdsAndroid.wrapperInitialized)
			{
				UnityAdsAndroid.wrapperInitialized = true;
				UnityAdsAndroid.unityAdsUnity = new AndroidJavaObject("com.unity3d.ads.android.unity3d.UnityAdsUnityWrapper", new object[0]);
			}
			return UnityAdsAndroid.unityAdsUnity;
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00009C30 File Offset: 0x00007E30
		public override void init(string gameId, bool testModeEnabled, string gameObjectName, string unityVersion)
		{
			Utils.LogDebug(string.Concat(new object[]
			{
				"UnityAndroid: init(), gameId=",
				gameId,
				", testModeEnabled=",
				testModeEnabled,
				", gameObjectName=",
				gameObjectName
			}));
			if (Advertisement.UnityDeveloperInternalTestMode)
			{
				this.getAndroidWrapper().Call("enableUnityDeveloperInternalTestMode", new object[0]);
			}
			UnityAdsAndroid.currentActivity = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
			this.getAndroidWrapper().Call("init", new object[]
			{
				gameId,
				UnityAdsAndroid.currentActivity,
				testModeEnabled,
				(int)Advertisement.debugLevel,
				gameObjectName,
				unityVersion
			});
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00009CF0 File Offset: 0x00007EF0
		public override bool show(string zoneId, string rewardItemKey, string options)
		{
			Utils.LogDebug("UnityAndroid: show()");
			return this.getAndroidWrapper().Call<bool>("show", new object[]
			{
				zoneId,
				rewardItemKey,
				options
			});
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00009D2C File Offset: 0x00007F2C
		public override void hide()
		{
			Utils.LogDebug("UnityAndroid: hide()");
			this.getAndroidWrapper().Call("hide", new object[0]);
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00009D5C File Offset: 0x00007F5C
		public override bool isSupported()
		{
			Utils.LogDebug("UnityAndroid: isSupported()");
			return this.getAndroidWrapper().Call<bool>("isSupported", new object[0]);
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00009D8C File Offset: 0x00007F8C
		public override string getSDKVersion()
		{
			Utils.LogDebug("UnityAndroid: getSDKVersion()");
			return this.getAndroidWrapper().Call<string>("getSDKVersion", new object[0]);
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00009DBC File Offset: 0x00007FBC
		public override bool canShowZone(string zone)
		{
			return this.getAndroidWrapper().Call<bool>("canShowZone", new object[]
			{
				zone
			});
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00009DD8 File Offset: 0x00007FD8
		public override bool hasMultipleRewardItems()
		{
			Utils.LogDebug("UnityAndroid: hasMultipleRewardItems()");
			return this.getAndroidWrapper().Call<bool>("hasMultipleRewardItems", new object[0]);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00009E08 File Offset: 0x00008008
		public override string getRewardItemKeys()
		{
			Utils.LogDebug("UnityAndroid: getRewardItemKeys()");
			return this.getAndroidWrapper().Call<string>("getRewardItemKeys", new object[0]);
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00009E38 File Offset: 0x00008038
		public override string getDefaultRewardItemKey()
		{
			Utils.LogDebug("UnityAndroid: getDefaultRewardItemKey()");
			return this.getAndroidWrapper().Call<string>("getDefaultRewardItemKey", new object[0]);
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00009E68 File Offset: 0x00008068
		public override string getCurrentRewardItemKey()
		{
			Utils.LogDebug("UnityAndroid: getCurrentRewardItemKey()");
			return this.getAndroidWrapper().Call<string>("getCurrentRewardItemKey", new object[0]);
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00009E98 File Offset: 0x00008098
		public override bool setRewardItemKey(string rewardItemKey)
		{
			Utils.LogDebug("UnityAndroid: setRewardItemKey() rewardItemKey=" + rewardItemKey);
			return this.getAndroidWrapper().Call<bool>("setRewardItemKey", new object[]
			{
				rewardItemKey
			});
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00009ED0 File Offset: 0x000080D0
		public override void setDefaultRewardItemAsRewardItem()
		{
			Utils.LogDebug("UnityAndroid: setDefaultRewardItemAsRewardItem()");
			this.getAndroidWrapper().Call("setDefaultRewardItemAsRewardItem", new object[0]);
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00009F00 File Offset: 0x00008100
		public override string getRewardItemDetailsWithKey(string rewardItemKey)
		{
			Utils.LogDebug("UnityAndroid: getRewardItemDetailsWithKey() rewardItemKey=" + rewardItemKey);
			return this.getAndroidWrapper().Call<string>("getRewardItemDetailsWithKey", new object[]
			{
				rewardItemKey
			});
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00009F38 File Offset: 0x00008138
		public override string getRewardItemDetailsKeys()
		{
			Utils.LogDebug("UnityAndroid: getRewardItemDetailsKeys()");
			return this.getAndroidWrapper().Call<string>("getRewardItemDetailsKeys", new object[0]);
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00009F68 File Offset: 0x00008168
		public override void setLogLevel(Advertisement.DebugLevel logLevel)
		{
			Utils.LogDebug("UnityAndroid: setLogLevel()");
			this.getAndroidWrapper().Call("setLogLevel", new object[]
			{
				(int)logLevel
			});
		}

		// Token: 0x04000124 RID: 292
		private static AndroidJavaObject unityAds;

		// Token: 0x04000125 RID: 293
		private static AndroidJavaObject unityAdsUnity;

		// Token: 0x04000126 RID: 294
		private static AndroidJavaObject currentActivity;

		// Token: 0x04000127 RID: 295
		private static bool wrapperInitialized;
	}
}
