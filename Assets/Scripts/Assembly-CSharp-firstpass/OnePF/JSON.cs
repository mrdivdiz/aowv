using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

namespace OnePF
{
	// Token: 0x02000019 RID: 25
	public class JSON
	{
		// Token: 0x060000DC RID: 220 RVA: 0x000051D4 File Offset: 0x000033D4
		public JSON()
		{
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000051E8 File Offset: 0x000033E8
		public JSON(string jsonString)
		{
			this.serialized = jsonString;
		}

		// Token: 0x17000001 RID: 1
		public object this[string fieldName]
		{
			get
			{
				if (this.fields.ContainsKey(fieldName))
				{
					return this.fields[fieldName];
				}
				return null;
			}
			set
			{
				if (this.fields.ContainsKey(fieldName))
				{
					this.fields[fieldName] = value;
				}
				else
				{
					this.fields.Add(fieldName, value);
				}
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00005268 File Offset: 0x00003468
		public string ToString(string fieldName)
		{
			if (this.fields.ContainsKey(fieldName))
			{
				return Convert.ToString(this.fields[fieldName]);
			}
			return string.Empty;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000052A0 File Offset: 0x000034A0
		public int ToInt(string fieldName)
		{
			if (this.fields.ContainsKey(fieldName))
			{
				return Convert.ToInt32(this.fields[fieldName]);
			}
			return 0;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x000052D4 File Offset: 0x000034D4
		public long ToLong(string fieldName)
		{
			if (this.fields.ContainsKey(fieldName))
			{
				return Convert.ToInt64(this.fields[fieldName]);
			}
			return 0L;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000052FC File Offset: 0x000034FC
		public float ToFloat(string fieldName)
		{
			if (this.fields.ContainsKey(fieldName))
			{
				return Convert.ToSingle(this.fields[fieldName]);
			}
			return 0f;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00005334 File Offset: 0x00003534
		public bool ToBoolean(string fieldName)
		{
			return this.fields.ContainsKey(fieldName) && Convert.ToBoolean(this.fields[fieldName]);
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x00005368 File Offset: 0x00003568
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x00005370 File Offset: 0x00003570
		public string serialized
		{
			get
			{
				return JSON._JSON.Serialize(this);
			}
			set
			{
				JSON json = JSON._JSON.Deserialize(value);
				if (json != null)
				{
					this.fields = json.fields;
				}
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00005398 File Offset: 0x00003598
		public JSON ToJSON(string fieldName)
		{
			if (!this.fields.ContainsKey(fieldName))
			{
				this.fields.Add(fieldName, new JSON());
			}
			return (JSON)this[fieldName];
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000053D4 File Offset: 0x000035D4
		public T[] ToArray<T>(string fieldName)
		{
			if (this.fields.ContainsKey(fieldName) && this.fields[fieldName] is IEnumerable)
			{
				List<T> list = new List<T>();
				foreach (object obj in (this.fields[fieldName] as IEnumerable))
				{
					if (list is List<string>)
					{
						(list as List<string>).Add(Convert.ToString(obj));
					}
					else if (list is List<int>)
					{
						(list as List<int>).Add(Convert.ToInt32(obj));
					}
					else if (list is List<float>)
					{
						(list as List<float>).Add(Convert.ToSingle(obj));
					}
					else if (list is List<bool>)
					{
						(list as List<bool>).Add(Convert.ToBoolean(obj));
					}
					else if (list is List<Vector2>)
					{
						(list as List<Vector2>).Add((JSON)obj);
					}
					else if (list is List<Vector3>)
					{
						(list as List<Vector3>).Add((JSON)obj);
					}
					else if (list is List<Rect>)
					{
						(list as List<Rect>).Add((JSON)obj);
					}
					else if (list is List<Color>)
					{
						(list as List<Color>).Add((JSON)obj);
					}
					else if (list is List<Color32>)
					{
						(list as List<Color32>).Add((JSON)obj);
					}
					else if (list is List<Quaternion>)
					{
						(list as List<Quaternion>).Add((JSON)obj);
					}
					else if (list is List<JSON>)
					{
						(list as List<JSON>).Add((JSON)obj);
					}
				}
				return list.ToArray();
			}
			return new T[0];
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00005638 File Offset: 0x00003838
		public static implicit operator Vector2(JSON value)
		{
			return new Vector3(Convert.ToSingle(value["x"]), Convert.ToSingle(value["y"]));
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00005670 File Offset: 0x00003870
		public static explicit operator JSON(Vector2 value)
		{
			JSON json = new JSON();
			json["x"] = value.x;
			json["y"] = value.y;
			return json;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x000056B4 File Offset: 0x000038B4
		public static implicit operator Vector3(JSON value)
		{
			return new Vector3(Convert.ToSingle(value["x"]), Convert.ToSingle(value["y"]), Convert.ToSingle(value["z"]));
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000056F8 File Offset: 0x000038F8
		public static explicit operator JSON(Vector3 value)
		{
			JSON json = new JSON();
			json["x"] = value.x;
			json["y"] = value.y;
			json["z"] = value.z;
			return json;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00005754 File Offset: 0x00003954
		public static implicit operator Quaternion(JSON value)
		{
			return new Quaternion(Convert.ToSingle(value["x"]), Convert.ToSingle(value["y"]), Convert.ToSingle(value["z"]), Convert.ToSingle(value["w"]));
		}

		// Token: 0x060000EE RID: 238 RVA: 0x000057A8 File Offset: 0x000039A8
		public static explicit operator JSON(Quaternion value)
		{
			JSON json = new JSON();
			json["x"] = value.x;
			json["y"] = value.y;
			json["z"] = value.z;
			json["w"] = value.w;
			return json;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00005818 File Offset: 0x00003A18
		public static implicit operator Color(JSON value)
		{
			return new Color(Convert.ToSingle(value["r"]), Convert.ToSingle(value["g"]), Convert.ToSingle(value["b"]), Convert.ToSingle(value["a"]));
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0000586C File Offset: 0x00003A6C
		public static explicit operator JSON(Color value)
		{
			JSON json = new JSON();
			json["r"] = value.r;
			json["g"] = value.g;
			json["b"] = value.b;
			json["a"] = value.a;
			return json;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x000058DC File Offset: 0x00003ADC
		public static implicit operator Color32(JSON value)
		{
			return new Color32(Convert.ToByte(value["r"]), Convert.ToByte(value["g"]), Convert.ToByte(value["b"]), Convert.ToByte(value["a"]));
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00005930 File Offset: 0x00003B30
		public static explicit operator JSON(Color32 value)
		{
			JSON json = new JSON();
			json["r"] = value.r;
			json["g"] = value.g;
			json["b"] = value.b;
			json["a"] = value.a;
			return json;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x000059A0 File Offset: 0x00003BA0
		public static implicit operator Rect(JSON value)
		{
			return new Rect((float)Convert.ToByte(value["left"]), (float)Convert.ToByte(value["top"]), (float)Convert.ToByte(value["width"]), (float)Convert.ToByte(value["height"]));
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x000059F8 File Offset: 0x00003BF8
		public static explicit operator JSON(Rect value)
		{
			JSON json = new JSON();
			json["left"] = value.xMin;
			json["top"] = value.yMax;
			json["width"] = value.width;
			json["height"] = value.height;
			return json;
		}

		// Token: 0x040000A5 RID: 165
		public Dictionary<string, object> fields = new Dictionary<string, object>();

		// Token: 0x0200001A RID: 26
		private sealed class _JSON
		{
			// Token: 0x060000F6 RID: 246 RVA: 0x00005A70 File Offset: 0x00003C70
			public static JSON Deserialize(string json)
			{
				if (json == null)
				{
					return null;
				}
				return JSON._JSON.Parser.Parse(json);
			}

			// Token: 0x060000F7 RID: 247 RVA: 0x00005A80 File Offset: 0x00003C80
			public static string Serialize(JSON obj)
			{
				return JSON._JSON.Serializer.Serialize(obj);
			}

			// Token: 0x0200001B RID: 27
			private sealed class Parser : IDisposable
			{
				// Token: 0x060000F8 RID: 248 RVA: 0x00005A88 File Offset: 0x00003C88
				private Parser(string jsonString)
				{
					this.json = new StringReader(jsonString);
				}

				// Token: 0x060000F9 RID: 249 RVA: 0x00005A9C File Offset: 0x00003C9C
				public static JSON Parse(string jsonString)
				{
					JSON result;
					using (JSON._JSON.Parser parser = new JSON._JSON.Parser(jsonString))
					{
						result = (parser.ParseValue() as JSON);
					}
					return result;
				}

				// Token: 0x060000FA RID: 250 RVA: 0x00005AF0 File Offset: 0x00003CF0
				public void Dispose()
				{
					this.json.Dispose();
					this.json = null;
				}

				// Token: 0x060000FB RID: 251 RVA: 0x00005B04 File Offset: 0x00003D04
				private JSON ParseObject()
				{
					Dictionary<string, object> dictionary = new Dictionary<string, object>();
					JSON json = new JSON();
					json.fields = dictionary;
					this.json.Read();
					for (;;)
					{
						JSON._JSON.Parser.TOKEN nextToken = this.NextToken;
						switch (nextToken)
						{
						case JSON._JSON.Parser.TOKEN.NONE:
							goto IL_44;
						default:
							if (nextToken != JSON._JSON.Parser.TOKEN.COMMA)
							{
								string text = this.ParseString();
								if (text == null)
								{
									goto Block_2;
								}
								if (this.NextToken != JSON._JSON.Parser.TOKEN.COLON)
								{
									goto Block_3;
								}
								this.json.Read();
								dictionary[text] = this.ParseValue();
							}
							break;
						case JSON._JSON.Parser.TOKEN.CURLY_CLOSE:
							return json;
						}
					}
					IL_44:
					return null;
					Block_2:
					return null;
					Block_3:
					return null;
				}

				// Token: 0x060000FC RID: 252 RVA: 0x00005BA0 File Offset: 0x00003DA0
				private List<object> ParseArray()
				{
					List<object> list = new List<object>();
					this.json.Read();
					bool flag = true;
					while (flag)
					{
						JSON._JSON.Parser.TOKEN nextToken = this.NextToken;
						JSON._JSON.Parser.TOKEN token = nextToken;
						switch (token)
						{
						case JSON._JSON.Parser.TOKEN.SQUARED_CLOSE:
							flag = false;
							break;
						default:
						{
							if (token == JSON._JSON.Parser.TOKEN.NONE)
							{
								return null;
							}
							object item = this.ParseByToken(nextToken);
							list.Add(item);
							break;
						}
						case JSON._JSON.Parser.TOKEN.COMMA:
							break;
						}
					}
					return list;
				}

				// Token: 0x060000FD RID: 253 RVA: 0x00005C1C File Offset: 0x00003E1C
				private object ParseValue()
				{
					JSON._JSON.Parser.TOKEN nextToken = this.NextToken;
					return this.ParseByToken(nextToken);
				}

				// Token: 0x060000FE RID: 254 RVA: 0x00005C38 File Offset: 0x00003E38
				private object ParseByToken(JSON._JSON.Parser.TOKEN token)
				{
					switch (token)
					{
					case JSON._JSON.Parser.TOKEN.CURLY_OPEN:
						return this.ParseObject();
					case JSON._JSON.Parser.TOKEN.SQUARED_OPEN:
						return this.ParseArray();
					case JSON._JSON.Parser.TOKEN.STRING:
						return this.ParseString();
					case JSON._JSON.Parser.TOKEN.NUMBER:
						return this.ParseNumber();
					case JSON._JSON.Parser.TOKEN.TRUE:
						return true;
					case JSON._JSON.Parser.TOKEN.FALSE:
						return false;
					case JSON._JSON.Parser.TOKEN.NULL:
						return null;
					}
					return null;
				}

				// Token: 0x060000FF RID: 255 RVA: 0x00005CB0 File Offset: 0x00003EB0
				private string ParseString()
				{
					StringBuilder stringBuilder = new StringBuilder();
					this.json.Read();
					bool flag = true;
					while (flag)
					{
						if (this.json.Peek() == -1)
						{
							break;
						}
						char nextChar = this.NextChar;
						char c = nextChar;
						if (c != '"')
						{
							if (c != '\\')
							{
								stringBuilder.Append(nextChar);
							}
							else if (this.json.Peek() == -1)
							{
								flag = false;
							}
							else
							{
								nextChar = this.NextChar;
								char c2 = nextChar;
								switch (c2)
								{
								case 'n':
									stringBuilder.Append('\n');
									break;
								default:
									if (c2 != '"' && c2 != '/' && c2 != '\\')
									{
										if (c2 != 'b')
										{
											if (c2 == 'f')
											{
												stringBuilder.Append('\f');
											}
										}
										else
										{
											stringBuilder.Append('\b');
										}
									}
									else
									{
										stringBuilder.Append(nextChar);
									}
									break;
								case 'r':
									stringBuilder.Append('\r');
									break;
								case 't':
									stringBuilder.Append('\t');
									break;
								case 'u':
								{
									StringBuilder stringBuilder2 = new StringBuilder();
									for (int i = 0; i < 4; i++)
									{
										stringBuilder2.Append(this.NextChar);
									}
									stringBuilder.Append((char)Convert.ToInt32(stringBuilder2.ToString(), 16));
									break;
								}
								}
							}
						}
						else
						{
							flag = false;
						}
					}
					return stringBuilder.ToString();
				}

				// Token: 0x06000100 RID: 256 RVA: 0x00005E48 File Offset: 0x00004048
				private object ParseNumber()
				{
					string nextWord = this.NextWord;
					if (nextWord.IndexOf('.') == -1)
					{
						long num;
						long.TryParse(nextWord, out num);
						return num;
					}
					double num2;
					double.TryParse(nextWord, out num2);
					return num2;
				}

				// Token: 0x06000101 RID: 257 RVA: 0x00005E8C File Offset: 0x0000408C
				private void EatWhitespace()
				{
					while (" \t\n\r".IndexOf(this.PeekChar) != -1)
					{
						this.json.Read();
						if (this.json.Peek() == -1)
						{
							break;
						}
					}
				}

				// Token: 0x17000003 RID: 3
				// (get) Token: 0x06000102 RID: 258 RVA: 0x00005ED8 File Offset: 0x000040D8
				private char PeekChar
				{
					get
					{
						return Convert.ToChar(this.json.Peek());
					}
				}

				// Token: 0x17000004 RID: 4
				// (get) Token: 0x06000103 RID: 259 RVA: 0x00005EEC File Offset: 0x000040EC
				private char NextChar
				{
					get
					{
						return Convert.ToChar(this.json.Read());
					}
				}

				// Token: 0x17000005 RID: 5
				// (get) Token: 0x06000104 RID: 260 RVA: 0x00005F00 File Offset: 0x00004100
				private string NextWord
				{
					get
					{
						StringBuilder stringBuilder = new StringBuilder();
						while (" \t\n\r{}[],:\"".IndexOf(this.PeekChar) == -1)
						{
							stringBuilder.Append(this.NextChar);
							if (this.json.Peek() == -1)
							{
								break;
							}
						}
						return stringBuilder.ToString();
					}
				}

				// Token: 0x17000006 RID: 6
				// (get) Token: 0x06000105 RID: 261 RVA: 0x00005F58 File Offset: 0x00004158
				private JSON._JSON.Parser.TOKEN NextToken
				{
					get
					{
						this.EatWhitespace();
						if (this.json.Peek() == -1)
						{
							return JSON._JSON.Parser.TOKEN.NONE;
						}
						char peekChar = this.PeekChar;
						char c = peekChar;
						switch (c)
						{
						case '"':
							return JSON._JSON.Parser.TOKEN.STRING;
						default:
							switch (c)
							{
							case '[':
								return JSON._JSON.Parser.TOKEN.SQUARED_OPEN;
							default:
							{
								switch (c)
								{
								case '{':
									return JSON._JSON.Parser.TOKEN.CURLY_OPEN;
								case '}':
									this.json.Read();
									return JSON._JSON.Parser.TOKEN.CURLY_CLOSE;
								}
								string nextWord = this.NextWord;
								string text = nextWord;
								switch (text)
								{
								case "false":
									return JSON._JSON.Parser.TOKEN.FALSE;
								case "true":
									return JSON._JSON.Parser.TOKEN.TRUE;
								case "null":
									return JSON._JSON.Parser.TOKEN.NULL;
								}
								return JSON._JSON.Parser.TOKEN.NONE;
							}
							case ']':
								this.json.Read();
								return JSON._JSON.Parser.TOKEN.SQUARED_CLOSE;
							}
							break;
						case ',':
							this.json.Read();
							return JSON._JSON.Parser.TOKEN.COMMA;
						case '-':
						case '0':
						case '1':
						case '2':
						case '3':
						case '4':
						case '5':
						case '6':
						case '7':
						case '8':
						case '9':
							return JSON._JSON.Parser.TOKEN.NUMBER;
						case ':':
							return JSON._JSON.Parser.TOKEN.COLON;
						}
					}
				}

				// Token: 0x040000A6 RID: 166
				private const string WHITE_SPACE = " \t\n\r";

				// Token: 0x040000A7 RID: 167
				private const string WORD_BREAK = " \t\n\r{}[],:\"";

				// Token: 0x040000A8 RID: 168
				private StringReader json;

				// Token: 0x0200001C RID: 28
				private enum TOKEN
				{
					// Token: 0x040000AB RID: 171
					NONE,
					// Token: 0x040000AC RID: 172
					CURLY_OPEN,
					// Token: 0x040000AD RID: 173
					CURLY_CLOSE,
					// Token: 0x040000AE RID: 174
					SQUARED_OPEN,
					// Token: 0x040000AF RID: 175
					SQUARED_CLOSE,
					// Token: 0x040000B0 RID: 176
					COLON,
					// Token: 0x040000B1 RID: 177
					COMMA,
					// Token: 0x040000B2 RID: 178
					STRING,
					// Token: 0x040000B3 RID: 179
					NUMBER,
					// Token: 0x040000B4 RID: 180
					TRUE,
					// Token: 0x040000B5 RID: 181
					FALSE,
					// Token: 0x040000B6 RID: 182
					NULL
				}
			}

			// Token: 0x0200001D RID: 29
			private sealed class Serializer
			{
				// Token: 0x06000106 RID: 262 RVA: 0x000060DC File Offset: 0x000042DC
				private Serializer()
				{
					this.builder = new StringBuilder();
				}

				// Token: 0x06000107 RID: 263 RVA: 0x000060F0 File Offset: 0x000042F0
				public static string Serialize(JSON obj)
				{
					JSON._JSON.Serializer serializer = new JSON._JSON.Serializer();
					serializer.SerializeValue(obj);
					return serializer.builder.ToString();
				}

				// Token: 0x06000108 RID: 264 RVA: 0x00006118 File Offset: 0x00004318
				private void SerializeValue(object value)
				{
					if (value == null)
					{
						this.builder.Append("null");
					}
					else if (value is string)
					{
						this.SerializeString(value as string);
					}
					else if (value is bool)
					{
						this.builder.Append(value.ToString().ToLower());
					}
					else if (value is JSON)
					{
						this.SerializeObject(value as JSON);
					}
					else if (value is IDictionary)
					{
						this.SerializeDictionary(value as IDictionary);
					}
					else if (value is IList)
					{
						this.SerializeArray(value as IList);
					}
					else if (value is char)
					{
						this.SerializeString(value.ToString());
					}
					else
					{
						this.SerializeOther(value);
					}
				}

				// Token: 0x06000109 RID: 265 RVA: 0x000061FC File Offset: 0x000043FC
				private void SerializeObject(JSON obj)
				{
					this.SerializeDictionary(obj.fields);
				}

				// Token: 0x0600010A RID: 266 RVA: 0x0000620C File Offset: 0x0000440C
				private void SerializeDictionary(IDictionary obj)
				{
					bool flag = true;
					this.builder.Append('{');
					foreach (object obj2 in obj.Keys)
					{
						if (!flag)
						{
							this.builder.Append(',');
						}
						this.SerializeString(obj2.ToString());
						this.builder.Append(':');
						this.SerializeValue(obj[obj2]);
						flag = false;
					}
					this.builder.Append('}');
				}

				// Token: 0x0600010B RID: 267 RVA: 0x000062CC File Offset: 0x000044CC
				private void SerializeArray(IList anArray)
				{
					this.builder.Append('[');
					bool flag = true;
					foreach (object value in anArray)
					{
						if (!flag)
						{
							this.builder.Append(',');
						}
						this.SerializeValue(value);
						flag = false;
					}
					this.builder.Append(']');
				}

				// Token: 0x0600010C RID: 268 RVA: 0x00006368 File Offset: 0x00004568
				private void SerializeString(string str)
				{
					this.builder.Append('"');
					char[] array = str.ToCharArray();
					foreach (char c in array)
					{
						char c2 = c;
						switch (c2)
						{
						case '\b':
							this.builder.Append("\\b");
							break;
						case '\t':
							this.builder.Append("\\t");
							break;
						case '\n':
							this.builder.Append("\\n");
							break;
						default:
							if (c2 != '"')
							{
								if (c2 != '\\')
								{
									int num = Convert.ToInt32(c);
									if (num >= 32 && num <= 126)
									{
										this.builder.Append(c);
									}
									else
									{
										this.builder.Append("\\u" + Convert.ToString(num, 16).PadLeft(4, '0'));
									}
								}
								else
								{
									this.builder.Append("\\\\");
								}
							}
							else
							{
								this.builder.Append("\\\"");
							}
							break;
						case '\f':
							this.builder.Append("\\f");
							break;
						case '\r':
							this.builder.Append("\\r");
							break;
						}
					}
					this.builder.Append('"');
				}

				// Token: 0x0600010D RID: 269 RVA: 0x000064E0 File Offset: 0x000046E0
				private void SerializeOther(object value)
				{
					if (value is float || value is int || value is uint || value is long || value is double || value is sbyte || value is byte || value is short || value is ushort || value is ulong || value is decimal)
					{
						this.builder.Append(value.ToString());
					}
					else
					{
						this.SerializeString(value.ToString());
					}
				}

				// Token: 0x040000B7 RID: 183
				private StringBuilder builder;
			}
		}
	}
}
