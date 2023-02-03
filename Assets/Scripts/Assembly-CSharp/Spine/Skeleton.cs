using System;
using System.Collections.Generic;

namespace Spine
{
	// Token: 0x0200012B RID: 299
	public class Skeleton
	{
		// Token: 0x060008C2 RID: 2242 RVA: 0x0002849C File Offset: 0x0002669C
		public Skeleton(SkeletonData data)
		{
			if (data == null)
			{
				throw new ArgumentNullException("data cannot be null.");
			}
			this.data = data;
			this.bones = new List<Bone>(data.bones.Count);
			foreach (BoneData boneData in data.bones)
			{
				Bone bone = (boneData.parent != null) ? this.bones[data.bones.IndexOf(boneData.parent)] : null;
				Bone item = new Bone(boneData, this, bone);
				if (bone != null)
				{
					bone.children.Add(item);
				}
				this.bones.Add(item);
			}
			this.slots = new List<Slot>(data.slots.Count);
			this.drawOrder = new List<Slot>(data.slots.Count);
			foreach (SlotData slotData in data.slots)
			{
				Bone bone2 = this.bones[data.bones.IndexOf(slotData.boneData)];
				Slot item2 = new Slot(slotData, bone2);
				this.slots.Add(item2);
				this.drawOrder.Add(item2);
			}
			this.ikConstraints = new List<IkConstraint>(data.ikConstraints.Count);
			foreach (IkConstraintData ikConstraintData in data.ikConstraints)
			{
				this.ikConstraints.Add(new IkConstraint(ikConstraintData, this));
			}
			this.UpdateCache();
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060008C3 RID: 2243 RVA: 0x000286FC File Offset: 0x000268FC
		public SkeletonData Data
		{
			get
			{
				return this.data;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060008C4 RID: 2244 RVA: 0x00028704 File Offset: 0x00026904
		public List<Bone> Bones
		{
			get
			{
				return this.bones;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060008C5 RID: 2245 RVA: 0x0002870C File Offset: 0x0002690C
		public List<Slot> Slots
		{
			get
			{
				return this.slots;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060008C6 RID: 2246 RVA: 0x00028714 File Offset: 0x00026914
		public List<Slot> DrawOrder
		{
			get
			{
				return this.drawOrder;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060008C7 RID: 2247 RVA: 0x0002871C File Offset: 0x0002691C
		// (set) Token: 0x060008C8 RID: 2248 RVA: 0x00028724 File Offset: 0x00026924
		public List<IkConstraint> IkConstraints
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

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060008C9 RID: 2249 RVA: 0x00028730 File Offset: 0x00026930
		// (set) Token: 0x060008CA RID: 2250 RVA: 0x00028738 File Offset: 0x00026938
		public Skin Skin
		{
			get
			{
				return this.skin;
			}
			set
			{
				this.skin = value;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060008CB RID: 2251 RVA: 0x00028744 File Offset: 0x00026944
		// (set) Token: 0x060008CC RID: 2252 RVA: 0x0002874C File Offset: 0x0002694C
		public float R
		{
			get
			{
				return this.r;
			}
			set
			{
				this.r = value;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060008CD RID: 2253 RVA: 0x00028758 File Offset: 0x00026958
		// (set) Token: 0x060008CE RID: 2254 RVA: 0x00028760 File Offset: 0x00026960
		public float G
		{
			get
			{
				return this.g;
			}
			set
			{
				this.g = value;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060008CF RID: 2255 RVA: 0x0002876C File Offset: 0x0002696C
		// (set) Token: 0x060008D0 RID: 2256 RVA: 0x00028774 File Offset: 0x00026974
		public float B
		{
			get
			{
				return this.b;
			}
			set
			{
				this.b = value;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060008D1 RID: 2257 RVA: 0x00028780 File Offset: 0x00026980
		// (set) Token: 0x060008D2 RID: 2258 RVA: 0x00028788 File Offset: 0x00026988
		public float A
		{
			get
			{
				return this.a;
			}
			set
			{
				this.a = value;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060008D3 RID: 2259 RVA: 0x00028794 File Offset: 0x00026994
		// (set) Token: 0x060008D4 RID: 2260 RVA: 0x0002879C File Offset: 0x0002699C
		public float Time
		{
			get
			{
				return this.time;
			}
			set
			{
				this.time = value;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060008D5 RID: 2261 RVA: 0x000287A8 File Offset: 0x000269A8
		// (set) Token: 0x060008D6 RID: 2262 RVA: 0x000287B0 File Offset: 0x000269B0
		public float X
		{
			get
			{
				return this.x;
			}
			set
			{
				this.x = value;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060008D7 RID: 2263 RVA: 0x000287BC File Offset: 0x000269BC
		// (set) Token: 0x060008D8 RID: 2264 RVA: 0x000287C4 File Offset: 0x000269C4
		public float Y
		{
			get
			{
				return this.y;
			}
			set
			{
				this.y = value;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060008D9 RID: 2265 RVA: 0x000287D0 File Offset: 0x000269D0
		// (set) Token: 0x060008DA RID: 2266 RVA: 0x000287D8 File Offset: 0x000269D8
		public bool FlipX
		{
			get
			{
				return this.flipX;
			}
			set
			{
				this.flipX = value;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060008DB RID: 2267 RVA: 0x000287E4 File Offset: 0x000269E4
		// (set) Token: 0x060008DC RID: 2268 RVA: 0x000287EC File Offset: 0x000269EC
		public bool FlipY
		{
			get
			{
				return this.flipY;
			}
			set
			{
				this.flipY = value;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060008DD RID: 2269 RVA: 0x000287F8 File Offset: 0x000269F8
		public Bone RootBone
		{
			get
			{
				return (this.bones.Count != 0) ? this.bones[0] : null;
			}
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x00028828 File Offset: 0x00026A28
		public void UpdateCache()
		{
			List<List<Bone>> list = this.boneCache;
			List<IkConstraint> list2 = this.ikConstraints;
			int count = list2.Count;
			int num = count + 1;
			if (list.Count > num)
			{
				list.RemoveRange(num, list.Count - num);
			}
			int i = 0;
			int count2 = list.Count;
			while (i < count2)
			{
				list[i].Clear();
				i++;
			}
			while (list.Count < num)
			{
				list.Add(new List<Bone>());
			}
			List<Bone> list3 = list[0];
			int j = 0;
			int count3 = this.bones.Count;
			while (j < count3)
			{
				Bone bone = this.bones[j];
				Bone bone2 = bone;
				int k;
				for (;;)
				{
					k = 0;
					IL_13A:
					while (k < count)
					{
						IkConstraint ikConstraint = list2[k];
						Bone bone3 = ikConstraint.bones[0];
						Bone bone4 = ikConstraint.bones[ikConstraint.bones.Count - 1];
						while (bone2 != bone4)
						{
							if (bone4 == bone3)
							{
								k++;
								goto IL_13A;
							}
							bone4 = bone4.parent;
						}
						goto Block_4;
					}
					bone2 = bone2.parent;
					if (bone2 == null)
					{
						goto Block_7;
					}
				}
				IL_15B:
				j++;
				continue;
				Block_4:
				list[k].Add(bone);
				list[k + 1].Add(bone);
				goto IL_15B;
				Block_7:
				list3.Add(bone);
				goto IL_15B;
			}
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x000289A0 File Offset: 0x00026BA0
		public void UpdateWorldTransform()
		{
			List<Bone> list = this.bones;
			int i = 0;
			int count = list.Count;
			while (i < count)
			{
				Bone bone = list[i];
				bone.rotationIK = bone.rotation;
				i++;
			}
			List<List<Bone>> list2 = this.boneCache;
			List<IkConstraint> list3 = this.ikConstraints;
			int num = 0;
			int num2 = list2.Count - 1;
			for (;;)
			{
				List<Bone> list4 = list2[num];
				int j = 0;
				int count2 = list4.Count;
				while (j < count2)
				{
					list4[j].UpdateWorldTransform();
					j++;
				}
				if (num == num2)
				{
					break;
				}
				list3[num].apply();
				num++;
			}
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x00028A60 File Offset: 0x00026C60
		public void SetToSetupPose()
		{
			this.SetBonesToSetupPose();
			this.SetSlotsToSetupPose();
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x00028A70 File Offset: 0x00026C70
		public void SetBonesToSetupPose()
		{
			List<Bone> list = this.bones;
			int i = 0;
			int count = list.Count;
			while (i < count)
			{
				list[i].SetToSetupPose();
				i++;
			}
			List<IkConstraint> list2 = this.ikConstraints;
			int j = 0;
			int count2 = list2.Count;
			while (j < count2)
			{
				IkConstraint ikConstraint = list2[j];
				ikConstraint.bendDirection = ikConstraint.data.bendDirection;
				ikConstraint.mix = ikConstraint.data.mix;
				j++;
			}
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x00028B00 File Offset: 0x00026D00
		public void SetSlotsToSetupPose()
		{
			List<Slot> list = this.slots;
			this.drawOrder.Clear();
			this.drawOrder.AddRange(list);
			int i = 0;
			int count = list.Count;
			while (i < count)
			{
				list[i].SetToSetupPose(i);
				i++;
			}
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x00028B54 File Offset: 0x00026D54
		public Bone FindBone(string boneName)
		{
			if (boneName == null)
			{
				throw new ArgumentNullException("boneName cannot be null.");
			}
			List<Bone> list = this.bones;
			int i = 0;
			int count = list.Count;
			while (i < count)
			{
				Bone bone = list[i];
				if (bone.data.name == boneName)
				{
					return bone;
				}
				i++;
			}
			return null;
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x00028BB4 File Offset: 0x00026DB4
		public int FindBoneIndex(string boneName)
		{
			if (boneName == null)
			{
				throw new ArgumentNullException("boneName cannot be null.");
			}
			List<Bone> list = this.bones;
			int i = 0;
			int count = list.Count;
			while (i < count)
			{
				if (list[i].data.name == boneName)
				{
					return i;
				}
				i++;
			}
			return -1;
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x00028C14 File Offset: 0x00026E14
		public Slot FindSlot(string slotName)
		{
			if (slotName == null)
			{
				throw new ArgumentNullException("slotName cannot be null.");
			}
			List<Slot> list = this.slots;
			int i = 0;
			int count = list.Count;
			while (i < count)
			{
				Slot slot = list[i];
				if (slot.data.name == slotName)
				{
					return slot;
				}
				i++;
			}
			return null;
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x00028C74 File Offset: 0x00026E74
		public int FindSlotIndex(string slotName)
		{
			if (slotName == null)
			{
				throw new ArgumentNullException("slotName cannot be null.");
			}
			List<Slot> list = this.slots;
			int i = 0;
			int count = list.Count;
			while (i < count)
			{
				if (list[i].data.name.Equals(slotName))
				{
					return i;
				}
				i++;
			}
			return -1;
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x00028CD4 File Offset: 0x00026ED4
		public void SetSkin(string skinName)
		{
			Skin skin = this.data.FindSkin(skinName);
			if (skin == null)
			{
				throw new ArgumentException("Skin not found: " + skinName);
			}
			this.SetSkin(skin);
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x00028D0C File Offset: 0x00026F0C
		public void SetSkin(Skin newSkin)
		{
			if (newSkin != null)
			{
				if (this.skin != null)
				{
					newSkin.AttachAll(this, this.skin);
				}
				else
				{
					List<Slot> list = this.slots;
					int i = 0;
					int count = list.Count;
					while (i < count)
					{
						Slot slot = list[i];
						string attachmentName = slot.data.attachmentName;
						if (attachmentName != null)
						{
							Attachment attachment = newSkin.GetAttachment(i, attachmentName);
							if (attachment != null)
							{
								slot.Attachment = attachment;
							}
						}
						i++;
					}
				}
			}
			this.skin = newSkin;
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x00028D9C File Offset: 0x00026F9C
		public Attachment GetAttachment(string slotName, string attachmentName)
		{
			return this.GetAttachment(this.data.FindSlotIndex(slotName), attachmentName);
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x00028DB4 File Offset: 0x00026FB4
		public Attachment GetAttachment(int slotIndex, string attachmentName)
		{
			if (attachmentName == null)
			{
				throw new ArgumentNullException("attachmentName cannot be null.");
			}
			if (this.skin != null)
			{
				Attachment attachment = this.skin.GetAttachment(slotIndex, attachmentName);
				if (attachment != null)
				{
					return attachment;
				}
			}
			if (this.data.defaultSkin != null)
			{
				return this.data.defaultSkin.GetAttachment(slotIndex, attachmentName);
			}
			return null;
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x00028E18 File Offset: 0x00027018
		public void SetAttachment(string slotName, string attachmentName)
		{
			if (slotName == null)
			{
				throw new ArgumentNullException("slotName cannot be null.");
			}
			List<Slot> list = this.slots;
			int i = 0;
			int count = list.Count;
			while (i < count)
			{
				Slot slot = list[i];
				if (slot.data.name == slotName)
				{
					Attachment attachment = null;
					if (attachmentName != null)
					{
						attachment = this.GetAttachment(i, attachmentName);
						if (attachment == null)
						{
							throw new Exception("Attachment not found: " + attachmentName + ", for slot: " + slotName);
						}
					}
					slot.Attachment = attachment;
					return;
				}
				i++;
			}
			throw new Exception("Slot not found: " + slotName);
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x00028EC0 File Offset: 0x000270C0
		public IkConstraint FindIkConstraint(string ikConstraintName)
		{
			if (ikConstraintName == null)
			{
				throw new ArgumentNullException("ikConstraintName cannot be null.");
			}
			List<IkConstraint> list = this.ikConstraints;
			int i = 0;
			int count = list.Count;
			while (i < count)
			{
				IkConstraint ikConstraint = list[i];
				if (ikConstraint.data.name == ikConstraintName)
				{
					return ikConstraint;
				}
				i++;
			}
			return null;
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x00028F20 File Offset: 0x00027120
		public void Update(float delta)
		{
			this.time += delta;
		}

		// Token: 0x040005BB RID: 1467
		internal SkeletonData data;

		// Token: 0x040005BC RID: 1468
		internal List<Bone> bones;

		// Token: 0x040005BD RID: 1469
		internal List<Slot> slots;

		// Token: 0x040005BE RID: 1470
		internal List<Slot> drawOrder;

		// Token: 0x040005BF RID: 1471
		internal List<IkConstraint> ikConstraints;

		// Token: 0x040005C0 RID: 1472
		private List<List<Bone>> boneCache = new List<List<Bone>>();

		// Token: 0x040005C1 RID: 1473
		internal Skin skin;

		// Token: 0x040005C2 RID: 1474
		internal float r = 1f;

		// Token: 0x040005C3 RID: 1475
		internal float g = 1f;

		// Token: 0x040005C4 RID: 1476
		internal float b = 1f;

		// Token: 0x040005C5 RID: 1477
		internal float a = 1f;

		// Token: 0x040005C6 RID: 1478
		internal float time;

		// Token: 0x040005C7 RID: 1479
		internal bool flipX;

		// Token: 0x040005C8 RID: 1480
		internal bool flipY;

		// Token: 0x040005C9 RID: 1481
		internal float x;

		// Token: 0x040005CA RID: 1482
		internal float y;
	}
}
