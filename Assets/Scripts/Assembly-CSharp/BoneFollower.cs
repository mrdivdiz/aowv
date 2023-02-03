using System;
using Spine;
using UnityEngine;

// Token: 0x02000136 RID: 310
[ExecuteInEditMode]
[AddComponentMenu("Spine/BoneFollower")]
public class BoneFollower : MonoBehaviour
{
	// Token: 0x17000152 RID: 338
	// (get) Token: 0x06000976 RID: 2422 RVA: 0x0002C5D4 File Offset: 0x0002A7D4
	// (set) Token: 0x06000977 RID: 2423 RVA: 0x0002C5DC File Offset: 0x0002A7DC
	public SkeletonRenderer SkeletonRenderer
	{
		get
		{
			return this.skeletonRenderer;
		}
		set
		{
			this.skeletonRenderer = value;
			this.Reset();
		}
	}

	// Token: 0x06000978 RID: 2424 RVA: 0x0002C5EC File Offset: 0x0002A7EC
	public void HandleResetRenderer(SkeletonRenderer skeletonRenderer)
	{
		this.Reset();
	}

	// Token: 0x06000979 RID: 2425 RVA: 0x0002C5F4 File Offset: 0x0002A7F4
	public void Reset()
	{
		this.bone = null;
		this.cachedTransform = base.transform;
		this.valid = (this.skeletonRenderer != null && this.skeletonRenderer.valid);
		if (!this.valid)
		{
			return;
		}
		this.skeletonTransform = this.skeletonRenderer.transform;
		SkeletonRenderer skeletonRenderer = this.skeletonRenderer;
		skeletonRenderer.OnReset = (SkeletonRenderer.SkeletonRendererDelegate)Delegate.Remove(skeletonRenderer.OnReset, new SkeletonRenderer.SkeletonRendererDelegate(this.HandleResetRenderer));
		SkeletonRenderer skeletonRenderer2 = this.skeletonRenderer;
		skeletonRenderer2.OnReset = (SkeletonRenderer.SkeletonRendererDelegate)Delegate.Combine(skeletonRenderer2.OnReset, new SkeletonRenderer.SkeletonRendererDelegate(this.HandleResetRenderer));
		if (Application.isEditor)
		{
			this.DoUpdate();
		}
	}

	// Token: 0x0600097A RID: 2426 RVA: 0x0002C6B4 File Offset: 0x0002A8B4
	private void OnDestroy()
	{
		if (this.skeletonRenderer != null)
		{
			SkeletonRenderer skeletonRenderer = this.skeletonRenderer;
			skeletonRenderer.OnReset = (SkeletonRenderer.SkeletonRendererDelegate)Delegate.Remove(skeletonRenderer.OnReset, new SkeletonRenderer.SkeletonRendererDelegate(this.HandleResetRenderer));
		}
	}

	// Token: 0x0600097B RID: 2427 RVA: 0x0002C6FC File Offset: 0x0002A8FC
	public void Awake()
	{
		if (this.resetOnAwake)
		{
			this.Reset();
		}
	}

	// Token: 0x0600097C RID: 2428 RVA: 0x0002C710 File Offset: 0x0002A910
	private void LateUpdate()
	{
		this.DoUpdate();
	}

	// Token: 0x0600097D RID: 2429 RVA: 0x0002C718 File Offset: 0x0002A918
	public void DoUpdate()
	{
		if (!this.valid)
		{
			this.Reset();
			return;
		}
		if (this.bone == null)
		{
			if (this.boneName == null || this.boneName.Length == 0)
			{
				return;
			}
			this.bone = this.skeletonRenderer.skeleton.FindBone(this.boneName);
			if (this.bone == null)
			{
				Debug.LogError("Bone not found: " + this.boneName, this);
				return;
			}
		}
		Skeleton skeleton = this.skeletonRenderer.skeleton;
		float num = (!(skeleton.flipX ^ skeleton.flipY)) ? 1f : -1f;
		if (this.cachedTransform.parent == this.skeletonTransform)
		{
			this.cachedTransform.localPosition = new Vector3(this.bone.worldX, this.bone.worldY, (!this.followZPosition) ? this.cachedTransform.localPosition.z : 0f);
			if (this.followBoneRotation)
			{
				Vector3 eulerAngles = this.cachedTransform.localRotation.eulerAngles;
				this.cachedTransform.localRotation = Quaternion.Euler(eulerAngles.x, eulerAngles.y, this.bone.worldRotation * num);
			}
		}
		else
		{
			Vector3 position = this.skeletonTransform.TransformPoint(new Vector3(this.bone.worldX, this.bone.worldY, 0f));
			if (!this.followZPosition)
			{
				position.z = this.cachedTransform.position.z;
			}
			this.cachedTransform.position = position;
			if (this.followBoneRotation)
			{
				Vector3 eulerAngles2 = this.skeletonTransform.rotation.eulerAngles;
				this.cachedTransform.rotation = Quaternion.Euler(eulerAngles2.x, eulerAngles2.y, this.skeletonTransform.rotation.eulerAngles.z + this.bone.worldRotation * num);
			}
		}
	}

	// Token: 0x040005FB RID: 1531
	[NonSerialized]
	public bool valid;

	// Token: 0x040005FC RID: 1532
	public SkeletonRenderer skeletonRenderer;

	// Token: 0x040005FD RID: 1533
	public Bone bone;

	// Token: 0x040005FE RID: 1534
	public bool followZPosition = true;

	// Token: 0x040005FF RID: 1535
	public bool followBoneRotation = true;

	// Token: 0x04000600 RID: 1536
	public string boneName;

	// Token: 0x04000601 RID: 1537
	public bool resetOnAwake = true;

	// Token: 0x04000602 RID: 1538
	protected Transform cachedTransform;

	// Token: 0x04000603 RID: 1539
	protected Transform skeletonTransform;
}
