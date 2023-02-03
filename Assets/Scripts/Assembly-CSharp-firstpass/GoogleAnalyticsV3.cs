using System;
using UnityEngine;

// Token: 0x0200000B RID: 11
public class GoogleAnalyticsV3 : MonoBehaviour
{
	// Token: 0x0600002D RID: 45 RVA: 0x000036B8 File Offset: 0x000018B8
	private void Awake()
	{
		this.InitializeTracker();
		if (this.sendLaunchEvent)
		{
			this.LogEvent("Google Analytics", "Auto Instrumentation", "Game Launch", 0L);
		}
		if (this.UncaughtExceptionReporting)
		{
			Application.RegisterLogCallback(new Application.LogCallback(this.HandleException));
			if (GoogleAnalyticsV3.belowThreshold(this.logLevel, GoogleAnalyticsV3.DebugMode.VERBOSE))
			{
				Debug.Log("Enabling uncaught exception reporting.");
			}
		}
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00003724 File Offset: 0x00001924
	private void Update()
	{
		if (this.uncaughtExceptionStackTrace != null)
		{
			this.LogException(this.uncaughtExceptionStackTrace, true);
			this.uncaughtExceptionStackTrace = null;
		}
	}

	// Token: 0x0600002F RID: 47 RVA: 0x00003748 File Offset: 0x00001948
	private void HandleException(string condition, string stackTrace, LogType type)
	{
		if (type == LogType.Exception)
		{
			this.uncaughtExceptionStackTrace = condition + "\n" + stackTrace + StackTraceUtility.ExtractStackTrace();
		}
	}

	// Token: 0x06000030 RID: 48 RVA: 0x00003768 File Offset: 0x00001968
	private void InitializeTracker()
	{
		if (!this.initialized)
		{
			GoogleAnalyticsV3.instance = this;
			Debug.Log("Initializing Google Analytics 0.1.");
			this.androidTracker.SetTrackingCode(this.androidTrackingCode);
			this.androidTracker.SetAppName(this.productName);
			this.androidTracker.SetBundleIdentifier(this.bundleIdentifier);
			this.androidTracker.SetAppVersion(this.bundleVersion);
			this.androidTracker.SetDispatchPeriod(this.dispatchPeriod);
			this.androidTracker.SetSampleFrequency(this.sampleFrequency);
			this.androidTracker.SetLogLevelValue(this.logLevel);
			this.androidTracker.SetAnonymizeIP(this.anonymizeIP);
			this.androidTracker.SetDryRun(this.dryRun);
			this.androidTracker.InitializeTracker();
			this.initialized = true;
			this.SetOnTracker(Fields.DEVELOPER_ID, "GbOCSs");
		}
	}

	// Token: 0x06000031 RID: 49 RVA: 0x0000384C File Offset: 0x00001A4C
	public void SetAppLevelOptOut(bool optOut)
	{
		this.InitializeTracker();
		this.androidTracker.SetOptOut(optOut);
	}

	// Token: 0x06000032 RID: 50 RVA: 0x00003860 File Offset: 0x00001A60
	public void SetUserIDOverride(string userID)
	{
		this.SetOnTracker(Fields.USER_ID, userID);
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00003870 File Offset: 0x00001A70
	public void ClearUserIDOverride()
	{
		this.InitializeTracker();
		this.androidTracker.ClearUserIDOverride();
	}

	// Token: 0x06000034 RID: 52 RVA: 0x00003884 File Offset: 0x00001A84
	public void DispatchHits()
	{
		this.InitializeTracker();
		this.androidTracker.DispatchHits();
	}

	// Token: 0x06000035 RID: 53 RVA: 0x00003898 File Offset: 0x00001A98
	public void StartSession()
	{
		this.InitializeTracker();
		this.androidTracker.StartSession();
	}

	// Token: 0x06000036 RID: 54 RVA: 0x000038AC File Offset: 0x00001AAC
	public void StopSession()
	{
		this.InitializeTracker();
		this.androidTracker.StopSession();
	}

	// Token: 0x06000037 RID: 55 RVA: 0x000038C0 File Offset: 0x00001AC0
	public void SetOnTracker(Field fieldName, object value)
	{
		this.InitializeTracker();
		this.androidTracker.SetTrackerVal(fieldName, value);
	}

	// Token: 0x06000038 RID: 56 RVA: 0x000038D8 File Offset: 0x00001AD8
	public void LogScreen(string title)
	{
		AppViewHitBuilder builder = new AppViewHitBuilder().SetScreenName(title);
		this.LogScreen(builder);
	}

	// Token: 0x06000039 RID: 57 RVA: 0x000038F8 File Offset: 0x00001AF8
	public void LogScreen(AppViewHitBuilder builder)
	{
		this.InitializeTracker();
		if (builder.Validate() == null)
		{
			return;
		}
		if (GoogleAnalyticsV3.belowThreshold(this.logLevel, GoogleAnalyticsV3.DebugMode.VERBOSE))
		{
			Debug.Log("Logging screen.");
		}
		this.androidTracker.LogScreen(builder);
	}

	// Token: 0x0600003A RID: 58 RVA: 0x00003940 File Offset: 0x00001B40
	public void LogEvent(string eventCategory, string eventAction, string eventLabel, long value)
	{
		EventHitBuilder builder = new EventHitBuilder().SetEventCategory(eventCategory).SetEventAction(eventAction).SetEventLabel(eventLabel).SetEventValue(value);
		this.LogEvent(builder);
	}

	// Token: 0x0600003B RID: 59 RVA: 0x00003974 File Offset: 0x00001B74
	public void LogEvent(EventHitBuilder builder)
	{
		this.InitializeTracker();
		if (builder.Validate() == null)
		{
			return;
		}
		if (GoogleAnalyticsV3.belowThreshold(this.logLevel, GoogleAnalyticsV3.DebugMode.VERBOSE))
		{
			Debug.Log("Logging event.");
		}
		this.androidTracker.LogEvent(builder);
	}

	// Token: 0x0600003C RID: 60 RVA: 0x000039BC File Offset: 0x00001BBC
	public void LogTransaction(string transID, string affiliation, double revenue, double tax, double shipping)
	{
		this.LogTransaction(transID, affiliation, revenue, tax, shipping, string.Empty);
	}

	// Token: 0x0600003D RID: 61 RVA: 0x000039D0 File Offset: 0x00001BD0
	public void LogTransaction(string transID, string affiliation, double revenue, double tax, double shipping, string currencyCode)
	{
		TransactionHitBuilder builder = new TransactionHitBuilder().SetTransactionID(transID).SetAffiliation(affiliation).SetRevenue(revenue).SetTax(tax).SetShipping(shipping).SetCurrencyCode(currencyCode);
		this.LogTransaction(builder);
	}

	// Token: 0x0600003E RID: 62 RVA: 0x00003A14 File Offset: 0x00001C14
	public void LogTransaction(TransactionHitBuilder builder)
	{
		this.InitializeTracker();
		if (builder.Validate() == null)
		{
			return;
		}
		if (GoogleAnalyticsV3.belowThreshold(this.logLevel, GoogleAnalyticsV3.DebugMode.VERBOSE))
		{
			Debug.Log("Logging transaction.");
		}
		this.androidTracker.LogTransaction(builder);
	}

	// Token: 0x0600003F RID: 63 RVA: 0x00003A5C File Offset: 0x00001C5C
	public void LogItem(string transID, string name, string sku, string category, double price, long quantity)
	{
		this.LogItem(transID, name, sku, category, price, quantity, null);
	}

	// Token: 0x06000040 RID: 64 RVA: 0x00003A7C File Offset: 0x00001C7C
	public void LogItem(string transID, string name, string sku, string category, double price, long quantity, string currencyCode)
	{
		ItemHitBuilder builder = new ItemHitBuilder().SetTransactionID(transID).SetName(name).SetSKU(sku).SetCategory(category).SetPrice(price).SetQuantity(quantity).SetCurrencyCode(currencyCode);
		this.LogItem(builder);
	}

	// Token: 0x06000041 RID: 65 RVA: 0x00003AC4 File Offset: 0x00001CC4
	public void LogItem(ItemHitBuilder builder)
	{
		this.InitializeTracker();
		if (builder.Validate() == null)
		{
			return;
		}
		if (GoogleAnalyticsV3.belowThreshold(this.logLevel, GoogleAnalyticsV3.DebugMode.VERBOSE))
		{
			Debug.Log("Logging item.");
		}
		this.androidTracker.LogItem(builder);
	}

	// Token: 0x06000042 RID: 66 RVA: 0x00003B0C File Offset: 0x00001D0C
	public void LogException(string exceptionDescription, bool isFatal)
	{
		ExceptionHitBuilder builder = new ExceptionHitBuilder().SetExceptionDescription(exceptionDescription).SetFatal(isFatal);
		this.LogException(builder);
	}

	// Token: 0x06000043 RID: 67 RVA: 0x00003B34 File Offset: 0x00001D34
	public void LogException(ExceptionHitBuilder builder)
	{
		this.InitializeTracker();
		if (builder.Validate() == null)
		{
			return;
		}
		if (GoogleAnalyticsV3.belowThreshold(this.logLevel, GoogleAnalyticsV3.DebugMode.VERBOSE))
		{
			Debug.Log("Logging exception.");
		}
		this.androidTracker.LogException(builder);
	}

	// Token: 0x06000044 RID: 68 RVA: 0x00003B7C File Offset: 0x00001D7C
	public void LogSocial(string socialNetwork, string socialAction, string socialTarget)
	{
		SocialHitBuilder builder = new SocialHitBuilder().SetSocialNetwork(socialNetwork).SetSocialAction(socialAction).SetSocialTarget(socialTarget);
		this.LogSocial(builder);
	}

	// Token: 0x06000045 RID: 69 RVA: 0x00003BA8 File Offset: 0x00001DA8
	public void LogSocial(SocialHitBuilder builder)
	{
		this.InitializeTracker();
		if (builder.Validate() == null)
		{
			return;
		}
		if (GoogleAnalyticsV3.belowThreshold(this.logLevel, GoogleAnalyticsV3.DebugMode.VERBOSE))
		{
			Debug.Log("Logging social.");
		}
		this.androidTracker.LogSocial(builder);
	}

	// Token: 0x06000046 RID: 70 RVA: 0x00003BF0 File Offset: 0x00001DF0
	public void LogTiming(string timingCategory, long timingInterval, string timingName, string timingLabel)
	{
		TimingHitBuilder builder = new TimingHitBuilder().SetTimingCategory(timingCategory).SetTimingInterval(timingInterval).SetTimingName(timingName).SetTimingLabel(timingLabel);
		this.LogTiming(builder);
	}

	// Token: 0x06000047 RID: 71 RVA: 0x00003C24 File Offset: 0x00001E24
	public void LogTiming(TimingHitBuilder builder)
	{
		this.InitializeTracker();
		if (builder.Validate() == null)
		{
			return;
		}
		if (GoogleAnalyticsV3.belowThreshold(this.logLevel, GoogleAnalyticsV3.DebugMode.VERBOSE))
		{
			Debug.Log("Logging timing.");
		}
		this.androidTracker.LogTiming(builder);
	}

	// Token: 0x06000048 RID: 72 RVA: 0x00003C6C File Offset: 0x00001E6C
	public void Dispose()
	{
		this.initialized = false;
		this.androidTracker.Dispose();
	}

	// Token: 0x06000049 RID: 73 RVA: 0x00003C80 File Offset: 0x00001E80
	public static bool belowThreshold(GoogleAnalyticsV3.DebugMode userLogLevel, GoogleAnalyticsV3.DebugMode comparelogLevel)
	{
		return comparelogLevel == userLogLevel || (userLogLevel != GoogleAnalyticsV3.DebugMode.ERROR && (userLogLevel == GoogleAnalyticsV3.DebugMode.VERBOSE || ((userLogLevel != GoogleAnalyticsV3.DebugMode.WARNING || (comparelogLevel != GoogleAnalyticsV3.DebugMode.INFO && comparelogLevel != GoogleAnalyticsV3.DebugMode.VERBOSE)) && (userLogLevel != GoogleAnalyticsV3.DebugMode.INFO || comparelogLevel != GoogleAnalyticsV3.DebugMode.VERBOSE))));
	}

	// Token: 0x0600004A RID: 74 RVA: 0x00003CD0 File Offset: 0x00001ED0
	public static GoogleAnalyticsV3 getInstance()
	{
		return GoogleAnalyticsV3.instance;
	}

	// Token: 0x04000051 RID: 81
	private string uncaughtExceptionStackTrace;

	// Token: 0x04000052 RID: 82
	private bool initialized;

	// Token: 0x04000053 RID: 83
	[global::Tooltip("The tracking code to be used for Android. Example value: UA-XXXX-Y.")]
	public string androidTrackingCode;

	// Token: 0x04000054 RID: 84
	[global::Tooltip("The tracking code to be used for iOS. Example value: UA-XXXX-Y.")]
	public string IOSTrackingCode;

	// Token: 0x04000055 RID: 85
	[global::Tooltip("The tracking code to be used for platforms other than Android and iOS. Example value: UA-XXXX-Y.")]
	public string otherTrackingCode;

	// Token: 0x04000056 RID: 86
	[global::Tooltip("The application name. This value should be modified in the Unity Player Settings.")]
	public string productName;

	// Token: 0x04000057 RID: 87
	[global::Tooltip("The application identifier. Example value: com.company.app.")]
	public string bundleIdentifier;

	// Token: 0x04000058 RID: 88
	[global::Tooltip("The application version. Example value: 1.2")]
	public string bundleVersion;

	// Token: 0x04000059 RID: 89
	[RangedTooltip("The dispatch period in seconds. Only required for Android and iOS.", 0f, 3600f)]
	public int dispatchPeriod = 5;

	// Token: 0x0400005A RID: 90
	[RangedTooltip("The sample rate to use. Only required for Android and iOS.", 0f, 100f)]
	public int sampleFrequency = 100;

	// Token: 0x0400005B RID: 91
	[global::Tooltip("The log level. Default is WARNING.")]
	public GoogleAnalyticsV3.DebugMode logLevel = GoogleAnalyticsV3.DebugMode.WARNING;

	// Token: 0x0400005C RID: 92
	[global::Tooltip("If checked, the IP address of the sender will be anonymized.")]
	public bool anonymizeIP;

	// Token: 0x0400005D RID: 93
	[global::Tooltip("Automatically report uncaught exceptions.")]
	public bool UncaughtExceptionReporting;

	// Token: 0x0400005E RID: 94
	[global::Tooltip("Automatically send a launch event when the game starts up.")]
	public bool sendLaunchEvent;

	// Token: 0x0400005F RID: 95
	[global::Tooltip("If checked, hits will not be dispatched. Use for testing.")]
	public bool dryRun;

	// Token: 0x04000060 RID: 96
	[global::Tooltip("The amount of time in seconds your application can stay inthe background before the session is ended. Default is 30 minutes (1800 seconds). A value of -1 will disable session management.")]
	public int sessionTimeout = 1800;

	// Token: 0x04000061 RID: 97
	public static GoogleAnalyticsV3 instance;

	// Token: 0x04000062 RID: 98
	[HideInInspector]
	public static readonly string currencySymbol = "USD";

	// Token: 0x04000063 RID: 99
	public static readonly string EVENT_HIT = "createEvent";

	// Token: 0x04000064 RID: 100
	public static readonly string APP_VIEW = "createAppView";

	// Token: 0x04000065 RID: 101
	public static readonly string SET = "set";

	// Token: 0x04000066 RID: 102
	public static readonly string SET_ALL = "setAll";

	// Token: 0x04000067 RID: 103
	public static readonly string SEND = "send";

	// Token: 0x04000068 RID: 104
	public static readonly string ITEM_HIT = "createItem";

	// Token: 0x04000069 RID: 105
	public static readonly string TRANSACTION_HIT = "createTransaction";

	// Token: 0x0400006A RID: 106
	public static readonly string SOCIAL_HIT = "createSocial";

	// Token: 0x0400006B RID: 107
	public static readonly string TIMING_HIT = "createTiming";

	// Token: 0x0400006C RID: 108
	public static readonly string EXCEPTION_HIT = "createException";

	// Token: 0x0400006D RID: 109
	private GoogleAnalyticsAndroidV3 androidTracker = new GoogleAnalyticsAndroidV3();

	// Token: 0x0200000C RID: 12
	public enum DebugMode
	{
		// Token: 0x0400006F RID: 111
		ERROR,
		// Token: 0x04000070 RID: 112
		WARNING,
		// Token: 0x04000071 RID: 113
		INFO,
		// Token: 0x04000072 RID: 114
		VERBOSE
	}
}
