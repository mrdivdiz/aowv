using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000EA RID: 234
public class LoadingScreen : MonoBehaviour
{
	// Token: 0x06000666 RID: 1638 RVA: 0x0001C608 File Offset: 0x0001A808
	public static IEnumerator LoadLevel(string levelName)
	{
		LoadingScreen.init();
		LoadingScreen.instance.show();
		AsyncOperation asynk = Application.LoadLevelAsync(levelName);
		LoadingScreen.timeStartedLoading = Time.time;
		asynk.allowSceneActivation = false;
		while (!asynk.isDone || Time.time - LoadingScreen.timeStartedLoading < 2f)
		{
			if (Time.time - LoadingScreen.timeStartedLoading > 2f)
			{
				asynk.allowSceneActivation = true;
			}
			yield return 0;
		}
		asynk.allowSceneActivation = true;
		yield break;
	}

	// Token: 0x06000667 RID: 1639 RVA: 0x0001C62C File Offset: 0x0001A82C
	public static void init()
	{
		if (LoadingScreen.instance == null)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(PrefabCache.LoadingScreen);
			LoadingScreen.instance = gameObject.GetComponent<LoadingScreen>();
			UnityEngine.Object.DontDestroyOnLoad(LoadingScreen.instance);
			LoadingScreen.instance.originalTopPosition = LoadingScreen.instance.top.rectTransform.localPosition;
			LoadingScreen.instance.originalBottomPosition = LoadingScreen.instance.bottom.rectTransform.localPosition;
			LoadingScreen.instance.hideTopPosition = LoadingScreen.instance.top.rectTransform.localPosition + new Vector3(0f, 1000f, 0f);
			LoadingScreen.instance.hideBottomPosition = LoadingScreen.instance.bottom.rectTransform.localPosition + new Vector3(0f, -1000f, 0f);
		}
	}

	// Token: 0x06000668 RID: 1640 RVA: 0x0001C714 File Offset: 0x0001A914
	public void show()
	{
		this.top.enabled = true;
		this.bottom.enabled = true;
		this.top.rectTransform.localPosition = this.hideTopPosition;
		this.bottom.rectTransform.localPosition = this.hideBottomPosition;
	}

	// Token: 0x06000669 RID: 1641 RVA: 0x0001C768 File Offset: 0x0001A968
	public void hide()
	{
	}

	// Token: 0x0600066A RID: 1642 RVA: 0x0001C76C File Offset: 0x0001A96C
	public void fixToCamera()
	{
	}

	// Token: 0x0600066B RID: 1643 RVA: 0x0001C770 File Offset: 0x0001A970
	private void LateUpdate()
	{
		if (Application.isLoadingLevel)
		{
			this.top.transform.localPosition = Vector3.Lerp(this.top.transform.localPosition, this.originalTopPosition, 0.1f * Time.unscaledDeltaTime * 60f);
			this.bottom.transform.localPosition = Vector3.Lerp(this.bottom.transform.localPosition, this.originalBottomPosition, 0.1f * Time.unscaledDeltaTime * 60f);
			Time.timeScale = 1f;
		}
		else
		{
			this.top.transform.localPosition = Vector3.Lerp(this.top.transform.localPosition, this.hideTopPosition, 0.15f * Time.unscaledDeltaTime * 60f);
			this.bottom.transform.localPosition = Vector3.Lerp(this.bottom.transform.localPosition, this.hideBottomPosition, 0.15f * Time.unscaledDeltaTime * 60f);
			if ((this.top.transform.localPosition - this.hideTopPosition).magnitude < 0.05f && (this.bottom.transform.localPosition - this.hideBottomPosition).magnitude < 0.05f)
			{
				UnityEngine.Object.Destroy(LoadingScreen.instance.gameObject);
				LoadingScreen.instance = null;
			}
		}
		this.fixToCamera();
	}

	// Token: 0x0400039E RID: 926
	public Image top;

	// Token: 0x0400039F RID: 927
	public Image bottom;

	// Token: 0x040003A0 RID: 928
	private static float timeStartedLoading;

	// Token: 0x040003A1 RID: 929
	public static LoadingScreen instance;

	// Token: 0x040003A2 RID: 930
	private Vector3 originalTopPosition;

	// Token: 0x040003A3 RID: 931
	private Vector3 originalBottomPosition;

	// Token: 0x040003A4 RID: 932
	private Vector3 hideTopPosition;

	// Token: 0x040003A5 RID: 933
	private Vector3 hideBottomPosition;
}
