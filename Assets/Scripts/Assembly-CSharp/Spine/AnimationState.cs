using System;
using System.Collections.Generic;
using System.Text;

namespace Spine
{
	// Token: 0x0200010F RID: 271
	public class AnimationState
	{
		// Token: 0x06000750 RID: 1872 RVA: 0x000248F0 File Offset: 0x00022AF0
		public AnimationState(AnimationStateData data)
		{
			if (data == null)
			{
				throw new ArgumentNullException("data cannot be null.");
			}
			this.data = data;
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000751 RID: 1873 RVA: 0x0002493C File Offset: 0x00022B3C
		// (remove) Token: 0x06000752 RID: 1874 RVA: 0x00024958 File Offset: 0x00022B58
		public event AnimationState.StartEndDelegate Start;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000753 RID: 1875 RVA: 0x00024974 File Offset: 0x00022B74
		// (remove) Token: 0x06000754 RID: 1876 RVA: 0x00024990 File Offset: 0x00022B90
		public event AnimationState.StartEndDelegate End;

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000755 RID: 1877 RVA: 0x000249AC File Offset: 0x00022BAC
		// (remove) Token: 0x06000756 RID: 1878 RVA: 0x000249C8 File Offset: 0x00022BC8
		public event AnimationState.EventDelegate Event;

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000757 RID: 1879 RVA: 0x000249E4 File Offset: 0x00022BE4
		// (remove) Token: 0x06000758 RID: 1880 RVA: 0x00024A00 File Offset: 0x00022C00
		public event AnimationState.CompleteDelegate Complete;

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000759 RID: 1881 RVA: 0x00024A1C File Offset: 0x00022C1C
		public AnimationStateData Data
		{
			get
			{
				return this.data;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600075A RID: 1882 RVA: 0x00024A24 File Offset: 0x00022C24
		// (set) Token: 0x0600075B RID: 1883 RVA: 0x00024A2C File Offset: 0x00022C2C
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

		// Token: 0x0600075C RID: 1884 RVA: 0x00024A38 File Offset: 0x00022C38
		public void Update(float delta)
		{
			delta *= this.timeScale;
			for (int i = 0; i < this.tracks.Count; i++)
			{
				TrackEntry trackEntry = this.tracks[i];
				if (trackEntry != null)
				{
					float num = delta * trackEntry.timeScale;
					float num2 = trackEntry.time + num;
					float endTime = trackEntry.endTime;
					trackEntry.time = num2;
					if (trackEntry.previous != null)
					{
						trackEntry.previous.time += num;
						trackEntry.mixTime += num;
					}
					if ((!trackEntry.loop) ? (trackEntry.lastTime < endTime && num2 >= endTime) : (trackEntry.lastTime % endTime > num2 % endTime))
					{
						int loopCount = (int)(num2 / endTime);
						trackEntry.OnComplete(this, i, loopCount);
						if (this.Complete != null)
						{
							this.Complete(this, i, loopCount);
						}
					}
					TrackEntry next = trackEntry.next;
					if (next != null)
					{
						next.time = trackEntry.lastTime - next.delay;
						if (next.time >= 0f)
						{
							this.SetCurrent(i, next);
						}
					}
					else if (!trackEntry.loop && trackEntry.lastTime >= trackEntry.endTime)
					{
						this.ClearTrack(i);
					}
				}
			}
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x00024BA0 File Offset: 0x00022DA0
		public void Apply(Skeleton skeleton)
		{
			List<Event> list = this.events;
			for (int i = 0; i < this.tracks.Count; i++)
			{
				TrackEntry trackEntry = this.tracks[i];
				if (trackEntry != null)
				{
					list.Clear();
					float num = trackEntry.time;
					bool loop = trackEntry.loop;
					if (!loop && num > trackEntry.endTime)
					{
						num = trackEntry.endTime;
					}
					TrackEntry previous = trackEntry.previous;
					if (previous == null)
					{
						if (trackEntry.mix == 1f)
						{
							trackEntry.animation.Apply(skeleton, trackEntry.lastTime, num, loop, list);
						}
						else
						{
							trackEntry.animation.Mix(skeleton, trackEntry.lastTime, num, loop, list, trackEntry.mix);
						}
					}
					else
					{
						float num2 = previous.time;
						if (!previous.loop && num2 > previous.endTime)
						{
							num2 = previous.endTime;
						}
						previous.animation.Apply(skeleton, num2, num2, previous.loop, null);
						float num3 = trackEntry.mixTime / trackEntry.mixDuration * trackEntry.mix;
						if (num3 >= 1f)
						{
							num3 = 1f;
							trackEntry.previous = null;
						}
						trackEntry.animation.Mix(skeleton, trackEntry.lastTime, num, loop, list, num3);
					}
					int j = 0;
					int count = list.Count;
					while (j < count)
					{
						Event e = list[j];
						trackEntry.OnEvent(this, i, e);
						if (this.Event != null)
						{
							this.Event(this, i, e);
						}
						j++;
					}
					trackEntry.lastTime = trackEntry.time;
				}
			}
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x00024D58 File Offset: 0x00022F58
		public void ClearTracks()
		{
			int i = 0;
			int count = this.tracks.Count;
			while (i < count)
			{
				this.ClearTrack(i);
				i++;
			}
			this.tracks.Clear();
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00024D98 File Offset: 0x00022F98
		public void ClearTrack(int trackIndex)
		{
			if (trackIndex >= this.tracks.Count)
			{
				return;
			}
			TrackEntry trackEntry = this.tracks[trackIndex];
			if (trackEntry == null)
			{
				return;
			}
			trackEntry.OnEnd(this, trackIndex);
			if (this.End != null)
			{
				this.End(this, trackIndex);
			}
			this.tracks[trackIndex] = null;
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x00024DF8 File Offset: 0x00022FF8
		private TrackEntry ExpandToIndex(int index)
		{
			if (index < this.tracks.Count)
			{
				return this.tracks[index];
			}
			while (index >= this.tracks.Count)
			{
				this.tracks.Add(null);
			}
			return null;
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x00024E48 File Offset: 0x00023048
		private void SetCurrent(int index, TrackEntry entry)
		{
			TrackEntry trackEntry = this.ExpandToIndex(index);
			if (trackEntry != null)
			{
				TrackEntry previous = trackEntry.previous;
				trackEntry.previous = null;
				trackEntry.OnEnd(this, index);
				if (this.End != null)
				{
					this.End(this, index);
				}
				entry.mixDuration = this.data.GetMix(trackEntry.animation, entry.animation);
				if (entry.mixDuration > 0f)
				{
					entry.mixTime = 0f;
					if (previous != null && trackEntry.mixTime / trackEntry.mixDuration < 0.5f)
					{
						entry.previous = previous;
					}
					else
					{
						entry.previous = trackEntry;
					}
				}
			}
			this.tracks[index] = entry;
			entry.OnStart(this, index);
			if (this.Start != null)
			{
				this.Start(this, index);
			}
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x00024F28 File Offset: 0x00023128
		public TrackEntry SetAnimation(int trackIndex, string animationName, bool loop)
		{
			Animation animation = this.data.skeletonData.FindAnimation(animationName);
			if (animation == null)
			{
				throw new ArgumentException("Animation not found: " + animationName);
			}
			return this.SetAnimation(trackIndex, animation, loop);
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x00024F68 File Offset: 0x00023168
		public TrackEntry SetAnimation(int trackIndex, Animation animation, bool loop)
		{
			TrackEntry trackEntry = new TrackEntry();
			trackEntry.animation = animation;
			trackEntry.loop = loop;
			trackEntry.time = 0f;
			trackEntry.endTime = animation.Duration;
			this.SetCurrent(trackIndex, trackEntry);
			return trackEntry;
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x00024FAC File Offset: 0x000231AC
		public TrackEntry AddAnimation(int trackIndex, string animationName, bool loop, float delay)
		{
			Animation animation = this.data.skeletonData.FindAnimation(animationName);
			if (animation == null)
			{
				throw new ArgumentException("Animation not found: " + animationName);
			}
			return this.AddAnimation(trackIndex, animation, loop, delay);
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x00024FF0 File Offset: 0x000231F0
		public TrackEntry AddAnimation(int trackIndex, Animation animation, bool loop, float delay)
		{
			TrackEntry trackEntry = new TrackEntry();
			trackEntry.animation = animation;
			trackEntry.loop = loop;
			trackEntry.time = 0f;
			trackEntry.endTime = animation.Duration;
			TrackEntry trackEntry2 = this.ExpandToIndex(trackIndex);
			if (trackEntry2 != null)
			{
				while (trackEntry2.next != null)
				{
					trackEntry2 = trackEntry2.next;
				}
				trackEntry2.next = trackEntry;
			}
			else
			{
				this.tracks[trackIndex] = trackEntry;
			}
			if (delay <= 0f)
			{
				if (trackEntry2 != null)
				{
					delay += trackEntry2.endTime - this.data.GetMix(trackEntry2.animation, animation);
				}
				else
				{
					delay = 0f;
				}
			}
			trackEntry.delay = delay;
			return trackEntry;
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x000250AC File Offset: 0x000232AC
		public TrackEntry GetCurrent(int trackIndex)
		{
			if (trackIndex >= this.tracks.Count)
			{
				return null;
			}
			return this.tracks[trackIndex];
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x000250D0 File Offset: 0x000232D0
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			int i = 0;
			int count = this.tracks.Count;
			while (i < count)
			{
				TrackEntry trackEntry = this.tracks[i];
				if (trackEntry != null)
				{
					if (stringBuilder.Length > 0)
					{
						stringBuilder.Append(", ");
					}
					stringBuilder.Append(trackEntry.ToString());
				}
				i++;
			}
			if (stringBuilder.Length == 0)
			{
				return "<none>";
			}
			return stringBuilder.ToString();
		}

		// Token: 0x040004CD RID: 1229
		private AnimationStateData data;

		// Token: 0x040004CE RID: 1230
		private List<TrackEntry> tracks = new List<TrackEntry>();

		// Token: 0x040004CF RID: 1231
		private List<Event> events = new List<Event>();

		// Token: 0x040004D0 RID: 1232
		private float timeScale = 1f;

		// Token: 0x0200017C RID: 380
		// (Invoke) Token: 0x06000AB2 RID: 2738
		public delegate void StartEndDelegate(AnimationState state, int trackIndex);

		// Token: 0x0200017D RID: 381
		// (Invoke) Token: 0x06000AB6 RID: 2742
		public delegate void EventDelegate(AnimationState state, int trackIndex, Event e);

		// Token: 0x0200017E RID: 382
		// (Invoke) Token: 0x06000ABA RID: 2746
		public delegate void CompleteDelegate(AnimationState state, int trackIndex, int loopCount);
	}
}
