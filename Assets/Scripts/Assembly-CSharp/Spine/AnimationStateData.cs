using System;
using System.Collections.Generic;

namespace Spine
{
	// Token: 0x02000111 RID: 273
	public class AnimationStateData
	{
		// Token: 0x06000785 RID: 1925 RVA: 0x00025398 File Offset: 0x00023598
		public AnimationStateData(SkeletonData skeletonData)
		{
			this.skeletonData = skeletonData;
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000786 RID: 1926 RVA: 0x000253B4 File Offset: 0x000235B4
		public SkeletonData SkeletonData
		{
			get
			{
				return this.skeletonData;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000787 RID: 1927 RVA: 0x000253BC File Offset: 0x000235BC
		// (set) Token: 0x06000788 RID: 1928 RVA: 0x000253C4 File Offset: 0x000235C4
		public float DefaultMix
		{
			get
			{
				return this.defaultMix;
			}
			set
			{
				this.defaultMix = value;
			}
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x000253D0 File Offset: 0x000235D0
		public void SetMix(string fromName, string toName, float duration)
		{
			Animation animation = this.skeletonData.FindAnimation(fromName);
			if (animation == null)
			{
				throw new ArgumentException("Animation not found: " + fromName);
			}
			Animation animation2 = this.skeletonData.FindAnimation(toName);
			if (animation2 == null)
			{
				throw new ArgumentException("Animation not found: " + toName);
			}
			this.SetMix(animation, animation2, duration);
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x00025430 File Offset: 0x00023630
		public void SetMix(Animation from, Animation to, float duration)
		{
			if (from == null)
			{
				throw new ArgumentNullException("from cannot be null.");
			}
			if (to == null)
			{
				throw new ArgumentNullException("to cannot be null.");
			}
			KeyValuePair<Animation, Animation> key = new KeyValuePair<Animation, Animation>(from, to);
			this.animationToMixTime.Remove(key);
			this.animationToMixTime.Add(key, duration);
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x00025484 File Offset: 0x00023684
		public float GetMix(Animation from, Animation to)
		{
			KeyValuePair<Animation, Animation> key = new KeyValuePair<Animation, Animation>(from, to);
			float result;
			if (this.animationToMixTime.TryGetValue(key, out result))
			{
				return result;
			}
			return this.defaultMix;
		}

		// Token: 0x040004E5 RID: 1253
		internal SkeletonData skeletonData;

		// Token: 0x040004E6 RID: 1254
		private Dictionary<KeyValuePair<Animation, Animation>, float> animationToMixTime = new Dictionary<KeyValuePair<Animation, Animation>, float>();

		// Token: 0x040004E7 RID: 1255
		internal float defaultMix;
	}
}
