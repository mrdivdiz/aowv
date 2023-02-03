using System;
using UnityEngine;

// Token: 0x020000D3 RID: 211
public class EndgameScreen : MonoBehaviour
{
	// Token: 0x060005F2 RID: 1522 RVA: 0x00012374 File Offset: 0x00010574
	private void Start()
	{
	}

	// Token: 0x060005F3 RID: 1523 RVA: 0x00012378 File Offset: 0x00010578
	private void Update()
	{
		if (Input.GetMouseButtonDown(0) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
		{
			Vector3 vector = Input.mousePosition;
			if (Input.touchCount > 0)
			{
				vector = Input.GetTouch(0).position;
			}
			vector = Camera.main.ScreenToWorldPoint(vector);
			vector.z = 0f;
			if ((this.restartButton.transform.position - vector).magnitude < 1f)
			{
				base.StartCoroutine(LoadingScreen.LoadLevel("Game"));
				Time.timeScale = 1f;
			}
			if ((this.exitButton.transform.position - vector).magnitude < 1f)
			{
				base.StartCoroutine(LoadingScreen.LoadLevel("MainMenu"));
				Time.timeScale = 1f;
			}
		}
	}

	// Token: 0x0400029E RID: 670
	public GameObject restartButton;

	// Token: 0x0400029F RID: 671
	public GameObject exitButton;

	// Token: 0x040002A0 RID: 672
	public TextMesh titleText;
}
