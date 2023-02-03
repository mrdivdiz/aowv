using System;
using UnityEngine;

// Token: 0x02000141 RID: 321
[RequireComponent(typeof(SkeletonUtilityBone))]
[ExecuteInEditMode]
public class SkeletonUtilityGroundConstraint : SkeletonUtilityConstraint
{
	// Token: 0x060009C3 RID: 2499 RVA: 0x0002F4CC File Offset: 0x0002D6CC
	protected override void OnEnable()
	{
		base.OnEnable();
	}

	// Token: 0x060009C4 RID: 2500 RVA: 0x0002F4D4 File Offset: 0x0002D6D4
	protected override void OnDisable()
	{
		base.OnDisable();
	}

	// Token: 0x060009C5 RID: 2501 RVA: 0x0002F4DC File Offset: 0x0002D6DC
	public override void DoUpdate()
	{
		this.rayOrigin = base.transform.position + new Vector3(this.castOffset, this.castDistance, 0f);
		this.hitY = float.MinValue;
		if (this.use2D)
		{
			RaycastHit2D raycastHit2D;
			if (this.useRadius)
			{
				raycastHit2D = Physics2D.CircleCast(this.rayOrigin, this.castRadius, this.rayDir, this.castDistance + this.groundOffset, this.groundMask);
			}
			else
			{
				raycastHit2D = Physics2D.Raycast(this.rayOrigin, this.rayDir, this.castDistance + this.groundOffset, this.groundMask);
			}
			if (raycastHit2D.collider != null)
			{
				this.hitY = raycastHit2D.point.y + this.groundOffset;
				if (Application.isPlaying)
				{
					this.hitY = Mathf.MoveTowards(this.lastHitY, this.hitY, this.adjustSpeed * Time.deltaTime);
				}
			}
			else if (Application.isPlaying)
			{
				this.hitY = Mathf.MoveTowards(this.lastHitY, base.transform.position.y, this.adjustSpeed * Time.deltaTime);
			}
		}
		else
		{
			RaycastHit raycastHit;
			bool flag;
			if (this.useRadius)
			{
				flag = Physics.SphereCast(this.rayOrigin, this.castRadius, this.rayDir, out raycastHit, this.castDistance + this.groundOffset, this.groundMask);
			}
			else
			{
				flag = Physics.Raycast(this.rayOrigin, this.rayDir, out raycastHit, this.castDistance + this.groundOffset, this.groundMask);
			}
			if (flag)
			{
				this.hitY = raycastHit.point.y + this.groundOffset;
				if (Application.isPlaying)
				{
					this.hitY = Mathf.MoveTowards(this.lastHitY, this.hitY, this.adjustSpeed * Time.deltaTime);
				}
			}
			else if (Application.isPlaying)
			{
				this.hitY = Mathf.MoveTowards(this.lastHitY, base.transform.position.y, this.adjustSpeed * Time.deltaTime);
			}
		}
		Vector3 position = base.transform.position;
		position.y = Mathf.Clamp(position.y, Mathf.Min(this.lastHitY, this.hitY), float.MaxValue);
		base.transform.position = position;
		this.utilBone.bone.X = base.transform.localPosition.x;
		this.utilBone.bone.Y = base.transform.localPosition.y;
		this.lastHitY = this.hitY;
	}

	// Token: 0x060009C6 RID: 2502 RVA: 0x0002F7E0 File Offset: 0x0002D9E0
	private void OnDrawGizmos()
	{
		Vector3 vector = this.rayOrigin + this.rayDir * Mathf.Min(this.castDistance, this.rayOrigin.y - this.hitY);
		Vector3 to = this.rayOrigin + this.rayDir * this.castDistance;
		Gizmos.DrawLine(this.rayOrigin, vector);
		if (this.useRadius)
		{
			Gizmos.DrawLine(new Vector3(vector.x - this.castRadius, vector.y - this.groundOffset, vector.z), new Vector3(vector.x + this.castRadius, vector.y - this.groundOffset, vector.z));
			Gizmos.DrawLine(new Vector3(to.x - this.castRadius, to.y, to.z), new Vector3(to.x + this.castRadius, to.y, to.z));
		}
		Gizmos.color = Color.red;
		Gizmos.DrawLine(vector, to);
	}

	// Token: 0x04000655 RID: 1621
	[global::Tooltip("LayerMask for what objects to raycast against")]
	public LayerMask groundMask;

	// Token: 0x04000656 RID: 1622
	[global::Tooltip("The 2D")]
	public bool use2D;

	// Token: 0x04000657 RID: 1623
	[global::Tooltip("Uses SphereCast for 3D mode and CircleCast for 2D mode")]
	public bool useRadius;

	// Token: 0x04000658 RID: 1624
	[global::Tooltip("The Radius")]
	public float castRadius = 0.1f;

	// Token: 0x04000659 RID: 1625
	[global::Tooltip("How high above the target bone to begin casting from")]
	public float castDistance = 5f;

	// Token: 0x0400065A RID: 1626
	[global::Tooltip("X-Axis adjustment")]
	public float castOffset;

	// Token: 0x0400065B RID: 1627
	[global::Tooltip("Y-Axis adjustment")]
	public float groundOffset;

	// Token: 0x0400065C RID: 1628
	[global::Tooltip("How fast the target IK position adjusts to the ground.  Use smaller values to prevent snapping")]
	public float adjustSpeed = 5f;

	// Token: 0x0400065D RID: 1629
	private Vector3 rayOrigin;

	// Token: 0x0400065E RID: 1630
	private Vector3 rayDir = new Vector3(0f, -1f, 0f);

	// Token: 0x0400065F RID: 1631
	private float hitY;

	// Token: 0x04000660 RID: 1632
	private float lastHitY;
}
