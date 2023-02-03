using System;
using System.Collections.Generic;
using Spine;
using UnityEngine;

// Token: 0x0200013A RID: 314
[ExecuteInEditMode]
[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class SkeletonRenderer : MonoBehaviour
{
	// Token: 0x06000993 RID: 2451 RVA: 0x0002D050 File Offset: 0x0002B250
	public virtual void Reset()
	{
		if (this.meshFilter != null)
		{
			this.meshFilter.sharedMesh = null;
		}
		if (this.mesh != null)
		{
			UnityEngine.Object.DestroyImmediate(this.mesh);
		}
		if (base.GetComponent<Renderer>() != null)
		{
			base.GetComponent<Renderer>().sharedMaterial = null;
		}
		this.mesh = null;
		this.mesh1 = null;
		this.mesh2 = null;
		this.lastVertexCount = 0;
		this.vertices = null;
		this.colors = null;
		this.uvs = null;
		this.sharedMaterials = new Material[0];
		this.submeshMaterials.Clear();
		this.submeshes.Clear();
		this.skeleton = null;
		this.valid = false;
		if (!this.skeletonDataAsset)
		{
			if (this.logErrors)
			{
				Debug.LogError("Missing SkeletonData asset.", this);
			}
			return;
		}
		SkeletonData skeletonData = this.skeletonDataAsset.GetSkeletonData(false);
		if (skeletonData == null)
		{
			return;
		}
		this.valid = true;
		this.meshFilter = base.GetComponent<MeshFilter>();
		this.mesh1 = this.newMesh();
		this.mesh2 = this.newMesh();
		this.vertices = new Vector3[0];
		this.skeleton = new Skeleton(skeletonData);
		if (this.initialSkinName != null && this.initialSkinName.Length > 0 && this.initialSkinName != "default")
		{
			this.skeleton.SetSkin(this.initialSkinName);
		}
		if (this.OnReset != null)
		{
			this.OnReset(this);
		}
	}

	// Token: 0x06000994 RID: 2452 RVA: 0x0002D1EC File Offset: 0x0002B3EC
	public void Awake()
	{
		this.Reset();
	}

	// Token: 0x06000995 RID: 2453 RVA: 0x0002D1F4 File Offset: 0x0002B3F4
	private Mesh newMesh()
	{
		Mesh mesh = new Mesh();
		mesh.name = "Skeleton Mesh";
		mesh.hideFlags = HideFlags.HideAndDontSave;
		mesh.MarkDynamic();
		return mesh;
	}

	// Token: 0x06000996 RID: 2454 RVA: 0x0002D224 File Offset: 0x0002B424
	public virtual void LateUpdate()
	{
		if (!this.valid)
		{
			return;
		}
		int num = 0;
		int num2 = 0;
		int firstVertex = 0;
		int startSlot = 0;
		Material material = null;
		this.submeshMaterials.Clear();
		List<Slot> drawOrder = this.skeleton.DrawOrder;
		int count = drawOrder.Count;
		bool flag = this.renderMeshes;
		int i = 0;
		while (i < count)
		{
			Slot slot = drawOrder[i];
			Attachment attachment = slot.attachment;
			object rendererObject;
			int num3;
			int num4;
			if (attachment is RegionAttachment)
			{
				rendererObject = ((RegionAttachment)attachment).RendererObject;
				num3 = 4;
				num4 = 6;
				goto IL_108;
			}
			if (flag)
			{
				if (attachment is MeshAttachment)
				{
					MeshAttachment meshAttachment = (MeshAttachment)attachment;
					rendererObject = meshAttachment.RendererObject;
					num3 = meshAttachment.vertices.Length >> 1;
					num4 = meshAttachment.triangles.Length;
					goto IL_108;
				}
				if (attachment is SkinnedMeshAttachment)
				{
					SkinnedMeshAttachment skinnedMeshAttachment = (SkinnedMeshAttachment)attachment;
					rendererObject = skinnedMeshAttachment.RendererObject;
					num3 = skinnedMeshAttachment.uvs.Length >> 1;
					num4 = skinnedMeshAttachment.triangles.Length;
					goto IL_108;
				}
			}
			IL_177:
			i++;
			continue;
			IL_108:
			Material material2 = (Material)((AtlasRegion)rendererObject).page.rendererObject;
			if ((material != material2 && material != null) || slot.Data.name[0] == '*')
			{
				this.AddSubmesh(material, startSlot, i, num2, firstVertex, false);
				num2 = 0;
				firstVertex = num;
				startSlot = i;
			}
			material = material2;
			num2 += num4;
			num += num3;
			goto IL_177;
		}
		this.AddSubmesh(material, startSlot, count, num2, firstVertex, true);
		if (this.submeshMaterials.Count == this.sharedMaterials.Length)
		{
			this.submeshMaterials.CopyTo(this.sharedMaterials);
		}
		else
		{
			this.sharedMaterials = this.submeshMaterials.ToArray();
		}
		base.GetComponent<Renderer>().sharedMaterials = this.sharedMaterials;
		Vector3[] array = this.vertices;
		bool flag2 = num > array.Length;
		if (flag2)
		{
			array = (this.vertices = new Vector3[num]);
			this.colors = new Color32[num];
			this.uvs = new Vector2[num];
			this.mesh1.Clear();
			this.mesh2.Clear();
		}
		else
		{
			Vector3 zero = Vector3.zero;
			int j = num;
			int num5 = this.lastVertexCount;
			while (j < num5)
			{
				array[j] = zero;
				j++;
			}
		}
		this.lastVertexCount = num;
		float[] array2 = this.tempVertices;
		Vector2[] array3 = this.uvs;
		Color32[] array4 = this.colors;
		int num6 = 0;
		Color32 color = default(Color32);
		float num7 = this.zSpacing;
		float num8 = this.skeleton.a * 255f;
		float r = this.skeleton.r;
		float g = this.skeleton.g;
		float b = this.skeleton.b;
		for (int k = 0; k < count; k++)
		{
			Slot slot2 = drawOrder[k];
			Attachment attachment2 = slot2.attachment;
			if (attachment2 is RegionAttachment)
			{
				RegionAttachment regionAttachment = (RegionAttachment)attachment2;
				regionAttachment.ComputeWorldVertices(slot2.bone, array2);
				float z = (float)k * num7;
				array[num6] = new Vector3(array2[0], array2[1], z);
				array[num6 + 1] = new Vector3(array2[6], array2[7], z);
				array[num6 + 2] = new Vector3(array2[2], array2[3], z);
				array[num6 + 3] = new Vector3(array2[4], array2[5], z);
				color.a = (byte)(num8 * slot2.a * regionAttachment.a);
				color.r = (byte)(r * slot2.r * regionAttachment.r * (float)color.a);
				color.g = (byte)(g * slot2.g * regionAttachment.g * (float)color.a);
				color.b = (byte)(b * slot2.b * regionAttachment.b * (float)color.a);
				if (slot2.data.additiveBlending)
				{
					color.a = 0;
				}
				array4[num6] = color;
				array4[num6 + 1] = color;
				array4[num6 + 2] = color;
				array4[num6 + 3] = color;
				float[] array5 = regionAttachment.uvs;
				array3[num6] = new Vector2(array5[0], array5[1]);
				array3[num6 + 1] = new Vector2(array5[6], array5[7]);
				array3[num6 + 2] = new Vector2(array5[2], array5[3]);
				array3[num6 + 3] = new Vector2(array5[4], array5[5]);
				num6 += 4;
			}
			else if (flag)
			{
				if (attachment2 is MeshAttachment)
				{
					MeshAttachment meshAttachment2 = (MeshAttachment)attachment2;
					int num9 = meshAttachment2.vertices.Length;
					if (array2.Length < num9)
					{
						array2 = new float[num9];
					}
					meshAttachment2.ComputeWorldVertices(slot2, array2);
					color.a = (byte)(num8 * slot2.a * meshAttachment2.a);
					color.r = (byte)(r * slot2.r * meshAttachment2.r * (float)color.a);
					color.g = (byte)(g * slot2.g * meshAttachment2.g * (float)color.a);
					color.b = (byte)(b * slot2.b * meshAttachment2.b * (float)color.a);
					if (slot2.data.additiveBlending)
					{
						color.a = 0;
					}
					float[] array6 = meshAttachment2.uvs;
					float z2 = (float)k * num7;
					int l = 0;
					while (l < num9)
					{
						array[num6] = new Vector3(array2[l], array2[l + 1], z2);
						array4[num6] = color;
						array3[num6] = new Vector2(array6[l], array6[l + 1]);
						l += 2;
						num6++;
					}
				}
				else if (attachment2 is SkinnedMeshAttachment)
				{
					SkinnedMeshAttachment skinnedMeshAttachment2 = (SkinnedMeshAttachment)attachment2;
					int num10 = skinnedMeshAttachment2.uvs.Length;
					if (array2.Length < num10)
					{
						array2 = new float[num10];
					}
					skinnedMeshAttachment2.ComputeWorldVertices(slot2, array2);
					color.a = (byte)(num8 * slot2.a * skinnedMeshAttachment2.a);
					color.r = (byte)(r * slot2.r * skinnedMeshAttachment2.r * (float)color.a);
					color.g = (byte)(g * slot2.g * skinnedMeshAttachment2.g * (float)color.a);
					color.b = (byte)(b * slot2.b * skinnedMeshAttachment2.b * (float)color.a);
					if (slot2.data.additiveBlending)
					{
						color.a = 0;
					}
					float[] array7 = skinnedMeshAttachment2.uvs;
					float z3 = (float)k * num7;
					int m = 0;
					while (m < num10)
					{
						array[num6] = new Vector3(array2[m], array2[m + 1], z3);
						array4[num6] = color;
						array3[num6] = new Vector2(array7[m], array7[m + 1]);
						m += 2;
						num6++;
					}
				}
			}
		}
		Mesh mesh = (!this.useMesh1) ? this.mesh2 : this.mesh1;
		this.meshFilter.sharedMesh = mesh;
		mesh.vertices = array;
		mesh.colors32 = array4;
		mesh.uv = array3;
		int count2 = this.submeshMaterials.Count;
		mesh.subMeshCount = count2;
		for (int n = 0; n < count2; n++)
		{
			mesh.SetTriangles(this.submeshes[n].triangles, n);
		}
		mesh.RecalculateBounds();
		if (flag2 && this.calculateNormals)
		{
			Vector3[] array8 = new Vector3[num];
			Vector3 vector = new Vector3(0f, 0f, -1f);
			for (int num11 = 0; num11 < num; num11++)
			{
				array8[num11] = vector;
			}
			((!this.useMesh1) ? this.mesh1 : this.mesh2).vertices = array;
			this.mesh1.normals = array8;
			this.mesh2.normals = array8;
			if (this.calculateTangents)
			{
				Vector4[] array9 = new Vector4[num];
				Vector3 v = new Vector3(0f, 0f, 1f);
				for (int num12 = 0; num12 < num; num12++)
				{
					array9[num12] = v;
				}
				this.mesh1.tangents = array9;
				this.mesh2.tangents = array9;
			}
		}
		this.useMesh1 = !this.useMesh1;
	}

	// Token: 0x06000997 RID: 2455 RVA: 0x0002DBB4 File Offset: 0x0002BDB4
	private void AddSubmesh(Material material, int startSlot, int endSlot, int triangleCount, int firstVertex, bool lastSubmesh)
	{
		int count = this.submeshMaterials.Count;
		this.submeshMaterials.Add(material);
		if (this.submeshes.Count <= count)
		{
			this.submeshes.Add(new Submesh());
		}
		else if (this.immutableTriangles)
		{
			return;
		}
		Submesh submesh = this.submeshes[count];
		int[] array = submesh.triangles;
		int num = array.Length;
		if (lastSubmesh && num > triangleCount)
		{
			for (int i = triangleCount; i < num; i++)
			{
				array[i] = 0;
			}
			submesh.triangleCount = triangleCount;
		}
		else if (num != triangleCount)
		{
			array = (submesh.triangles = new int[triangleCount]);
			submesh.triangleCount = 0;
		}
		if (!this.renderMeshes)
		{
			if (submesh.firstVertex != firstVertex || submesh.triangleCount < triangleCount)
			{
				submesh.triangleCount = triangleCount;
				submesh.firstVertex = firstVertex;
				int j = 0;
				while (j < triangleCount)
				{
					array[j] = firstVertex;
					array[j + 1] = firstVertex + 2;
					array[j + 2] = firstVertex + 1;
					array[j + 3] = firstVertex + 2;
					array[j + 4] = firstVertex + 3;
					array[j + 5] = firstVertex + 1;
					j += 6;
					firstVertex += 4;
				}
			}
			return;
		}
		List<Slot> drawOrder = this.skeleton.DrawOrder;
		int k = startSlot;
		int num2 = 0;
		while (k < endSlot)
		{
			Attachment attachment = drawOrder[k].attachment;
			if (attachment is RegionAttachment)
			{
				array[num2] = firstVertex;
				array[num2 + 1] = firstVertex + 2;
				array[num2 + 2] = firstVertex + 1;
				array[num2 + 3] = firstVertex + 2;
				array[num2 + 4] = firstVertex + 3;
				array[num2 + 5] = firstVertex + 1;
				num2 += 6;
				firstVertex += 4;
			}
			else
			{
				int num3;
				int[] triangles;
				if (attachment is MeshAttachment)
				{
					MeshAttachment meshAttachment = (MeshAttachment)attachment;
					num3 = meshAttachment.vertices.Length >> 1;
					triangles = meshAttachment.triangles;
				}
				else
				{
					if (!(attachment is SkinnedMeshAttachment))
					{
						goto IL_25B;
					}
					SkinnedMeshAttachment skinnedMeshAttachment = (SkinnedMeshAttachment)attachment;
					num3 = skinnedMeshAttachment.uvs.Length >> 1;
					triangles = skinnedMeshAttachment.triangles;
				}
				int l = 0;
				int num4 = triangles.Length;
				while (l < num4)
				{
					array[num2] = firstVertex + triangles[l];
					l++;
					num2++;
				}
				firstVertex += num3;
			}
			IL_25B:
			k++;
		}
	}

	// Token: 0x04000614 RID: 1556
	public SkeletonRenderer.SkeletonRendererDelegate OnReset;

	// Token: 0x04000615 RID: 1557
	[NonSerialized]
	public bool valid;

	// Token: 0x04000616 RID: 1558
	[NonSerialized]
	public Skeleton skeleton;

	// Token: 0x04000617 RID: 1559
	public SkeletonDataAsset skeletonDataAsset;

	// Token: 0x04000618 RID: 1560
	public string initialSkinName;

	// Token: 0x04000619 RID: 1561
	public bool calculateNormals;

	// Token: 0x0400061A RID: 1562
	public bool calculateTangents;

	// Token: 0x0400061B RID: 1563
	public float zSpacing;

	// Token: 0x0400061C RID: 1564
	public bool renderMeshes = true;

	// Token: 0x0400061D RID: 1565
	public bool immutableTriangles;

	// Token: 0x0400061E RID: 1566
	public bool logErrors;

	// Token: 0x0400061F RID: 1567
	private MeshFilter meshFilter;

	// Token: 0x04000620 RID: 1568
	private Mesh mesh;

	// Token: 0x04000621 RID: 1569
	private Mesh mesh1;

	// Token: 0x04000622 RID: 1570
	private Mesh mesh2;

	// Token: 0x04000623 RID: 1571
	private bool useMesh1;

	// Token: 0x04000624 RID: 1572
	private float[] tempVertices = new float[8];

	// Token: 0x04000625 RID: 1573
	private int lastVertexCount;

	// Token: 0x04000626 RID: 1574
	private Vector3[] vertices;

	// Token: 0x04000627 RID: 1575
	private Color32[] colors;

	// Token: 0x04000628 RID: 1576
	private Vector2[] uvs;

	// Token: 0x04000629 RID: 1577
	private Material[] sharedMaterials = new Material[0];

	// Token: 0x0400062A RID: 1578
	private readonly List<Material> submeshMaterials = new List<Material>();

	// Token: 0x0400062B RID: 1579
	private readonly List<Submesh> submeshes = new List<Submesh>();

	// Token: 0x0200017F RID: 383
	// (Invoke) Token: 0x06000ABE RID: 2750
	public delegate void SkeletonRendererDelegate(SkeletonRenderer skeletonRenderer);
}
