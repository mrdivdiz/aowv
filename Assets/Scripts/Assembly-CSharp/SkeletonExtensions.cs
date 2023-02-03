using System;
using Spine;
using UnityEngine;

// Token: 0x02000139 RID: 313
public static class SkeletonExtensions
{
	// Token: 0x06000988 RID: 2440 RVA: 0x0002CD48 File Offset: 0x0002AF48
	public static void SetColor(this Slot slot, Color color)
	{
		slot.A = color.a;
		slot.R = color.r;
		slot.G = color.g;
		slot.B = color.b;
	}

	// Token: 0x06000989 RID: 2441 RVA: 0x0002CD8C File Offset: 0x0002AF8C
	public static void SetColor(this Slot slot, Color32 color)
	{
		slot.A = (float)color.a / 255f;
		slot.R = (float)color.r / 255f;
		slot.G = (float)color.g / 255f;
		slot.B = (float)color.b / 255f;
	}

	// Token: 0x0600098A RID: 2442 RVA: 0x0002CDEC File Offset: 0x0002AFEC
	public static void SetColor(this RegionAttachment attachment, Color color)
	{
		attachment.A = color.a;
		attachment.R = color.r;
		attachment.G = color.g;
		attachment.B = color.b;
	}

	// Token: 0x0600098B RID: 2443 RVA: 0x0002CE30 File Offset: 0x0002B030
	public static void SetColor(this RegionAttachment attachment, Color32 color)
	{
		attachment.A = (float)color.a / 255f;
		attachment.R = (float)color.r / 255f;
		attachment.G = (float)color.g / 255f;
		attachment.B = (float)color.b / 255f;
	}

	// Token: 0x0600098C RID: 2444 RVA: 0x0002CE90 File Offset: 0x0002B090
	public static void SetColor(this MeshAttachment attachment, Color color)
	{
		attachment.A = color.a;
		attachment.R = color.r;
		attachment.G = color.g;
		attachment.B = color.b;
	}

	// Token: 0x0600098D RID: 2445 RVA: 0x0002CED4 File Offset: 0x0002B0D4
	public static void SetColor(this MeshAttachment attachment, Color32 color)
	{
		attachment.A = (float)color.a / 255f;
		attachment.R = (float)color.r / 255f;
		attachment.G = (float)color.g / 255f;
		attachment.B = (float)color.b / 255f;
	}

	// Token: 0x0600098E RID: 2446 RVA: 0x0002CF34 File Offset: 0x0002B134
	public static void SetColor(this SkinnedMeshAttachment attachment, Color color)
	{
		attachment.A = color.a;
		attachment.R = color.r;
		attachment.G = color.g;
		attachment.B = color.b;
	}

	// Token: 0x0600098F RID: 2447 RVA: 0x0002CF78 File Offset: 0x0002B178
	public static void SetColor(this SkinnedMeshAttachment attachment, Color32 color)
	{
		attachment.A = (float)color.a / 255f;
		attachment.R = (float)color.r / 255f;
		attachment.G = (float)color.g / 255f;
		attachment.B = (float)color.b / 255f;
	}

	// Token: 0x06000990 RID: 2448 RVA: 0x0002CFD8 File Offset: 0x0002B1D8
	public static void SetPosition(this Bone bone, Vector2 position)
	{
		bone.X = position.x;
		bone.Y = position.y;
	}

	// Token: 0x06000991 RID: 2449 RVA: 0x0002CFF4 File Offset: 0x0002B1F4
	public static void SetPosition(this Bone bone, Vector3 position)
	{
		bone.X = position.x;
		bone.Y = position.y;
	}
}
