using System;

namespace Spine
{
	// Token: 0x0200011A RID: 282
	public abstract class Attachment
	{
		// Token: 0x0600079E RID: 1950 RVA: 0x00025E10 File Offset: 0x00024010
		public Attachment(string name)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name cannot be null.");
			}
			this.Name = name;
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600079F RID: 1951 RVA: 0x00025E30 File Offset: 0x00024030
		// (set) Token: 0x060007A0 RID: 1952 RVA: 0x00025E38 File Offset: 0x00024038
		public string Name { get; private set; }

		// Token: 0x060007A1 RID: 1953 RVA: 0x00025E44 File Offset: 0x00024044
		public override string ToString()
		{
			return this.Name;
		}
	}
}
