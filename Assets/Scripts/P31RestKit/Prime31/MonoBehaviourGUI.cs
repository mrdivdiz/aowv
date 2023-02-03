using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Prime31
{
	// Token: 0x0200000C RID: 12
	public class MonoBehaviourGUI : MonoBehaviour
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00003BFC File Offset: 0x00001DFC
		private Texture2D normalBackground
		{
			get
			{
				if (!this._normalBackground)
				{
					this._normalBackground = new Texture2D(1, 1);
					this._normalBackground.SetPixel(0, 0, Color.gray);
					this._normalBackground.Apply();
				}
				return this._normalBackground;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00003C4C File Offset: 0x00001E4C
		private Texture2D bottomButtonBackground
		{
			get
			{
				if (!this._bottomButtonBackground)
				{
					this._bottomButtonBackground = new Texture2D(1, 1);
					this._bottomButtonBackground.SetPixel(0, 0, Color.Lerp(Color.gray, Color.black, 0.5f));
					this._bottomButtonBackground.Apply();
				}
				return this._bottomButtonBackground;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00003CA8 File Offset: 0x00001EA8
		private Texture2D activeBackground
		{
			get
			{
				if (!this._activeBackground)
				{
					this._activeBackground = new Texture2D(1, 1);
					this._activeBackground.SetPixel(0, 0, Color.yellow);
					this._activeBackground.Apply();
				}
				return this._activeBackground;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00003CF8 File Offset: 0x00001EF8
		private Texture2D toggleButtonBackground
		{
			get
			{
				if (!this._toggleButtonBackground)
				{
					this._toggleButtonBackground = new Texture2D(1, 1);
					this._toggleButtonBackground.SetPixel(0, 0, Color.black);
					this._toggleButtonBackground.Apply();
				}
				return this._toggleButtonBackground;
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00003D45 File Offset: 0x00001F45
		private bool isRetinaOrLargeScreen()
		{
			return this._isWindowsPhone || Screen.width >= 960 || Screen.height >= 960;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00003D73 File Offset: 0x00001F73
		private bool isRetinaIpad()
		{
			if (!this._didRetinaIpadCheck)
			{
				if (Screen.height >= 2048 || Screen.width >= 2048)
				{
					this._isRetinaIpad = true;
				}
				this._didRetinaIpadCheck = true;
			}
			return this._isRetinaIpad;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00003DB2 File Offset: 0x00001FB2
		private int buttonHeight()
		{
			if (!this.isRetinaOrLargeScreen())
			{
				return 30;
			}
			if (this.isRetinaIpad())
			{
				return 140;
			}
			return 70;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00003DD5 File Offset: 0x00001FD5
		private int buttonFontSize()
		{
			if (!this.isRetinaOrLargeScreen())
			{
				return 15;
			}
			if (this.isRetinaIpad())
			{
				return 40;
			}
			return 25;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00003DF8 File Offset: 0x00001FF8
		private void paintWindow(int id)
		{
			GUI.skin.label.alignment = TextAnchor.UpperLeft;
			GUI.skin.label.fontSize = this.buttonFontSize();
			this._logScrollPosition = GUILayout.BeginScrollView(this._logScrollPosition, new GUILayoutOption[0]);
			if (GUILayout.Button("Clear Console", new GUILayoutOption[0]))
			{
				this._logBuilder.Remove(0, this._logBuilder.Length);
			}
			GUILayout.Label(this._logBuilder.ToString(), new GUILayoutOption[0]);
			GUILayout.EndScrollView();
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00003E89 File Offset: 0x00002089
		private void handleLog(string logString, string stackTrace, LogType type)
		{
			this._logBuilder.AppendFormat("{0}\n", logString);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00003E9D File Offset: 0x0000209D
		private void OnDestroy()
		{
			Application.RegisterLogCallback(null);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00003EA8 File Offset: 0x000020A8
		private void Update()
		{
			if (!this._logRegistered)
			{
				Application.RegisterLogCallback(new Application.LogCallback(this.handleLog));
				this._logRegistered = true;
				this._isWindowsPhone = Application.platform.ToString().ToLower().Contains("wp8");
			}
			bool flag = false;
			if (Input.GetMouseButtonDown(0))
			{
				float num = Time.time - this._previousClickTime;
				if (num < this._doubleClickDelay)
				{
					flag = true;
				}
				else
				{
					this._previousClickTime = Time.time;
				}
			}
			if (flag)
			{
				this._isShowingLogConsole = !this._isShowingLogConsole;
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00003F50 File Offset: 0x00002150
		protected void beginColumn()
		{
			this._width = (float)(Screen.width / 2 - 15);
			this._buttonHeight = (float)this.buttonHeight();
			GUI.skin.button.fontSize = this.buttonFontSize();
			GUI.skin.button.margin = new RectOffset(0, 0, 10, 0);
			GUI.skin.button.stretchWidth = true;
			GUI.skin.button.fixedHeight = this._buttonHeight;
			GUI.skin.button.wordWrap = false;
			GUI.skin.button.hover.background = this.normalBackground;
			GUI.skin.button.normal.background = this.normalBackground;
			GUI.skin.button.active.background = this.activeBackground;
			GUI.skin.button.active.textColor = Color.black;
			GUI.skin.label.normal.textColor = Color.black;
			GUI.skin.label.fontSize = this.buttonFontSize();
			if (this._isShowingLogConsole)
			{
				GUILayout.BeginArea(new Rect(0f, 0f, 0f, 0f));
			}
			else
			{
				GUILayout.BeginArea(new Rect(10f, 10f, this._width, (float)Screen.height));
			}
			GUILayout.BeginVertical(new GUILayoutOption[0]);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000040CC File Offset: 0x000022CC
		protected void endColumn()
		{
			this.endColumn(false);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000040D8 File Offset: 0x000022D8
		protected void endColumn(bool hasSecondColumn)
		{
			GUILayout.EndVertical();
			GUILayout.EndArea();
			if (this._isShowingLogConsole)
			{
				GUILayout.Window(1, new Rect(0f, 0f, (float)Screen.width, (float)Screen.height), new GUI.WindowFunction(this.paintWindow), "prime[31] Log Console - double tap to dismiss", new GUILayoutOption[0]);
			}
			if (hasSecondColumn)
			{
				this.beginRightColumn();
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00004140 File Offset: 0x00002340
		private void beginRightColumn()
		{
			if (this._isShowingLogConsole)
			{
				GUILayout.BeginArea(new Rect(0f, 0f, 0f, 0f));
			}
			else
			{
				GUILayout.BeginArea(new Rect((float)Screen.width - this._width - 10f, 10f, this._width, (float)Screen.height));
			}
			GUILayout.BeginVertical(new GUILayoutOption[0]);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000041B4 File Offset: 0x000023B4
		protected bool button(string text)
		{
			return GUILayout.Button(text, new GUILayoutOption[0]);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000041C4 File Offset: 0x000023C4
		protected bool bottomRightButton(string text, float width = 150f)
		{
			GUI.skin.button.hover.background = this.bottomButtonBackground;
			GUI.skin.button.normal.background = this.bottomButtonBackground;
			width = (float)Screen.width / 2f - 35f - 20f;
			return GUI.Button(new Rect((float)Screen.width - width - 10f, (float)Screen.height - this._buttonHeight - 10f, width, this._buttonHeight), text);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00004254 File Offset: 0x00002454
		protected bool bottomLeftButton(string text, float width = 150f)
		{
			GUI.skin.button.hover.background = this.bottomButtonBackground;
			GUI.skin.button.normal.background = this.bottomButtonBackground;
			width = (float)Screen.width / 2f - 35f - 20f;
			return GUI.Button(new Rect(10f, (float)Screen.height - this._buttonHeight - 10f, width, this._buttonHeight), text);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000042DC File Offset: 0x000024DC
		protected bool bottomCenterButton(string text, float width = 150f)
		{
			GUI.skin.button.hover.background = this.bottomButtonBackground;
			GUI.skin.button.normal.background = this.bottomButtonBackground;
			float left = (float)(Screen.width / 2) - width / 2f;
			return GUI.Button(new Rect(left, (float)Screen.height - this._buttonHeight - 10f, width, this._buttonHeight), text);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00004354 File Offset: 0x00002554
		protected bool toggleButton(string defaultText, string selectedText)
		{
			if (!this._toggleButtons.ContainsKey(defaultText))
			{
				this._toggleButtons[defaultText] = true;
			}
			string text = (!this._toggleButtons[defaultText]) ? selectedText : defaultText;
			GUI.skin.button.normal.background = this.toggleButtonBackground;
			if (!this._toggleButtons[defaultText])
			{
				GUI.contentColor = Color.yellow;
			}
			else
			{
				GUI.skin.button.fontStyle = FontStyle.Bold;
				GUI.contentColor = Color.red;
			}
			if (GUILayout.Button(text, new GUILayoutOption[0]))
			{
				this._toggleButtons[defaultText] = (text != defaultText);
			}
			GUI.skin.button.normal.background = this.normalBackground;
			GUI.skin.button.fontStyle = FontStyle.Normal;
			GUI.contentColor = Color.white;
			return this._toggleButtons[defaultText];
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00004450 File Offset: 0x00002650
		protected bool toggleButtonState(string defaultText)
		{
			if (!this._toggleButtons.ContainsKey(defaultText))
			{
				this._toggleButtons[defaultText] = true;
			}
			return this._toggleButtons[defaultText];
		}

		// Token: 0x04000015 RID: 21
		protected float _width;

		// Token: 0x04000016 RID: 22
		protected float _buttonHeight;

		// Token: 0x04000017 RID: 23
		protected Dictionary<string, bool> _toggleButtons = new Dictionary<string, bool>();

		// Token: 0x04000018 RID: 24
		protected StringBuilder _logBuilder = new StringBuilder();

		// Token: 0x04000019 RID: 25
		private bool _logRegistered;

		// Token: 0x0400001A RID: 26
		private Vector2 _logScrollPosition;

		// Token: 0x0400001B RID: 27
		private bool _isShowingLogConsole;

		// Token: 0x0400001C RID: 28
		private float _doubleClickDelay = 0.15f;

		// Token: 0x0400001D RID: 29
		private float _previousClickTime;

		// Token: 0x0400001E RID: 30
		private float _lastTwoFingerTouchTime = -1f;

		// Token: 0x0400001F RID: 31
		private bool _isWindowsPhone;

		// Token: 0x04000020 RID: 32
		private Texture2D _normalBackground;

		// Token: 0x04000021 RID: 33
		private Texture2D _bottomButtonBackground;

		// Token: 0x04000022 RID: 34
		private Texture2D _activeBackground;

		// Token: 0x04000023 RID: 35
		private Texture2D _toggleButtonBackground;

		// Token: 0x04000024 RID: 36
		private bool _didRetinaIpadCheck;

		// Token: 0x04000025 RID: 37
		private bool _isRetinaIpad;
	}
}
