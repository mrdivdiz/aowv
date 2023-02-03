using System;
using UnityEngine;

namespace Prime31
{
	// Token: 0x02000026 RID: 38
	public class LifecycleHelper : MonoBehaviour
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060000EF RID: 239 RVA: 0x00007D18 File Offset: 0x00005F18
		// (remove) Token: 0x060000F0 RID: 240 RVA: 0x00007D50 File Offset: 0x00005F50
		public event Action<bool> onApplicationPausedEvent;

		// Token: 0x060000F1 RID: 241 RVA: 0x00007D86 File Offset: 0x00005F86
		private void OnApplicationPause(bool paused)
		{
			if (this.onApplicationPausedEvent != null)
			{
				this.onApplicationPausedEvent(paused);
			}
		}
	}
}
