using System;
using UnityEngine;

// Token: 0x02000140 RID: 320
public class SkeletonUtilityEyeConstraint : SkeletonUtilityConstraint
{
	// Token: 0x060009BF RID: 2495 RVA: 0x0002F2E4 File Offset: 0x0002D4E4
	protected override void OnEnable()
	{
		if (!Application.isPlaying)
		{
			return;
		}
		base.OnEnable();
		Bounds bounds = new Bounds(this.eyes[0].localPosition, Vector3.zero);
		this.origins = new Vector3[this.eyes.Length];
		for (int i = 0; i < this.eyes.Length; i++)
		{
			this.origins[i] = this.eyes[i].localPosition;
			bounds.Encapsulate(this.origins[i]);
		}
		this.centerPoint = bounds.center;
	}

	// Token: 0x060009C0 RID: 2496 RVA: 0x0002F38C File Offset: 0x0002D58C
	protected override void OnDisable()
	{
		if (!Application.isPlaying)
		{
			return;
		}
		base.OnDisable();
	}

	// Token: 0x060009C1 RID: 2497 RVA: 0x0002F3A0 File Offset: 0x0002D5A0
	public override void DoUpdate()
	{
		if (this.target != null)
		{
			this.targetPosition = this.target.position;
		}
		Vector3 a = this.targetPosition;
		Vector3 vector = base.transform.TransformPoint(this.centerPoint);
		Vector3 a2 = a - vector;
		if (a2.magnitude > 1f)
		{
			a2.Normalize();
		}
		for (int i = 0; i < this.eyes.Length; i++)
		{
			vector = base.transform.TransformPoint(this.origins[i]);
			this.eyes[i].position = Vector3.MoveTowards(this.eyes[i].position, vector + a2 * this.radius, this.speed * Time.deltaTime);
		}
	}

	// Token: 0x0400064E RID: 1614
	public Transform[] eyes;

	// Token: 0x0400064F RID: 1615
	public float radius = 0.5f;

	// Token: 0x04000650 RID: 1616
	public Transform target;

	// Token: 0x04000651 RID: 1617
	public Vector3 targetPosition;

	// Token: 0x04000652 RID: 1618
	public float speed = 10f;

	// Token: 0x04000653 RID: 1619
	private Vector3[] origins;

	// Token: 0x04000654 RID: 1620
	private Vector3 centerPoint;
}
