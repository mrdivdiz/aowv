using System;
using System.Collections.Generic;
using Spine;
using UnityEngine;

// Token: 0x0200013C RID: 316
[ExecuteInEditMode]
[RequireComponent(typeof(SkeletonAnimation))]
public class SkeletonUtility : MonoBehaviour
{
	// Token: 0x14000009 RID: 9
	// (add) Token: 0x0600099A RID: 2458 RVA: 0x0002DE68 File Offset: 0x0002C068
	// (remove) Token: 0x0600099B RID: 2459 RVA: 0x0002DE84 File Offset: 0x0002C084
	public event SkeletonUtility.SkeletonUtilityDelegate OnReset;

	// Token: 0x0600099C RID: 2460 RVA: 0x0002DEA0 File Offset: 0x0002C0A0
	public static T GetInParent<T>(Transform origin) where T : Component
	{
		return origin.GetComponentInParent<T>();
	}

	// Token: 0x0600099D RID: 2461 RVA: 0x0002DEA8 File Offset: 0x0002C0A8
	private void Update()
	{
		if (this.boneRoot != null && this.skeletonRenderer.skeleton != null)
		{
			Vector3 one = Vector3.one;
			if (this.skeletonRenderer.skeleton.FlipX)
			{
				one.x = -1f;
			}
			if (this.skeletonRenderer.skeleton.FlipY)
			{
				one.y = -1f;
			}
			this.boneRoot.localScale = one;
		}
	}

	// Token: 0x0600099E RID: 2462 RVA: 0x0002DF2C File Offset: 0x0002C12C
	private void OnEnable()
	{
		if (this.skeletonRenderer == null)
		{
			this.skeletonRenderer = base.GetComponent<SkeletonRenderer>();
		}
		if (this.skeletonAnimation == null)
		{
			this.skeletonAnimation = base.GetComponent<SkeletonAnimation>();
		}
		SkeletonRenderer skeletonRenderer = this.skeletonRenderer;
		skeletonRenderer.OnReset = (SkeletonRenderer.SkeletonRendererDelegate)Delegate.Remove(skeletonRenderer.OnReset, new SkeletonRenderer.SkeletonRendererDelegate(this.HandleRendererReset));
		SkeletonRenderer skeletonRenderer2 = this.skeletonRenderer;
		skeletonRenderer2.OnReset = (SkeletonRenderer.SkeletonRendererDelegate)Delegate.Combine(skeletonRenderer2.OnReset, new SkeletonRenderer.SkeletonRendererDelegate(this.HandleRendererReset));
		if (this.skeletonAnimation != null)
		{
			SkeletonAnimation skeletonAnimation = this.skeletonAnimation;
			skeletonAnimation.UpdateLocal = (SkeletonAnimation.UpdateBonesDelegate)Delegate.Remove(skeletonAnimation.UpdateLocal, new SkeletonAnimation.UpdateBonesDelegate(this.UpdateLocal));
			SkeletonAnimation skeletonAnimation2 = this.skeletonAnimation;
			skeletonAnimation2.UpdateLocal = (SkeletonAnimation.UpdateBonesDelegate)Delegate.Combine(skeletonAnimation2.UpdateLocal, new SkeletonAnimation.UpdateBonesDelegate(this.UpdateLocal));
		}
		this.CollectBones();
	}

	// Token: 0x0600099F RID: 2463 RVA: 0x0002E028 File Offset: 0x0002C228
	private void Start()
	{
	}

	// Token: 0x060009A0 RID: 2464 RVA: 0x0002E02C File Offset: 0x0002C22C
	private void OnDisable()
	{
		SkeletonRenderer skeletonRenderer = this.skeletonRenderer;
		skeletonRenderer.OnReset = (SkeletonRenderer.SkeletonRendererDelegate)Delegate.Remove(skeletonRenderer.OnReset, new SkeletonRenderer.SkeletonRendererDelegate(this.HandleRendererReset));
		if (this.skeletonAnimation != null)
		{
			SkeletonAnimation skeletonAnimation = this.skeletonAnimation;
			skeletonAnimation.UpdateLocal = (SkeletonAnimation.UpdateBonesDelegate)Delegate.Remove(skeletonAnimation.UpdateLocal, new SkeletonAnimation.UpdateBonesDelegate(this.UpdateLocal));
			SkeletonAnimation skeletonAnimation2 = this.skeletonAnimation;
			skeletonAnimation2.UpdateWorld = (SkeletonAnimation.UpdateBonesDelegate)Delegate.Remove(skeletonAnimation2.UpdateWorld, new SkeletonAnimation.UpdateBonesDelegate(this.UpdateWorld));
			SkeletonAnimation skeletonAnimation3 = this.skeletonAnimation;
			skeletonAnimation3.UpdateComplete = (SkeletonAnimation.UpdateBonesDelegate)Delegate.Remove(skeletonAnimation3.UpdateComplete, new SkeletonAnimation.UpdateBonesDelegate(this.UpdateComplete));
		}
	}

