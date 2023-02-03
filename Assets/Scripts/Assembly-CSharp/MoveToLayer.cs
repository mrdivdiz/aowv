using System;
using UnityEngine;

// Token: 0x020000EE RID: 238
public class MoveToLayer : MonoBehaviour
{
	// Token: 0x06000694 RID: 1684 RVA: 0x0001EA78 File Offset: 0x0001CC78
	private void Start()
	{
		base.GetComponent<Renderer>().sortingLayerName = this.layerName;
	}

	// Token: 0x040003F5 RID: 1013
	public string layerName;
}
