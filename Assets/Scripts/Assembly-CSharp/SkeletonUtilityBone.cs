using System;
using Spine;
using UnityEngine;

// Token: 0x0200013D RID: 317
[ExecuteInEditMode]
[AddComponentMenu("Spine/SkeletonUtilityBone")]
public class SkeletonUtilityBone : MonoBehaviour
{
	// Token: 0x17000154 RID: 340
	// (get) Token: 0x060009B2 RID: 2482 RVA: 0x0002E8E4 File Offset: 0x0002CAE4
	public bool NonUniformScaleWarning
	{
		get
		{
			return this.nonUniformScaleWarning;
		}
	}

	// Token: 0x060009B3 RID: 2483 RVA: 0x0002E8EC File Offset: 0x0002CAEC
	public void Reset()
	{
		this.bone = null;
		this.cachedTransform = base.transform;
		this.valid = (this.skeletonUtility != null && this.skeletonUtility.skeletonRenderer != null && this.skeletonUtility.skeletonRenderer.valid);
		if (!this.valid)
		{
			return;
		}
		this.skeletonTransform = this.skeletonUtility.transform;
		this.skeletonUtility.OnReset -= this.HandleOnReset;
		this.skeletonUtility.OnReset += this.HandleOnReset;
		this.DoUpdate();
	}

	// Token: 0x060009B4 RID: 2484 RVA: 0x0002E9A0 File Offset: 0x0002CBA0
	private void OnEnable()
	{
		this.skeletonUtility = SkeletonUtility.GetInParent<SkeletonUtility>(base.transform);
		if (this.skeletonUtility == null)
		{
			return;
		}
		this.skeletonUtility.RegisterBone(this);
		this.skeletonUtility.OnReset += this.HandleOnReset;
	}

	// Token: 0x060009B5 RID: 2485 RVA: 0x0002E9F4 File Offset: 0x0002CBF4
	private void HandleOnReset()
	{
		this.Reset();
	}

	// Token: 0x060009B6 RID: 2486 RVA: 0x0002E9FC File Offset: 0x0002CBFC
	private void OnDisable()
	{
		if (this.skeletonUtility != null)
		{
			this.skeletonUtility.OnReset -= this.HandleOnReset;
			this.skeletonUtility.UnregisterBone(this);
		}
	}

	// Token: 0x060009B7 RID: 2487 RVA: 0x0002EA40 File Offset: 0x0002CC40
	public void DoUpdate()
	{
		if (!this.valid)
		{
			this.Reset();
			return;
		}
		Skeleton skeleton = this.skeletonUtility.skeletonRenderer.skeleton;
		if (this.bone == null)
		{
			if (this.boneName == null || this.boneName.Length == 0)
			{
				return;
			}
			this.bone = skeleton.FindBone(this.boneName);
			if (this.bone == null)
			{
				Debug.LogError("Bone not found: " + this.boneName, this);
				return;
			}
		}
		float num = (!(skeleton.flipX ^ skeleton.flipY)) ? 1f : -1f;
		float num2 = 0f;
		if (this.flip && (this.flipX || this.flipX != this.bone.flipX) && this.bone.parent != null)
		{
			num2 = this.bone.parent.WorldRotation * -2f;
		}
		if (this.mode == SkeletonUtilityBone.Mode.Follow)
		{
			if (this.flip)
			{
				this.flipX = this.bone.flipX;
			}
			if (this.position)
			{
				this.cachedTransform.localPosition = new Vector3(this.bone.x, this.bone.y, 0f);
			}
			if (this.rotation)
			{
				if (this.bone.Data.InheritRotation)
				{
					if (this.bone.FlipX)
					{
						this.cachedTransform.localRotation = Quaternion.Euler(0f, 180f, this.bone.rotationIK - num2);
					}
					else
					{
						this.cachedTransform.localRotation = Quaternion.Euler(0f, 0f, this.bone.rotationIK);
					}
				}
				else
				{
					Vector3 eulerAngles = this.skeletonTransform.rotation.eulerAngles;
					this.cachedTransform.rotation = Quaternion.Euler(eulerAngles.x, eulerAngles.y, this.skeletonTransform.rotation.eulerAngles.z + this.bone.worldRotation * num);
				}
			}
			if (this.scale)
			{
				this.cachedTransform.localScale = new Vector3(this.bone.scaleX, this.bone.scaleY, 1f);
				this.nonUniformScaleWarning = (this.bone.scaleX != this.bone.scaleY);
			}
		}
		else if (this.mode == SkeletonUtilityBone.Mode.Override)
		{
			if (this.transformLerpComplete)
			{
				return;
			}
			if (this.parentReference == null)
			{
				if (this.position)
				{
					this.bone.x = Mathf.Lerp(this.bone.x, this.cachedTransform.localPosition.x, this.overrideAlpha);
					this.bone.y = Mathf.Lerp(this.bone.y, this.cachedTransform.localPosition.y, this.overrideAlpha);
				}
				if (this.rotation)
				{
					float num3 = Mathf.LerpAngle(this.bone.Rotation, this.cachedTransform.localRotation.eulerAngles.z, this.overrideAlpha) + num2;
					if (this.flip)
					{
						if (!this.flipX && this.bone.flipX)
						{
							num3 -= num2;
						}
						if (num3 >= 360f)
						{
							num3 -= 360f;
						}
						else if (num3 <= -360f)
						{
							num3 += 360f;
						}
					}
					this.bone.Rotation = num3;
				}
				if (this.scale)
				{
					this.bone.scaleX = Mathf.Lerp(this.bone.scaleX, this.cachedTransform.localScale.x, this.overrideAlpha);
					this.bone.scaleY = Mathf.Lerp(this.bone.scaleY, this.cachedTransform.localScale.y, this.overrideAlpha);
					this.nonUniformScaleWarning = (this.bone.scaleX != this.bone.scaleY);
				}
				if (this.flip)
				{
					this.bone.flipX = this.flipX;
				}
			}
			else
			{
				if (this.transformLerpComplete)
				{
					return;
				}
				if (this.position)
				{
					Vector3 vector = this.parentReference.InverseTransformPoint(this.cachedTransform.position);
					this.bone.x = Mathf.Lerp(this.bone.x, vector.x, this.overrideAlpha);
					this.bone.y = Mathf.Lerp(this.bone.y, vector.y, this.overrideAlpha);
				}
				if (this.rotation)
				{
					float num4 = Mathf.LerpAngle(this.bone.Rotation, Quaternion.LookRotation((!this.flipX) ? Vector3.forward : (Vector3.forward * -1f), this.parentReference.InverseTransformDirection(this.cachedTransform.up)).eulerAngles.z, this.overrideAlpha) + num2;
					if (this.flip)
					{
						if (!this.flipX && this.bone.flipX)
						{
							num4 -= num2;
						}
						if (num4 >= 360f)
						{
							num4 -= 360f;
						}
						else if (num4 <= -360f)
						{
							num4 += 360f;
						}
					}
					this.bone.Rotation = num4;
				}
				if (this.scale)
				{
					this.bone.scaleX = Mathf.Lerp(this.bone.scaleX, this.cachedTransform.localScale.x, this.overrideAlpha);
					this.bone.scaleY = Mathf.Lerp(this.bone.scaleY, this.cachedTransform.localScale.y, this.overrideAlpha);
					this.nonUniformScaleWarning = (this.bone.scaleX != this.bone.scaleY);
				}
				if (this.flip)
				{
					this.bone.flipX = this.flipX;
				}
			}
			this.transformLerpComplete = true;
		}
	}