	// Token: 0x060009A1 RID: 2465 RVA: 0x0002E0E8 File Offset: 0x0002C2E8
	private void HandleRendererReset(SkeletonRenderer r)
	{
		if (this.OnReset != null)
		{
			this.OnReset();
		}
		this.CollectBones();
	}

	// Token: 0x060009A2 RID: 2466 RVA: 0x0002E108 File Offset: 0x0002C308
	public void RegisterBone(SkeletonUtilityBone bone)
	{
		if (this.utilityBones.Contains(bone))
		{
			return;
		}
		this.utilityBones.Add(bone);
		this.needToReprocessBones = true;
	}

	// Token: 0x060009A3 RID: 2467 RVA: 0x0002E130 File Offset: 0x0002C330
	public void UnregisterBone(SkeletonUtilityBone bone)
	{
		this.utilityBones.Remove(bone);
	}

	// Token: 0x060009A4 RID: 2468 RVA: 0x0002E140 File Offset: 0x0002C340
	public void RegisterConstraint(SkeletonUtilityConstraint constraint)
	{
		if (this.utilityConstraints.Contains(constraint))
		{
			return;
		}
		this.utilityConstraints.Add(constraint);
		this.needToReprocessBones = true;
	}

	// Token: 0x060009A5 RID: 2469 RVA: 0x0002E168 File Offset: 0x0002C368
	public void UnregisterConstraint(SkeletonUtilityConstraint constraint)
	{
		this.utilityConstraints.Remove(constraint);
	}

	// Token: 0x060009A6 RID: 2470 RVA: 0x0002E178 File Offset: 0x0002C378
	public void CollectBones()
	{
		if (this.skeletonRenderer.skeleton == null)
		{
			return;
		}
		if (this.boneRoot != null)
		{
			List<string> list = new List<string>();
			foreach (IkConstraint ikConstraint in this.skeletonRenderer.skeleton.IkConstraints)
			{
				list.Add(ikConstraint.Target.Data.Name);
			}
			foreach (SkeletonUtilityBone skeletonUtilityBone in this.utilityBones)
			{
				if (skeletonUtilityBone.bone == null)
				{
					return;
				}
				if (skeletonUtilityBone.mode == SkeletonUtilityBone.Mode.Override)
				{
					this.hasTransformBones = true;
				}
				if (list.Contains(skeletonUtilityBone.bone.Data.Name))
				{
					this.hasUtilityConstraints = true;
				}
			}
			if (this.utilityConstraints.Count > 0)
			{
				this.hasUtilityConstraints = true;
			}
			if (this.skeletonAnimation != null)
			{
				SkeletonAnimation skeletonAnimation = this.skeletonAnimation;
				skeletonAnimation.UpdateWorld = (SkeletonAnimation.UpdateBonesDelegate)Delegate.Remove(skeletonAnimation.UpdateWorld, new SkeletonAnimation.UpdateBonesDelegate(this.UpdateWorld));
				SkeletonAnimation skeletonAnimation2 = this.skeletonAnimation;
				skeletonAnimation2.UpdateComplete = (SkeletonAnimation.UpdateBonesDelegate)Delegate.Remove(skeletonAnimation2.UpdateComplete, new SkeletonAnimation.UpdateBonesDelegate(this.UpdateComplete));
				if (this.hasTransformBones || this.hasUtilityConstraints)
				{
					SkeletonAnimation skeletonAnimation3 = this.skeletonAnimation;
					skeletonAnimation3.UpdateWorld = (SkeletonAnimation.UpdateBonesDelegate)Delegate.Combine(skeletonAnimation3.UpdateWorld, new SkeletonAnimation.UpdateBonesDelegate(this.UpdateWorld));
				}
				if (this.hasUtilityConstraints)
				{
					SkeletonAnimation skeletonAnimation4 = this.skeletonAnimation;
					skeletonAnimation4.UpdateComplete = (SkeletonAnimation.UpdateBonesDelegate)Delegate.Combine(skeletonAnimation4.UpdateComplete, new SkeletonAnimation.UpdateBonesDelegate(this.UpdateComplete));
				}
			}
			this.needToReprocessBones = false;
		}
		else
		{
			this.utilityBones.Clear();
			this.utilityConstraints.Clear();
		}
	}

