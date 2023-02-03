using System;

namespace Spine
{
	// Token: 0x0200011B RID: 283
	public interface AttachmentLoader
	{
		// Token: 0x060007A2 RID: 1954
		RegionAttachment NewRegionAttachment(Skin skin, string name, string path);

		// Token: 0x060007A3 RID: 1955
		MeshAttachment NewMeshAttachment(Skin skin, string name, string path);

		// Token: 0x060007A4 RID: 1956
		SkinnedMeshAttachment NewSkinnedMeshAttachment(Skin skin, string name, string path);

		// Token: 0x060007A5 RID: 1957
		BoundingBoxAttachment NewBoundingBoxAttachment(Skin skin, string name);
	}
}
