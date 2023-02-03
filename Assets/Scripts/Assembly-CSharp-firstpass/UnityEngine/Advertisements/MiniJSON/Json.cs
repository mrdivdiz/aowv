using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace UnityEngine.Advertisements.MiniJSON
{
	// Token: 0x02000031 RID: 49
	public static class Json
	{
		// Token: 0x060001FE RID: 510 RVA: 0x00008880 File Offset: 0x00006A80
		public static object Deserialize(string json)
		{
			if (json == null)
			{
				return null;
			}
			return Json.Parser.Parse(json);
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00008890 File Offset: 0x00006A90
		public static string Serialize(object obj)
		{
			return Json.Serializer.Serialize(obj);
		}

		// Token: 0x02000032 RID: 50
		private sealed class Parser : IDisposable
		{
			// Token: 0x06000200 RID: 512 RVA: 0x00008898 File Offset: 0x00006A98
			private Parser(string jsonString)
			{
				this.json = new StringReader(jsonString);
			}

			// Token: 0x06000201 RID: 513 RVA: 0x000088AC File Offset: 0x00006AAC
			public static bool IsWordBreak(char c)
			{
				return char.IsWhiteSpace(c) || "{}[],:\"".IndexOf(c) != -1;
			}

			// Token: 0x06000202 RID: 514 RVA: 0x000088D0 File Offset: 0x00006AD0
			public static object Parse(string jsonString)
			{
				object result;
				using (Json.Parser parser = new Json.Parser(jsonString))
				{
					result = parser.ParseValue();
				}
				return result;
			}

			// Token: 0x06000203 RID: 515 RVA: 0x00008920 File Offset: 0x00006B20
			public void Dispose()
			{
				this.json.Dispose();
				this.json = null;
			}

			// Token: 0x06000204 RID: 516 RVA: 0x00008934 File Offset: 0x00006B34
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

			// Token: 0x06000205 RID: 517 RVA: 0x000089C0 File Offset: 0x00006BC0
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

			// Token: 0x06000206 RID: 518 RVA: 0x00008A3C File Offset: 0x00006C3C
			private object ParseValue()
			{
				Json.Parser.TOKEN nextToken = this.NextToken;
				return this.ParseByToken(nextToken);
			}

			// Token: 0x06000207 RID: 519 RVA: 0x00008A58 File Offset: 0x00006C58
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

			// Token: 0x06000208 RID: 520 RVA: 0x00008AD0 File Offset: 0x00006CD0
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
								char[] array = new char[4];
								for (int i = 0; i < 4; i++)
								{
									array[i] = this.NextChar;
								}
								stringBuilder.Append((char)Convert.ToInt32(new string(array), 16));
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

			// Token: 0x06000209 RID: 521 RVA: 0x00008C68 File Offset: 0x00006E68
			private object ParseNumber()
			{
				string nextWord = this.NextWord;
				if (nextWord.IndexOf('.') == -1)
				{
					long num;
					long.TryParse(nextWord, NumberStyles.Any, CultureInfo.InvariantCulture, out num);
					return num;
				}
				double num2;
				double.TryParse(nextWord, NumberStyles.Any, CultureInfo.InvariantCulture, out num2);
				return num2;
			}

			// Token: 0x0600020A RID: 522 RVA: 0x00008CC0 File Offset: 0x00006EC0
			private void EatWhitespace()
			{
				while (char.IsWhiteSpace(this.PeekChar))
				{
					this.json.Read();
					if (this.json.Peek() == -1)
					{
						break;
					}
				}
			}

			// Token: 0x17000040 RID: 64
			// (get) Token: 0x0600020B RID: 523 RVA: 0x00008CFC File Offset: 0x00006EFC
			private char PeekChar
			{
				get
				{
					return Convert.ToChar(this.json.Peek());
				}
			}

			// Token: 0x17000041 RID: 65
			// (get) Token: 0x0600020C RID: 524 RVA: 0x00008D10 File Offset: 0x00006F10
			private char NextChar
			{
				get
				{
					return Convert.ToChar(this.json.Read());
				}
			}

			// Token: 0x17000042 RID: 66
			// (get) Token: 0x0600020D RID: 525 RVA: 0x00008D24 File Offset: 0x00006F24
			private string NextWord
			{
				get
				{
					StringBuilder stringBuilder = new StringBuilder();
					while (!Json.Parser.IsWordBreak(this.PeekChar))
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

			// Token: 0x17000043 RID: 67
			// (get) Token: 0x0600020E RID: 526 RVA: 0x00008D78 File Offset: 0x00006F78
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
					switch (peekChar)
					{
					case '"':
						return Json.Parser.TOKEN.STRING;
					default:
						switch (peekChar)
						{
						case '[':
							return Json.Parser.TOKEN.SQUARED_OPEN;
						default:
						{
							switch (peekChar)
							{
							case '{':
								return Json.Parser.TOKEN.CURLY_OPEN;
							case '}':
								this.json.Read();
								return Json.Parser.TOKEN.CURLY_CLOSE;
							}
							string nextWord = this.NextWord;
							switch (nextWord)
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

			// Token: 0x04000108 RID: 264
			private const string WORD_BREAK = "{}[],:\"";

			// Token: 0x04000109 RID: 265
			private StringReader json;

			// Token: 0x02000033 RID: 51
			private enum TOKEN
			{
				// Token: 0x0400010C RID: 268
				NONE,
				// Token: 0x0400010D RID: 269
				CURLY_OPEN,
				// Token: 0x0400010E RID: 270
				CURLY_CLOSE,
				// Token: 0x0400010F RID: 271
				SQUARED_OPEN,
				// Token: 0x04000110 RID: 272
				SQUARED_CLOSE,
				// Token: 0x04000111 RID: 273
				COLON,
				// Token: 0x04000112 RID: 274
				COMMA,
				// Token: 0x04000113 RID: 275
				STRING,
				// Token: 0x04000114 RID: 276
				NUMBER,
				// Token: 0x04000115 RID: 277
				TRUE,
				// Token: 0x04000116 RID: 278
				FALSE,
				// Token: 0x04000117 RID: 279
				NULL
			}
		}

		// Token: 0x02000034 RID: 52
		private sealed class Serializer
		{
			// Token: 0x0600020F RID: 527 RVA: 0x00008EF0 File Offset: 0x000070F0
			private Serializer()
			{
				this.builder = new StringBuilder();
			}

			// Token: 0x06000210 RID: 528 RVA: 0x00008F04 File Offset: 0x00007104
			public static string Serialize(object obj)
			{
				Json.Serializer serializer = new Json.Serializer();
				serializer.SerializeValue(obj);
				return serializer.builder.ToString();
			}

			// Token: 0x06000211 RID: 529 RVA: 0x00008F2C File Offset: 0x0000712C
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
					this.builder.Append((!(bool)value) ? "false" : "true");
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
					this.SerializeString(new string((char)value, 1));
				}
				else
				{
					this.SerializeOther(value);
				}
			}

			// Token: 0x06000212 RID: 530 RVA: 0x00009000 File Offset: 0x00007200
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

			// Token: 0x06000213 RID: 531 RVA: 0x000090C0 File Offset: 0x000072C0
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

			// Token: 0x06000214 RID: 532 RVA: 0x0000915C File Offset: 0x0000735C
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
									this.builder.Append("\\u");
									this.builder.Append(num.ToString("x4"));
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

			// Token: 0x06000215 RID: 533 RVA: 0x000092D8 File Offset: 0x000074D8
			private void SerializeOther(object value)
			{
				if (value is float)
				{
					this.builder.Append(((float)value).ToString("R", CultureInfo.InvariantCulture));
				}
				else if (value is int || value is uint || value is long || value is sbyte || value is byte || value is short || value is ushort || value is ulong)
				{
					this.builder.Append(value);
				}
				else if (value is double || value is decimal)
				{
					this.builder.Append(Convert.ToDouble(value).ToString("R", CultureInfo.InvariantCulture));
				}
				else
				{
					this.SerializeString(value.ToString());
				}
			}

			// Token: 0x04000118 RID: 280
			private StringBuilder builder;
		}
	}
}
