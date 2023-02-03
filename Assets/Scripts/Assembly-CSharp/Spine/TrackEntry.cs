using System;

namespace Spine
{
	// Token: 0x02000110 RID: 272
	public class TrackEntry
	{
		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000769 RID: 1897 RVA: 0x00025184 File Offset: 0x00023384
		// (remove) Token: 0x0600076A RID: 1898 RVA: 0x000251A0 File Offset: 0x000233A0
		public event AnimationState.StartEndDelegate Start;

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x0600076B RID: 1899 RVA: 0x000251BC File Offset: 0x000233BC
		// (remove) Token: 0x0600076C RID: 1900 RVA: 0x000251D8 File Offset: 0x000233D8
		public event AnimationState.StartEndDelegate End;

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x0600076D RID: 1901 RVA: 0x000251F4 File Offset: 0x000233F4
		// (remove) Token: 0x0600076E RID: 1902 RVA: 0x00025210 File Offset: 0x00023410
		public event AnimationState.EventDelegate Event;

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x0600076F RID: 1903 RVA: 0x0002522C File Offset: 0x0002342C
		// (remove) Token: 0x06000770 RID: 1904 RVA: 0x00025248 File Offset: 0x00023448
		public event AnimationState.CompleteDelegate Complete;

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000771 RID: 1905 RVA: 0x00025264 File Offset: 0x00023464
		public Animation Animation
		{
			get
			{
				return this.animation;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000772 RID: 1906 RVA: 0x0002526C File Offset: 0x0002346C
		// (set) Token: 0x06000773 RID: 1907 RVA: 0x00025274 File Offset: 0x00023474
		public float Delay
		{
			get
			{
				return this.delay;
			}
			set
			{
				this.delay = value;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000774 RID: 1908 RVA: 0x00025280 File Offset: 0x00023480
		// (set) Token: 0x06000775 RID: 1909 RVA: 0x00025288 File Offset: 0x00023488
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

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000776 RID: 1910 RVA: 0x00025294 File Offset: 0x00023494
		// (set) Token: 0x06000777 RID: 1911 RVA: 0x0002529C File Offset: 0x0002349C
		public float LastTime
		{
			get
			{
				return this.lastTime;
			}
			set
			{
				this.lastTime = value;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000778 RID: 1912 RVA: 0x000252A8 File Offset: 0x000234A8
		// (set) Token: 0x06000779 RID: 1913 RVA: 0x000252B0 File Offset: 0x000234B0
		public float EndTime
		{
			get
			{
				return this.endTime;
			}
			set
			{
				this.endTime = value;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600077A RID: 1914 RVA: 0x000252BC File Offset: 0x000234BC
		// (set) Token: 0x0600077B RID: 1915 RVA: 0x000252C4 File Offset: 0x000234C4
		public float TimeScale
		{
			get
			{
				return this.timeScale;
			}
			set
			{
				this.timeScale = value;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600077C RID: 1916 RVA: 0x000252D0 File Offset: 0x000234D0
		// (set) Token: 0x0600077D RID: 1917 RVA: 0x000252D8 File Offset: 0x000234D8
		public float Mix
		{
			get
			{
				return this.mix;
			}
			set
			{
				this.mix = value;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600077E RID: 1918 RVA: 0x000252E4 File Offset: 0x000234E4
		// (set) Token: 0x0600077F RID: 1919 RVA: 0x000252EC File Offset: 0x000234EC
		public bool Loop
		{
			get
			{
				return this.loop;
			}
			set
			{
				this.loop = value;
			}
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x000252F8 File Offset: 0x000234F8
		internal void OnStart(AnimationState state, int index)
		{
			if (this.Start != null)
			{
				this.Start(state, index);
			}
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x00025314 File Offset: 0x00023514
		internal void OnEnd(AnimationState state, int index)
		{
			if (this.End != null)
			{
				this.End(state, index);
			}
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x00025330 File Offset: 0x00023530
		internal void OnEvent(AnimationState state, int index, Event e)
		{
			if (this.Event != null)
			{
				this.Event(state, index, e);
			}
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x0002534C File Offset: 0x0002354C
		internal void OnComplete(AnimationState state, int index, int loopCount)
		{
			if (this.Complete != null)
			{
				this.Complete(state, index, loopCount);
			}
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x00025368 File Offset: 0x00023568
		public override string ToString()
		{
			return (this.animation != null) ? this.animation.name : "<none>";
		}

		// Token: 0x040004D5 RID: 1237
		internal TrackEntry next;

		// Token: 0x040004D6 RID: 1238
		internal TrackEntry previous;

		// Token: 0x040004D7 RID: 1239
		internal Animation animation;

		// Token: 0x040004D8 RID: 1240
		internal bool loop;

		// Token: 0x040004D9 RID: 1241
		internal float delay;

		// Token: 0x040004DA RID: 1242
		internal float time;

		// Token: 0x040004DB RID: 1243
		internal float lastTime = -1f;

		// Token: 0x040004DC RID: 1244
		internal float endTime;

		// Token: 0x040004DD RID: 1245
		internal float timeScale = 1f;

		// Token: 0x040004DE RID: 1246
		internal float mixTime;

		// Token: 0x040004DF RID: 1247
		internal float mixDuration;

		// Token: 0x040004E0 RID: 1248
		internal float mix = 1f;
	}
}
