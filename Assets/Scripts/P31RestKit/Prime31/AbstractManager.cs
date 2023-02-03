using System;
using UnityEngine;

namespace Prime31
{
	// Token: 0x0200000D RID: 13
	public abstract class AbstractManager : MonoBehaviour
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00004484 File Offset: 0x00002684
		public static LifecycleHelper coroutineSurrogate
		{
			get
			{
				if (AbstractManager._prime31LifecycleHelperRef == null)
				{
					GameObject prime31ManagerGameObject = AbstractManager.getPrime31ManagerGameObject();
					AbstractManager._prime31LifecycleHelperRef = prime31ManagerGameObject.AddComponent<LifecycleHelper>();
				}
				return AbstractManager._prime31LifecycleHelperRef;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000057 RID: 87 RVA: 0x000044B7 File Offset: 0x000026B7
		public static LifecycleHelper lifecycleHelper
		{
			get
			{
				return AbstractManager.coroutineSurrogate;
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000044BE File Offset: 0x000026BE
		public static ThreadingCallbackHelper getThreadingCallbackHelper()
		{
			return AbstractManager._threadingCallbackHelper;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000044C8 File Offset: 0x000026C8
		public static void createThreadingCallbackHelper()
		{
			if (AbstractManager._threadingCallbackHelper != null)
			{
				return;
			}
			AbstractManager._threadingCallbackHelper = (UnityEngine.Object.FindObjectOfType(typeof(ThreadingCallbackHelper)) as ThreadingCallbackHelper);
			if (AbstractManager._threadingCallbackHelper != null)
			{
				return;
			}
			GameObject prime31ManagerGameObject = AbstractManager.getPrime31ManagerGameObject();
			AbstractManager._threadingCallbackHelper = prime31ManagerGameObject.AddComponent<ThreadingCallbackHelper>();
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00004524 File Offset: 0x00002724
		public static GameObject getPrime31ManagerGameObject()
		{
			if (AbstractManager._prime31GameObject != null)
			{
				return AbstractManager._prime31GameObject;
			}
			AbstractManager._prime31GameObject = GameObject.Find("prime[31]");
			if (AbstractManager._prime31GameObject == null)
			{
				AbstractManager._prime31GameObject = new GameObject("prime[31]");
				UnityEngine.Object.DontDestroyOnLoad(AbstractManager._prime31GameObject);
			}
			return AbstractManager._prime31GameObject;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00004584 File Offset: 0x00002784
		public static void initialize(Type type)
		{
			try
			{
				MonoBehaviour x = UnityEngine.Object.FindObjectOfType(type) as MonoBehaviour;
				if (!(x != null))
				{
					GameObject prime31ManagerGameObject = AbstractManager.getPrime31ManagerGameObject();
					GameObject gameObject = new GameObject(type.Name);
					gameObject.AddComponent(type);
					gameObject.transform.parent = prime31ManagerGameObject.transform;
					UnityEngine.Object.DontDestroyOnLoad(gameObject);
				}
			}
			catch (UnityException)
			{
				Debug.LogWarning(string.Concat(new object[]
				{
					"It looks like you have the ",
					type,
					" on a GameObject in your scene. Our new prefab-less manager system does not require the ",
					type,
					" to be on a GameObject.\nIt will be added to your scene at runtime automatically for you. Please remove the script from your scene."
				}));
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000462C File Offset: 0x0000282C
		private void Awake()
		{
			base.gameObject.name = base.GetType().Name;
			UnityEngine.Object.DontDestroyOnLoad(this);
		}

		// Token: 0x04000026 RID: 38
		private static LifecycleHelper _prime31LifecycleHelperRef;

		// Token: 0x04000027 RID: 39
		private static ThreadingCallbackHelper _threadingCallbackHelper;

		// Token: 0x04000028 RID: 40
		private static GameObject _prime31GameObject;
	}
}
