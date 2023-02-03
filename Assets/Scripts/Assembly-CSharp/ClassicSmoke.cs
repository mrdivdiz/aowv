using System;
using UnityEngine;

// Token: 0x020000D1 RID: 209
public class ClassicSmoke : MonoBehaviour
{
	// Token: 0x060005EB RID: 1515 RVA: 0x00012160 File Offset: 0x00010360
	private void Start()
	{
		this.c = base.GetComponent<Renderer>().material.color;
	}

	// Token: 0x060005EC RID: 1516 RVA: 0x00012178 File Offset: 0x00010378
	private void FixedUpdate()
	{
		base.transform.localScale = base.transform.localScale * this.scaleChange;
	}

	// Token: 0x060005ED RID: 1517 RVA: 0x000121A8 File Offset: 0x000103A8
	private void Update()
	{
		this.c.a = this.c.a - this.fadeOut * Time.deltaTime;
		base.GetComponent<Renderer>().material.color = this.c;
		base.transform.localEulerAngles = new Vector3(0f, 0f, base.transform.localEulerAngles.z + this.rot);
		base.transform.position += this.vel * Time.deltaTime;
		if (this.c.a < 0f)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x04000297 RID: 663
	private Color c;

	// Token: 0x04000298 RID: 664
	public float rot;

	// Token: 0x04000299 RID: 665
	public Vector3 vel;

	// Token: 0x0400029A RID: 666
	public float scaleChange = 0.999f;

	// Token: 0x0400029B RID: 667
	public float fadeOut = 0.6f;
}
