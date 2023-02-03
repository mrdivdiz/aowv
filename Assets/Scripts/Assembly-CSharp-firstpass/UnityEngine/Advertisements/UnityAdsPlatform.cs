using System;

namespace UnityEngine.Advertisements
{
	// Token: 0x0200003A RID: 58
	internal abstract class UnityAdsPlatform
	{
		// Token: 0x06000262 RID: 610
		public abstract void init(string gameId, bool testModeEnabled, string gameObjectName, string unityVersion);

		// Token: 0x06000263 RID: 611
		public abstract bool show(string zoneId, string rewardItemKey, string options);

		// Token: 0x06000264 RID: 612
		public abstract void hide();

		// Token: 0x06000265 RID: 613
		public abstract bool isSupported();

		// Token: 0x06000266 RID: 614
		public abstract string getSDKVersion();

		// Token: 0x06000267 RID: 615
		public abstract bool canShowZone(string zone);

		// Token: 0x06000268 RID: 616
		public abstract bool hasMultipleRewardItems();

		// Token: 0x06000269 RID: 617
		public abstract string getRewardItemKeys();

		// Token: 0x0600026A RID: 618
		public abstract string getDefaultRewardItemKey();

		// Token: 0x0600026B RID: 619
		public abstract string getCurrentRewardItemKey();

		// Token: 0x0600026C RID: 620
		public abstract bool setRewardItemKey(string rewardItemKey);

		// Token: 0x0600026D RID: 621
		public abstract void setDefaultRewardItemAsRewardItem();

		// Token: 0x0600026E RID: 622
		public abstract string getRewardItemDetailsWithKey(string rewardItemKey);

		// Token: 0x0600026F RID: 623
		public abstract string getRewardItemDetailsKeys();

		// Token: 0x06000270 RID: 624
		public abstract void setLogLevel(Advertisement.DebugLevel logLevel);
	}
}
