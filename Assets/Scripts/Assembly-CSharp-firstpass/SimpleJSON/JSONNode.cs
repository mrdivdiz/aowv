using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace SimpleJSON
{
	// Token: 0x02000028 RID: 40
	public class JSONNode
	{
		// Token: 0x0600017B RID: 379 RVA: 0x00007044 File Offset: 0x00005244
		public virtual void Add(string aKey, JSONNode aItem)
		{
		}

		// Token: 0x1700001D RID: 29
		public virtual JSONNode this[int aIndex]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1700001E RID: 30
		public virtual JSONNode this[string aKey]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000180 RID: 384 RVA: 0x00007058 File Offset: 0x00005258
		// (set) Token: 0x06000181 RID: 385 RVA: 0x00007060 File Offset: 0x00005260
		public virtual string Value
		{
			get
			{
				return string.Empty;
			}
			set
			{
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000182 RID: 386 RVA: 0x00007064 File Offset: 0x00005264
		public virtual int Count
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00007068 File Offset: 0x00005268
		public virtual void Add(JSONNode aItem)
		{
			this.Add(string.Empty, aItem);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00007078 File Offset: 0x00005278
		public virtual JSONNode Remove(string aKey)
		{
			return null;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x0000707C File Offset: 0x0000527C
		public virtual JSONNode Remove(int aIndex)
		{
			return null;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00007080 File Offset: 0x00005280
		public virtual JSONNode Remove(JSONNode aNode)
		{
			return aNode;
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000187 RID: 391 RVA: 0x00007084 File Offset: 0x00005284
		public virtual IEnumerable<JSONNode> Childs
		{
			get
			{
				yield break;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000188 RID: 392 RVA: 0x000070A0 File Offset: 0x000052A0
		public IEnumerable<JSONNode> DeepChilds
		{
			get
			{
				foreach (JSONNode C in this.Childs)
				{
					foreach (JSONNode D in C.DeepChilds)
					{
						yield return D;
					}
				}
				yield break;
			}
		}

		// Token: 0x06000189 RID: 393 RVA: 0x000070C4 File Offset: 0x000052C4
		public override string ToString()
		{
			return "JSONNode";
		}

		// Token: 0x0600018A RID: 394 RVA: 0x000070CC File Offset: 0x000052CC
		public virtual string ToString(string aPrefix)
		{
			return "JSONNode";
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600018B RID: 395 RVA: 0x000070D4 File Offset: 0x000052D4
		// (set) Token: 0x0600018C RID: 396 RVA: 0x000070F8 File Offset: 0x000052F8
		public virtual int AsInt
		{
			get
			{
				int result = 0;
				if (int.TryParse(this.Value, out result))
				{
					return result;
				}
				return 0;
			}
			set
			{
				this.Value = value.ToString();
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600018D RID: 397 RVA: 0x00007108 File Offset: 0x00005308
		// (set) Token: 0x0600018E RID: 398 RVA: 0x00007134 File Offset: 0x00005334
		public virtual float AsFloat
		{
			get
			{
				float result = 0f;
				if (float.TryParse(this.Value, out result))
				{
					return result;
				}
				return 0f;
			}
			set
			{
				this.Value = value.ToString();
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600018F RID: 399 RVA: 0x00007144 File Offset: 0x00005344
		// (set) Token: 0x06000190 RID: 400 RVA: 0x00007178 File Offset: 0x00005378
		public virtual double AsDouble
		{
			get
			{
				double result = 0.0;
				if (double.TryParse(this.Value, out result))
				{
					return result;
				}
				return 0.0;
			}
			set
			{
				this.Value = value.ToString();
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000191 RID: 401 RVA: 0x00007188 File Offset: 0x00005388
		// (set) Token: 0x06000192 RID: 402 RVA: 0x000071BC File Offset: 0x000053BC
		public virtual bool AsBool
		{
			get
			{
				bool result = false;
				if (bool.TryParse(this.Value, out result))
				{
					return result;
				}
				return !string.IsNullOrEmpty(this.Value);
			}
			set
			{
				this.Value = ((!value) ? "false" : "true");
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000193 RID: 403 RVA: 0x000071DC File Offset: 0x000053DC
		public virtual JSONArray AsArray
		{
			get
			{
				return this as JSONArray;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000194 RID: 404 RVA: 0x000071E4 File Offset: 0x000053E4
		public virtual JSONClass AsObject
		{
			get
			{
				return this as JSONClass;
			}
		}

		// Token: 0x06000195 RID: 405 RVA: 0x000071EC File Offset: 0x000053EC
		public override bool Equals(object obj)
		{
			return object.ReferenceEquals(this, obj);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x000071F8 File Offset: 0x000053F8
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00007200 File Offset: 0x00005400
		internal static string Escape(string aText)
		{
			string text = string.Empty;
			foreach (char c in aText)
			{
				char c2 = c;
				switch (c2)
				{
				case '\b':
					text += "\\b";
					break;
				case '\t':
					text += "\\t";
					break;
				case '\n':
					text += "\\n";
					break;
				default:
					if (c2 != '"')
					{
						if (c2 != '\\')
						{
							text += c;
						}
						else
						{
							text += "\\\\";
						}
					}
					else
					{
						text += "\\\"";
					}
					break;
				case '\f':
					text += "\\f";
					break;
				case '\r':
					text += "\\r";
					break;
				}
			}
			return text;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x000072FC File Offset: 0x000054FC
		public static JSONNode Parse(string aJSON)
		{
			Stack<JSONNode> stack = new Stack<JSONNode>();
			JSONNode jsonnode = null;
			int i = 0;
			string text = string.Empty;
			string text2 = string.Empty;
			bool flag = false;
			while (i < aJSON.Length)
			{
				char c = aJSON[i];
				switch (c)
				{
				case '\t':
					goto IL_333;
				case '\n':
				case '\r':
					break;
				default:
					switch (c)
					{
					case ' ':
						goto IL_333;
					default:
						switch (c)
						{
						case '[':
							if (flag)
							{
								text += aJSON[i];
								goto IL_467;
							}
							stack.Push(new JSONArray());
							if (jsonnode != null)
							{
								text2 = text2.Trim();
								if (jsonnode is JSONArray)
								{
									jsonnode.Add(stack.Peek());
								}
								else if (text2 != string.Empty)
								{
									jsonnode.Add(text2, stack.Peek());
								}
							}
							text2 = string.Empty;
							text = string.Empty;
							jsonnode = stack.Peek();
							goto IL_467;
						case '\\':
							i++;
							if (flag)
							{
								char c2 = aJSON[i];
								char c3 = c2;
								switch (c3)
								{
								case 'n':
									text += '\n';
									break;
								default:
									if (c3 != 'b')
									{
										if (c3 != 'f')
										{
											text += c2;
										}
										else
										{
											text += '\f';
										}
									}
									else
									{
										text += '\b';
									}
									break;
								case 'r':
									text += '\r';
									break;
								case 't':
									text += '\t';
									break;
								case 'u':
								{
									string s = aJSON.Substring(i + 1, 4);
									text += (char)int.Parse(s, NumberStyles.AllowHexSpecifier);
									i += 4;
									break;
								}
								}
							}
							goto IL_467;
						case ']':
							break;
						default:
							switch (c)
							{
							case '{':
								if (flag)
								{
									text += aJSON[i];
									goto IL_467;
								}
								stack.Push(new JSONClass());
								if (jsonnode != null)
								{
									text2 = text2.Trim();
									if (jsonnode is JSONArray)
									{
										jsonnode.Add(stack.Peek());
									}
									else if (text2 != string.Empty)
									{
										jsonnode.Add(text2, stack.Peek());
									}
								}
								text2 = string.Empty;
								text = string.Empty;
								jsonnode = stack.Peek();
								goto IL_467;
							default:
								if (c != ',')
								{
									if (c != ':')
									{
										text += aJSON[i];
										goto IL_467;
									}
									if (flag)
									{
										text += aJSON[i];
										goto IL_467;
									}
									text2 = text;
									text = string.Empty;
									goto IL_467;
								}
								else
								{
									if (flag)
									{
										text += aJSON[i];
										goto IL_467;
									}
									if (text != string.Empty)
									{
										if (jsonnode is JSONArray)
										{
											jsonnode.Add(text);
										}
										else if (text2 != string.Empty)
										{
											jsonnode.Add(text2, text);
										}
									}
									text2 = string.Empty;
									text = string.Empty;
									goto IL_467;
								}
								break;
							case '}':
								break;
							}
							break;
						}
						if (flag)
						{
							text += aJSON[i];
						}
						else
						{
							if (stack.Count == 0)
							{
								throw new Exception("JSON Parse: Too many closing brackets");
							}
							stack.Pop();
							if (text != string.Empty)
							{
								text2 = text2.Trim();
								if (jsonnode is JSONArray)
								{
									jsonnode.Add(text);
								}
								else if (text2 != string.Empty)
								{
									jsonnode.Add(text2, text);
								}
							}
							text2 = string.Empty;
							text = string.Empty;
							if (stack.Count > 0)
							{
								jsonnode = stack.Peek();
							}
						}
						break;
					case '"':
						flag ^= true;
						break;
					}
					break;
				}
				IL_467:
				i++;
				continue;
				IL_333:
				if (flag)
				{
					text += aJSON[i];
				}
				goto IL_467;
			}
			if (flag)
			{
				throw new Exception("JSON Parse: Quotation marks seems to be messed up.");
			}
			return jsonnode;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00007794 File Offset: 0x00005994
		public virtual void Serialize(BinaryWriter aWriter)
		{
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00007798 File Offset: 0x00005998
		public void SaveToStream(Stream aData)
		{
			BinaryWriter aWriter = new BinaryWriter(aData);
			this.Serialize(aWriter);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x000077B4 File Offset: 0x000059B4
		public void SaveToCompressedStream(Stream aData)
		{
			throw new Exception("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
		}

		// Token: 0x0600019C RID: 412 RVA: 0x000077C0 File Offset: 0x000059C0
		public void SaveToCompressedFile(string aFileName)
		{
			throw new Exception("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
		}

		// Token: 0x0600019D RID: 413 RVA: 0x000077CC File Offset: 0x000059CC
		public string SaveToCompressedBase64()
		{
			throw new Exception("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
		}

		// Token: 0x0600019E RID: 414 RVA: 0x000077D8 File Offset: 0x000059D8
		public void SaveToFile(string aFileName)
		{
			Directory.CreateDirectory(new FileInfo(aFileName).Directory.FullName);
			using (FileStream fileStream = File.OpenWrite(aFileName))
			{
				this.SaveToStream(fileStream);
			}
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00007838 File Offset: 0x00005A38
		public string SaveToBase64()
		{
			string result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				this.SaveToStream(memoryStream);
				memoryStream.Position = 0L;
				result = Convert.ToBase64String(memoryStream.ToArray());
			}
			return result;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0000789C File Offset: 0x00005A9C
		public static JSONNode Deserialize(BinaryReader aReader)
		{
			JSONBinaryTag jsonbinaryTag = (JSONBinaryTag)aReader.ReadByte();
			switch (jsonbinaryTag)
			{
			case JSONBinaryTag.Array:
			{
				int num = aReader.ReadInt32();
				JSONArray jsonarray = new JSONArray();
				for (int i = 0; i < num; i++)
				{
					jsonarray.Add(JSONNode.Deserialize(aReader));
				}
				return jsonarray;
			}
			case JSONBinaryTag.Class:
			{
				int num2 = aReader.ReadInt32();
				JSONClass jsonclass = new JSONClass();
				for (int j = 0; j < num2; j++)
				{
					string aKey = aReader.ReadString();
					JSONNode aItem = JSONNode.Deserialize(aReader);
					jsonclass.Add(aKey, aItem);
				}
				return jsonclass;
			}
			case JSONBinaryTag.Value:
				return new JSONData(aReader.ReadString());
			case JSONBinaryTag.IntValue:
				return new JSONData(aReader.ReadInt32());
			case JSONBinaryTag.DoubleValue:
				return new JSONData(aReader.ReadDouble());
			case JSONBinaryTag.BoolValue:
				return new JSONData(aReader.ReadBoolean());
			case JSONBinaryTag.FloatValue:
				return new JSONData(aReader.ReadSingle());
			default:
				throw new Exception("Error deserializing JSON. Unknown tag: " + jsonbinaryTag);
			}
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x000079A0 File Offset: 0x00005BA0
		public static JSONNode LoadFromCompressedFile(string aFileName)
		{
			throw new Exception("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x000079AC File Offset: 0x00005BAC
		public static JSONNode LoadFromCompressedStream(Stream aData)
		{
			throw new Exception("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x000079B8 File Offset: 0x00005BB8
		public static JSONNode LoadFromCompressedBase64(string aBase64)
		{
			throw new Exception("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x000079C4 File Offset: 0x00005BC4
		public static JSONNode LoadFromStream(Stream aData)
		{
			JSONNode result;
			using (BinaryReader binaryReader = new BinaryReader(aData))
			{
				result = JSONNode.Deserialize(binaryReader);
			}
			return result;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00007A14 File Offset: 0x00005C14
		public static JSONNode LoadFromFile(string aFileName)
		{
			JSONNode result;
			using (FileStream fileStream = File.OpenRead(aFileName))
			{
				result = JSONNode.LoadFromStream(fileStream);
			}
			return result;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00007A64 File Offset: 0x00005C64
		public static JSONNode LoadFromBase64(string aBase64)
		{
			byte[] buffer = Convert.FromBase64String(aBase64);
			return JSONNode.LoadFromStream(new MemoryStream(buffer)
			{
				Position = 0L
			});
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00007A90 File Offset: 0x00005C90
		public static implicit operator JSONNode(string s)
		{
			return new JSONData(s);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00007A98 File Offset: 0x00005C98
		public static implicit operator string(JSONNode d)
		{
			return (!(d == null)) ? d.Value : null;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00007AB4 File Offset: 0x00005CB4
		public static bool operator ==(JSONNode a, object b)
		{
			return (b == null && a is JSONLazyCreator) || object.ReferenceEquals(a, b);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00007AD0 File Offset: 0x00005CD0
		public static bool operator !=(JSONNode a, object b)
		{
			return !(a == b);
		}
	}
}
