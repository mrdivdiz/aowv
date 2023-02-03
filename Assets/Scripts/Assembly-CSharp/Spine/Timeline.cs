using System;
using System.Collections.Generic;

namespace Spine
{
	// Token: 0x02000102 RID: 258
	public interface Timeline
	{
		// Token: 0x060006FA RID: 1786
		void Apply(Skeleton skeleton, float lastTime, float time, List<Event> events, float alpha);
	}
}
