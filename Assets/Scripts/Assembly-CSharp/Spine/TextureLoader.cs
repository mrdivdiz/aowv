using System;

namespace Spine
{
	// Token: 0x02000118 RID: 280
	public interface TextureLoader
	{
		// Token: 0x06000797 RID: 1943
		void Load(AtlasPage page, string path);

		// Token: 0x06000798 RID: 1944
		void Unload(object texture);
	}
}
