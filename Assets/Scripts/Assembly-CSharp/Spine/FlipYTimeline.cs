using System;

namespace Spine
{
	// Token: 0x0200010E RID: 270
	public class FlipYTimeline : FlipXTimeline
	{
		// Token: 0x0600074E RID: 1870 RVA: 0x000248D8 File Offset: 0x00022AD8
		public FlipYTimeline(int frameCount) : base(frameCount)
		{
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x000248E4 File Offset: 0x00022AE4
		protected override void SetFlip(Bone bone, bool flip)
		{
			bone.flipY = flip;
		}
	}
}
