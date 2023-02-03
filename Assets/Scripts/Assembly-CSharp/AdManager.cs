using System;
using UnityEngine;
using UnityEngine.Advertisements;

// Token: 0x02000002 RID: 2
public class AdManager : MonoBehaviour
{
	// Token: 0x06000003 RID: 3 RVA: 0x0000211C File Offset: 0x0000031C
	private void Start()
	{
		if (AdManager.instance != null)
		{
			UnityEngine.Object.DestroyImmediate(base.gameObject);
			return;
		}
		AdManager.instance = this;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06000004 RID: 4 RVA: 0x0000214C File Offset: 0x0000034C
	public void Init()
	{
		this.platformId = this.androidGameId;
		Advertisement.Initialize(this.platformId, true);
		this.hasAds = true;
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002170 File Offset: 0x00000370
	public void ShowAd()
	{
		if (this.hasAds)
		{
			Debug.Log("Show ad: " + Advertisement.isReady(null));
			if (Advertisement.isReady(null))
			{
				Advertisement.Show(null, null);
			}
		}
	}

	// Token: 0x04000001 RID: 1
	public static AdManager instance;

	// Token: 0x04000002 RID: 2
	[SerializeField]
	private string androidGameId = "34188";

	// Token: 0x04000003 RID: 3
	[SerializeField]
	private string iosGameId = "34186";

	// Token: 0x04000004 RID: 4
	private string platformId = string.Empty;

	// Token: 0x04000005 RID: 5
	public bool hasAds;
}
