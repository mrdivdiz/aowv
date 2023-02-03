using System;
using System.Collections.Generic;

namespace Spine
{
	// Token: 0x0200012C RID: 300
	public class SkeletonBounds
	{
		// Token: 0x060008EE RID: 2286 RVA: 0x00028F30 File Offset: 0x00027130
		public SkeletonBounds()
		{
			this.BoundingBoxes = new List<BoundingBoxAttachment>();
			this.Polygons = new List<Polygon>();
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060008EF RID: 2287 RVA: 0x00028F5C File Offset: 0x0002715C
		// (set) Token: 0x060008F0 RID: 2288 RVA: 0x00028F64 File Offset: 0x00027164
		public List<BoundingBoxAttachment> BoundingBoxes { get; private set; }

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060008F1 RID: 2289 RVA: 0x00028F70 File Offset: 0x00027170
		// (set) Token: 0x060008F2 RID: 2290 RVA: 0x00028F78 File Offset: 0x00027178
		public List<Polygon> Polygons { get; private set; }

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060008F3 RID: 2291 RVA: 0x00028F84 File Offset: 0x00027184
		// (set) Token: 0x060008F4 RID: 2292 RVA: 0x00028F8C File Offset: 0x0002718C
		public float MinX
		{
			get
			{
				return this.minX;
			}
			set
			{
				this.minX = value;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060008F5 RID: 2293 RVA: 0x00028F98 File Offset: 0x00027198
		// (set) Token: 0x060008F6 RID: 2294 RVA: 0x00028FA0 File Offset: 0x000271A0
		public float MinY
		{
			get
			{
				return this.minY;
			}
			set
			{
				this.minY = value;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060008F7 RID: 2295 RVA: 0x00028FAC File Offset: 0x000271AC
		// (set) Token: 0x060008F8 RID: 2296 RVA: 0x00028FB4 File Offset: 0x000271B4
		public float MaxX
		{
			get
			{
				return this.maxX;
			}
			set
			{
				this.maxX = value;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060008F9 RID: 2297 RVA: 0x00028FC0 File Offset: 0x000271C0
		// (set) Token: 0x060008FA RID: 2298 RVA: 0x00028FC8 File Offset: 0x000271C8
		public float MaxY
		{
			get
			{
				return this.maxY;
			}
			set
			{
				this.maxY = value;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060008FB RID: 2299 RVA: 0x00028FD4 File Offset: 0x000271D4
		public float Width
		{
			get
			{
				return this.maxX - this.minX;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060008FC RID: 2300 RVA: 0x00028FE4 File Offset: 0x000271E4
		public float Height
		{
			get
			{
				return this.maxY - this.minY;
			}
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x00028FF4 File Offset: 0x000271F4
		public void Update(Skeleton skeleton, bool updateAabb)
		{
			List<BoundingBoxAttachment> boundingBoxes = this.BoundingBoxes;
			List<Polygon> polygons = this.Polygons;
			List<Slot> slots = skeleton.slots;
			int count = slots.Count;
			boundingBoxes.Clear();
			foreach (Polygon item in polygons)
			{
				this.polygonPool.Add(item);
			}
			polygons.Clear();
			for (int i = 0; i < count; i++)
			{
				Slot slot = slots[i];
				BoundingBoxAttachment boundingBoxAttachment = slot.attachment as BoundingBoxAttachment;
				if (boundingBoxAttachment != null)
				{
					boundingBoxes.Add(boundingBoxAttachment);
					int count2 = this.polygonPool.Count;
					Polygon polygon;
					if (count2 > 0)
					{
						polygon = this.polygonPool[count2 - 1];
						this.polygonPool.RemoveAt(count2 - 1);
					}
					else
					{
						polygon = new Polygon();
					}
					polygons.Add(polygon);
					int num = boundingBoxAttachment.Vertices.Length;
					polygon.Count = num;
					if (polygon.Vertices.Length < num)
					{
						polygon.Vertices = new float[num];
					}
					boundingBoxAttachment.ComputeWorldVertices(slot.bone, polygon.Vertices);
				}
			}
			if (updateAabb)
			{
				this.aabbCompute();
			}
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x00029168 File Offset: 0x00027368
		private void aabbCompute()
		{
			float val = 2.1474836E+09f;
			float val2 = 2.1474836E+09f;
			float val3 = -2.1474836E+09f;
			float val4 = -2.1474836E+09f;
			List<Polygon> polygons = this.Polygons;
			int i = 0;
			int count = polygons.Count;
			while (i < count)
			{
				Polygon polygon = polygons[i];
				float[] vertices = polygon.Vertices;
				int j = 0;
				int count2 = polygon.Count;
				while (j < count2)
				{
					float val5 = vertices[j];
					float val6 = vertices[j + 1];
					val = Math.Min(val, val5);
					val2 = Math.Min(val2, val6);
					val3 = Math.Max(val3, val5);
					val4 = Math.Max(val4, val6);
					j += 2;
				}
				i++;
			}
			this.minX = val;
			this.minY = val2;
			this.maxX = val3;
			this.maxY = val4;
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x0002923C File Offset: 0x0002743C
		public bool AabbContainsPoint(float x, float y)
		{
			return x >= this.minX && x <= this.maxX && y >= this.minY && y <= this.maxY;
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x00029274 File Offset: 0x00027474
		public bool AabbIntersectsSegment(float x1, float y1, float x2, float y2)
		{
			float num = this.minX;
			float num2 = this.minY;
			float num3 = this.maxX;
			float num4 = this.maxY;
			if ((x1 <= num && x2 <= num) || (y1 <= num2 && y2 <= num2) || (x1 >= num3 && x2 >= num3) || (y1 >= num4 && y2 >= num4))
			{
				return false;
			}
			float num5 = (y2 - y1) / (x2 - x1);
			float num6 = num5 * (num - x1) + y1;
			if (num6 > num2 && num6 < num4)
			{
				return true;
			}
			num6 = num5 * (num3 - x1) + y1;
			if (num6 > num2 && num6 < num4)
			{
				return true;
			}
			float num7 = (num2 - y1) / num5 + x1;
			if (num7 > num && num7 < num3)
			{
				return true;
			}
			num7 = (num4 - y1) / num5 + x1;
			return num7 > num && num7 < num3;
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x00029354 File Offset: 0x00027554
		public bool AabbIntersectsSkeleton(SkeletonBounds bounds)
		{
			return this.minX < bounds.maxX && this.maxX > bounds.minX && this.minY < bounds.maxY && this.maxY > bounds.minY;
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x000293A8 File Offset: 0x000275A8
		public bool ContainsPoint(Polygon polygon, float x, float y)
		{
			float[] vertices = polygon.Vertices;
			int count = polygon.Count;
			int num = count - 2;
			bool flag = false;
			for (int i = 0; i < count; i += 2)
			{
				float num2 = vertices[i + 1];
				float num3 = vertices[num + 1];
				if ((num2 < y && num3 >= y) || (num3 < y && num2 >= y))
				{
					float num4 = vertices[i];
					if (num4 + (y - num2) / (num3 - num2) * (vertices[num] - num4) < x)
					{
						flag = !flag;
					}
				}
				num = i;
			}
			return flag;
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x00029438 File Offset: 0x00027638
		public BoundingBoxAttachment ContainsPoint(float x, float y)
		{
			List<Polygon> polygons = this.Polygons;
			int i = 0;
			int count = polygons.Count;
			while (i < count)
			{
				if (this.ContainsPoint(polygons[i], x, y))
				{
					return this.BoundingBoxes[i];
				}
				i++;
			}
			return null;
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x00029488 File Offset: 0x00027688
		public BoundingBoxAttachment IntersectsSegment(float x1, float y1, float x2, float y2)
		{
			List<Polygon> polygons = this.Polygons;
			int i = 0;
			int count = polygons.Count;
			while (i < count)
			{
				if (this.IntersectsSegment(polygons[i], x1, y1, x2, y2))
				{
					return this.BoundingBoxes[i];
				}
				i++;
			}
			return null;
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x000294DC File Offset: 0x000276DC
		public bool IntersectsSegment(Polygon polygon, float x1, float y1, float x2, float y2)
		{
			float[] vertices = polygon.Vertices;
			int count = polygon.Count;
			float num = x1 - x2;
			float num2 = y1 - y2;
			float num3 = x1 * y2 - y1 * x2;
			float num4 = vertices[count - 2];
			float num5 = vertices[count - 1];
			for (int i = 0; i < count; i += 2)
			{
				float num6 = vertices[i];
				float num7 = vertices[i + 1];
				float num8 = num4 * num7 - num5 * num6;
				float num9 = num4 - num6;
				float num10 = num5 - num7;
				float num11 = num * num10 - num2 * num9;
				float num12 = (num3 * num9 - num * num8) / num11;
				if (((num12 >= num4 && num12 <= num6) || (num12 >= num6 && num12 <= num4)) && ((num12 >= x1 && num12 <= x2) || (num12 >= x2 && num12 <= x1)))
				{
					float num13 = (num3 * num10 - num2 * num8) / num11;
					if (((num13 >= num5 && num13 <= num7) || (num13 >= num7 && num13 <= num5)) && ((num13 >= y1 && num13 <= y2) || (num13 >= y2 && num13 <= y1)))
					{
						return true;
					}
				}
				num4 = num6;
				num5 = num7;
			}
			return false;
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x0002961C File Offset: 0x0002781C
		public Polygon getPolygon(BoundingBoxAttachment attachment)
		{
			int num = this.BoundingBoxes.IndexOf(attachment);
			return (num != -1) ? this.Polygons[num] : null;
		}

		// Token: 0x040005CB RID: 1483
		private List<Polygon> polygonPool = new List<Polygon>();

		// Token: 0x040005CC RID: 1484
		private float minX;

		// Token: 0x040005CD RID: 1485
		private float minY;

		// Token: 0x040005CE RID: 1486
		private float maxX;

		// Token: 0x040005CF RID: 1487
		private float maxY;
	}
}
