using System;
using Spine;
using UnityEngine;

// Token: 0x02000137 RID: 311
[AddComponentMenu("Spine/SkeletonAnimation")]
[ExecuteInEditMode]
public class SkeletonAnimation : SkeletonRenderer
{
	// Token: 0x17000153 RID: 339
	// (get) Token: 0x0600097F RID: 2431 RVA: 0x0002C960 File Offset: 0x0002AB60
	// (set) Token: 0x06000980 RID: 2432 RVA: 0x0002C994 File Offset: 0x0002AB94
	public string AnimationName
	{
		get
		{
			TrackEntry current = this.state.GetCurrent(0);
			return (current != null) ? current.Animation.Name : null;
		}
		set
		{
			if (this._animationName == value)
			{
				return;
			}
			this._animationName = value;
			if (value == null || value.Length == 0)
			{
				this.state.ClearTrack(0);
			}
			else
			{
				this.state.SetAnimation(0, value, this.loop);
			}
		}
	}

	// Token: 0x06000981 RID: 2433 RVA: 0x0002C9F0 File Offset: 0x0002ABF0
	public override void Reset()
	{
		base.Reset();
		if (!this.valid)
		{
			return;
		}
		this.state = new Spine.AnimationState(this.skeletonDataAsset.GetAnimationStateData());
		if (this._animationName != null && this._animationName.Length > 0)
		{
			this.state.SetAnimation(0, this._animationName, this.loop);
			this.Update(0f);
		}
	}

	// Token: 0x06000982 RID: 2434 RVA: 0x0002CA68 File Offset: 0x0002AC68
	public virtual void Update()
	{
	}

	// Token: 0x06000983 RID: 2435 RVA: 0x0002CA6C File Offset: 0x0002AC6C
	public virtual void Update(float deltaTime)
	{
		if (!this.valid)
		{
			return;
		}
		deltaTime *= this.timeScale;
		this.skeleton.Update(deltaTime);
		this.state.Update(deltaTime);
		this.state.Apply(this.skeleton);
		if (this.UpdateLocal != null)
		{
			this.UpdateLocal(this);
		}
		this.skeleton.UpdateWorldTransform();
		if (this.UpdateWorld != null)
		{
			this.UpdateWorld(this);
			this.skeleton.UpdateWorldTransform();
		}
		if (this.UpdateComplete != null)
		{
			this.UpdateComplete(this);
		}
	}

	// Token: 0x04000604 RID: 1540
	public float timeScale = 1f;

	// Token: 0x04000605 RID: 1541
	public bool loop;

	// Token: 0x04000606 RID: 1542
	public Spine.AnimationState state;

	// Token: 0x04000607 RID: 1543
	public SkeletonAnimation.UpdateBonesDelegate UpdateLocal;

	// Token: 0x04000608 RID: 1544
	public SkeletonAnimation.UpdateBonesDelegate UpdateWorld;

	// Token: 0x04000609 RID: 1545
	public SkeletonAnimation.UpdateBonesDelegate UpdateComplete;

	// Token: 0x0400060A RID: 1546
	[SerializeField]
	private string _animationName;

	// Token: 0x02000180 RID: 384
	// (Invoke) Token: 0x06000AC2 RID: 2754
	public delegate void UpdateBonesDelegate(SkeletonAnimation skeleton);
}