	// Token: 0x060009B8 RID: 2488 RVA: 0x0002F0FC File Offset: 0x0002D2FC
	public void FlipX(bool state)
	{
		if (state != this.flipX)
		{
			this.flipX = state;
			if (this.flipX && Mathf.Abs(base.transform.localRotation.eulerAngles.y) > 90f)
			{
				this.skeletonUtility.skeletonAnimation.LateUpdate();
				return;
			}
			if (!this.flipX && Mathf.Abs(base.transform.localRotation.eulerAngles.y) < 90f)
			{
				this.skeletonUtility.skeletonAnimation.LateUpdate();
				return;
			}
		}
		this.bone.FlipX = state;
		base.transform.RotateAround(base.transform.position, this.skeletonUtility.transform.up, 180f);
		Vector3 eulerAngles = base.transform.localRotation.eulerAngles;
		eulerAngles.x = 0f;
		eulerAngles.y = (float)((!this.bone.FlipX) ? 0 : 180);
		base.transform.localRotation = Quaternion.Euler(eulerAngles);
	}

	// Token: 0x060009B9 RID: 2489 RVA: 0x0002F238 File Offset: 0x0002D438
	private void OnDrawGizmos()
	{
		if (this.NonUniformScaleWarning)
		{
			Gizmos.DrawIcon(base.transform.position + new Vector3(0f, 0.128f, 0f), "icon-warning");
		}
	}

	// Token: 0x04000638 RID: 1592
	[NonSerialized]
	public bool valid;

	// Token: 0x04000639 RID: 1593
	[NonSerialized]
	public SkeletonUtility skeletonUtility;

	// Token: 0x0400063A RID: 1594
	[NonSerialized]
	public Bone bone;

	// Token: 0x0400063B RID: 1595
	public SkeletonUtilityBone.Mode mode;

	// Token: 0x0400063C RID: 1596
	public bool zPosition = true;

	// Token: 0x0400063D RID: 1597
	public bool position;

	// Token: 0x0400063E RID: 1598
	public bool rotation;

	// Token: 0x0400063F RID: 1599
	public bool scale;

	// Token: 0x04000640 RID: 1600
	public bool flip;

	// Token: 0x04000641 RID: 1601
	public bool flipX;

	// Token: 0x04000642 RID: 1602
	[Range(0f, 1f)]
	public float overrideAlpha = 1f;

	// Token: 0x04000643 RID: 1603
	public string boneName;

	// Token: 0x04000644 RID: 1604
	public Transform parentReference;

	// Token: 0x04000645 RID: 1605
	[HideInInspector]
	public bool transformLerpComplete;

	// Token: 0x04000646 RID: 1606
	protected Transform cachedTransform;

	// Token: 0x04000647 RID: 1607
	protected Transform skeletonTransform;

	// Token: 0x04000648 RID: 1608
	private bool nonUniformScaleWarning;

	// Token: 0x0200013E RID: 318
	public enum Mode
	{
		// Token: 0x0400064A RID: 1610
		Follow,
		// Token: 0x0400064B RID: 1611
		Override
	}
}
