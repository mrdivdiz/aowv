using System;
using UnityEngine;

// Token: 0x0200013F RID: 319
[RequireComponent(typeof(SkeletonUtilityBone))]
[ExecuteInEditMode]
public abstract class SkeletonUtilityConstraint : MonoBehaviour
{
	// Token: 0x060009BB RID: 2491 RVA: 0x0002F288 File Offset: 0x0002D488
	protected virtual void OnEnable()
	{
		this.utilBone = base.GetComponent<SkeletonUtilityBone>();
		this.skeletonUtility = SkeletonUtility.GetInParent<SkeletonUtility>(base.transform);
		this.skeletonUtility.RegisterConstraint(this);
	}

	// Token: 0x060009BC RID: 2492 RVA: 0x0002F2B4 File Offset: 0x0002D4B4
	protected virtual void OnDisable()
	{
		this.skeletonUtility.UnregisterConstraint(this);
	}

	// Token: 0x060009BD RID: 2493
	public abstract void DoUpdate();

	// Token: 0x0400064C RID: 1612
	protected SkeletonUtilityBone utilBone;

	// Token: 0x0400064D RID: 1613
	protected SkeletonUtility skeletonUtility;
}
