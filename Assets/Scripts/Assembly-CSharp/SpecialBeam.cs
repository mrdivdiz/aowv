using System;
using UnityEngine;

// Token: 0x020000F8 RID: 248
public class SpecialBeam : MonoBehaviour
{
	// Token: 0x060006B4 RID: 1716 RVA: 0x000206C8 File Offset: 0x0001E8C8
	private void Start()
	{
		this.startPosition = base.transform.position.x;
		this.renderer = base.GetComponentInChildren<SpriteRenderer>();
		this.renderer.enabled = false;
	}

	// Token: 0x060006B5 RID: 1717 RVA: 0x00020708 File Offset: 0x0001E908
	private void LateUpdate()
	{
	}

	// Token: 0x060006B6 RID: 1718 RVA: 0x0002070C File Offset: 0x0001E90C
	private void FixedUpdate()
	{
		if (Game.instance.IsPaused)
		{
			return;
		}
		this.renderer.enabled = (this.frames > 1);
		if (this.team == 1 && !this.hasSwitched)
		{
			Vector3 position = base.transform.position;
			position.x += 1000f * Game.P2U;
			this.startPosition = position.x;
			base.transform.position = position;
			if (this.team == 1)
			{
				this.dir = -1;
			}
			this.hasSwitched = true;
		}
		this.cc++;
		float num = Mathf.Abs(base.transform.position.x - this.startPosition) * 1f / Game.P2U;
		if (this.cc == 5)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(PrefabCache.BeamCircle);
			gameObject.GetComponentInChildren<SpecialBeamCircle>().team = this.team;
			gameObject.transform.position = new Vector3(base.transform.position.x + 30f * Game.P2U, Game.GROUND_LEVEL, 0f);
			base.gameObject.GetComponentInChildren<Animator>().Play("Beam", 0, 0f);
			base.transform.Translate(new Vector3((float)(this.dir * 50) * Game.P2U, 0f, 0f));
			this.cc = 0;
		}
		Game.instance.shakeCamera();
		if (num > 1000f)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0400044F RID: 1103
	private int cc;

	// Token: 0x04000450 RID: 1104
	public int team;

	// Token: 0x04000451 RID: 1105
	private float startPosition;

	// Token: 0x04000452 RID: 1106
	public bool hasSwitched;

	// Token: 0x04000453 RID: 1107
	private int dir = 1;

	// Token: 0x04000454 RID: 1108
	private int frames;

	// Token: 0x04000455 RID: 1109
	private SpriteRenderer renderer;
}
