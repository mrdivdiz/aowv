using System;
using System.Collections;

namespace UnityEngine.Advertisements
{
	// Token: 0x02000030 RID: 48
	internal class AsyncExec
	{
		// Token: 0x060001FB RID: 507 RVA: 0x000087F0 File Offset: 0x000069F0
		private static MonoBehaviour getImpl()
		{
			if (!AsyncExec.init)
			{
				AsyncExec.asyncImpl = new AsyncExec();
				AsyncExec.asyncExecGameObject = new GameObject("Unity Ads Coroutine Host")
				{
					hideFlags = HideFlags.HideAndDontSave
				};
				AsyncExec.coroutineHost = AsyncExec.asyncExecGameObject.AddComponent<MonoBehaviour>();
				Object.DontDestroyOnLoad(AsyncExec.asyncExecGameObject);
				AsyncExec.init = true;
			}
			return AsyncExec.coroutineHost;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00008850 File Offset: 0x00006A50
		private static AsyncExec getAsyncImpl()
		{
			if (!AsyncExec.init)
			{
				AsyncExec.getImpl();
			}
			return AsyncExec.asyncImpl;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00008868 File Offset: 0x00006A68
		public static void runWithCallback<K, T>(Func<K, Action<T>, IEnumerator> asyncMethod, K arg0, Action<T> callback)
		{
			AsyncExec.getImpl().StartCoroutine(asyncMethod(arg0, callback));
		}

		// Token: 0x04000104 RID: 260
		private static GameObject asyncExecGameObject;

		// Token: 0x04000105 RID: 261
		private static MonoBehaviour coroutineHost;

		// Token: 0x04000106 RID: 262
		private static AsyncExec asyncImpl;

		// Token: 0x04000107 RID: 263
		private static bool init;
	}
}
