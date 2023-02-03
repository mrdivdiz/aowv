using System;
using UnityEngine;

// Token: 0x020000E7 RID: 231
public class HUDFPS : MonoBehaviour
{
	// Token: 0x0600065B RID: 1627 RVA: 0x0001AE74 File Offset: 0x00019074
	private void Start()
	{
		if (!base.GetComponentInChildren<TextMesh>())
		{
			Debug.Log("UtilityFramesPerSecond needs a GUIText component!");
			base.enabled = false;
			return;
		}
		this.timeleft = this.updateInterval;
	}

	// Token: 0x0600065C RID: 1628 RVA: 0x0001AEB0 File Offset: 0x000190B0
	private void Update()
	{
		this.timeleft -= Time.deltaTime;
		this.accum += Time.timeScale / Time.deltaTime;
		this.frames++;
		if ((double)this.timeleft <= 0.0)
		{
			float num = this.accum / (float)this.frames;
			string text = string.Format("{0:F2}", num);
			base.GetComponentInChildren<TextMesh>().text = text;
			if (num < 30f)
			{
				base.GetComponentInChildren<TextMesh>().GetComponent<Renderer>().material.color = Color.yellow;
			}
			else if (num < 10f)
			{
				base.GetComponentInChildren<TextMesh>().GetComponent<Renderer>().material.color = Color.red;
			}
			else
			{
				base.GetComponentInChildren<TextMesh>().GetComponent<Renderer>().material.color = Color.green;
			}
			this.timeleft = this.updateInterval;
			this.accum = 0f;
			this.frames = 0;
		}
	}

	// Token: 0x0400034D RID: 845
	public float updateInterval = 0.5f;

	// Token: 0x0400034E RID: 846
	private float accum;

	// Token: 0x0400034F RID: 847
	private int frames;

	// Token: 0x04000350 RID: 848
	private float timeleft;
}
