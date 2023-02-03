using System;
using UnityEngine;

// Token: 0x02000143 RID: 323
[ExecuteInEditMode]
public class SkeletonUtilitySubmeshRenderer : MonoBehaviour
{
	// Token: 0x060009CB RID: 2507 RVA: 0x0002FC88 File Offset: 0x0002DE88
	private void Awake()
	{
		this.cachedRenderer = base.GetComponent<Renderer>();
		this.sharedMaterials = this.cachedRenderer.sharedMaterials;
		this.filter = base.GetComponent<MeshFilter>();
		if (this.parentRenderer != null)
		{
			this.Initialize(this.parentRenderer);
		}
	}

	// Token: 0x060009CC RID: 2508 RVA: 0x0002FCDC File Offset: 0x0002DEDC
	private void OnEnable()
	{
		this.parentRenderer = base.transform.parent.GetComponent<Renderer>();
		SkeletonRenderer component = this.parentRenderer.GetComponent<SkeletonRenderer>();
		component.OnReset = (SkeletonRenderer.SkeletonRendererDelegate)Delegate.Combine(component.OnReset, new SkeletonRenderer.SkeletonRendererDelegate(this.HandleSkeletonReset));
	}

	// Token: 0x060009CD RID: 2509 RVA: 0x0002FD2C File Offset: 0x0002DF2C
	private void OnDisable()
	{
		SkeletonRenderer component = this.parentRenderer.GetComponent<SkeletonRenderer>();
		component.OnReset = (SkeletonRenderer.SkeletonRendererDelegate)Delegate.Remove(component.OnReset, new SkeletonRenderer.SkeletonRendererDelegate(this.HandleSkeletonReset));
	}

	// Token: 0x060009CE RID: 2510 RVA: 0x0002FD68 File Offset: 0x0002DF68
	private void HandleSkeletonReset(SkeletonRenderer r)
	{
		if (this.parentRenderer != null)
		{
			this.Initialize(this.parentRenderer);
		}
	}

	// Token: 0x060009CF RID: 2511 RVA: 0x0002FD88 File Offset: 0x0002DF88
	public void Initialize(Renderer parentRenderer)
	{
		this.parentRenderer = parentRenderer;
		this.parentFilter = parentRenderer.GetComponent<MeshFilter>();
		this.mesh = this.parentFilter.sharedMesh;
		this.filter.sharedMesh = this.mesh;
		Debug.Log("Mesh: " + this.mesh);
	}

	// Token: 0x060009D0 RID: 2512 RVA: 0x0002FDE0 File Offset: 0x0002DFE0
	public void Update()
	{
		if (this.mesh == null || this.mesh != this.parentFilter.sharedMesh)
		{
			this.mesh = this.parentFilter.sharedMesh;
			this.filter.sharedMesh = this.mesh;
		}
		if (this.cachedRenderer == null)
		{
			this.cachedRenderer = base.GetComponent<Renderer>();
		}
		if (this.mesh == null || this.submeshIndex > this.mesh.subMeshCount - 1)
		{
			this.cachedRenderer.enabled = false;
			return;
		}
		base.GetComponent<Renderer>().enabled = true;
		bool flag = false;
		if (this.sharedMaterials.Length != this.parentRenderer.sharedMaterials.Length)
		{
			this.sharedMaterials = this.parentRenderer.sharedMaterials;
			flag = true;
		}
		for (int i = 0; i < base.GetComponent<Renderer>().sharedMaterials.Length; i++)
		{
			if (i != this.submeshIndex)
			{
				if (this.sharedMaterials[i] != this.hiddenPassMaterial)
				{
					this.sharedMaterials[i] = this.hiddenPassMaterial;
					flag = true;
				}
			}
		}
		if (this.sharedMaterials[this.submeshIndex] != this.parentRenderer.sharedMaterials[this.submeshIndex])
		{
			this.sharedMaterials[this.submeshIndex] = this.parentRenderer.sharedMaterials[this.submeshIndex];
			flag = true;
		}
		if (flag)
		{
			this.cachedRenderer.sharedMaterials = this.sharedMaterials;
		}
		this.cachedRenderer.sortingLayerID = this.sortingLayerID;
		this.cachedRenderer.sortingOrder = this.sortingOrder;
	}

	// Token: 0x04000664 RID: 1636
	public Renderer parentRenderer;

	// Token: 0x04000665 RID: 1637
	[NonSerialized]
	public Mesh mesh;

	// Token: 0x04000666 RID: 1638
	public int submeshIndex;

	// Token: 0x04000667 RID: 1639
	public int sortingOrder;

	// Token: 0x04000668 RID: 1640
	public int sortingLayerID;

	// Token: 0x04000669 RID: 1641
	public Material hiddenPassMaterial;

	// Token: 0x0400066A RID: 1642
	private Renderer cachedRenderer;

	// Token: 0x0400066B RID: 1643
	private MeshFilter filter;

	// Token: 0x0400066C RID: 1644
	private Material[] sharedMaterials;

	// Token: 0x0400066D RID: 1645
	private MeshFilter parentFilter;
}
