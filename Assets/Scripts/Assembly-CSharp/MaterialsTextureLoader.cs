using System;
using System.IO;
using Spine;
using UnityEngine;

// Token: 0x02000135 RID: 309
public class MaterialsTextureLoader : TextureLoader
{
	// Token: 0x06000972 RID: 2418 RVA: 0x0002C4A8 File Offset: 0x0002A6A8
	public MaterialsTextureLoader(AtlasAsset atlasAsset)
	{
		this.atlasAsset = atlasAsset;
	}

	// Token: 0x06000973 RID: 2419 RVA: 0x0002C4B8 File Offset: 0x0002A6B8
	public void Load(AtlasPage page, string path)
	{
		string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(path);
		Material material = null;
		foreach (Material material2 in this.atlasAsset.materials)
		{
			if (material2.mainTexture == null)
			{
				Debug.LogError("Material is missing texture: " + material2.name, material2);
				return;
			}
			//if (material2.mainTexture.name == fileNameWithoutExtension)
			//{
				material = material2;
				break;
			//}
		}
		if (material == null)
		{
			Debug.LogError("Material with texture name \"" + fileNameWithoutExtension + "\" not found for atlas asset: " + this.atlasAsset.name, this.atlasAsset);
			return;
		}
		page.rendererObject = material;
		if (page.width == 0 || page.height == 0)
		{
			page.width = material.mainTexture.width;
			page.height = material.mainTexture.height;
		}
	}

	// Token: 0x06000974 RID: 2420 RVA: 0x0002C5B0 File Offset: 0x0002A7B0
	public void Unload(object texture)
	{
	}

	// Token: 0x040005FA RID: 1530
	private AtlasAsset atlasAsset;
}
