using System;
using System.Collections.Generic;
using UnityEngine;

namespace OnePF
{
	// Token: 0x02000016 RID: 22
	public class OpenIAB_Android : IOpenIAB
	{
		// Token: 0x060000AF RID: 175 RVA: 0x0000449C File Offset: 0x0000269C
		static OpenIAB_Android()
		{
			if (Application.platform != RuntimePlatform.Android)
			{
				OpenIAB_Android.STORE_GOOGLE = "STORE_GOOGLE";
				OpenIAB_Android.STORE_AMAZON = "STORE_AMAZON";
				OpenIAB_Android.STORE_SAMSUNG = "STORE_SAMSUNG";
				OpenIAB_Android.STORE_NOKIA = "STORE_NOKIA";
				OpenIAB_Android.STORE_SKUBIT = "STORE_SKUBIT";
				OpenIAB_Android.STORE_SKUBIT_TEST = "STORE_SKUBIT_TEST";
				OpenIAB_Android.STORE_YANDEX = "STORE_YANDEX";
				OpenIAB_Android.STORE_APPLAND = "STORE_APPLAND";
				OpenIAB_Android.STORE_SLIDEME = "STORE_SLIDEME";
				OpenIAB_Android.STORE_APTOIDE = "STORE_APTOIDE";
				return;
			}
			AndroidJNI.AttachCurrentThread();
			using (AndroidJavaClass androidJavaClass = new AndroidJavaClass("org.onepf.openiab.UnityPlugin"))
			{
				OpenIAB_Android._plugin = androidJavaClass.CallStatic<AndroidJavaObject>("instance", new object[0]);
			}
			using (AndroidJavaClass androidJavaClass2 = new AndroidJavaClass("org.onepf.oms.OpenIabHelper"))
			{
				OpenIAB_Android.STORE_GOOGLE = androidJavaClass2.GetStatic<string>("NAME_GOOGLE");
				OpenIAB_Android.STORE_AMAZON = androidJavaClass2.GetStatic<string>("NAME_AMAZON");
				OpenIAB_Android.STORE_SAMSUNG = androidJavaClass2.GetStatic<string>("NAME_SAMSUNG");
				OpenIAB_Android.STORE_NOKIA = androidJavaClass2.GetStatic<string>("NAME_NOKIA");
				OpenIAB_Android.STORE_SKUBIT = androidJavaClass2.GetStatic<string>("NAME_SKUBIT");
				OpenIAB_Android.STORE_SKUBIT_TEST = androidJavaClass2.GetStatic<string>("NAME_SKUBIT_TEST");
				OpenIAB_Android.STORE_YANDEX = androidJavaClass2.GetStatic<string>("NAME_YANDEX");
				OpenIAB_Android.STORE_APPLAND = androidJavaClass2.GetStatic<string>("NAME_APPLAND");
				OpenIAB_Android.STORE_SLIDEME = androidJavaClass2.GetStatic<string>("NAME_SLIDEME");
				OpenIAB_Android.STORE_APTOIDE = androidJavaClass2.GetStatic<string>("NAME_APTOIDE");
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00004644 File Offset: 0x00002844
		private IntPtr ConvertToStringJNIArray(string[] array)
		{
			IntPtr clazz = AndroidJNI.FindClass("java/lang/String");
			IntPtr obj = AndroidJNI.NewStringUTF(string.Empty);
			IntPtr intPtr = AndroidJNI.NewObjectArray(array.Length, clazz, obj);
			for (int i = 0; i < array.Length; i++)
			{
				AndroidJNI.SetObjectArrayElement(intPtr, i, AndroidJNI.NewStringUTF(array[i]));
			}
			return intPtr;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00004698 File Offset: 0x00002898
		private bool IsDevice()
		{
			return Application.platform == RuntimePlatform.Android;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000046AC File Offset: 0x000028AC
		private AndroidJavaObject CreateJavaHashMap(Dictionary<string, string> storeKeys)
		{
			AndroidJavaObject androidJavaObject = new AndroidJavaObject("java.util.HashMap", new object[0]);
			IntPtr methodID = AndroidJNIHelper.GetMethodID(androidJavaObject.GetRawClass(), "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			if (storeKeys != null)
			{
				object[] array = new object[2];
				foreach (KeyValuePair<string, string> keyValuePair in storeKeys)
				{
					using (AndroidJavaObject androidJavaObject2 = new AndroidJavaObject("java.lang.String", new object[]
					{
						keyValuePair.Key
					}))
					{
						using (AndroidJavaObject androidJavaObject3 = new AndroidJavaObject("java.lang.String", new object[]
						{
							keyValuePair.Value
						}))
						{
							array[0] = androidJavaObject2;
							array[1] = androidJavaObject3;
							AndroidJNI.CallObjectMethod(androidJavaObject.GetRawObject(), methodID, AndroidJNIHelper.CreateJNIArgArray(array));
						}
					}
				}
			}
			return androidJavaObject;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000047EC File Offset: 0x000029EC
		public void init(Options options)
		{
			if (!this.IsDevice())
			{
				OpenIAB.EventManager.SendMessage("OnBillingSupported", string.Empty);
				return;
			}
			using (AndroidJavaObject androidJavaObject = new AndroidJavaObject("org.onepf.oms.OpenIabHelper$Options$Builder", new object[0]))
			{
				IntPtr rawClass = androidJavaObject.GetRawClass();
				IntPtr rawObject = androidJavaObject.GetRawObject();
				androidJavaObject.Call<AndroidJavaObject>("setDiscoveryTimeout", new object[]
				{
					options.discoveryTimeoutMs
				}).Call<AndroidJavaObject>("setCheckInventory", new object[]
				{
					options.checkInventory
				}).Call<AndroidJavaObject>("setCheckInventoryTimeout", new object[]
				{
					options.checkInventoryTimeoutMs
				}).Call<AndroidJavaObject>("setVerifyMode", new object[]
				{
					(int)options.verifyMode
				}).Call<AndroidJavaObject>("setStoreSearchStrategy", new object[]
				{
					(int)options.storeSearchStrategy
				});
				if (options.samsungCertificationRequestCode > 0)
				{
					androidJavaObject.Call<AndroidJavaObject>("setSamsungCertificationRequestCode", new object[]
					{
						options.samsungCertificationRequestCode
					});
				}
				foreach (KeyValuePair<string, string> keyValuePair in options.storeKeys)
				{
					androidJavaObject.Call<AndroidJavaObject>("addStoreKey", new object[]
					{
						keyValuePair.Key,
						keyValuePair.Value
					});
				}
				IntPtr methodID = AndroidJNI.GetMethodID(rawClass, "addPreferredStoreName", "([Ljava/lang/String;)Lorg/onepf/oms/OpenIabHelper$Options$Builder;");
				jvalue[] array = new jvalue[1];
				array[0].l = this.ConvertToStringJNIArray(options.prefferedStoreNames);
				AndroidJNI.CallObjectMethod(rawObject, methodID, array);
				IntPtr methodID2 = AndroidJNI.GetMethodID(rawClass, "addAvailableStoreNames", "([Ljava/lang/String;)Lorg/onepf/oms/OpenIabHelper$Options$Builder;");
				array = new jvalue[1];
				array[0].l = this.ConvertToStringJNIArray(options.availableStoreNames);
				AndroidJNI.CallObjectMethod(rawObject, methodID2, array);
				IntPtr methodID3 = AndroidJNI.GetMethodID(rawClass, "build", "()Lorg/onepf/oms/OpenIabHelper$Options;");
				IntPtr l = AndroidJNI.CallObjectMethod(rawObject, methodID3, new jvalue[0]);
				IntPtr methodID4 = AndroidJNI.GetMethodID(OpenIAB_Android._plugin.GetRawClass(), "initWithOptions", "(Lorg/onepf/oms/OpenIabHelper$Options;)V");
				array = new jvalue[1];
				array[0].l = l;
				AndroidJNI.CallVoidMethod(OpenIAB_Android._plugin.GetRawObject(), methodID4, array);
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00004A84 File Offset: 0x00002C84
		public void init(Dictionary<string, string> storeKeys = null)
		{
			if (!this.IsDevice())
			{
				return;
			}
			if (storeKeys != null)
			{
				AndroidJavaObject androidJavaObject = this.CreateJavaHashMap(storeKeys);
				OpenIAB_Android._plugin.Call("init", new object[]
				{
					androidJavaObject
				});
				androidJavaObject.Dispose();
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00004ACC File Offset: 0x00002CCC
		public void mapSku(string sku, string storeName, string storeSku)
		{
			if (!this.IsDevice())
			{
				return;
			}
			OpenIAB_Android._plugin.Call("mapSku", new object[]
			{
				sku,
				storeName,
				storeSku
			});
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00004AFC File Offset: 0x00002CFC
		public void unbindService()
		{
			if (this.IsDevice())
			{
				OpenIAB_Android._plugin.Call("unbindService", new object[0]);
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00004B2C File Offset: 0x00002D2C
		public bool areSubscriptionsSupported()
		{
			return !this.IsDevice() || OpenIAB_Android._plugin.Call<bool>("areSubscriptionsSupported", new object[0]);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00004B5C File Offset: 0x00002D5C
		public void queryInventory()
		{
			if (!this.IsDevice())
			{
				return;
			}
			IntPtr methodID = AndroidJNI.GetMethodID(OpenIAB_Android._plugin.GetRawClass(), "queryInventory", "()V");
			AndroidJNI.CallVoidMethod(OpenIAB_Android._plugin.GetRawObject(), methodID, new jvalue[0]);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00004BA8 File Offset: 0x00002DA8
		public void queryInventory(string[] skus)
		{
			this.queryInventory(skus, skus);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00004BB4 File Offset: 0x00002DB4
		private void queryInventory(string[] inAppSkus, string[] subsSkus)
		{
			if (!this.IsDevice())
			{
				return;
			}
			jvalue[] array = new jvalue[2];
			array[0].l = this.ConvertToStringJNIArray(inAppSkus);
			array[1].l = this.ConvertToStringJNIArray(subsSkus);
			IntPtr methodID = AndroidJNI.GetMethodID(OpenIAB_Android._plugin.GetRawClass(), "queryInventory", "([Ljava/lang/String;[Ljava/lang/String;)V");
			AndroidJNI.CallVoidMethod(OpenIAB_Android._plugin.GetRawObject(), methodID, array);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00004C28 File Offset: 0x00002E28
		public void purchaseProduct(string sku, string developerPayload = "")
		{
			if (!this.IsDevice())
			{
				OpenIAB.EventManager.SendMessage("OnPurchaseSucceeded", Purchase.CreateFromSku(sku, developerPayload).Serialize());
				return;
			}
			OpenIAB_Android._plugin.Call("purchaseProduct", new object[]
			{
				sku,
				developerPayload
			});
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00004C7C File Offset: 0x00002E7C
		public void purchaseSubscription(string sku, string developerPayload = "")
		{
			if (!this.IsDevice())
			{
				OpenIAB.EventManager.SendMessage("OnPurchaseSucceeded", Purchase.CreateFromSku(sku, developerPayload).Serialize());
				return;
			}
			OpenIAB_Android._plugin.Call("purchaseSubscription", new object[]
			{
				sku,
				developerPayload
			});
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00004CD0 File Offset: 0x00002ED0
		public void consumeProduct(Purchase purchase)
		{
			if (!this.IsDevice())
			{
				OpenIAB.EventManager.SendMessage("OnConsumePurchaseSucceeded", purchase.Serialize());
				return;
			}
			OpenIAB_Android._plugin.Call("consumeProduct", new object[]
			{
				purchase.Serialize()
			});
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00004D1C File Offset: 0x00002F1C
		public void restoreTransactions()
		{
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00004D20 File Offset: 0x00002F20
		public bool isDebugLog()
		{
			return OpenIAB_Android._plugin.Call<bool>("isDebugLog", new object[0]);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00004D38 File Offset: 0x00002F38
		public void enableDebugLogging(bool enabled)
		{
			OpenIAB_Android._plugin.Call("enableDebugLogging", new object[]
			{
				enabled
			});
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00004D58 File Offset: 0x00002F58
		public void enableDebugLogging(bool enabled, string tag)
		{
			OpenIAB_Android._plugin.Call("enableDebugLogging", new object[]
			{
				enabled,
				tag
			});
		}

		// Token: 0x04000098 RID: 152
		public static readonly string STORE_GOOGLE;

		// Token: 0x04000099 RID: 153
		public static readonly string STORE_AMAZON;

		// Token: 0x0400009A RID: 154
		public static readonly string STORE_SAMSUNG;

		// Token: 0x0400009B RID: 155
		public static readonly string STORE_NOKIA;

		// Token: 0x0400009C RID: 156
		public static readonly string STORE_SKUBIT;

		// Token: 0x0400009D RID: 157
		public static readonly string STORE_SKUBIT_TEST;

		// Token: 0x0400009E RID: 158
		public static readonly string STORE_YANDEX;

		// Token: 0x0400009F RID: 159
		public static readonly string STORE_APPLAND;

		// Token: 0x040000A0 RID: 160
		public static readonly string STORE_SLIDEME;

		// Token: 0x040000A1 RID: 161
		public static readonly string STORE_APTOIDE;

		// Token: 0x040000A2 RID: 162
		private static AndroidJavaObject _plugin;
	}
}
