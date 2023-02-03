using System;
using UnityEngine;

// Token: 0x020000D2 RID: 210
public class CoinFadeAway : MonoBehaviour
{
	// Token: 0x060005EF RID: 1519 RVA: 0x00012284 File Offset: 0x00010484
	private void Start()
	{
		base.GetComponentInChildren<TextMesh>().GetComponent<Renderer>().sortingLayerName = "Blood";
	}

	// Token: 0x060005F0 RID: 1520 RVA: 0x0001229C File Offset: 0x0001049C
	private void FixedUpdate()
	{
		base.transform.Translate(new Vector3(0f, this.ymove * Game.P2U, 0f));
		this.ymove /= 1.1f;
		if (this.ymove <= 0.2f)
		{
			this.alpha -= 0.79999995f * Time.fixedDeltaTime;
			foreach (Renderer renderer in base.GetComponentsInChildren<Renderer>())
			{
				Color color = renderer.material.color;
				color.a = this.alpha;
				renderer.material.color = color;
				if (color.a < 0f)
				{
					UnityEngine.Object.Destroy(base.gameObject);
				}
			}
		}
	}

	// Token: 0x0400029C RID: 668
	private float ymove = 3f;

	// Token: 0x0400029D RID: 669
	private float alpha = 1f;
}
