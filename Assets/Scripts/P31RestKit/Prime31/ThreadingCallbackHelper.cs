using System;
using System.Collections.Generic;
using UnityEngine;

namespace Prime31
{
	// Token: 0x0200000E RID: 14
	public class ThreadingCallbackHelper : MonoBehaviour
	{
		// Token: 0x0600005E RID: 94 RVA: 0x00004668 File Offset: 0x00002868
		public void addActionToQueue(Action action)
		{
			object actions = this._actions;
			lock (actions)
			{
				this._actions.Add(action);
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000046AC File Offset: 0x000028AC
		private void Update()
		{
			object actions = this._actions;
			lock (actions)
			{
				this._currentActions.AddRange(this._actions);
				this._actions.Clear();
			}
			for (int i = 0; i < this._currentActions.Count; i++)
			{
				this._currentActions[i]();
			}
			this._currentActions.Clear();
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00004738 File Offset: 0x00002938
		public void disableIfEmpty()
		{
			object actions = this._actions;
			lock (actions)
			{
				if (this._actions.Count == 0)
				{
					base.enabled = false;
				}
			}
		}

		// Token: 0x04000029 RID: 41
		private List<Action> _actions = new List<Action>();

		// Token: 0x0400002A RID: 42
		private List<Action> _currentActions = new List<Action>();
	}
}
