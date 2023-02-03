using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000009 RID: 9
public class GoogleAnalyticsAndroidV3 : IDisposable
{
	// Token: 0x0600000B RID: 11 RVA: 0x000024C0 File Offset: 0x000006C0
	internal void InitializeTracker()
	{
		Debug.Log("Initializing Google Analytics Android Tracker.");
		this.analyticsTrackingFields = new AndroidJavaClass("com.google.analytics.tracking.android.Fields");
		using (AndroidJavaObject androidJavaObject = new AndroidJavaClass("com.google.analytics.tracking.android.GoogleAnalytics"))
		{
			using (AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.google.analytics.tracking.android.GAServiceManager"))
			{
				using (AndroidJavaClass androidJavaClass2 = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
				{
					this.currentActivityObject = androidJavaClass2.GetStatic<AndroidJavaObject>("currentActivity");
					this.googleAnalyticsSingleton = androidJavaObject.CallStatic<AndroidJavaObject>("getInstance", new object[]
					{
						this.currentActivityObject
					});
					this.gaServiceManagerSingleton = androidJavaClass.CallStatic<AndroidJavaObject>("getInstance", new object[0]);
					this.gaServiceManagerSingleton.Call("setLocalDispatchPeriod", new object[]
					{
						this.dispatchPeriod
					});
					this.tracker = this.googleAnalyticsSingleton.Call<AndroidJavaObject>("getTracker", new object[]
					{
						this.trackingCode
					});
					this.SetTrackerVal(Fields.SAMPLE_RATE, this.sampleFrequency.ToString());
					this.SetTrackerVal(Fields.APP_NAME, this.appName);
					this.SetTrackerVal(Fields.APP_ID, this.bundleIdentifier);
					this.SetTrackerVal(Fields.APP_VERSION, this.appVersion);
					if (this.anonymizeIP)
					{
						this.SetTrackerVal(Fields.ANONYMIZE_IP, "1");
					}
					this.googleAnalyticsSingleton.Call("setDryRun", new object[]
					{
						this.dryRun
					});
					this.SetLogLevel(this.logLevel);
				}
			}
		}
	}

	// Token: 0x0600000C RID: 12 RVA: 0x000026B0 File Offset: 0x000008B0
	internal void SetTrackerVal(Field fieldName, object value)
	{
		object[] args = new object[]
		{
			fieldName.ToString(),
			value
		};
		this.tracker.Call(GoogleAnalyticsV3.SET, args);
	}

	// Token: 0x0600000D RID: 13 RVA: 0x000026E4 File Offset: 0x000008E4
	public void SetSampleFrequency(int sampleFrequency)
	{
		this.sampleFrequency = sampleFrequency;
	}

	// Token: 0x0600000E RID: 14 RVA: 0x000026F0 File Offset: 0x000008F0
	private void SetLogLevel(GoogleAnalyticsV3.DebugMode logLevel)
	{
		using (this.logger = this.googleAnalyticsSingleton.Call<AndroidJavaObject>("getLogger", new object[0]))
		{
			using (AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.google.analytics.tracking.android.Logger$LogLevel"))
			{
				switch (logLevel)
				{
				case GoogleAnalyticsV3.DebugMode.ERROR:
					using (AndroidJavaObject @static = androidJavaClass.GetStatic<AndroidJavaObject>("ERROR"))
					{
						this.logger.Call("setLogLevel", new object[]
						{
							@static
						});
					}
					goto IL_148;
				case GoogleAnalyticsV3.DebugMode.INFO:
					using (AndroidJavaObject static2 = androidJavaClass.GetStatic<AndroidJavaObject>("INFO"))
					{
						this.logger.Call("setLogLevel", new object[]
						{
							static2
						});
					}
					goto IL_148;
				case GoogleAnalyticsV3.DebugMode.VERBOSE:
					using (AndroidJavaObject static3 = androidJavaClass.GetStatic<AndroidJavaObject>("VERBOSE"))
					{
						this.logger.Call("setLogLevel", new object[]
						{
							static3
						});
					}
					goto IL_148;
				}
				using (AndroidJavaObject static4 = androidJavaClass.GetStatic<AndroidJavaObject>("WARNING"))
				{
					this.logger.Call("setLogLevel", new object[]
					{
						static4
					});
				}
				IL_148:;
			}
		}
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00002900 File Offset: 0x00000B00
	private void SetSessionOnBuilder(AndroidJavaObject hitBuilder)
	{
		if (this.startSessionOnNextHit)
		{
			object[] args = new object[]
			{
				Fields.SESSION_CONTROL.ToString(),
				"start"
			};
			hitBuilder.Call<AndroidJavaObject>("set", args);
			this.startSessionOnNextHit = false;
		}
		else if (this.endSessionOnNextHit)
		{
			object[] args2 = new object[]
			{
				Fields.SESSION_CONTROL.ToString(),
				"end"
			};
			hitBuilder.Call<AndroidJavaObject>("set", args2);
			this.endSessionOnNextHit = false;
		}
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00002988 File Offset: 0x00000B88
	private AndroidJavaObject BuildMap(string methodName)
	{
		AndroidJavaObject result;
		using (AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.google.analytics.tracking.android.MapBuilder"))
		{
			using (AndroidJavaObject androidJavaObject = androidJavaClass.CallStatic<AndroidJavaObject>(methodName, new object[0]))
			{
				this.SetSessionOnBuilder(androidJavaObject);
				result = androidJavaObject.Call<AndroidJavaObject>("build", new object[0]);
			}
		}
		return result;
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00002A28 File Offset: 0x00000C28
	private AndroidJavaObject BuildMap(string methodName, object[] args)
	{
		AndroidJavaObject result;
		using (AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.google.analytics.tracking.android.MapBuilder"))
		{
			using (AndroidJavaObject androidJavaObject = androidJavaClass.CallStatic<AndroidJavaObject>(methodName, args))
			{
				this.SetSessionOnBuilder(androidJavaObject);
				result = androidJavaObject.Call<AndroidJavaObject>("build", new object[0]);
			}
		}
		return result;
	}

	// Token: 0x06000012 RID: 18 RVA: 0x00002AC0 File Offset: 0x00000CC0
	private AndroidJavaObject BuildMap(string methodName, Dictionary<AndroidJavaObject, string> parameters)
	{
		return this.BuildMap(methodName, null, parameters);
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00002ACC File Offset: 0x00000CCC
	private AndroidJavaObject BuildMap(string methodName, object[] simpleArgs, Dictionary<AndroidJavaObject, string> parameters)
	{
		AndroidJavaObject result;
		using (AndroidJavaObject androidJavaObject = new AndroidJavaObject("java.util.HashMap", new object[0]))
		{
			using (AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.google.analytics.tracking.android.MapBuilder"))
			{
				IntPtr methodID = AndroidJNIHelper.GetMethodID(androidJavaObject.GetRawClass(), "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
				object[] array = new object[2];
				foreach (KeyValuePair<AndroidJavaObject, string> keyValuePair in parameters)
				{
					using (AndroidJavaObject key = keyValuePair.Key)
					{
						using (AndroidJavaObject androidJavaObject2 = new AndroidJavaObject("java.lang.String", new object[]
						{
							keyValuePair.Value
						}))
						{
							array[0] = key;
							array[1] = androidJavaObject2;
							AndroidJNI.CallObjectMethod(androidJavaObject.GetRawObject(), methodID, AndroidJNIHelper.CreateJNIArgArray(array));
						}
					}
				}
				if (simpleArgs != null)
				{
					using (AndroidJavaObject androidJavaObject3 = androidJavaClass.CallStatic<AndroidJavaObject>(methodName, simpleArgs))
					{
						androidJavaObject3.Call<AndroidJavaObject>(GoogleAnalyticsV3.SET_ALL, new object[]
						{
							androidJavaObject
						});
						this.SetSessionOnBuilder(androidJavaObject3);
						return androidJavaObject3.Call<AndroidJavaObject>("build", new object[0]);
					}
				}
				using (AndroidJavaObject androidJavaObject4 = androidJavaClass.CallStatic<AndroidJavaObject>(methodName, new object[0]))
				{
					androidJavaObject4.Call<AndroidJavaObject>(GoogleAnalyticsV3.SET_ALL, new object[]
					{
						androidJavaObject
					});
					this.SetSessionOnBuilder(androidJavaObject4);
					result = androidJavaObject4.Call<AndroidJavaObject>("build", new object[0]);
				}
			}
		}
		return result;
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00002D3C File Offset: 0x00000F3C
	private Dictionary<AndroidJavaObject, string> AddCustomVariablesAndCampaignParameters<T>(HitBuilder<T> builder)
	{
		Dictionary<AndroidJavaObject, string> dictionary = new Dictionary<AndroidJavaObject, string>();
		foreach (KeyValuePair<int, string> keyValuePair in builder.GetCustomDimensions())
		{
			AndroidJavaObject key = this.analyticsTrackingFields.CallStatic<AndroidJavaObject>("customDimension", new object[]
			{
				keyValuePair.Key
			});
			dictionary.Add(key, keyValuePair.Value);
		}
		foreach (KeyValuePair<int, string> keyValuePair2 in builder.GetCustomMetrics())
		{
			AndroidJavaObject key = this.analyticsTrackingFields.CallStatic<AndroidJavaObject>("customMetric", new object[]
			{
				keyValuePair2.Key
			});
			dictionary.Add(key, keyValuePair2.Value);
		}
		if (dictionary.Keys.Count > 0 && GoogleAnalyticsV3.belowThreshold(this.logLevel, GoogleAnalyticsV3.DebugMode.VERBOSE))
		{
			Debug.Log("Added custom variables to hit.");
		}
		if (!string.IsNullOrEmpty(builder.GetCampaignSource()))
		{
			AndroidJavaObject key = this.analyticsTrackingFields.GetStatic<AndroidJavaObject>("CAMPAIGN_SOURCE");
			dictionary.Add(key, builder.GetCampaignSource());
			key = this.analyticsTrackingFields.GetStatic<AndroidJavaObject>("CAMPAIGN_MEDIUM");
			dictionary.Add(key, builder.GetCampaignMedium());
			key = this.analyticsTrackingFields.GetStatic<AndroidJavaObject>("CAMPAIGN_NAME");
			dictionary.Add(key, builder.GetCampaignName());
			key = this.analyticsTrackingFields.GetStatic<AndroidJavaObject>("CAMPAIGN_CONTENT");
			dictionary.Add(key, builder.GetCampaignContent());
			key = this.analyticsTrackingFields.GetStatic<AndroidJavaObject>("CAMPAIGN_KEYWORD");
			dictionary.Add(key, builder.GetCampaignKeyword());
			key = this.analyticsTrackingFields.GetStatic<AndroidJavaObject>("CAMPAIGN_ID");
			dictionary.Add(key, builder.GetCampaignID());
			key = this.analyticsTrackingFields.GetStatic<AndroidJavaObject>("GCLID");
			dictionary.Add(key, builder.GetGclid());
			key = this.analyticsTrackingFields.GetStatic<AndroidJavaObject>("DCLID");
			dictionary.Add(key, builder.GetDclid());
			if (GoogleAnalyticsV3.belowThreshold(this.logLevel, GoogleAnalyticsV3.DebugMode.VERBOSE))
			{
				Debug.Log("Added campaign parameters to hit.");
			}
		}
		if (dictionary.Keys.Count > 0)
		{
			return dictionary;
		}
		return null;
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00002FB8 File Offset: 0x000011B8
	internal void StartSession()
	{
		this.startSessionOnNextHit = true;
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00002FC4 File Offset: 0x000011C4
	internal void StopSession()
	{
		this.endSessionOnNextHit = true;
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002FD0 File Offset: 0x000011D0
	public void SetOptOut(bool optOut)
	{
		this.googleAnalyticsSingleton.Call("setAppOptOut", new object[]
		{
			optOut
		});
	}

	// Token: 0x06000018 RID: 24 RVA: 0x00002FF4 File Offset: 0x000011F4
	internal void LogScreen(AppViewHitBuilder builder)
	{
		using (AndroidJavaObject @static = this.analyticsTrackingFields.GetStatic<AndroidJavaObject>("SCREEN_NAME"))
		{
			object[] args = new object[]
			{
				@static,
				builder.GetScreenName()
			};
			this.tracker.Call(GoogleAnalyticsV3.SET, args);
		}
		Dictionary<AndroidJavaObject, string> dictionary = this.AddCustomVariablesAndCampaignParameters<AppViewHitBuilder>(builder);
		if (dictionary != null)
		{
			object obj = this.BuildMap(GoogleAnalyticsV3.APP_VIEW, dictionary);
			this.tracker.Call(GoogleAnalyticsV3.SEND, new object[]
			{
				obj
			});
		}
		else
		{
			object[] args2 = new object[]
			{
				this.BuildMap(GoogleAnalyticsV3.APP_VIEW)
			};
			this.tracker.Call(GoogleAnalyticsV3.SEND, args2);
		}
	}

	// Token: 0x06000019 RID: 25 RVA: 0x000030C8 File Offset: 0x000012C8
	internal void LogEvent(EventHitBuilder builder)
	{
		using (AndroidJavaObject androidJavaObject = new AndroidJavaObject("java.lang.Long", new object[]
		{
			builder.GetEventValue()
		}))
		{
			object[] array = new object[]
			{
				builder.GetEventCategory(),
				builder.GetEventAction(),
				builder.GetEventLabel(),
				androidJavaObject
			};
			Dictionary<AndroidJavaObject, string> dictionary = this.AddCustomVariablesAndCampaignParameters<EventHitBuilder>(builder);
			object obj;
			if (dictionary != null)
			{
				obj = this.BuildMap(GoogleAnalyticsV3.EVENT_HIT, array, dictionary);
			}
			else
			{
				obj = this.BuildMap(GoogleAnalyticsV3.EVENT_HIT, array);
			}
			this.tracker.Call(GoogleAnalyticsV3.SEND, new object[]
			{
				obj
			});
		}
	}

	// Token: 0x0600001A RID: 26 RVA: 0x00003190 File Offset: 0x00001390
	internal void LogTransaction(TransactionHitBuilder builder)
	{
		AndroidJavaObject[] array = new AndroidJavaObject[]
		{
			new AndroidJavaObject("java.lang.Double", new object[]
			{
				builder.GetRevenue()
			}),
			new AndroidJavaObject("java.lang.Double", new object[]
			{
				builder.GetTax()
			}),
			new AndroidJavaObject("java.lang.Double", new object[]
			{
				builder.GetShipping()
			})
		};
		object[] array2 = new object[6];
		array2[0] = builder.GetTransactionID();
		array2[1] = builder.GetAffiliation();
		array2[2] = array[0];
		array2[3] = array[1];
		array2[4] = array[2];
		if (builder.GetCurrencyCode() == null)
		{
			array2[5] = GoogleAnalyticsV3.currencySymbol;
		}
		else
		{
			array2[5] = builder.GetCurrencyCode();
		}
		Dictionary<AndroidJavaObject, string> dictionary = this.AddCustomVariablesAndCampaignParameters<TransactionHitBuilder>(builder);
		object obj;
		if (dictionary != null)
		{
			obj = this.BuildMap(GoogleAnalyticsV3.TRANSACTION_HIT, array2, dictionary);
		}
		else
		{
			obj = this.BuildMap(GoogleAnalyticsV3.TRANSACTION_HIT, array2);
		}
		this.tracker.Call(GoogleAnalyticsV3.SEND, new object[]
		{
			obj
		});
	}

	// Token: 0x0600001B RID: 27 RVA: 0x0000329C File Offset: 0x0000149C
	internal void LogItem(ItemHitBuilder builder)
	{
		object[] array;
		if (builder.GetCurrencyCode() != null)
		{
			array = new object[]
			{
				null,
				null,
				null,
				null,
				null,
				null,
				builder.GetCurrencyCode()
			};
		}
		else
		{
			array = new object[6];
		}
		array[0] = builder.GetTransactionID();
		array[1] = builder.GetName();
		array[2] = builder.GetSKU();
		array[3] = builder.GetCategory();
		array[4] = new AndroidJavaObject("java.lang.Double", new object[]
		{
			builder.GetPrice()
		});
		array[5] = new AndroidJavaObject("java.lang.Long", new object[]
		{
			builder.GetQuantity()
		});
		Dictionary<AndroidJavaObject, string> dictionary = this.AddCustomVariablesAndCampaignParameters<ItemHitBuilder>(builder);
		object obj;
		if (dictionary != null)
		{
			obj = this.BuildMap(GoogleAnalyticsV3.ITEM_HIT, array, dictionary);
		}
		else
		{
			obj = this.BuildMap(GoogleAnalyticsV3.ITEM_HIT, array);
		}
		this.tracker.Call(GoogleAnalyticsV3.SEND, new object[]
		{
			obj
		});
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00003380 File Offset: 0x00001580
	public void LogException(ExceptionHitBuilder builder)
	{
		object[] array = new object[]
		{
			builder.GetExceptionDescription(),
			new AndroidJavaObject("java.lang.Boolean", new object[]
			{
				builder.IsFatal()
			})
		};
		Dictionary<AndroidJavaObject, string> dictionary = this.AddCustomVariablesAndCampaignParameters<ExceptionHitBuilder>(builder);
		object obj;
		if (dictionary != null)
		{
			obj = this.BuildMap(GoogleAnalyticsV3.EXCEPTION_HIT, array, dictionary);
		}
		else
		{
			obj = this.BuildMap(GoogleAnalyticsV3.EXCEPTION_HIT, array);
		}
		this.tracker.Call(GoogleAnalyticsV3.SEND, new object[]
		{
			obj
		});
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00003408 File Offset: 0x00001608
	public void DispatchHits()
	{
		this.gaServiceManagerSingleton.Call("dispatchLocalHits", new object[0]);
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00003420 File Offset: 0x00001620
	public void LogSocial(SocialHitBuilder builder)
	{
		object[] array = new object[]
		{
			builder.GetSocialNetwork(),
			builder.GetSocialAction(),
			builder.GetSocialTarget()
		};
		Dictionary<AndroidJavaObject, string> dictionary = this.AddCustomVariablesAndCampaignParameters<SocialHitBuilder>(builder);
		object obj;
		if (dictionary != null)
		{
			obj = this.BuildMap(GoogleAnalyticsV3.SOCIAL_HIT, array, dictionary);
		}
		else
		{
			obj = this.BuildMap(GoogleAnalyticsV3.SOCIAL_HIT, array);
		}
		this.tracker.Call(GoogleAnalyticsV3.SEND, new object[]
		{
			obj
		});
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00003498 File Offset: 0x00001698
	public void LogTiming(TimingHitBuilder builder)
	{
		using (AndroidJavaObject androidJavaObject = new AndroidJavaObject("java.lang.Long", new object[]
		{
			builder.GetTimingInterval()
		}))
		{
			object[] array = new object[]
			{
				builder.GetTimingCategory(),
				androidJavaObject,
				builder.GetTimingName(),
				builder.GetTimingLabel()
			};
			Dictionary<AndroidJavaObject, string> dictionary = this.AddCustomVariablesAndCampaignParameters<TimingHitBuilder>(builder);
			object obj;
			if (dictionary != null)
			{
				obj = this.BuildMap(GoogleAnalyticsV3.TIMING_HIT, array, dictionary);
			}
			else
			{
				obj = this.BuildMap(GoogleAnalyticsV3.TIMING_HIT, array);
			}
			this.tracker.Call(GoogleAnalyticsV3.SEND, new object[]
			{
				obj
			});
		}
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00003560 File Offset: 0x00001760
	public void ClearUserIDOverride()
	{
		this.SetTrackerVal(Fields.USER_ID, null);
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00003570 File Offset: 0x00001770
	public void SetTrackingCode(string trackingCode)
	{
		this.trackingCode = trackingCode;
	}

	// Token: 0x06000022 RID: 34 RVA: 0x0000357C File Offset: 0x0000177C
	public void SetAppName(string appName)
	{
		this.appName = appName;
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00003588 File Offset: 0x00001788
	public void SetBundleIdentifier(string bundleIdentifier)
	{
		this.bundleIdentifier = bundleIdentifier;
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00003594 File Offset: 0x00001794
	public void SetAppVersion(string appVersion)
	{
		this.appVersion = appVersion;
	}

	// Token: 0x06000025 RID: 37 RVA: 0x000035A0 File Offset: 0x000017A0
	public void SetDispatchPeriod(int dispatchPeriod)
	{
		this.dispatchPeriod = dispatchPeriod;
	}

	// Token: 0x06000026 RID: 38 RVA: 0x000035AC File Offset: 0x000017AC
	public void SetLogLevelValue(GoogleAnalyticsV3.DebugMode logLevel)
	{
		this.logLevel = logLevel;
	}

	// Token: 0x06000027 RID: 39 RVA: 0x000035B8 File Offset: 0x000017B8
	public void SetAnonymizeIP(bool anonymizeIP)
	{
		this.anonymizeIP = anonymizeIP;
	}

	// Token: 0x06000028 RID: 40 RVA: 0x000035C4 File Offset: 0x000017C4
	public void SetDryRun(bool dryRun)
	{
		this.dryRun = dryRun;
	}

	// Token: 0x06000029 RID: 41 RVA: 0x000035D0 File Offset: 0x000017D0
	public void Dispose()
	{
		this.googleAnalyticsSingleton.Dispose();
		this.tracker.Dispose();
		this.analyticsTrackingFields.Dispose();
	}

	// Token: 0x0400003F RID: 63
	private string trackingCode;

	// Token: 0x04000040 RID: 64
	private string appVersion;

	// Token: 0x04000041 RID: 65
	private string appName;

	// Token: 0x04000042 RID: 66
	private string bundleIdentifier;

	// Token: 0x04000043 RID: 67
	private int dispatchPeriod;

	// Token: 0x04000044 RID: 68
	private int sampleFrequency;

	// Token: 0x04000045 RID: 69
	private GoogleAnalyticsV3.DebugMode logLevel;

	// Token: 0x04000046 RID: 70
	private bool anonymizeIP;

	// Token: 0x04000047 RID: 71
	private bool dryRun;

	// Token: 0x04000048 RID: 72
	private int sessionTimeout;

	// Token: 0x04000049 RID: 73
	private AndroidJavaObject tracker;

	// Token: 0x0400004A RID: 74
	private AndroidJavaObject logger;

	// Token: 0x0400004B RID: 75
	private AndroidJavaObject currentActivityObject;

	// Token: 0x0400004C RID: 76
	private AndroidJavaObject googleAnalyticsSingleton;

	// Token: 0x0400004D RID: 77
	private AndroidJavaObject gaServiceManagerSingleton;

	// Token: 0x0400004E RID: 78
	private AndroidJavaClass analyticsTrackingFields;

	// Token: 0x0400004F RID: 79
	private bool startSessionOnNextHit;

	// Token: 0x04000050 RID: 80
	private bool endSessionOnNextHit;
}
