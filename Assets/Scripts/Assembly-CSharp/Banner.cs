using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000003 RID: 3
public class Banner : MonoBehaviour
{
	// Token: 0x06000007 RID: 7 RVA: 0x000021B4 File Offset: 0x000003B4
	public void FollowLink()
	{
		if (this.link != string.Empty)
		{
			Application.OpenURL(this.link);
		}
	}

	// Token: 0x06000008 RID: 8 RVA: 0x000021E4 File Offset: 0x000003E4
	private void Start()
	{
		this.canvas.enabled = false;
		base.StartCoroutine(this.GetBannerInfo());
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002200 File Offset: 0x00000400
	private IEnumerator GetBannerInfo()
	{
		Debug.Log("Request the banner");
		WWW www = new WWW("http://www.maxgames.com/banner.php");
		yield return www;
		Debug.Log(www.text);
		if (www.error == null && www.text != string.Empty)
		{
			JSONObject data = new JSONObject(www.text, -2, false, false);
			string platform = "android";
			if (data.HasField(platform) && data.GetField(platform).HasFields(new string[]
			{
				"text",
				"link",
				"img"
			}))
			{
				string textToShow = data.GetField(platform).GetField("text").str;
				string link = data.GetField(platform).GetField("link").str;
				string imgLink = data.GetField(platform).GetField("img").str;
				this.text.text = textToShow;
				this.link = link;
				this.imgURL = imgLink;
				if (this.imgURL != string.Empty)
				{
					base.StartCoroutine(this.LoadImage());
				}
				Debug.Log(string.Concat(new object[]
				{
					this.text,
					" ",
					link,
					" ",
					imgLink
				}));
			}
		}
		yield break;
	}

	// Token: 0x0600000A RID: 10 RVA: 0x0000221C File Offset: 0x0000041C
	public void Update()
	{
		this.canvas.gameObject.SetActive(MainMenu.instance.menu == MainMenu.M_MAIN);
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002240 File Offset: 0x00000440
	private IEnumerator LoadImage()
	{
		WWW www = new WWW(this.imgURL);
		yield return www;
		Rect rect = new Rect(0f, 0f, (float)www.texture.width, (float)www.texture.height);
		this.image.sprite = Sprite.Create(www.texture, rect, this.image.sprite.pivot);
		this.canvas.enabled = true;
		yield break;
	}

	// Token: 0x04000006 RID: 6
	public Canvas canvas;

	// Token: 0x04000007 RID: 7
	public Image image;

	// Token: 0x04000008 RID: 8
	public Text text;

	// Token: 0x04000009 RID: 9
	public string link;

	// Token: 0x0400000A RID: 10
	public string imgURL;
}
