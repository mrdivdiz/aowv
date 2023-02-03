using System;
using System.IO;
using Spine;
using UnityEngine;

// Token: 0x02000134 RID: 308
public class AtlasAsset : ScriptableObject
{
	// Token: 0x06000970 RID: 2416 RVA: 0x0002C368 File Offset: 0x0002A568
	public void Reset()
	{
		this.atlas = null;
	}

	// Token: 0x06000971 RID: 2417 RVA: 0x0002C374 File Offset: 0x0002A574
	public Atlas GetAtlas()
	{
		if (this.atlasFile == null)
		{
			Debug.LogError("Atlas file not set for atlas asset: " + base.name, this);
			this.Reset();
			return null;
		}
		if (this.materials == null || this.materials.Length == 0)
		{
			Debug.LogError("Materials not set for atlas asset: " + base.name, this);
			this.Reset();
			return null;
		}
		if (this.atlas != null)
		{
			return this.atlas;
		}
		Atlas result;
		try
		{
			this.atlas = new Atlas(new StringReader(this.atlasFile.text), string.Empty, new MaterialsTextureLoader(this));
			this.atlas.FlipV();
			result = this.atlas;
		}
		catch (Exception ex)
		{
			Debug.LogError(string.Concat(new string[]
			{
				"Error reading atlas file for atlas asset: ",
				base.name,
				"\n",
				ex.Message,
				"\n",
				ex.StackTrace
			}), this);
			result = null;
		}
		return result;
	}

	// Token: 0x040005F7 RID: 1527
	public TextAsset atlasFile;

	// Token: 0x040005F8 RID: 1528
	public Material[] materials;

	// Token: 0x040005F9 RID: 1529
	private Atlas atlas;
}
