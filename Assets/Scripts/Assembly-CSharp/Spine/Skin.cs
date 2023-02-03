using System;
using System.Collections.Generic;

namespace Spine
{
	// Token: 0x02000130 RID: 304
	public class Skin
	{
		// Token: 0x0600093C RID: 2364 RVA: 0x0002BD54 File Offset: 0x00029F54
		public Skin(string name)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name cannot be null.");
			}
			this.name = name;
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600093D RID: 2365 RVA: 0x0002BD90 File Offset: 0x00029F90
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x0002BD98 File Offset: 0x00029F98
		public void AddAttachment(int slotIndex, string name, Attachment attachment)
		{
			if (attachment == null)
			{
				throw new ArgumentNullException("attachment cannot be null.");
			}
			this.attachments[new KeyValuePair<int, string>(slotIndex, name)] = attachment;
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x0002BDCC File Offset: 0x00029FCC
		public Attachment GetAttachment(int slotIndex, string name)
		{
			Attachment result;
			this.attachments.TryGetValue(new KeyValuePair<int, string>(slotIndex, name), out result);
			return result;
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x0002BDF0 File Offset: 0x00029FF0
		public void FindNamesForSlot(int slotIndex, List<string> names)
		{
			if (names == null)
			{
				throw new ArgumentNullException("names cannot be null.");
			}
			foreach (KeyValuePair<int, string> keyValuePair in this.attachments.Keys)
			{
				if (keyValuePair.Key == slotIndex)
				{
					names.Add(keyValuePair.Value);
				}
			}
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x0002BE80 File Offset: 0x0002A080
		public void FindAttachmentsForSlot(int slotIndex, List<Attachment> attachments)
		{
			if (attachments == null)
			{
				throw new ArgumentNullException("attachments cannot be null.");
			}
			foreach (KeyValuePair<KeyValuePair<int, string>, Attachment> keyValuePair in this.attachments)
			{
				if (keyValuePair.Key.Key == slotIndex)
				{
					attachments.Add(keyValuePair.Value);
				}
			}
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x0002BF14 File Offset: 0x0002A114
		public override string ToString()
		{
			return this.name;
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x0002BF1C File Offset: 0x0002A11C
		internal void AttachAll(Skeleton skeleton, Skin oldSkin)
		{
			foreach (KeyValuePair<KeyValuePair<int, string>, Attachment> keyValuePair in oldSkin.attachments)
			{
				int key = keyValuePair.Key.Key;
				Slot slot = skeleton.slots[key];
				if (slot.attachment == keyValuePair.Value)
				{
					Attachment attachment = this.GetAttachment(key, keyValuePair.Key.Value);
					if (attachment != null)
					{
						slot.Attachment = attachment;
					}
				}
			}
		}

		// Token: 0x040005E2 RID: 1506
		internal string name;

		// Token: 0x040005E3 RID: 1507
		private Dictionary<KeyValuePair<int, string>, Attachment> attachments = new Dictionary<KeyValuePair<int, string>, Attachment>(Skin.AttachmentComparer.Instance);

		// Token: 0x02000131 RID: 305
		private class AttachmentComparer : IEqualityComparer<KeyValuePair<int, string>>
		{
			// Token: 0x06000946 RID: 2374 RVA: 0x0002BFE8 File Offset: 0x0002A1E8
			bool IEqualityComparer<KeyValuePair<int, string>>.Equals(KeyValuePair<int, string> o1, KeyValuePair<int, string> o2)
			{
				return o1.Key == o2.Key && o1.Value == o2.Value;
			}

			// Token: 0x06000947 RID: 2375 RVA: 0x0002C020 File Offset: 0x0002A220
			int IEqualityComparer<KeyValuePair<int, string>>.GetHashCode(KeyValuePair<int, string> o)
			{
				return o.Key;
			}

			// Token: 0x040005E4 RID: 1508
			internal static readonly Skin.AttachmentComparer Instance = new Skin.AttachmentComparer();
		}
	}
}
