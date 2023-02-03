using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000142 RID: 322
public class SkeletonUtilityKinematicShadow : MonoBehaviour
{
	// Token: 0x060009C8 RID: 2504 RVA: 0x0002F914 File Offset: 0x0002DB14
	private void Start()
	{
		this.shadowRoot = UnityEngine.Object.Instantiate<GameObject>(base.gameObject);
		if (this.hideShadow)
		{
			this.shadowRoot.hideFlags = HideFlags.HideInHierarchy;
		}
		this.shadowRoot.transform.parent = base.transform.root;
		this.shadowTable = new Dictionary<Transform, Transform>();
		UnityEngine.Object.Destroy(this.shadowRoot.GetComponent<SkeletonUtilityKinematicShadow>());
		this.shadowRoot.transform.position = base.transform.position;
		this.shadowRoot.transform.rotation = base.transform.rotation;
		Vector3 b = base.transform.TransformPoint(Vector3.right);
		float d = Vector3.Distance(base.transform.position, b);
		this.shadowRoot.transform.localScale = Vector3.one;
		Joint[] componentsInChildren = this.shadowRoot.GetComponentsInChildren<Joint>();
		foreach (Joint joint in componentsInChildren)
		{
			joint.connectedAnchor *= d;
		}
		Joint[] componentsInChildren2 = base.GetComponentsInChildren<Joint>();
		foreach (Joint obj in componentsInChildren2)
		{
			UnityEngine.Object.Destroy(obj);
		}
		Rigidbody[] componentsInChildren3 = base.GetComponentsInChildren<Rigidbody>();
		foreach (Rigidbody obj2 in componentsInChildren3)
		{
			UnityEngine.Object.Destroy(obj2);
		}
		Collider[] componentsInChildren4 = base.GetComponentsInChildren<Collider>();
		foreach (Collider obj3 in componentsInChildren4)
		{
			UnityEngine.Object.Destroy(obj3);
		}
		SkeletonUtilityBone[] componentsInChildren5 = this.shadowRoot.GetComponentsInChildren<SkeletonUtilityBone>();
		SkeletonUtilityBone[] componentsInChildren6 = base.GetComponentsInChildren<SkeletonUtilityBone>();
		foreach (SkeletonUtilityBone skeletonUtilityBone in componentsInChildren6)
		{
			if (!(skeletonUtilityBone.gameObject == base.gameObject))
			{
				foreach (SkeletonUtilityBone skeletonUtilityBone2 in componentsInChildren5)
				{
					if (!(skeletonUtilityBone2.GetComponent<Rigidbody>() == null))
					{
						if (skeletonUtilityBone2.boneName == skeletonUtilityBone.boneName)
						{
							this.shadowTable.Add(skeletonUtilityBone2.transform, skeletonUtilityBone.transform);
							break;
						}
					}
				}
			}
		}
		foreach (SkeletonUtilityBone obj4 in componentsInChildren5)
		{
			UnityEngine.Object.Destroy(obj4);
		}
	}

	// Token: 0x060009C9 RID: 2505 RVA: 0x0002FBB8 File Offset: 0x0002DDB8
	private void FixedUpdate()
	{
		this.shadowRoot.GetComponent<Rigidbody>().MovePosition(base.transform.position);
		this.shadowRoot.GetComponent<Rigidbody>().MoveRotation(base.transform.rotation);
		foreach (KeyValuePair<Transform, Transform> keyValuePair in this.shadowTable)
		{
			keyValuePair.Value.localPosition = keyValuePair.Key.localPosition;
			keyValuePair.Value.localRotation = keyValuePair.Key.localRotation;
		}
	}

	// Token: 0x04000661 RID: 1633
	public bool hideShadow = true;

	// Token: 0x04000662 RID: 1634
	private Dictionary<Transform, Transform> shadowTable;

	// Token: 0x04000663 RID: 1635
	private GameObject shadowRoot;
}
