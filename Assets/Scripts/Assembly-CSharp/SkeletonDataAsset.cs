using System;
using System.IO;
using Spine;
using UnityEngine;

// Token: 0x02000138 RID: 312
public class SkeletonDataAsset : ScriptableObject
{
	// Token: 0x06000985 RID: 2437 RVA: 0x0002CB28 File Offset: 0x0002AD28
	public void Reset()
	{
		this.skeletonData = null;
		this.stateData = null;
	}

	// Token: 0x06000986 RID: 2438 RVA: 0x0002CB38 File Offset: 0x0002AD38
	public SkeletonData GetSkeletonData(bool quiet)
	{
		if (this.atlasAsset == null)
		{
			if (!quiet)
			{
				Debug.LogError("Atlas not set for SkeletonData asset: " + base.name, this);
			}
			this.Reset();
			return null;
		}
		if (this.skeletonJSON == null)
		{
			if (!quiet)
			{
				Debug.LogError("Skeleton JSON file not set for SkeletonData asset: " + base.name, this);
			}
			this.Reset();
			return null;
		}
		Atlas atlas = this.atlasAsset.GetAtlas();
		if (atlas == null)
		{
			this.Reset();
			return null;
		}
		if (this.skeletonData != null)
		{
			return this.skeletonData;
		}
		SkeletonJson skeletonJson = new SkeletonJson(atlas);
		skeletonJson.Scale = this.scale;
		try
		{
			this.skeletonData = skeletonJson.ReadSkeletonData(new StringReader(this.skeletonJSON.text));
		}
		catch (Exception ex)
		{
			if (!quiet)
			{
				Debug.LogError(string.Concat(new string[]
				{
					"Error reading skeleton JSON file for SkeletonData asset: ",
					base.name,
					"\n",
					ex.Message,
					"\n",
					ex.StackTrace
				}), this);
			}
			return null;
		}
		this.stateData = new AnimationStateData(this.skeletonData);
		this.stateData.DefaultMix = this.defaultMix;
		int i = 0;
		int num = this.fromAnimation.Length;
		while (i < num)
		{
			if (this.fromAnimation[i].Length != 0 && this.toAnimation[i].Length != 0)
			{
				this.stateData.SetMix(this.fromAnimation[i], this.toAnimation[i], this.duration[i]);
			}
			i++;
		}
		return this.skeletonData;
	}

	// Token: 0x06000987 RID: 2439 RVA: 0x0002CD18 File Offset: 0x0002AF18
	public AnimationStateData GetAnimationStateData()
	{
		if (this.stateData != null)
		{
			return this.stateData;
		}
		this.GetSkeletonData(false);
		return this.stateData;
	}

	// Token: 0x0400060B RID: 1547
	public AtlasAsset atlasAsset;

	// Token: 0x0400060C RID: 1548
	public TextAsset skeletonJSON;

	// Token: 0x0400060D RID: 1549
	public float scale = 1f;

	// Token: 0x0400060E RID: 1550
	public string[] fromAnimation;

	// Token: 0x0400060F RID: 1551
	public string[] toAnimation;

	// Token: 0x04000610 RID: 1552
	public float[] duration;

	// Token: 0x04000611 RID: 1553
	public float defaultMix;

	// Token: 0x04000612 RID: 1554
	private SkeletonData skeletonData;

	// Token: 0x04000613 RID: 1555
	private AnimationStateData stateData;
}
