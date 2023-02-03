using System;
using System.Collections.Generic;
using System.IO;

namespace Spine
{
	// Token: 0x0200012F RID: 303
	public class SkeletonJson
	{
		// Token: 0x0600092C RID: 2348 RVA: 0x00029B10 File Offset: 0x00027D10
		public SkeletonJson(Atlas atlas) : this(new AtlasAttachmentLoader(atlas))
		{
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x00029B20 File Offset: 0x00027D20
		public SkeletonJson(AttachmentLoader attachmentLoader)
		{
			if (attachmentLoader == null)
			{
				throw new ArgumentNullException("attachmentLoader cannot be null.");
			}
			this.attachmentLoader = attachmentLoader;
			this.Scale = 1f;
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x0600092E RID: 2350 RVA: 0x00029B4C File Offset: 0x00027D4C
		// (set) Token: 0x0600092F RID: 2351 RVA: 0x00029B54 File Offset: 0x00027D54
		public float Scale { get; set; }

		// Token: 0x06000930 RID: 2352 RVA: 0x00029B60 File Offset: 0x00027D60
		public SkeletonData ReadSkeletonData(string path)
		{
			SkeletonData result;
			using (StreamReader streamReader = new StreamReader(path))
			{
				SkeletonData skeletonData = this.ReadSkeletonData(streamReader);
				skeletonData.name = Path.GetFileNameWithoutExtension(path);
				result = skeletonData;
			}
			return result;
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x00029BC0 File Offset: 0x00027DC0
		public SkeletonData ReadSkeletonData(TextReader reader)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader cannot be null.");
			}
			SkeletonData skeletonData = new SkeletonData();
			Dictionary<string, object> dictionary = Json.Deserialize(reader) as Dictionary<string, object>;
			if (dictionary == null)
			{
				throw new Exception("Invalid JSON.");
			}
			if (dictionary.ContainsKey("skeleton"))
			{
				Dictionary<string, object> dictionary2 = (Dictionary<string, object>)dictionary["skeleton"];
				skeletonData.hash = (string)dictionary2["hash"];
				skeletonData.version = (string)dictionary2["spine"];
				skeletonData.width = this.GetFloat(dictionary2, "width", 0f);
				skeletonData.height = this.GetFloat(dictionary2, "height", 0f);
			}
			foreach (object obj in ((List<object>)dictionary["bones"]))
			{
				Dictionary<string, object> dictionary3 = (Dictionary<string, object>)obj;
				BoneData boneData = null;
				if (dictionary3.ContainsKey("parent"))
				{
					boneData = skeletonData.FindBone((string)dictionary3["parent"]);
					if (boneData == null)
					{
						throw new Exception("Parent bone not found: " + dictionary3["parent"]);
					}
				}
				BoneData boneData2 = new BoneData((string)dictionary3["name"], boneData);
				boneData2.length = this.GetFloat(dictionary3, "length", 0f) * this.Scale;
				boneData2.x = this.GetFloat(dictionary3, "x", 0f) * this.Scale;
				boneData2.y = this.GetFloat(dictionary3, "y", 0f) * this.Scale;
				boneData2.rotation = this.GetFloat(dictionary3, "rotation", 0f);
				boneData2.scaleX = this.GetFloat(dictionary3, "scaleX", 1f);
				boneData2.scaleY = this.GetFloat(dictionary3, "scaleY", 1f);
				boneData2.flipX = this.GetBoolean(dictionary3, "flipX", false);
				boneData2.flipY = this.GetBoolean(dictionary3, "flipY", false);
				boneData2.inheritScale = this.GetBoolean(dictionary3, "inheritScale", true);
				boneData2.inheritRotation = this.GetBoolean(dictionary3, "inheritRotation", true);
				skeletonData.bones.Add(boneData2);
			}
			if (dictionary.ContainsKey("ik"))
			{
				foreach (object obj2 in ((List<object>)dictionary["ik"]))
				{
					Dictionary<string, object> dictionary4 = (Dictionary<string, object>)obj2;
					IkConstraintData ikConstraintData = new IkConstraintData((string)dictionary4["name"]);
					foreach (object obj3 in ((List<object>)dictionary4["bones"]))
					{
						string text = (string)obj3;
						BoneData boneData3 = skeletonData.FindBone(text);
						if (boneData3 == null)
						{
							throw new Exception("IK bone not found: " + text);
						}
						ikConstraintData.bones.Add(boneData3);
					}
					string text2 = (string)dictionary4["target"];
					ikConstraintData.target = skeletonData.FindBone(text2);
					if (ikConstraintData.target == null)
					{
						throw new Exception("Target bone not found: " + text2);
					}
					ikConstraintData.bendDirection = ((!this.GetBoolean(dictionary4, "bendPositive", true)) ? -1 : 1);
					ikConstraintData.mix = this.GetFloat(dictionary4, "mix", 1f);
					skeletonData.ikConstraints.Add(ikConstraintData);
				}
			}
			if (dictionary.ContainsKey("slots"))
			{
				foreach (object obj4 in ((List<object>)dictionary["slots"]))
				{
					Dictionary<string, object> dictionary5 = (Dictionary<string, object>)obj4;
					string name = (string)dictionary5["name"];
					string text3 = (string)dictionary5["bone"];
					BoneData boneData4 = skeletonData.FindBone(text3);
					if (boneData4 == null)
					{
						throw new Exception("Slot bone not found: " + text3);
					}
					SlotData slotData = new SlotData(name, boneData4);
					if (dictionary5.ContainsKey("color"))
					{
						string hexString = (string)dictionary5["color"];
						slotData.r = SkeletonJson.ToColor(hexString, 0);
						slotData.g = SkeletonJson.ToColor(hexString, 1);
						slotData.b = SkeletonJson.ToColor(hexString, 2);
						slotData.a = SkeletonJson.ToColor(hexString, 3);
					}
					if (dictionary5.ContainsKey("attachment"))
					{
						slotData.attachmentName = (string)dictionary5["attachment"];
					}
					if (dictionary5.ContainsKey("additive"))
					{
						slotData.additiveBlending = (bool)dictionary5["additive"];
					}
					skeletonData.slots.Add(slotData);
				}
			}
			if (dictionary.ContainsKey("skins"))
			{
				foreach (KeyValuePair<string, object> keyValuePair in ((Dictionary<string, object>)dictionary["skins"]))
				{
					Skin skin = new Skin(keyValuePair.Key);
					foreach (KeyValuePair<string, object> keyValuePair2 in ((Dictionary<string, object>)keyValuePair.Value))
					{
						int slotIndex = skeletonData.FindSlotIndex(keyValuePair2.Key);
						foreach (KeyValuePair<string, object> keyValuePair3 in ((Dictionary<string, object>)keyValuePair2.Value))
						{
							Attachment attachment = this.ReadAttachment(skin, keyValuePair3.Key, (Dictionary<string, object>)keyValuePair3.Value);
							if (attachment != null)
							{
								skin.AddAttachment(slotIndex, keyValuePair3.Key, attachment);
							}
						}
					}
					skeletonData.skins.Add(skin);
					if (skin.name == "default")
					{
						skeletonData.defaultSkin = skin;
					}
				}
			}
			if (dictionary.ContainsKey("events"))
			{
				foreach (KeyValuePair<string, object> keyValuePair4 in ((Dictionary<string, object>)dictionary["events"]))
				{
					Dictionary<string, object> map = (Dictionary<string, object>)keyValuePair4.Value;
					EventData eventData = new EventData(keyValuePair4.Key);
					eventData.Int = this.GetInt(map, "int", 0);
					eventData.Float = this.GetFloat(map, "float", 0f);
					eventData.String = this.GetString(map, "string", null);
					skeletonData.events.Add(eventData);
				}
			}
			if (dictionary.ContainsKey("animations"))
			{
				foreach (KeyValuePair<string, object> keyValuePair5 in ((Dictionary<string, object>)dictionary["animations"]))
				{
					this.ReadAnimation(keyValuePair5.Key, (Dictionary<string, object>)keyValuePair5.Value, skeletonData);
				}
			}
			skeletonData.bones.TrimExcess();
			skeletonData.slots.TrimExcess();
			skeletonData.skins.TrimExcess();
			skeletonData.animations.TrimExcess();
			return skeletonData;
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x0002A48C File Offset: 0x0002868C
		private Attachment ReadAttachment(Skin skin, string name, Dictionary<string, object> map)
		{
			if (map.ContainsKey("name"))
			{
				name = (string)map["name"];
			}
			AttachmentType attachmentType = AttachmentType.region;
			if (map.ContainsKey("type"))
			{
				attachmentType = (AttachmentType)((int)Enum.Parse(typeof(AttachmentType), (string)map["type"], false));
			}
			string path = name;
			if (map.ContainsKey("path"))
			{
				path = (string)map["path"];
			}
			switch (attachmentType)
			{
			case AttachmentType.region:
			{
				RegionAttachment regionAttachment = this.attachmentLoader.NewRegionAttachment(skin, name, path);
				if (regionAttachment == null)
				{
					return null;
				}
				regionAttachment.Path = path;
				regionAttachment.x = this.GetFloat(map, "x", 0f) * this.Scale;
				regionAttachment.y = this.GetFloat(map, "y", 0f) * this.Scale;
				regionAttachment.scaleX = this.GetFloat(map, "scaleX", 1f);
				regionAttachment.scaleY = this.GetFloat(map, "scaleY", 1f);
				regionAttachment.rotation = this.GetFloat(map, "rotation", 0f);
				regionAttachment.width = this.GetFloat(map, "width", 32f) * this.Scale;
				regionAttachment.height = this.GetFloat(map, "height", 32f) * this.Scale;
				regionAttachment.UpdateOffset();
				if (map.ContainsKey("color"))
				{
					string hexString = (string)map["color"];
					regionAttachment.r = SkeletonJson.ToColor(hexString, 0);
					regionAttachment.g = SkeletonJson.ToColor(hexString, 1);
					regionAttachment.b = SkeletonJson.ToColor(hexString, 2);
					regionAttachment.a = SkeletonJson.ToColor(hexString, 3);
				}
				return regionAttachment;
			}
			case AttachmentType.boundingbox:
			{
				BoundingBoxAttachment boundingBoxAttachment = this.attachmentLoader.NewBoundingBoxAttachment(skin, name);
				if (boundingBoxAttachment == null)
				{
					return null;
				}
				boundingBoxAttachment.vertices = this.GetFloatArray(map, "vertices", this.Scale);
				return boundingBoxAttachment;
			}
			case AttachmentType.mesh:
			{
				MeshAttachment meshAttachment = this.attachmentLoader.NewMeshAttachment(skin, name, path);
				if (meshAttachment == null)
				{
					return null;
				}
				meshAttachment.Path = path;
				meshAttachment.vertices = this.GetFloatArray(map, "vertices", this.Scale);
				meshAttachment.triangles = this.GetIntArray(map, "triangles");
				meshAttachment.regionUVs = this.GetFloatArray(map, "uvs", 1f);
				meshAttachment.UpdateUVs();
				if (map.ContainsKey("color"))
				{
					string hexString2 = (string)map["color"];
					meshAttachment.r = SkeletonJson.ToColor(hexString2, 0);
					meshAttachment.g = SkeletonJson.ToColor(hexString2, 1);
					meshAttachment.b = SkeletonJson.ToColor(hexString2, 2);
					meshAttachment.a = SkeletonJson.ToColor(hexString2, 3);
				}
				meshAttachment.HullLength = this.GetInt(map, "hull", 0) * 2;
				if (map.ContainsKey("edges"))
				{
					meshAttachment.Edges = this.GetIntArray(map, "edges");
				}
				meshAttachment.Width = (float)this.GetInt(map, "width", 0) * this.Scale;
				meshAttachment.Height = (float)this.GetInt(map, "height", 0) * this.Scale;
				return meshAttachment;
			}
			case AttachmentType.skinnedmesh:
			{
				SkinnedMeshAttachment skinnedMeshAttachment = this.attachmentLoader.NewSkinnedMeshAttachment(skin, name, path);
				if (skinnedMeshAttachment == null)
				{
					return null;
				}
				skinnedMeshAttachment.Path = path;
				float[] floatArray = this.GetFloatArray(map, "uvs", 1f);
				float[] floatArray2 = this.GetFloatArray(map, "vertices", 1f);
				List<float> list = new List<float>(floatArray.Length * 3 * 3);
				List<int> list2 = new List<int>(floatArray.Length * 3);
				float scale = this.Scale;
				int i = 0;
				int num = floatArray2.Length;
				while (i < num)
				{
					int num2 = (int)floatArray2[i++];
					list2.Add(num2);
					int num3 = i + num2 * 4;
					while (i < num3)
					{
						list2.Add((int)floatArray2[i]);
						list.Add(floatArray2[i + 1] * scale);
						list.Add(floatArray2[i + 2] * scale);
						list.Add(floatArray2[i + 3]);
						i += 4;
					}
				}
				skinnedMeshAttachment.bones = list2.ToArray();
				skinnedMeshAttachment.weights = list.ToArray();
				skinnedMeshAttachment.triangles = this.GetIntArray(map, "triangles");
				skinnedMeshAttachment.regionUVs = floatArray;
				skinnedMeshAttachment.UpdateUVs();
				if (map.ContainsKey("color"))
				{
					string hexString3 = (string)map["color"];
					skinnedMeshAttachment.r = SkeletonJson.ToColor(hexString3, 0);
					skinnedMeshAttachment.g = SkeletonJson.ToColor(hexString3, 1);
					skinnedMeshAttachment.b = SkeletonJson.ToColor(hexString3, 2);
					skinnedMeshAttachment.a = SkeletonJson.ToColor(hexString3, 3);
				}
				skinnedMeshAttachment.HullLength = this.GetInt(map, "hull", 0) * 2;
				if (map.ContainsKey("edges"))
				{
					skinnedMeshAttachment.Edges = this.GetIntArray(map, "edges");
				}
				skinnedMeshAttachment.Width = (float)this.GetInt(map, "width", 0) * this.Scale;
				skinnedMeshAttachment.Height = (float)this.GetInt(map, "height", 0) * this.Scale;
				return skinnedMeshAttachment;
			}
			default:
				return null;
			}
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x0002A9E4 File Offset: 0x00028BE4
		private float[] GetFloatArray(Dictionary<string, object> map, string name, float scale)
		{
			List<object> list = (List<object>)map[name];
			float[] array = new float[list.Count];
			if (scale == 1f)
			{
				int i = 0;
				int count = list.Count;
				while (i < count)
				{
					array[i] = (float)list[i];
					i++;
				}
			}
			else
			{
				int j = 0;
				int count2 = list.Count;
				while (j < count2)
				{
					array[j] = (float)list[j] * scale;
					j++;
				}
			}
			return array;
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x0002AA78 File Offset: 0x00028C78
		private int[] GetIntArray(Dictionary<string, object> map, string name)
		{
			List<object> list = (List<object>)map[name];
			int[] array = new int[list.Count];
			int i = 0;
			int count = list.Count;
			while (i < count)
			{
				array[i] = (int)((float)list[i]);
				i++;
			}
			return array;
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x0002AAC8 File Offset: 0x00028CC8
		private float GetFloat(Dictionary<string, object> map, string name, float defaultValue)
		{
			if (!map.ContainsKey(name))
			{
				return defaultValue;
			}
			return (float)map[name];
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x0002AAE4 File Offset: 0x00028CE4
		private int GetInt(Dictionary<string, object> map, string name, int defaultValue)
		{
			if (!map.ContainsKey(name))
			{
				return defaultValue;
			}
			return (int)((float)map[name]);
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x0002AB04 File Offset: 0x00028D04
		private bool GetBoolean(Dictionary<string, object> map, string name, bool defaultValue)
		{
			if (!map.ContainsKey(name))
			{
				return defaultValue;
			}
			return (bool)map[name];
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x0002AB20 File Offset: 0x00028D20
		private string GetString(Dictionary<string, object> map, string name, string defaultValue)
		{
			if (!map.ContainsKey(name))
			{
				return defaultValue;
			}
			return (string)map[name];
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x0002AB3C File Offset: 0x00028D3C
		public static float ToColor(string hexString, int colorIndex)
		{
			if (hexString.Length != 8)
			{
				throw new ArgumentException("Color hexidecimal length must be 8, recieved: " + hexString);
			}
			return (float)Convert.ToInt32(hexString.Substring(colorIndex * 2, 2), 16) / 255f;
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x0002AB80 File Offset: 0x00028D80
		private void ReadAnimation(string name, Dictionary<string, object> map, SkeletonData skeletonData)
		{
			List<Timeline> list = new List<Timeline>();
			float num = 0f;
			float scale = this.Scale;
			if (map.ContainsKey("slots"))
			{
				foreach (KeyValuePair<string, object> keyValuePair in ((Dictionary<string, object>)map["slots"]))
				{
					string key = keyValuePair.Key;
					int slotIndex = skeletonData.FindSlotIndex(key);
					Dictionary<string, object> dictionary = (Dictionary<string, object>)keyValuePair.Value;
					foreach (KeyValuePair<string, object> keyValuePair2 in dictionary)
					{
						List<object> list2 = (List<object>)keyValuePair2.Value;
						string key2 = keyValuePair2.Key;
						if (key2 == "color")
						{
							ColorTimeline colorTimeline = new ColorTimeline(list2.Count);
							colorTimeline.slotIndex = slotIndex;
							int num2 = 0;
							foreach (object obj in list2)
							{
								Dictionary<string, object> dictionary2 = (Dictionary<string, object>)obj;
								float time = (float)dictionary2["time"];
								string hexString = (string)dictionary2["color"];
								colorTimeline.setFrame(num2, time, SkeletonJson.ToColor(hexString, 0), SkeletonJson.ToColor(hexString, 1), SkeletonJson.ToColor(hexString, 2), SkeletonJson.ToColor(hexString, 3));
								this.ReadCurve(colorTimeline, num2, dictionary2);
								num2++;
							}
							list.Add(colorTimeline);
							num = Math.Max(num, colorTimeline.frames[colorTimeline.FrameCount * 5 - 5]);
						}
						else
						{
							if (!(key2 == "attachment"))
							{
								throw new Exception(string.Concat(new string[]
								{
									"Invalid timeline type for a slot: ",
									key2,
									" (",
									key,
									")"
								}));
							}
							AttachmentTimeline attachmentTimeline = new AttachmentTimeline(list2.Count);
							attachmentTimeline.slotIndex = slotIndex;
							int num3 = 0;
							foreach (object obj2 in list2)
							{
								Dictionary<string, object> dictionary3 = (Dictionary<string, object>)obj2;
								float time2 = (float)dictionary3["time"];
								attachmentTimeline.setFrame(num3++, time2, (string)dictionary3["name"]);
							}
							list.Add(attachmentTimeline);
							num = Math.Max(num, attachmentTimeline.frames[attachmentTimeline.FrameCount - 1]);
						}
					}
				}
			}
			if (map.ContainsKey("bones"))
			{
				foreach (KeyValuePair<string, object> keyValuePair3 in ((Dictionary<string, object>)map["bones"]))
				{
					string key3 = keyValuePair3.Key;
					int num4 = skeletonData.FindBoneIndex(key3);
					if (num4 == -1)
					{
						throw new Exception("Bone not found: " + key3);
					}
					Dictionary<string, object> dictionary4 = (Dictionary<string, object>)keyValuePair3.Value;
					foreach (KeyValuePair<string, object> keyValuePair4 in dictionary4)
					{
						List<object> list3 = (List<object>)keyValuePair4.Value;
						string key4 = keyValuePair4.Key;
						if (key4 == "rotate")
						{
							RotateTimeline rotateTimeline = new RotateTimeline(list3.Count);
							rotateTimeline.boneIndex = num4;
							int num5 = 0;
							foreach (object obj3 in list3)
							{
								Dictionary<string, object> dictionary5 = (Dictionary<string, object>)obj3;
								float time3 = (float)dictionary5["time"];
								rotateTimeline.SetFrame(num5, time3, (float)dictionary5["angle"]);
								this.ReadCurve(rotateTimeline, num5, dictionary5);
								num5++;
							}
							list.Add(rotateTimeline);
							num = Math.Max(num, rotateTimeline.frames[rotateTimeline.FrameCount * 2 - 2]);
						}
						else if (key4 == "translate" || key4 == "scale")
						{
							float num6 = 1f;
							TranslateTimeline translateTimeline;
							if (key4 == "scale")
							{
								translateTimeline = new ScaleTimeline(list3.Count);
							}
							else
							{
								translateTimeline = new TranslateTimeline(list3.Count);
								num6 = scale;
							}
							translateTimeline.boneIndex = num4;
							int num7 = 0;
							foreach (object obj4 in list3)
							{
								Dictionary<string, object> dictionary6 = (Dictionary<string, object>)obj4;
								float time4 = (float)dictionary6["time"];
								float num8 = (!dictionary6.ContainsKey("x")) ? 0f : ((float)dictionary6["x"]);
								float num9 = (!dictionary6.ContainsKey("y")) ? 0f : ((float)dictionary6["y"]);
								translateTimeline.SetFrame(num7, time4, num8 * num6, num9 * num6);
								this.ReadCurve(translateTimeline, num7, dictionary6);
								num7++;
							}
							list.Add(translateTimeline);
							num = Math.Max(num, translateTimeline.frames[translateTimeline.FrameCount * 3 - 3]);
						}
						else
						{
							if (!(key4 == "flipX") && !(key4 == "flipY"))
							{
								throw new Exception(string.Concat(new string[]
								{
									"Invalid timeline type for a bone: ",
									key4,
									" (",
									key3,
									")"
								}));
							}
							bool flag = key4 == "flipX";
							FlipXTimeline flipXTimeline = (!flag) ? new FlipYTimeline(list3.Count) : new FlipXTimeline(list3.Count);
							flipXTimeline.boneIndex = num4;
							string key5 = (!flag) ? "y" : "x";
							int num10 = 0;
							foreach (object obj5 in list3)
							{
								Dictionary<string, object> dictionary7 = (Dictionary<string, object>)obj5;
								float time5 = (float)dictionary7["time"];
								flipXTimeline.SetFrame(num10, time5, dictionary7.ContainsKey(key5) && (bool)dictionary7[key5]);
								num10++;
							}
							list.Add(flipXTimeline);
							num = Math.Max(num, flipXTimeline.frames[flipXTimeline.FrameCount * 2 - 2]);
						}
					}
				}
			}
			if (map.ContainsKey("ik"))
			{
				foreach (KeyValuePair<string, object> keyValuePair5 in ((Dictionary<string, object>)map["ik"]))
				{
					IkConstraintData item = skeletonData.FindIkConstraint(keyValuePair5.Key);
					List<object> list4 = (List<object>)keyValuePair5.Value;
					IkConstraintTimeline ikConstraintTimeline = new IkConstraintTimeline(list4.Count);
					ikConstraintTimeline.ikConstraintIndex = skeletonData.ikConstraints.IndexOf(item);
					int num11 = 0;
					foreach (object obj6 in list4)
					{
						Dictionary<string, object> dictionary8 = (Dictionary<string, object>)obj6;
						float time6 = (float)dictionary8["time"];
						float mix = (!dictionary8.ContainsKey("mix")) ? 1f : ((float)dictionary8["mix"]);
						bool flag2 = !dictionary8.ContainsKey("bendPositive") || (bool)dictionary8["bendPositive"];
						ikConstraintTimeline.setFrame(num11, time6, mix, (!flag2) ? -1 : 1);
						this.ReadCurve(ikConstraintTimeline, num11, dictionary8);
						num11++;
					}
					list.Add(ikConstraintTimeline);
					num = Math.Max(num, ikConstraintTimeline.frames[ikConstraintTimeline.FrameCount * 3 - 3]);
				}
			}
			if (map.ContainsKey("ffd"))
			{
				foreach (KeyValuePair<string, object> keyValuePair6 in ((Dictionary<string, object>)map["ffd"]))
				{
					Skin skin = skeletonData.FindSkin(keyValuePair6.Key);
					foreach (KeyValuePair<string, object> keyValuePair7 in ((Dictionary<string, object>)keyValuePair6.Value))
					{
						int slotIndex2 = skeletonData.FindSlotIndex(keyValuePair7.Key);
						foreach (KeyValuePair<string, object> keyValuePair8 in ((Dictionary<string, object>)keyValuePair7.Value))
						{
							List<object> list5 = (List<object>)keyValuePair8.Value;
							FFDTimeline ffdtimeline = new FFDTimeline(list5.Count);
							Attachment attachment = skin.GetAttachment(slotIndex2, keyValuePair8.Key);
							if (attachment == null)
							{
								throw new Exception("FFD attachment not found: " + keyValuePair8.Key);
							}
							ffdtimeline.slotIndex = slotIndex2;
							ffdtimeline.attachment = attachment;
							int num12;
							if (attachment is MeshAttachment)
							{
								num12 = ((MeshAttachment)attachment).vertices.Length;
							}
							else
							{
								num12 = ((SkinnedMeshAttachment)attachment).Weights.Length / 3 * 2;
							}
							int num13 = 0;
							foreach (object obj7 in list5)
							{
								Dictionary<string, object> dictionary9 = (Dictionary<string, object>)obj7;
								float[] array;
								if (!dictionary9.ContainsKey("vertices"))
								{
									if (attachment is MeshAttachment)
									{
										array = ((MeshAttachment)attachment).vertices;
									}
									else
									{
										array = new float[num12];
									}
								}
								else
								{
									List<object> list6 = (List<object>)dictionary9["vertices"];
									array = new float[num12];
									int @int = this.GetInt(dictionary9, "offset", 0);
									if (scale == 1f)
									{
										int i = 0;
										int count = list6.Count;
										while (i < count)
										{
											array[i + @int] = (float)list6[i];
											i++;
										}
									}
									else
									{
										int j = 0;
										int count2 = list6.Count;
										while (j < count2)
										{
											array[j + @int] = (float)list6[j] * scale;
											j++;
										}
									}
									if (attachment is MeshAttachment)
									{
										float[] vertices = ((MeshAttachment)attachment).vertices;
										for (int k = 0; k < num12; k++)
										{
											array[k] += vertices[k];
										}
									}
								}
								ffdtimeline.setFrame(num13, (float)dictionary9["time"], array);
								this.ReadCurve(ffdtimeline, num13, dictionary9);
								num13++;
							}
							list.Add(ffdtimeline);
							num = Math.Max(num, ffdtimeline.frames[ffdtimeline.FrameCount - 1]);
						}
					}
				}
			}
			if (map.ContainsKey("drawOrder") || map.ContainsKey("draworder"))
			{
				List<object> list7 = (List<object>)map[(!map.ContainsKey("drawOrder")) ? "draworder" : "drawOrder"];
				DrawOrderTimeline drawOrderTimeline = new DrawOrderTimeline(list7.Count);
				int count3 = skeletonData.slots.Count;
				int num14 = 0;
				foreach (object obj8 in list7)
				{
					Dictionary<string, object> dictionary10 = (Dictionary<string, object>)obj8;
					int[] array2 = null;
					if (dictionary10.ContainsKey("offsets"))
					{
						array2 = new int[count3];
						for (int l = count3 - 1; l >= 0; l--)
						{
							array2[l] = -1;
						}
						List<object> list8 = (List<object>)dictionary10["offsets"];
						int[] array3 = new int[count3 - list8.Count];
						int m = 0;
						int num15 = 0;
						foreach (object obj9 in list8)
						{
							Dictionary<string, object> dictionary11 = (Dictionary<string, object>)obj9;
							int num16 = skeletonData.FindSlotIndex((string)dictionary11["slot"]);
							if (num16 == -1)
							{
								throw new Exception("Slot not found: " + dictionary11["slot"]);
							}
							while (m != num16)
							{
								array3[num15++] = m++;
							}
							array2[m + (int)((float)dictionary11["offset"])] = m++;
						}
						while (m < count3)
						{
							array3[num15++] = m++;
						}
						for (int n = count3 - 1; n >= 0; n--)
						{
							if (array2[n] == -1)
							{
								array2[n] = array3[--num15];
							}
						}
					}
					drawOrderTimeline.setFrame(num14++, (float)dictionary10["time"], array2);
				}
				list.Add(drawOrderTimeline);
				num = Math.Max(num, drawOrderTimeline.frames[drawOrderTimeline.FrameCount - 1]);
			}
			if (map.ContainsKey("events"))
			{
				List<object> list9 = (List<object>)map["events"];
				EventTimeline eventTimeline = new EventTimeline(list9.Count);
				int num17 = 0;
				foreach (object obj10 in list9)
				{
					Dictionary<string, object> dictionary12 = (Dictionary<string, object>)obj10;
					EventData eventData = skeletonData.FindEvent((string)dictionary12["name"]);
					if (eventData == null)
					{
						throw new Exception("Event not found: " + dictionary12["name"]);
					}
					Event @event = new Event(eventData);
					@event.Int = this.GetInt(dictionary12, "int", eventData.Int);
					@event.Float = this.GetFloat(dictionary12, "float", eventData.Float);
					@event.String = this.GetString(dictionary12, "string", eventData.String);
					eventTimeline.setFrame(num17++, (float)dictionary12["time"], @event);
				}
				list.Add(eventTimeline);
				num = Math.Max(num, eventTimeline.frames[eventTimeline.FrameCount - 1]);
			}
			list.TrimExcess();
			skeletonData.animations.Add(new Animation(name, list, num));
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x0002BCC4 File Offset: 0x00029EC4
		private void ReadCurve(CurveTimeline timeline, int frameIndex, Dictionary<string, object> valueMap)
		{
			if (!valueMap.ContainsKey("curve"))
			{
				return;
			}
			object obj = valueMap["curve"];
			if (obj.Equals("stepped"))
			{
				timeline.SetStepped(frameIndex);
			}
			else if (obj is List<object>)
			{
				List<object> list = (List<object>)obj;
				timeline.SetCurve(frameIndex, (float)list[0], (float)list[1], (float)list[2], (float)list[3]);
			}
		}

		// Token: 0x040005E0 RID: 1504
		private AttachmentLoader attachmentLoader;
	}
}
