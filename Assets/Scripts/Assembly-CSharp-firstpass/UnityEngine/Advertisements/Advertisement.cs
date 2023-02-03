using System;

namespace UnityEngine.Advertisements
{
	// Token: 0x0200002E RID: 46
	public static class Advertisement
	{
		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060001ED RID: 493 RVA: 0x0000874C File Offset: 0x0000694C
		// (set) Token: 0x060001EE RID: 494 RVA: 0x00008754 File Offset: 0x00006954
		public static Advertisement.DebugLevel debugLevel
		{
			get
			{
				return Advertisement._debugLevel;
			}
			set
			{
				Advertisement._debugLevel = value;
				UnityAds.setLogLevel(Advertisement._debugLevel);
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060001EF RID: 495 RVA: 0x00008768 File Offset: 0x00006968
		public static bool isSupported
		{
			get
			{
				return Application.isEditor || Application.platform == RuntimePlatform.IPhonePlayer || Application.platform == RuntimePlatform.Android;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x0000878C File Offset: 0x0000698C
		public static bool isInitialized
		{
			get
			{
				return UnityAds.isInitialized;
			}
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00008794 File Offset: 0x00006994
		public static void Initialize(string appId, bool testMode = false)
		{
			UnityAds.SharedInstance.Init(appId, testMode);
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x000087A4 File Offset: 0x000069A4
		public static void Show(string zoneId = null, ShowOptions options = null)
		{
			UnityAds.SharedInstance.Show(zoneId, options);
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x000087B4 File Offset: 0x000069B4
		// (set) Token: 0x060001F4 RID: 500 RVA: 0x000087BC File Offset: 0x000069BC
		public static bool allowPrecache
		{
			get
			{
				return UnityAds.allowPrecache;
			}
			set
			{
				UnityAds.allowPrecache = value;
			}
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x000087C4 File Offset: 0x000069C4
		public static bool isReady(string zoneId = null)
		{
			return UnityAds.canShowZone(zoneId);
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x000087CC File Offset: 0x000069CC
		public static bool isShowing
		{
			get
			{
				return UnityAds.isShowing;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x000087D4 File Offset: 0x000069D4
		// (set) Token: 0x060001F8 RID: 504 RVA: 0x000087DC File Offset: 0x000069DC
		public static bool UnityDeveloperInternalTestMode { get; set; }

		// Token: 0x040000FB RID: 251
		public static readonly string version = "1.1.4";

		// Token: 0x040000FC RID: 252
		private static Advertisement.DebugLevel _debugLevel = (!Debug.isDebugBuild) ? ((Advertisement.DebugLevel)7) : ((Advertisement.DebugLevel)15);

		// Token: 0x0200002F RID: 47
		public enum DebugLevel
		{
			// Token: 0x040000FF RID: 255
			NONE,
			// Token: 0x04000100 RID: 256
			ERROR,
			// Token: 0x04000101 RID: 257
			WARNING,
			// Token: 0x04000102 RID: 258
			INFO = 4,
			// Token: 0x04000103 RID: 259
			DEBUG = 8
		}
	}
}
