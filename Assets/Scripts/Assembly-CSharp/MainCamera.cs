using System;
using UnityEngine;

// Token: 0x020000EB RID: 235
public class MainCamera : MonoBehaviour
{
	// Token: 0x0600066E RID: 1646 RVA: 0x0001C908 File Offset: 0x0001AB08
	private void Start()
	{
	}

	// Token: 0x0600066F RID: 1647 RVA: 0x0001C90C File Offset: 0x0001AB0C
	private void Awake()
	{
		if (MainCamera.instance != null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		else
		{
			MainCamera.instance = this;
			UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		}
	}

	// Token: 0x06000670 RID: 1648 RVA: 0x0001C940 File Offset: 0x0001AB40
	private void Update()
	{
	}

	// Token: 0x040003A6 RID: 934
	public static MainCamera instance;
}
