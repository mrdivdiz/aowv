using System;
using UnityEngine;

// Token: 0x020000C0 RID: 192
public class AttackTrigger : MonoBehaviour
{
	// Token: 0x06000590 RID: 1424 RVA: 0x0000E640 File Offset: 0x0000C840
	public void attackTrigger()
	{
		base.GetComponentInParent<Unit>().attack();
	}

	// Token: 0x06000591 RID: 1425 RVA: 0x0000E650 File Offset: 0x0000C850
	public void rangedAttackTrigger()
	{
		base.GetComponentInParent<Unit>().rangedAttack();
	}

	// Token: 0x06000592 RID: 1426 RVA: 0x0000E660 File Offset: 0x0000C860
	public void shootClip()
	{
		AudioSource.PlayClipAtPoint(base.GetComponentInParent<Unit>().shootClip, Camera.main.transform.position);
	}

	// Token: 0x06000593 RID: 1427 RVA: 0x0000E68C File Offset: 0x0000C88C
	public void attackClip()
	{
		AudioSource.PlayClipAtPoint(base.GetComponentInParent<Unit>().attackClip, Camera.main.transform.position);
	}

	// Token: 0x06000594 RID: 1428 RVA: 0x0000E6B8 File Offset: 0x0000C8B8
	public void dieClip()
	{
		AudioSource.PlayClipAtPoint(base.GetComponentInParent<Unit>().dieClip, Camera.main.transform.position);
	}

	// Token: 0x06000595 RID: 1429 RVA: 0x0000E6E4 File Offset: 0x0000C8E4
	public void extraClip1()
	{
		AudioSource.PlayClipAtPoint(base.GetComponentInParent<Unit>().extraClip1, Camera.main.transform.position);
	}

	// Token: 0x06000596 RID: 1430 RVA: 0x0000E710 File Offset: 0x0000C910
	public void extraClip2()
	{
		AudioSource.PlayClipAtPoint(base.GetComponentInParent<Unit>().extraClip2, Camera.main.transform.position);
	}
}