	// Token: 0x060009A7 RID: 2471 RVA: 0x0002E3BC File Offset: 0x0002C5BC
	private void UpdateLocal(SkeletonAnimation anim)
	{
		if (this.needToReprocessBones)
		{
			this.CollectBones();
		}
		if (this.utilityBones == null)
		{
			return;
		}
		foreach (SkeletonUtilityBone skeletonUtilityBone in this.utilityBones)
		{
			skeletonUtilityBone.transformLerpComplete = false;
		}
		this.UpdateAllBones();
	}

	// Token: 0x060009A8 RID: 2472 RVA: 0x0002E448 File Offset: 0x0002C648
	private void UpdateWorld(SkeletonAnimation anim)
	{
		this.UpdateAllBones();
		foreach (SkeletonUtilityConstraint skeletonUtilityConstraint in this.utilityConstraints)
		{
			skeletonUtilityConstraint.DoUpdate();
		}
	}

	// Token: 0x060009A9 RID: 2473 RVA: 0x0002E4B4 File Offset: 0x0002C6B4
	private void UpdateComplete(SkeletonAnimation anim)
	{
		this.UpdateAllBones();
	}

	// Token: 0x060009AA RID: 2474 RVA: 0x0002E4BC File Offset: 0x0002C6BC
	private void UpdateAllBones()
	{
		if (this.boneRoot == null)
		{
			this.CollectBones();
		}
		if (this.utilityBones == null)
		{
			return;
		}
		foreach (SkeletonUtilityBone skeletonUtilityBone in this.utilityBones)
		{
			skeletonUtilityBone.DoUpdate();
		}
	}

	// Token: 0x060009AB RID: 2475 RVA: 0x0002E544 File Offset: 0x0002C744
	public Transform GetBoneRoot()
	{
		if (this.boneRoot != null)
		{
			return this.boneRoot;
		}
		this.boneRoot = new GameObject("SkeletonUtility-Root").transform;
		this.boneRoot.parent = base.transform;
		this.boneRoot.localPosition = Vector3.zero;
		this.boneRoot.localRotation = Quaternion.identity;
		this.boneRoot.localScale = Vector3.one;
		return this.boneRoot;
	}

	// Token: 0x060009AC RID: 2476 RVA: 0x0002E5C8 File Offset: 0x0002C7C8
	public GameObject SpawnRoot(SkeletonUtilityBone.Mode mode, bool pos, bool rot, bool sca)
	{
		this.GetBoneRoot();
		Skeleton skeleton = this.skeletonRenderer.skeleton;
		GameObject result = this.SpawnBone(skeleton.RootBone, this.boneRoot, mode, pos, rot, sca);
		this.CollectBones();
		return result;
	}

	// Token: 0x060009AD RID: 2477 RVA: 0x0002E608 File Offset: 0x0002C808
	public GameObject SpawnHierarchy(SkeletonUtilityBone.Mode mode, bool pos, bool rot, bool sca)
	{
		this.GetBoneRoot();
		Skeleton skeleton = this.skeletonRenderer.skeleton;
		GameObject result = this.SpawnBoneRecursively(skeleton.RootBone, this.boneRoot, mode, pos, rot, sca);
		this.CollectBones();
		return result;
	}

	// Token: 0x060009AE RID: 2478 RVA: 0x0002E648 File Offset: 0x0002C848
	public GameObject SpawnBoneRecursively(Bone bone, Transform parent, SkeletonUtilityBone.Mode mode, bool pos, bool rot, bool sca)
	{
		GameObject gameObject = this.SpawnBone(bone, parent, mode, pos, rot, sca);
		foreach (Bone bone2 in bone.Children)
		{
			this.SpawnBoneRecursively(bone2, gameObject.transform, mode, pos, rot, sca);
		}
		return gameObject;
	}

