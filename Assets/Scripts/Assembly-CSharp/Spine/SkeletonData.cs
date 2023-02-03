using System;
using System.Collections.Generic;

namespace Spine
{
	// Token: 0x0200012E RID: 302
	public class SkeletonData
	{
		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600090D RID: 2317 RVA: 0x000296E8 File Offset: 0x000278E8
		// (set) Token: 0x0600090E RID: 2318 RVA: 0x000296F0 File Offset: 0x000278F0
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600090F RID: 2319 RVA: 0x000296FC File Offset: 0x000278FC
		public List<BoneData> Bones
		{
			get
			{
				return this.bones;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000910 RID: 2320 RVA: 0x00029704 File Offset: 0x00027904
		public List<SlotData> Slots
		{
			get
			{
				return this.slots;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000911 RID: 2321 RVA: 0x0002970C File Offset: 0x0002790C
		// (set) Token: 0x06000912 RID: 2322 RVA: 0x00029714 File Offset: 0x00027914
		public List<Skin> Skins
		{
			get
			{
				return this.skins;
			}
			set
			{
				this.skins = value;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000913 RID: 2323 RVA: 0x00029720 File Offset: 0x00027920
		// (set) Token: 0x06000914 RID: 2324 RVA: 0x00029728 File Offset: 0x00027928
		public Skin DefaultSkin
		{
			get
			{
				return this.defaultSkin;
			}
			set
			{
				this.defaultSkin = value;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000915 RID: 2325 RVA: 0x00029734 File Offset: 0x00027934
		// (set) Token: 0x06000916 RID: 2326 RVA: 0x0002973C File Offset: 0x0002793C
		public List<EventData> Events
		{
			get
			{
				return this.events;
			}
			set
			{
				this.events = value;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000917 RID: 2327 RVA: 0x00029748 File Offset: 0x00027948
		// (set) Token: 0x06000918 RID: 2328 RVA: 0x00029750 File Offset: 0x00027950
		public List<Animation> Animations
		{
			get
			{
				return this.animations;
			}
			set
			{
				this.animations = value;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000919 RID: 2329 RVA: 0x0002975C File Offset: 0x0002795C
		// (set) Token: 0x0600091A RID: 2330 RVA: 0x00029764 File Offset: 0x00027964
		public List<IkConstraintData> IkConstraints
		{
			get
			{
				return this.ikConstraints;
			}
			set
			{
				this.ikConstraints = value;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x0600091B RID: 2331 RVA: 0x00029770 File Offset: 0x00027970
		// (set) Token: 0x0600091C RID: 2332 RVA: 0x00029778 File Offset: 0x00027978
		public float Width
		{
			get
			{
				return this.width;
			}
			set
			{
				this.width = value;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x0600091D RID: 2333 RVA: 0x00029784 File Offset: 0x00027984
		// (set) Token: 0x0600091E RID: 2334 RVA: 0x0002978C File Offset: 0x0002798C
		public float Height
		{
			get
			{
				return this.height;
			}
			set
			{
				this.height = value;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x0600091F RID: 2335 RVA: 0x00029798 File Offset: 0x00027998
		// (set) Token: 0x06000920 RID: 2336 RVA: 0x000297A0 File Offset: 0x000279A0
		public string Version
		{
			get
			{
				return this.version;
			}
			set
			{
				this.version = value;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000921 RID: 2337 RVA: 0x000297AC File Offset: 0x000279AC
		// (set) Token: 0x06000922 RID: 2338 RVA: 0x000297B4 File Offset: 0x000279B4
		public string Hash
		{
			get
			{
				return this.hash;
			}
			set
			{
				this.hash = value;
			}
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x000297C0 File Offset: 0x000279C0
		public BoneData FindBone(string boneName)
		{
			if (boneName == null)
			{
				throw new ArgumentNullException("boneName cannot be null.");
			}
			List<BoneData> list = this.bones;
			int i = 0;
			int count = list.Count;
			while (i < count)
			{
				BoneData boneData = list[i];
				if (boneData.name == boneName)
				{
					return boneData;
				}
				i++;
			}
			return null;
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x0002981C File Offset: 0x00027A1C
		public int FindBoneIndex(string boneName)
		{
			if (boneName == null)
			{
				throw new ArgumentNullException("boneName cannot be null.");
			}
			List<BoneData> list = this.bones;
			int i = 0;
			int count = list.Count;
			while (i < count)
			{
				if (list[i].name == boneName)
				{
					return i;
				}
				i++;
			}
			return -1;
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x00029874 File Offset: 0x00027A74
		public SlotData FindSlot(string slotName)
		{
			if (slotName == null)
			{
				throw new ArgumentNullException("slotName cannot be null.");
			}
			List<SlotData> list = this.slots;
			int i = 0;
			int count = list.Count;
			while (i < count)
			{
				SlotData slotData = list[i];
				if (slotData.name == slotName)
				{
					return slotData;
				}
				i++;
			}
			return null;
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x000298D0 File Offset: 0x00027AD0
		public int FindSlotIndex(string slotName)
		{
			if (slotName == null)
			{
				throw new ArgumentNullException("slotName cannot be null.");
			}
			List<SlotData> list = this.slots;
			int i = 0;
			int count = list.Count;
			while (i < count)
			{
				if (list[i].name == slotName)
				{
					return i;
				}
				i++;
			}
			return -1;
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x00029928 File Offset: 0x00027B28
		public Skin FindSkin(string skinName)
		{
			if (skinName == null)
			{
				throw new ArgumentNullException("skinName cannot be null.");
			}
			foreach (Skin skin in this.skins)
			{
				if (skin.name == skinName)
				{
					return skin;
				}
			}
			return null;
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x000299B4 File Offset: 0x00027BB4
		public EventData FindEvent(string eventDataName)
		{
			if (eventDataName == null)
			{
				throw new ArgumentNullException("eventDataName cannot be null.");
			}
			foreach (EventData eventData in this.events)
			{
				if (eventData.name == eventDataName)
				{
					return eventData;
				}
			}
			return null;
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x00029A40 File Offset: 0x00027C40
		public Animation FindAnimation(string animationName)
		{
			if (animationName == null)
			{
				throw new ArgumentNullException("animationName cannot be null.");
			}
			List<Animation> list = this.animations;
			int i = 0;
			int count = list.Count;
			while (i < count)
			{
				Animation animation = list[i];
				if (animation.name == animationName)
				{
					return animation;
				}
				i++;
			}
			return null;
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x00029A9C File Offset: 0x00027C9C
		public IkConstraintData FindIkConstraint(string ikConstraintName)
		{
			if (ikConstraintName == null)
			{
				throw new ArgumentNullException("ikConstraintName cannot be null.");
			}
			List<IkConstraintData> list = this.ikConstraints;
			int i = 0;
			int count = list.Count;
			while (i < count)
			{
				IkConstraintData ikConstraintData = list[i];
				if (ikConstraintData.name == ikConstraintName)
				{
					return ikConstraintData;
				}
				i++;
			}
			return null;
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x00029AF8 File Offset: 0x00027CF8
		public override string ToString()
		{
			return this.name ?? base.ToString();
		}

		// Token: 0x040005D4 RID: 1492
		internal string name;

		// Token: 0x040005D5 RID: 1493
		internal List<BoneData> bones = new List<BoneData>();

		// Token: 0x040005D6 RID: 1494
		internal List<SlotData> slots = new List<SlotData>();

		// Token: 0x040005D7 RID: 1495
		internal List<Skin> skins = new List<Skin>();

		// Token: 0x040005D8 RID: 1496
		internal Skin defaultSkin;

		// Token: 0x040005D9 RID: 1497
		internal List<EventData> events = new List<EventData>();

		// Token: 0x040005DA RID: 1498
		internal List<Animation> animations = new List<Animation>();

		// Token: 0x040005DB RID: 1499
		internal List<IkConstraintData> ikConstraints = new List<IkConstraintData>();

		// Token: 0x040005DC RID: 1500
		internal float width;

		// Token: 0x040005DD RID: 1501
		internal float height;

		// Token: 0x040005DE RID: 1502
		internal string version;

		// Token: 0x040005DF RID: 1503
		internal string hash;
	}
}
