using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace Spine
{
	// Token: 0x02000127 RID: 295
	public static class Json
	{
		// Token: 0x060008AB RID: 2219 RVA: 0x000279E0 File Offset: 0x00025BE0
		public static object Deserialize(TextReader json)
		{
			if (json == null)
			{
				return null;
			}
			return Json.Parser.Parse(json);
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x000279F0 File Offset: 0x00025BF0
		public static string Serialize(object obj)
		{
			return Json.Serializer.Serialize(obj);
		}

		// Token: 0x02000128 RID: 296
		private sealed class Parser : IDisposable
		{
			// Token: 0x060008AD RID: 2221 RVA: 0x000279F8 File Offset: 0x00025BF8
			private Parser(TextReader reader)
			{
				this.json = reader;
			}

			// Token: 0x060008AE RID: 2222 RVA: 0x00027A08 File Offset: 0x00025C08
			public static object Parse(TextReader reader)
			{
				object result;
				using (Json.Parser parser = new Json.Parser(reader))
				{
					result = parser.ParseValue();
				}
				return result;
			}

			// Token: 0x060008AF RID: 2223 RVA: 0x00027A58 File Offset: 0x00025C58
			public void Dispose()
			{
				this.json.Dispose();
				this.json = null;
			}

			// Token: 0x060008B0 RID: 2224 RVA: 0x00027A6C File Offset: 0x00025C6C
			private Dictionary<string, object> ParseObject()
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				this.json.Read();
				for (;;)
				{
					Json.Parser.TOKEN nextToken = this.NextToken;
					switch (nextToken)
					{
					case Json.Parser.TOKEN.NONE:
						goto IL_37;
					default:
						if (nextToken != Json.Parser.TOKEN.COMMA)
						{
							string text = this.ParseString();
							if (text == null)
							{
								goto Block_2;
							}
							if (this.NextToken != Json.Parser.TOKEN.COLON)
							{
								goto Block_3;
							}
							this.json.Read();
							dictionary[text] = this.ParseValue();
						}
						break;
					case Json.Parser.TOKEN.CURLY_CLOSE:
						return dictionary;
					}
				}
				IL_37:
				return null;
				Block_2:
				return null;
				Block_3:
				return null;
			}

			// Token: 0x060008B1 RID: 2225 RVA: 0x00027AF8 File Offset: 0x00025CF8
			private List<object> ParseArray()
			{
				List<object> list = new List<object>();
				this.json.Read();
				bool flag = true;
				while (flag)
				{
					Json.Parser.TOKEN nextToken = this.NextToken;
					Json.Parser.TOKEN token = nextToken;
					switch (token)
					{
					case Json.Parser.TOKEN.SQUARED_CLOSE:
						flag = false;
						break;
					default:
					{
						if (token == Json.Parser.TOKEN.NONE)
						{
							return null;
						}
						object item = this.ParseByToken(nextToken);
						list.Add(item);
						break;
					}
					case Json.Parser.TOKEN.COMMA:
						break;
					}
				}
				return list;
			}

			// Token: 0x060008B2 RID: 2226 RVA: 0x00027B74 File Offset: 0x00025D74
			private object ParseValue()
			{
				Json.Parser.TOKEN nextToken = this.NextToken;
				return this.ParseByToken(nextToken);
			}

			// Token: 0x060008B3 RID: 2227 RVA: 0x00027B90 File Offset: 0x00025D90
			private object ParseByToken(Json.Parser.TOKEN token)
			{
				switch (token)
				{
				case Json.Parser.TOKEN.CURLY_OPEN:
					return this.ParseObject();
				case Json.Parser.TOKEN.SQUARED_OPEN:
					return this.ParseArray();
				case Json.Parser.TOKEN.STRING:
					return this.ParseString();
				case Json.Parser.TOKEN.NUMBER:
					return this.ParseNumber();
				case Json.Parser.TOKEN.TRUE:
					return true;
				case Json.Parser.TOKEN.FALSE:
					return false;
				case Json.Parser.TOKEN.NULL:
					return null;
				}
				return null;
			}

			// Token: 0x060008B4 RID: 2228 RVA: 0x00027C08 File Offset: 0x00025E08
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

			// Token: 0x060008B5 RID: 2229 RVA: 0x00027DA0 File Offset: 0x00025FA0
			private object ParseNumber()
			{
				string nextWord = this.NextWord;
				float num;
				float.TryParse(nextWord, NumberStyles.Float, CultureInfo.InvariantCulture, out num);
				return num;
			}

			// Token: 0x060008B6 RID: 2230 RVA: 0x00027DD0 File Offset: 0x00025FD0
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

			// Token: 0x17000113 RID: 275
			// (get) Token: 0x060008B7 RID: 2231 RVA: 0x00027E1C File Offset: 0x0002601C
			private char PeekChar
			{
				get
				{
					return Convert.ToChar(this.json.Peek());
				}
			}

			// Token: 0x17000114 RID: 276
			// (get) Token: 0x060008B8 RID: 2232 RVA: 0x00027E30 File Offset: 0x00026030
			private char NextChar
			{
				get
				{
					return Convert.ToChar(this.json.Read());
				}
			}

			// Token: 0x17000115 RID: 277
			// (get) Token: 0x060008B9 RID: 2233 RVA: 0x00027E44 File Offset: 0x00026044
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

			// Token: 0x17000116 RID: 278
			// (get) Token: 0x060008BA RID: 2234 RVA: 0x00027E9C File Offset: 0x0002609C
			private Json.Parser.TOKEN NextToken
			{
				get
				{
					this.EatWhitespace();
					if (this.json.Peek() == -1)
					{
						return Json.Parser.TOKEN.NONE;
					}
					char peekChar = this.PeekChar;
					char c = peekChar;
					switch (c)
					{
					case '"':
						return Json.Parser.TOKEN.STRING;
					default:
						switch (c)
						{
						case '[':
							return Json.Parser.TOKEN.SQUARED_OPEN;
						default:
						{
							switch (c)
							{
							case '{':
								return Json.Parser.TOKEN.CURLY_OPEN;
							case '}':
								this.json.Read();
								return Json.Parser.TOKEN.CURLY_CLOSE;
							}
							string nextWord = this.NextWord;
							string text = nextWord;
							switch (text)
							{
							case "false":
								return Json.Parser.TOKEN.FALSE;
							case "true":
								return Json.Parser.TOKEN.TRUE;
							case "null":
								return Json.Parser.TOKEN.NULL;
							}
							return Json.Parser.TOKEN.NONE;
						}
						case ']':
							this.json.Read();
							return Json.Parser.TOKEN.SQUARED_CLOSE;
						}
						break;
					case ',':
						this.json.Read();
						return Json.Parser.TOKEN.COMMA;
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
						return Json.Parser.TOKEN.NUMBER;
					case ':':
						return Json.Parser.TOKEN.COLON;
					}
				}
			}

			// Token: 0x040005A9 RID: 1449
			private const string WHITE_SPACE = " \t\n\r";

			// Token: 0x040005AA RID: 1450
			private const string WORD_BREAK = " \t\n\r{}[],:\"";

			// Token: 0x040005AB RID: 1451
			private TextReader json;

			// Token: 0x02000129 RID: 297
			private enum TOKEN
			{
				// Token: 0x040005AE RID: 1454
				NONE,
				// Token: 0x040005AF RID: 1455
				CURLY_OPEN,
				// Token: 0x040005B0 RID: 1456
				CURLY_CLOSE,
				// Token: 0x040005B1 RID: 1457
				SQUARED_OPEN,
				// Token: 0x040005B2 RID: 1458
				SQUARED_CLOSE,
				// Token: 0x040005B3 RID: 1459
				COLON,
				// Token: 0x040005B4 RID: 1460
				COMMA,
				// Token: 0x040005B5 RID: 1461
				STRING,
				// Token: 0x040005B6 RID: 1462
				NUMBER,
				// Token: 0x040005B7 RID: 1463
				TRUE,
				// Token: 0x040005B8 RID: 1464
				FALSE,
				// Token: 0x040005B9 RID: 1465
				NULL
			}
		}

		// Token: 0x0200012A RID: 298
		private sealed class Serializer
		{
			// Token: 0x060008BB RID: 2235 RVA: 0x00028020 File Offset: 0x00026220
			private Serializer()
			{
				this.builder = new StringBuilder();
			}

			// Token: 0x060008BC RID: 2236 RVA: 0x00028034 File Offset: 0x00026234
			public static string Serialize(object obj)
			{
				Json.Serializer serializer = new Json.Serializer();
				serializer.SerializeValue(obj);
				return serializer.builder.ToString();
			}

			// Token: 0x060008BD RID: 2237 RVA: 0x0002805C File Offset: 0x0002625C
			private void SerializeValue(object value)
			{
				string str;
				IList anArray;
				IDictionary obj;
				if (value == null)
				{
					this.builder.Append("null");
				}
				else if ((str = (value as string)) != null)
				{
					this.SerializeString(str);
				}
				else if (value is bool)
				{
					this.builder.Append(value.ToString().ToLower());
				}
				else if ((anArray = (value as IList)) != null)
				{
					this.SerializeArray(anArray);
				}
				else if ((obj = (value as IDictionary)) != null)
				{
					this.SerializeObject(obj);
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

			// Token: 0x060008BE RID: 2238 RVA: 0x0002811C File Offset: 0x0002631C
			private void SerializeObject(IDictionary obj)
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

			// Token: 0x060008BF RID: 2239 RVA: 0x000281DC File Offset: 0x000263DC
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

			// Token: 0x060008C0 RID: 2240 RVA: 0x00028278 File Offset: 0x00026478
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

			// Token: 0x060008C1 RID: 2241 RVA: 0x000283F0 File Offset: 0x000265F0
			private void SerializeOther(object value)
			{
				if (value is float || value is int || value is uint || value is long || value is float || value is sbyte || value is byte || value is short || value is ushort || value is ulong || value is decimal)
				{
					this.builder.Append(value.ToString());
				}
				else
				{
					this.SerializeString(value.ToString());
				}
			}

			// Token: 0x040005BA RID: 1466
			private StringBuilder builder;
		}
	}
}
