using System;

namespace Spine
{
	// Token: 0x02000119 RID: 281
	public class AtlasAttachmentLoader : AttachmentLoader
	{
		// Token: 0x06000799 RID: 1945 RVA: 0x00025B48 File Offset: 0x00023D48
		public AtlasAttachmentLoader(Atlas atlas)
		{
			if (atlas == null)
			{
				throw new ArgumentNullException("atlas cannot be null.");
			}
			this.atlas = atlas;
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x00025B68 File Offset: 0x00023D68
		public RegionAttachment NewRegionAttachment(Skin skin, string name, string path)
		{
			AtlasRegion atlasRegion = this.atlas.FindRegion(path);
			if (atlasRegion == null)
			{
				throw new Exception(string.Concat(new string[]
				{
					"Region not found in atlas: ",
					path,
					" (region attachment: ",
					name,
					")"
				}));
			}
			RegionAttachment regionAttachment = new RegionAttachment(name);
			regionAttachment.RendererObject = atlasRegion;
			regionAttachment.SetUVs(atlasRegion.u, atlasRegion.v, atlasRegion.u2, atlasRegion.v2, atlasRegion.rotate);
			regionAttachment.regionOffsetX = atlasRegion.offsetX;
			regionAttachment.regionOffsetY = atlasRegion.offsetY;
			regionAttachment.regionWidth = (float)atlasRegion.width;
			regionAttachment.regionHeight = (float)atlasRegion.height;
			regionAttachment.regionOriginalWidth = (float)atlasRegion.originalWidth;
			regionAttachment.regionOriginalHeight = (float)atlasRegion.originalHeight;
			return regionAttachment;
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x00025C38 File Offset: 0x00023E38
		public MeshAttachment NewMeshAttachment(Skin skin, string name, string path)
		{
			AtlasRegion atlasRegion = this.atlas.FindRegion(path);
			if (atlasRegion == null)
			{
				throw new Exception(string.Concat(new string[]
				{
					"Region not found in atlas: ",
					path,
					" (mesh attachment: ",
					name,
					")"
				}));
			}
			return new MeshAttachment(name)
			{
				RendererObject = atlasRegion,
				RegionU = atlasRegion.u,
				RegionV = atlasRegion.v,
				RegionU2 = atlasRegion.u2,
				RegionV2 = atlasRegion.v2,
				RegionRotate = atlasRegion.rotate,
				regionOffsetX = atlasRegion.offsetX,
				regionOffsetY = atlasRegion.offsetY,
				regionWidth = (float)atlasRegion.width,
				regionHeight = (float)atlasRegion.height,
				regionOriginalWidth = (float)atlasRegion.originalWidth,
				regionOriginalHeight = (float)atlasRegion.originalHeight
			};
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x00025D20 File Offset: 0x00023F20
		public SkinnedMeshAttachment NewSkinnedMeshAttachment(Skin skin, string name, string path)
		{
			AtlasRegion atlasRegion = this.atlas.FindRegion(path);
			if (atlasRegion == null)
			{
				throw new Exception(string.Concat(new string[]
				{
					"Region not found in atlas: ",
					path,
					" (skinned mesh attachment: ",
					name,
					")"
				}));
			}
			return new SkinnedMeshAttachment(name)
			{
				RendererObject = atlasRegion,
				RegionU = atlasRegion.u,
				RegionV = atlasRegion.v,
				RegionU2 = atlasRegion.u2,
				RegionV2 = atlasRegion.v2,
				RegionRotate = atlasRegion.rotate,
				regionOffsetX = atlasRegion.offsetX,
				regionOffsetY = atlasRegion.offsetY,
				regionWidth = (float)atlasRegion.width,
				regionHeight = (float)atlasRegion.height,
				regionOriginalWidth = (float)atlasRegion.originalWidth,
				regionOriginalHeight = (float)atlasRegion.originalHeight
			};
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x00025E08 File Offset: 0x00024008
		public BoundingBoxAttachment NewBoundingBoxAttachment(Skin skin, string name)
		{
			return new BoundingBoxAttachment(name);
		}

		// Token: 0x0400051A RID: 1306
		private Atlas atlas;
	}
}