	// Token: 0x060009AF RID: 2479 RVA: 0x0002E6D0 File Offset: 0x0002C8D0
	public GameObject SpawnBone(Bone bone, Transform parent, SkeletonUtilityBone.Mode mode, bool pos, bool rot, bool sca)
	{
		GameObject gameObject = new GameObject(bone.Data.Name);
		gameObject.transform.parent = parent;
		SkeletonUtilityBone skeletonUtilityBone = gameObject.AddComponent<SkeletonUtilityBone>();
		skeletonUtilityBone.skeletonUtility = this;
		skeletonUtilityBone.position = pos;
		skeletonUtilityBone.rotation = rot;
		skeletonUtilityBone.scale = sca;
		skeletonUtilityBone.mode = mode;
		skeletonUtilityBone.zPosition = true;
		skeletonUtilityBone.Reset();
		skeletonUtilityBone.bone = bone;
		skeletonUtilityBone.boneName = bone.Data.Name;
		skeletonUtilityBone.valid = true;
		if (mode == SkeletonUtilityBone.Mode.Override)
		{
			if (rot)
			{
				gameObject.transform.localRotation = Quaternion.Euler(0f, 0f, skeletonUtilityBone.bone.RotationIK);
			}
			if (pos)
			{
				gameObject.transform.localPosition = new Vector3(skeletonUtilityBone.bone.X, skeletonUtilityBone.bone.Y, 0f);
			}
			gameObject.transform.localScale = new Vector3(skeletonUtilityBone.bone.scaleX, skeletonUtilityBone.bone.scaleY, 0f);
		}
		return gameObject;
	}

	// Token: 0x060009B0 RID: 2480 RVA: 0x0002E7E4 File Offset: 0x0002C9E4
	public void SpawnSubRenderers(bool disablePrimaryRenderer)
	{
		int subMeshCount = base.GetComponent<MeshFilter>().sharedMesh.subMeshCount;
		for (int i = 0; i < subMeshCount; i++)
		{
			SkeletonUtilitySubmeshRenderer skeletonUtilitySubmeshRenderer = new GameObject("Submesh " + i, new Type[]
			{
				typeof(MeshFilter),
				typeof(MeshRenderer)
			})
			{
				transform = 
				{
					parent = base.transform,
					localPosition = Vector3.zero,
					localRotation = Quaternion.identity,
					localScale = Vector3.one
				}
			}.AddComponent<SkeletonUtilitySubmeshRenderer>();
			skeletonUtilitySubmeshRenderer.sortingOrder = i * 10;
			skeletonUtilitySubmeshRenderer.submeshIndex = i;
			skeletonUtilitySubmeshRenderer.Initialize(base.GetComponent<Renderer>());
			skeletonUtilitySubmeshRenderer.Update();
		}
		if (disablePrimaryRenderer)
		{
			base.GetComponent<Renderer>().enabled = false;
		}
	}

	// Token: 0x0400062F RID: 1583
	public Transform boneRoot;

	// Token: 0x04000630 RID: 1584
	[HideInInspector]
	public SkeletonRenderer skeletonRenderer;

	// Token: 0x04000631 RID: 1585
	[HideInInspector]
	public SkeletonAnimation skeletonAnimation;

	// Token: 0x04000632 RID: 1586
	[NonSerialized]
	public List<SkeletonUtilityBone> utilityBones = new List<SkeletonUtilityBone>();

	// Token: 0x04000633 RID: 1587
	[NonSerialized]
	public List<SkeletonUtilityConstraint> utilityConstraints = new List<SkeletonUtilityConstraint>();

	// Token: 0x04000634 RID: 1588
	protected bool hasTransformBones;

	// Token: 0x04000635 RID: 1589
	protected bool hasUtilityConstraints;

	// Token: 0x04000636 RID: 1590
	protected bool needToReprocessBones;

	// Token: 0x02000181 RID: 385
	// (Invoke) Token: 0x06000AC6 RID: 2758
	public delegate void SkeletonUtilityDelegate();
}
