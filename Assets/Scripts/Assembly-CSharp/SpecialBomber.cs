using System;
using UnityEngine;

// Token: 0x020000F6 RID: 246
public class SpecialBomber : MonoBehaviour
{
	// Token: 0x060006AE RID: 1710 RVA: 0x00020448 File Offset: 0x0001E648
	private void Start()
	{
		this.startPosition = base.transform.position.x;
	}

	// Token: 0x060006AF RID: 1711 RVA: 0x00020470 File Offset: 0x0001E670
	private void FixedUpdate()
	{
		if (Game.instance.IsPaused)
		{
			return;
		}
		if (this.team == 1 && !this.hasSwitched)
		{
			Vector3 position = base.transform.position;
			position.x += 1000f * Game.P2U;
			this.startPosition = position.x;
			base.transform.position = position;
			base.transform.localScale = new Vector3(base.transform.localScale.x * -1f, base.transform.localScale.y, base.transform.localScale.z);
			if (this.team == 1)
			{
				this.dir = -1;
			}
			this.hasSwitched = true;
		}
		this.cc++;
		float num = Mathf.Abs(base.transform.position.x - this.startPosition) * 1f / Game.P2U;
		if (this.cc == 15)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(PrefabCache.Bomb);
			gameObject.GetComponent<SpecialBomb>().team = this.team;
			gameObject.transform.position = base.GetComponent<Renderer>().bounds.center;
			this.cc = 0;
		}
		Game.instance.shakeCamera();
		base.transform.Translate(new Vector3((float)(this.dir * 4) * Game.P2U, 0f, 0f));
		if (num > 1100f)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x04000445 RID: 1093
	private int cc;

	// Token: 0x04000446 RID: 1094
	private float startPosition;

	// Token: 0x04000447 RID: 1095
	public int team;

	// Token: 0x04000448 RID: 1096
	public bool hasSwitched;

	// Token: 0x04000449 RID: 1097
	private int dir = 1;

	// Token: 0x0400044A RID: 1098
	private int frames;
}
