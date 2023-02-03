using System;
using UnityEngine;

// Token: 0x020000FC RID: 252
public class TurretShoot : MonoBehaviour
{
	// Token: 0x060006C0 RID: 1728 RVA: 0x00020AF0 File Offset: 0x0001ECF0
	private void Start()
	{
		this.turret = base.GetComponentInParent<Turret>();
	}

	// Token: 0x060006C1 RID: 1729 RVA: 0x00020B00 File Offset: 0x0001ED00
	public void shoot()
	{
		this.turret.shoot();
	}

	// Token: 0x060006C2 RID: 1730 RVA: 0x00020B10 File Offset: 0x0001ED10
	public void playSound()
	{
		AudioSource.PlayClipAtPoint(Game.instance.turrets[this.turret.Id].clip, Camera.main.transform.position);
	}

	// Token: 0x0400045D RID: 1117
	private Turret turret;
}
