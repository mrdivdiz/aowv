using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using UnityEngine;

// Token: 0x020000BC RID: 188
public class JSONObject
{
	// Token: 0x06000513 RID: 1299 RVA: 0x0000B2C4 File Offset: 0x000094C4
	public JSONObject(JSONObject.Type t)
	{
		this.type = t;
		if (t != JSONObject.Type.OBJECT)
		{
			if (t == JSONObject.Type.ARRAY)
			{
				this.list = new List<JSONObject>();
			}
		}
		else
		{
			this.list = new List<JSONObject>();
			this.keys = new List<string>();
		}
	}

	// Token: 0x06000514 RID: 1300 RVA: 0x0000B320 File Offset: 0x00009520
	public JSONObject(bool b)
	{
		this.type = JSONObject.Type.BOOL;
		this.b = b;
	}

	// Token: 0x06000515 RID: 1301 RVA: 0x0000B338 File Offset: 0x00009538
	public JSONObject(float f)
	{
		this.type = JSONObject.Type.NUMBER;
		this.n = f;
	}

	// Token: 0x06000516 RID: 1302 RVA: 0x0000B350 File Offset: 0x00009550
	public JSONObject(Dictionary<string, string> dic)
	{
		this.type = JSONObject.Type.OBJECT;
		this.keys = new List<string>();
		this.list = new List<JSONObject>();
		foreach (KeyValuePair<string, string> keyValuePair in dic)
		{
			this.keys.Add(keyValuePair.Key);
			this.list.Add(JSONObject.CreateStringObject(keyValuePair.Value));
		}
	}

	// Token: 0x06000517 RID: 1303 RVA: 0x0000B3F8 File Offset: 0x000095F8
	public JSONObject(Dictionary<string, JSONObject> dic)
	{
		this.type = JSONObject.Type.OBJECT;
		this.keys = new List<string>();
		this.list = new List<JSONObject>();
		foreach (KeyValuePair<string, JSONObject> keyValuePair in dic)
		{
			this.keys.Add(keyValuePair.Key);
			this.list.Add(keyValuePair.Value);
		}
	}

	// Token: 0x06000518 RID: 1304 RVA: 0x0000B49C File Offset: 0x0000969C
	public JSONObject(JSONObject.AddJSONConents content)
	{
		content(this);
	}

	// Token: 0x06000519 RID: 1305 RVA: 0x0000B4AC File Offset: 0x000096AC
	public JSONObject(JSONObject[] objs)
	{
		this.type = JSONObject.Type.ARRAY;
		this.list = new List<JSONObject>(objs);
	}

	// Token: 0x0600051A RID: 1306 RVA: 0x0000B4C8 File Offset: 0x000096C8
	public JSONObject()
	{
	}

	// Token: 0x0600051B RID: 1307 RVA: 0x0000B4D0 File Offset: 0x000096D0
	public JSONObject(string str, int maxDepth = -2, bool storeExcessLevels = false, bool strict = false)
	{
		this.Parse(str, maxDepth, storeExcessLevels, strict);
	}

	// Token: 0x17000052 RID: 82
	// (get) Token: 0x0600051D RID: 1309 RVA: 0x0000B514 File Offset: 0x00009714
	public bool isContainer
	{
		get
		{
			return this.type == JSONObject.Type.ARRAY || this.type == JSONObject.Type.OBJECT;
		}
	}

	// Token: 0x17000053 RID: 83
	// (get) Token: 0x0600051E RID: 1310 RVA: 0x0000B530 File Offset: 0x00009730
	public int Count
	{
		get
		{
			if (this.list == null)
			{
				return -1;
			}
			return this.list.Count;
		}
	}

	// Token: 0x17000054 RID: 84
	// (get) Token: 0x0600051F RID: 1311 RVA: 0x0000B54C File Offset: 0x0000974C
	public float f
	{
		get
		{
			return this.n;
		}
	}

	// Token: 0x17000055 RID: 85
	// (get) Token: 0x06000520 RID: 1312 RVA: 0x0000B554 File Offset: 0x00009754
	public static JSONObject nullJO
	{
		get
		{
			return JSONObject.Create(JSONObject.Type.NULL);
		}
	}

	// Token: 0x17000056 RID: 86
	// (get) Token: 0x06000521 RID: 1313 RVA: 0x0000B55C File Offset: 0x0000975C
	public static JSONObject obj
	{
		get
		{
			return JSONObject.Create(JSONObject.Type.OBJECT);
		}
	}

	// Token: 0x17000057 RID: 87
	// (get) Token: 0x06000522 RID: 1314 RVA: 0x0000B564 File Offset: 0x00009764
	public static JSONObject arr
	{
		get
		{
			return JSONObject.Create(JSONObject.Type.ARRAY);
		}
	}

	// Token: 0x06000523 RID: 1315 RVA: 0x0000B56C File Offset: 0x0000976C
	public static JSONObject StringObject(string val)
	{
		return JSONObject.CreateStringObject(val);
	}

	// Token: 0x06000524 RID: 1316 RVA: 0x0000B574 File Offset: 0x00009774
	public void Absorb(JSONObject obj)
	{
		this.list.AddRange(obj.list);
		this.keys.AddRange(obj.keys);
		this.str = obj.str;
		this.n = obj.n;
		this.b = obj.b;
		this.type = obj.type;
	}

	// Token: 0x06000525 RID: 1317 RVA: 0x0000B5D4 File Offset: 0x000097D4
	public static JSONObject Create()
	{
		return new JSONObject();
	}

	// Token: 0x06000526 RID: 1318 RVA: 0x0000B5DC File Offset: 0x000097DC
	public static JSONObject Create(JSONObject.Type t)
	{
		JSONObject jsonobject = JSONObject.Create();
		jsonobject.type = t;
		if (t != JSONObject.Type.OBJECT)
		{
			if (t == JSONObject.Type.ARRAY)
			{
				jsonobject.list = new List<JSONObject>();
			}
		}
		else
		{
			jsonobject.list = new List<JSONObject>();
			jsonobject.keys = new List<string>();
		}
		return jsonobject;
	}

	// Token: 0x06000527 RID: 1319 RVA: 0x0000B638 File Offset: 0x00009838
	public static JSONObject Create(bool val)
	{
		JSONObject jsonobject = JSONObject.Create();
		jsonobject.type = JSONObject.Type.BOOL;
		jsonobject.b = val;
		return jsonobject;
	}

	// Token: 0x06000528 RID: 1320 RVA: 0x0000B65C File Offset: 0x0000985C
	public static JSONObject Create(float val)
	{
		JSONObject jsonobject = JSONObject.Create();
		jsonobject.type = JSONObject.Type.NUMBER;
		jsonobject.n = val;
		return jsonobject;
	}

	// Token: 0x06000529 RID: 1321 RVA: 0x0000B680 File Offset: 0x00009880
	public static JSONObject Create(int val)
	{
		JSONObject jsonobject = JSONObject.Create();
		jsonobject.type = JSONObject.Type.NUMBER;
		jsonobject.n = (float)val;
		return jsonobject;
	}

	// Token: 0x0600052A RID: 1322 RVA: 0x0000B6A4 File Offset: 0x000098A4
	public static JSONObject CreateStringObject(string val)
	{
		JSONObject jsonobject = JSONObject.Create();
		jsonobject.type = JSONObject.Type.STRING;
		jsonobject.str = val;
		return jsonobject;
	}

	// Token: 0x0600052B RID: 1323 RVA: 0x0000B6C8 File Offset: 0x000098C8
	public static JSONObject CreateBakedObject(string val)
	{
		JSONObject jsonobject = JSONObject.Create();
		jsonobject.type = JSONObject.Type.BAKED;
		jsonobject.str = val;
		return jsonobject;
	}

	// Token: 0x0600052C RID: 1324 RVA: 0x0000B6EC File Offset: 0x000098EC
	public static JSONObject Create(string val, int maxDepth = -2, bool storeExcessLevels = false, bool strict = false)
	{
		JSONObject jsonobject = JSONObject.Create();
		jsonobject.Parse(val, maxDepth, storeExcessLevels, strict);
		return jsonobject;
	}

	// Token: 0x0600052D RID: 1325 RVA: 0x0000B70C File Offset: 0x0000990C
	public static JSONObject Create(JSONObject.AddJSONConents content)
	{
		JSONObject jsonobject = JSONObject.Create();
		content(jsonobject);
		return jsonobject;
	}

	// Token: 0x0600052E RID: 1326 RVA: 0x0000B728 File Offset: 0x00009928
	public static JSONObject Create(Dictionary<string, string> dic)
	{
		JSONObject jsonobject = JSONObject.Create();
		jsonobject.type = JSONObject.Type.OBJECT;
		jsonobject.keys = new List<string>();
		jsonobject.list = new List<JSONObject>();
		foreach (KeyValuePair<string, string> keyValuePair in dic)
		{
			jsonobject.keys.Add(keyValuePair.Key);
			jsonobject.list.Add(JSONObject.CreateStringObject(keyValuePair.Value));
		}
		return jsonobject;
	}

	// Token: 0x0600052F RID: 1327 RVA: 0x0000B7D0 File Offset: 0x000099D0
	private void Parse(string str, int maxDepth = -2, bool storeExcessLevels = false, bool strict = false)
	{
		if (!string.IsNullOrEmpty(str))
		{
			str = str.Trim(JSONObject.WHITESPACE);
			if (strict && str[0] != '[' && str[0] != '{')
			{
				this.type = JSONObject.Type.NULL;
				UnityEngine.Debug.LogWarning("Improper (strict) JSON formatting.  First character must be [ or {");
				return;
			}
			if (str.Length > 0)
			{
				if (string.Compare(str, "true", true) == 0)
				{
					this.type = JSONObject.Type.BOOL;
					this.b = true;
				}
				else if (string.Compare(str, "false", true) == 0)
				{
					this.type = JSONObject.Type.BOOL;
					this.b = false;
				}
				else if (string.Compare(str, "null", true) == 0)
				{
					this.type = JSONObject.Type.NULL;
				}
				else if (str == "\"INFINITY\"")
				{
					this.type = JSONObject.Type.NUMBER;
					this.n = float.PositiveInfinity;
				}
				else if (str == "\"NEGINFINITY\"")
				{
					this.type = JSONObject.Type.NUMBER;
					this.n = float.NegativeInfinity;
				}
				else if (str == "\"NaN\"")
				{
					this.type = JSONObject.Type.NUMBER;
					this.n = float.NaN;
				}
				else if (str[0] == '"')
				{
					this.type = JSONObject.Type.STRING;
					this.str = str.Substring(1, str.Length - 2);
				}
				else
				{
					int num = 1;
					int num2 = 0;
					char c = str[num2];
					if (c != '[')
					{
						if (c != '{')
						{
							try
							{
								this.n = Convert.ToSingle(str);
								this.type = JSONObject.Type.NUMBER;
							}
							catch (FormatException)
							{
								this.type = JSONObject.Type.NULL;
								UnityEngine.Debug.LogWarning("improper JSON formatting:" + str);
							}
							return;
						}
						this.type = JSONObject.Type.OBJECT;
						this.keys = new List<string>();
						this.list = new List<JSONObject>();
					}
					else
					{
						this.type = JSONObject.Type.ARRAY;
						this.list = new List<JSONObject>();
					}
					string item = string.Empty;
					bool flag = false;
					bool flag2 = false;
					int num3 = 0;
					while (++num2 < str.Length)
					{
						if (Array.IndexOf<char>(JSONObject.WHITESPACE, str[num2]) <= -1)
						{
							if (str[num2] == '\\')
							{
								num2++;
							}
							else
							{
								if (str[num2] == '"')
								{
									if (flag)
									{
										if (!flag2 && num3 == 0 && this.type == JSONObject.Type.OBJECT)
										{
											item = str.Substring(num + 1, num2 - num - 1);
										}
										flag = false;
									}
									else
									{
										if (num3 == 0 && this.type == JSONObject.Type.OBJECT)
										{
											num = num2;
										}
										flag = true;
									}
								}
								if (!flag)
								{
									if (this.type == JSONObject.Type.OBJECT && num3 == 0 && str[num2] == ':')
									{
										num = num2 + 1;
										flag2 = true;
									}
									if (str[num2] == '[' || str[num2] == '{')
									{
										num3++;
									}
									else if (str[num2] == ']' || str[num2] == '}')
									{
										num3--;
									}
									if ((str[num2] == ',' && num3 == 0) || num3 < 0)
									{
										flag2 = false;
										string text = str.Substring(num, num2 - num).Trim(JSONObject.WHITESPACE);
										if (text.Length > 0)
										{
											if (this.type == JSONObject.Type.OBJECT)
											{
												this.keys.Add(item);
											}
											if (maxDepth != -1)
											{
												this.list.Add(JSONObject.Create(text, (maxDepth >= -1) ? (maxDepth - 1) : -2, false, false));
											}
											else if (storeExcessLevels)
											{
												this.list.Add(JSONObject.CreateBakedObject(text));
											}
										}
										num = num2 + 1;
									}
								}
							}
						}
					}
				}
			}
			else
			{
				this.type = JSONObject.Type.NULL;
			}
		}
		else
		{
			this.type = JSONObject.Type.NULL;
		}
	}

	// Token: 0x17000058 RID: 88
	// (get) Token: 0x06000530 RID: 1328 RVA: 0x0000BBDC File Offset: 0x00009DDC
	public bool IsNumber
	{
		get
		{
			return this.type == JSONObject.Type.NUMBER;
		}
	}

	// Token: 0x17000059 RID: 89
	// (get) Token: 0x06000531 RID: 1329 RVA: 0x0000BBE8 File Offset: 0x00009DE8
	public bool IsNull
	{
		get
		{
			return this.type == JSONObject.Type.NULL;
		}
	}

	// Token: 0x1700005A RID: 90
	// (get) Token: 0x06000532 RID: 1330 RVA: 0x0000BBF4 File Offset: 0x00009DF4
	public bool IsString
	{
		get
		{
			return this.type == JSONObject.Type.STRING;
		}
	}

	// Token: 0x1700005B RID: 91
	// (get) Token: 0x06000533 RID: 1331 RVA: 0x0000BC00 File Offset: 0x00009E00
	public bool IsBool
	{
		get
		{
			return this.type == JSONObject.Type.BOOL;
		}
	}

	// Token: 0x1700005C RID: 92
	// (get) Token: 0x06000534 RID: 1332 RVA: 0x0000BC0C File Offset: 0x00009E0C
	public bool IsArray
	{
		get
		{
			return this.type == JSONObject.Type.ARRAY;
		}
	}

	// Token: 0x1700005D RID: 93
	// (get) Token: 0x06000535 RID: 1333 RVA: 0x0000BC18 File Offset: 0x00009E18
	public bool IsObject
	{
		get
		{
			return this.type == JSONObject.Type.OBJECT || this.type == JSONObject.Type.BAKED;
		}
	}

	// Token: 0x06000536 RID: 1334 RVA: 0x0000BC34 File Offset: 0x00009E34
	public void Add(bool val)
	{
		this.Add(JSONObject.Create(val));
	}

	// Token: 0x06000537 RID: 1335 RVA: 0x0000BC44 File Offset: 0x00009E44
	public void Add(float val)
	{
		this.Add(JSONObject.Create(val));
	}

	// Token: 0x06000538 RID: 1336 RVA: 0x0000BC54 File Offset: 0x00009E54
	public void Add(int val)
	{
		this.Add(JSONObject.Create(val));
	}

	// Token: 0x06000539 RID: 1337 RVA: 0x0000BC64 File Offset: 0x00009E64
	public void Add(string str)
	{
		this.Add(JSONObject.CreateStringObject(str));
	}

	// Token: 0x0600053A RID: 1338 RVA: 0x0000BC74 File Offset: 0x00009E74
	public void Add(JSONObject.AddJSONConents content)
	{
		this.Add(JSONObject.Create(content));
	}

	// Token: 0x0600053B RID: 1339 RVA: 0x0000BC84 File Offset: 0x00009E84
	public void Add(JSONObject obj)
	{
		if (obj)
		{
			if (this.type != JSONObject.Type.ARRAY)
			{
				this.type = JSONObject.Type.ARRAY;
				if (this.list == null)
				{
					this.list = new List<JSONObject>();
				}
			}
			this.list.Add(obj);
		}
	}

	// Token: 0x0600053C RID: 1340 RVA: 0x0000BCD4 File Offset: 0x00009ED4
	public void AddField(string name, bool val)
	{
		this.AddField(name, JSONObject.Create(val));
	}

	// Token: 0x0600053D RID: 1341 RVA: 0x0000BCE4 File Offset: 0x00009EE4
	public void AddField(string name, float val)
	{
		this.AddField(name, JSONObject.Create(val));
	}

	// Token: 0x0600053E RID: 1342 RVA: 0x0000BCF4 File Offset: 0x00009EF4
	public void AddField(string name, int val)
	{
		this.AddField(name, JSONObject.Create(val));
	}

	// Token: 0x0600053F RID: 1343 RVA: 0x0000BD04 File Offset: 0x00009F04
	public void AddField(string name, JSONObject.AddJSONConents content)
	{
		this.AddField(name, JSONObject.Create(content));
	}

	// Token: 0x06000540 RID: 1344 RVA: 0x0000BD14 File Offset: 0x00009F14
	public void AddField(string name, string val)
	{
		this.AddField(name, JSONObject.CreateStringObject(val));
	}

	// Token: 0x06000541 RID: 1345 RVA: 0x0000BD24 File Offset: 0x00009F24
	public void AddField(string name, JSONObject obj)
	{
		if (obj)
		{
			if (this.type != JSONObject.Type.OBJECT)
			{
				if (this.keys == null)
				{
					this.keys = new List<string>();
				}
				if (this.type == JSONObject.Type.ARRAY)
				{
					for (int i = 0; i < this.list.Count; i++)
					{
						this.keys.Add(i + string.Empty);
					}
				}
				else if (this.list == null)
				{
					this.list = new List<JSONObject>();
				}
				this.type = JSONObject.Type.OBJECT;
			}
			this.keys.Add(name);
			this.list.Add(obj);
		}
	}

	// Token: 0x06000542 RID: 1346 RVA: 0x0000BDDC File Offset: 0x00009FDC
	public void SetField(string name, string val)
	{
		this.SetField(name, JSONObject.CreateStringObject(val));
	}

	// Token: 0x06000543 RID: 1347 RVA: 0x0000BDEC File Offset: 0x00009FEC
	public void SetField(string name, bool val)
	{
		this.SetField(name, JSONObject.Create(val));
	}

	// Token: 0x06000544 RID: 1348 RVA: 0x0000BDFC File Offset: 0x00009FFC
	public void SetField(string name, float val)
	{
		this.SetField(name, JSONObject.Create(val));
	}

	// Token: 0x06000545 RID: 1349 RVA: 0x0000BE0C File Offset: 0x0000A00C
	public void SetField(string name, int val)
	{
		this.SetField(name, JSONObject.Create(val));
	}

	// Token: 0x06000546 RID: 1350 RVA: 0x0000BE1C File Offset: 0x0000A01C
	public void SetField(string name, JSONObject obj)
	{
		if (this.HasField(name))
		{
			this.list.Remove(this[name]);
			this.keys.Remove(name);
		}
		this.AddField(name, obj);
	}

	// Token: 0x06000547 RID: 1351 RVA: 0x0000BE60 File Offset: 0x0000A060
	public void RemoveField(string name)
	{
		if (this.keys.IndexOf(name) > -1)
		{
			this.list.RemoveAt(this.keys.IndexOf(name));
			this.keys.Remove(name);
		}
	}

	// Token: 0x06000548 RID: 1352 RVA: 0x0000BEA4 File Offset: 0x0000A0A4
	public bool GetField(ref bool field, string name, bool fallback)
	{
		if (this.GetField(ref field, name, null))
		{
			return true;
		}
		field = fallback;
		return false;
	}

	// Token: 0x06000549 RID: 1353 RVA: 0x0000BEBC File Offset: 0x0000A0BC
	public bool GetField(ref bool field, string name, JSONObject.FieldNotFound fail = null)
	{
		if (this.type == JSONObject.Type.OBJECT)
		{
			int num = this.keys.IndexOf(name);
			if (num >= 0)
			{
				field = this.list[num].b;
				return true;
			}
		}
		if (fail != null)
		{
			fail(name);
		}
		return false;
	}

	// Token: 0x0600054A RID: 1354 RVA: 0x0000BF0C File Offset: 0x0000A10C
	public bool GetField(ref float field, string name, float fallback)
	{
		if (this.GetField(ref field, name, null))
		{
			return true;
		}
		field = fallback;
		return false;
	}

	// Token: 0x0600054B RID: 1355 RVA: 0x0000BF24 File Offset: 0x0000A124
	public bool GetField(ref float field, string name, JSONObject.FieldNotFound fail = null)
	{
		if (this.type == JSONObject.Type.OBJECT)
		{
			int num = this.keys.IndexOf(name);
			if (num >= 0)
			{
				field = this.list[num].n;
				return true;
			}
		}
		if (fail != null)
		{
			fail(name);
		}
		return false;
	}

	// Token: 0x0600054C RID: 1356 RVA: 0x0000BF74 File Offset: 0x0000A174
	public bool GetField(ref int field, string name, int fallback)
	{
		if (this.GetField(ref field, name, null))
		{
			return true;
		}
		field = fallback;
		return false;
	}

	// Token: 0x0600054D RID: 1357 RVA: 0x0000BF8C File Offset: 0x0000A18C
	public bool GetField(ref int field, string name, JSONObject.FieldNotFound fail = null)
	{
		if (this.IsObject)
		{
			int num = this.keys.IndexOf(name);
			if (num >= 0)
			{
				field = (int)this.list[num].n;
				return true;
			}
		}
		if (fail != null)
		{
			fail(name);
		}
		return false;
	}

	// Token: 0x0600054E RID: 1358 RVA: 0x0000BFDC File Offset: 0x0000A1DC
	public bool GetField(ref uint field, string name, uint fallback)
	{
		if (this.GetField(ref field, name, null))
		{
			return true;
		}
		field = fallback;
		return false;
	}

	// Token: 0x0600054F RID: 1359 RVA: 0x0000BFF4 File Offset: 0x0000A1F4
	public bool GetField(ref uint field, string name, JSONObject.FieldNotFound fail = null)
	{
		if (this.IsObject)
		{
			int num = this.keys.IndexOf(name);
			if (num >= 0)
			{
				field = (uint)this.list[num].n;
				return true;
			}
		}
		if (fail != null)
		{
			fail(name);
		}
		return false;
	}

	// Token: 0x06000550 RID: 1360 RVA: 0x0000C044 File Offset: 0x0000A244
	public bool GetField(ref string field, string name, string fallback)
	{
		if (this.GetField(ref field, name, null))
		{
			return true;
		}
		field = fallback;
		return false;
	}

	// Token: 0x06000551 RID: 1361 RVA: 0x0000C05C File Offset: 0x0000A25C
	public bool GetField(ref string field, string name, JSONObject.FieldNotFound fail = null)
	{
		if (this.IsObject)
		{
			int num = this.keys.IndexOf(name);
			if (num >= 0)
			{
				field = this.list[num].str;
				return true;
			}
		}
		if (fail != null)
		{
			fail(name);
		}
		return false;
	}

	// Token: 0x06000552 RID: 1362 RVA: 0x0000C0AC File Offset: 0x0000A2AC
	public void GetField(string name, JSONObject.GetFieldResponse response, JSONObject.FieldNotFound fail = null)
	{
		if (response != null && this.IsObject)
		{
			int num = this.keys.IndexOf(name);
			if (num >= 0)
			{
				response(this.list[num]);
				return;
			}
		}
		if (fail != null)
		{
			fail(name);
		}
	}

	// Token: 0x06000553 RID: 1363 RVA: 0x0000C100 File Offset: 0x0000A300
	public JSONObject GetField(string name)
	{
		if (this.IsObject)
		{
			for (int i = 0; i < this.keys.Count; i++)
			{
				if (this.keys[i] == name)
				{
					return this.list[i];
				}
			}
		}
		return null;
	}

	// Token: 0x06000554 RID: 1364 RVA: 0x0000C15C File Offset: 0x0000A35C
	public bool HasFields(string[] names)
	{
		if (!this.IsObject)
		{
			return false;
		}
		for (int i = 0; i < names.Length; i++)
		{
			if (!this.keys.Contains(names[i]))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06000555 RID: 1365 RVA: 0x0000C1A0 File Offset: 0x0000A3A0
	public bool HasField(string name)
	{
		if (!this.IsObject)
		{
			return false;
		}
		for (int i = 0; i < this.keys.Count; i++)
		{
			if (this.keys[i] == name)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000556 RID: 1366 RVA: 0x0000C1F0 File Offset: 0x0000A3F0
	public void Clear()
	{
		this.type = JSONObject.Type.NULL;
		if (this.list != null)
		{
			this.list.Clear();
		}
		if (this.keys != null)
		{
			this.keys.Clear();
		}
		this.str = string.Empty;
		this.n = 0f;
		this.b = false;
	}

	// Token: 0x06000557 RID: 1367 RVA: 0x0000C250 File Offset: 0x0000A450
	public JSONObject Copy()
	{
		return JSONObject.Create(this.Print(false), -2, false, false);
	}

	// Token: 0x06000558 RID: 1368 RVA: 0x0000C264 File Offset: 0x0000A464
	public void Merge(JSONObject obj)
	{
		JSONObject.MergeRecur(this, obj);
	}

	// Token: 0x06000559 RID: 1369 RVA: 0x0000C270 File Offset: 0x0000A470
	private static void MergeRecur(JSONObject left, JSONObject right)
	{
		if (left.type == JSONObject.Type.NULL)
		{
			left.Absorb(right);
		}
		else if (left.type == JSONObject.Type.OBJECT && right.type == JSONObject.Type.OBJECT)
		{
			for (int i = 0; i < right.list.Count; i++)
			{
				string text = right.keys[i];
				if (right[i].isContainer)
				{
					if (left.HasField(text))
					{
						JSONObject.MergeRecur(left[text], right[i]);
					}
					else
					{
						left.AddField(text, right[i]);
					}
				}
				else if (left.HasField(text))
				{
					left.SetField(text, right[i]);
				}
				else
				{
					left.AddField(text, right[i]);
				}
			}
		}
		else if (left.type == JSONObject.Type.ARRAY && right.type == JSONObject.Type.ARRAY)
		{
			if (right.Count > left.Count)
			{
				UnityEngine.Debug.LogError("Cannot merge arrays when right object has more elements");
				return;
			}
			for (int j = 0; j < right.list.Count; j++)
			{
				if (left[j].type == right[j].type)
				{
					if (left[j].isContainer)
					{
						JSONObject.MergeRecur(left[j], right[j]);
					}
					else
					{
						left[j] = right[j];
					}
				}
			}
		}
	}

	// Token: 0x0600055A RID: 1370 RVA: 0x0000C3F4 File Offset: 0x0000A5F4
	public void Bake()
	{
		if (this.type != JSONObject.Type.BAKED)
		{
			this.str = this.Print(false);
			this.type = JSONObject.Type.BAKED;
		}
	}

	// Token: 0x0600055B RID: 1371 RVA: 0x0000C424 File Offset: 0x0000A624
	public IEnumerable BakeAsync()
	{
		if (this.type != JSONObject.Type.BAKED)
		{
			foreach (string s in this.PrintAsync(false))
			{
				if (s == null)
				{
					yield return s;
				}
				else
				{
					this.str = s;
				}
			}
			this.type = JSONObject.Type.BAKED;
		}
		yield break;
	}

	// Token: 0x0600055C RID: 1372 RVA: 0x0000C448 File Offset: 0x0000A648
	public string Print(bool pretty = false)
	{
		StringBuilder stringBuilder = new StringBuilder();
		this.Stringify(0, stringBuilder, pretty);
		return stringBuilder.ToString();
	}

	// Token: 0x0600055D RID: 1373 RVA: 0x0000C46C File Offset: 0x0000A66C
	public IEnumerable<string> PrintAsync(bool pretty = false)
	{
		StringBuilder builder = new StringBuilder();
		JSONObject.printWatch.Reset();
		JSONObject.printWatch.Start();
		foreach (object obj in this.StringifyAsync(0, builder, pretty))
		{
			IEnumerable e = (IEnumerable)obj;
			yield return null;
		}
		yield return builder.ToString();
		yield break;
	}

	// Token: 0x0600055E RID: 1374 RVA: 0x0000C4A0 File Offset: 0x0000A6A0
	private IEnumerable StringifyAsync(int depth, StringBuilder builder, bool pretty = false)
	{
		int num;
		depth = (num = depth) + 1;
		if (num > 100)
		{
			UnityEngine.Debug.Log("reached max depth!");
			yield break;
		}
		if (JSONObject.printWatch.Elapsed.TotalSeconds > 0.00800000037997961)
		{
			JSONObject.printWatch.Reset();
			yield return null;
			JSONObject.printWatch.Start();
		}
		switch (this.type)
		{
		case JSONObject.Type.NULL:
			builder.Append("null");
			break;
		case JSONObject.Type.STRING:
			builder.AppendFormat("\"{0}\"", this.str);
			break;
		case JSONObject.Type.NUMBER:
			if (float.IsInfinity(this.n))
			{
				builder.Append("\"INFINITY\"");
			}
			else if (float.IsNegativeInfinity(this.n))
			{
				builder.Append("\"NEGINFINITY\"");
			}
			else if (float.IsNaN(this.n))
			{
				builder.Append("\"NaN\"");
			}
			else
			{
				builder.Append(this.n.ToString());
			}
			break;
		case JSONObject.Type.OBJECT:
			builder.Append("{");
			if (this.list.Count > 0)
			{
				if (pretty)
				{
					builder.Append("\n");
				}
				for (int i = 0; i < this.list.Count; i++)
				{
					string key = this.keys[i];
					JSONObject obj = this.list[i];
					if (obj)
					{
						if (pretty)
						{
							for (int j = 0; j < depth; j++)
							{
								builder.Append("\t");
							}
						}
						builder.AppendFormat("\"{0}\":", key);
						foreach (object obj2 in obj.StringifyAsync(depth, builder, pretty))
						{
							IEnumerable e = (IEnumerable)obj2;
							yield return e;
						}
						builder.Append(",");
						if (pretty)
						{
							builder.Append("\n");
						}
					}
				}
				if (pretty)
				{
					builder.Length -= 2;
				}
				else
				{
					builder.Length--;
				}
			}
			if (pretty && this.list.Count > 0)
			{
				builder.Append("\n");
				for (int k = 0; k < depth - 1; k++)
				{
					builder.Append("\t");
				}
			}
			builder.Append("}");
			break;
		case JSONObject.Type.ARRAY:
			builder.Append("[");
			if (this.list.Count > 0)
			{
				if (pretty)
				{
					builder.Append("\n");
				}
				for (int l = 0; l < this.list.Count; l++)
				{
					if (this.list[l])
					{
						if (pretty)
						{
							for (int m = 0; m < depth; m++)
							{
								builder.Append("\t");
							}
						}
						foreach (object obj3 in this.list[l].StringifyAsync(depth, builder, pretty))
						{
							IEnumerable e2 = (IEnumerable)obj3;
							yield return e2;
						}
						builder.Append(",");
						if (pretty)
						{
							builder.Append("\n");
						}
					}
				}
				if (pretty)
				{
					builder.Length -= 2;
				}
				else
				{
					builder.Length--;
				}
			}
			if (pretty && this.list.Count > 0)
			{
				builder.Append("\n");
				for (int n = 0; n < depth - 1; n++)
				{
					builder.Append("\t");
				}
			}
			builder.Append("]");
			break;
		case JSONObject.Type.BOOL:
			if (this.b)
			{
				builder.Append("true");
			}
			else
			{
				builder.Append("false");
			}
			break;
		case JSONObject.Type.BAKED:
			builder.Append(this.str);
			break;
		}
		yield break;
	}

	// Token: 0x0600055F RID: 1375 RVA: 0x0000C4F0 File Offset: 0x0000A6F0
	private void Stringify(int depth, StringBuilder builder, bool pretty = false)
	{
		if (depth++ > 100)
		{
			UnityEngine.Debug.Log("reached max depth!");
			return;
		}
		switch (this.type)
		{
		case JSONObject.Type.NULL:
			builder.Append("null");
			break;
		case JSONObject.Type.STRING:
			builder.AppendFormat("\"{0}\"", this.str);
			break;
		case JSONObject.Type.NUMBER:
			if (float.IsInfinity(this.n))
			{
				builder.Append("\"INFINITY\"");
			}
			else if (float.IsNegativeInfinity(this.n))
			{
				builder.Append("\"NEGINFINITY\"");
			}
			else if (float.IsNaN(this.n))
			{
				builder.Append("\"NaN\"");
			}
			else
			{
				builder.Append(this.n.ToString());
			}
			break;
		case JSONObject.Type.OBJECT:
			builder.Append("{");
			if (this.list.Count > 0)
			{
				if (pretty)
				{
					builder.Append("\n");
				}
				for (int i = 0; i < this.list.Count; i++)
				{
					string arg = this.keys[i];
					JSONObject jsonobject = this.list[i];
					if (jsonobject)
					{
						if (pretty)
						{
							for (int j = 0; j < depth; j++)
							{
								builder.Append("\t");
							}
						}
						builder.AppendFormat("\"{0}\":", arg);
						jsonobject.Stringify(depth, builder, pretty);
						builder.Append(",");
						if (pretty)
						{
							builder.Append("\n");
						}
					}
				}
				if (pretty)
				{
					builder.Length -= 2;
				}
				else
				{
					builder.Length--;
				}
			}
			if (pretty && this.list.Count > 0)
			{
				builder.Append("\n");
				for (int k = 0; k < depth - 1; k++)
				{
					builder.Append("\t");
				}
			}
			builder.Append("}");
			break;
		case JSONObject.Type.ARRAY:
			builder.Append("[");
			if (this.list.Count > 0)
			{
				if (pretty)
				{
					builder.Append("\n");
				}
				for (int l = 0; l < this.list.Count; l++)
				{
					if (this.list[l])
					{
						if (pretty)
						{
							for (int m = 0; m < depth; m++)
							{
								builder.Append("\t");
							}
						}
						this.list[l].Stringify(depth, builder, pretty);
						builder.Append(",");
						if (pretty)
						{
							builder.Append("\n");
						}
					}
				}
				if (pretty)
				{
					builder.Length -= 2;
				}
				else
				{
					builder.Length--;
				}
			}
			if (pretty && this.list.Count > 0)
			{
				builder.Append("\n");
				for (int n = 0; n < depth - 1; n++)
				{
					builder.Append("\t");
				}
			}
			builder.Append("]");
			break;
		case JSONObject.Type.BOOL:
			if (this.b)
			{
				builder.Append("true");
			}
			else
			{
				builder.Append("false");
			}
			break;
		case JSONObject.Type.BAKED:
			builder.Append(this.str);
			break;
		}
	}

	// Token: 0x1700005E RID: 94
	public JSONObject this[int index]
	{
		get
		{
			if (this.list.Count > index)
			{
				return this.list[index];
			}
			return null;
		}
		set
		{
			if (this.list.Count > index)
			{
				this.list[index] = value;
			}
		}
	}

	// Token: 0x1700005F RID: 95
	public JSONObject this[string index]
	{
		get
		{
			return this.GetField(index);
		}
		set
		{
			this.SetField(index, value);
		}
	}

	// Token: 0x06000564 RID: 1380 RVA: 0x0000C90C File Offset: 0x0000AB0C
	public override string ToString()
	{
		return this.Print(false);
	}

	// Token: 0x06000565 RID: 1381 RVA: 0x0000C918 File Offset: 0x0000AB18
	public string ToString(bool pretty)
	{
		return this.Print(pretty);
	}

	// Token: 0x06000566 RID: 1382 RVA: 0x0000C924 File Offset: 0x0000AB24
	public Dictionary<string, string> ToDictionary()
	{
		if (this.type == JSONObject.Type.OBJECT)
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			int i = 0;
			while (i < this.list.Count)
			{
				JSONObject jsonobject = this.list[i];
				switch (jsonobject.type)
				{
				case JSONObject.Type.STRING:
					dictionary.Add(this.keys[i], jsonobject.str);
					break;
				case JSONObject.Type.NUMBER:
					dictionary.Add(this.keys[i], jsonobject.n + string.Empty);
					break;
				case JSONObject.Type.OBJECT:
				case JSONObject.Type.ARRAY:
					goto IL_C3;
				case JSONObject.Type.BOOL:
					dictionary.Add(this.keys[i], jsonobject.b + string.Empty);
					break;
				default:
					goto IL_C3;
				}
				IL_E8:
				i++;
				continue;
				IL_C3:
				UnityEngine.Debug.LogWarning("Omitting object: " + this.keys[i] + " in dictionary conversion");
				goto IL_E8;
			}
			return dictionary;
		}
		UnityEngine.Debug.LogWarning("Tried to turn non-Object JSONObject into a dictionary");
		return null;
	}

	// Token: 0x06000567 RID: 1383 RVA: 0x0000CA3C File Offset: 0x0000AC3C
	public static implicit operator WWWForm(JSONObject obj)
	{
		WWWForm wwwform = new WWWForm();
		for (int i = 0; i < obj.list.Count; i++)
		{
			string fieldName = i + string.Empty;
			if (obj.type == JSONObject.Type.OBJECT)
			{
				fieldName = obj.keys[i];
			}
			string text = obj.list[i].ToString();
			if (obj.list[i].type == JSONObject.Type.STRING)
			{
				text = text.Replace("\"", string.Empty);
			}
			wwwform.AddField(fieldName, text);
		}
		return wwwform;
	}

	// Token: 0x06000568 RID: 1384 RVA: 0x0000CAD8 File Offset: 0x0000ACD8
	public static implicit operator bool(JSONObject o)
	{
		return o != null;
	}

	// Token: 0x040001EA RID: 490
	private const int MAX_DEPTH = 100;

	// Token: 0x040001EB RID: 491
	private const string INFINITY = "\"INFINITY\"";

	// Token: 0x040001EC RID: 492
	private const string NEGINFINITY = "\"NEGINFINITY\"";

	// Token: 0x040001ED RID: 493
	private const string NaN = "\"NaN\"";

	// Token: 0x040001EE RID: 494
	private const float maxFrameTime = 0.008f;

	// Token: 0x040001EF RID: 495
	public static readonly char[] WHITESPACE = new char[]
	{
		' ',
		'\r',
		'\n',
		'\t',
		'﻿',
		'\t'
	};

	// Token: 0x040001F0 RID: 496
	public JSONObject.Type type;

	// Token: 0x040001F1 RID: 497
	public List<JSONObject> list;

	// Token: 0x040001F2 RID: 498
	public List<string> keys;

	// Token: 0x040001F3 RID: 499
	public string str;

	// Token: 0x040001F4 RID: 500
	public float n;

	// Token: 0x040001F5 RID: 501
	public bool b;

	// Token: 0x040001F6 RID: 502
	private static readonly Stopwatch printWatch = new Stopwatch();

	// Token: 0x020000BD RID: 189
	public enum Type
	{
		// Token: 0x040001F8 RID: 504
		NULL,
		// Token: 0x040001F9 RID: 505
		STRING,
		// Token: 0x040001FA RID: 506
		NUMBER,
		// Token: 0x040001FB RID: 507
		OBJECT,
		// Token: 0x040001FC RID: 508
		ARRAY,
		// Token: 0x040001FD RID: 509
		BOOL,
		// Token: 0x040001FE RID: 510
		BAKED
	}

	// Token: 0x02000179 RID: 377
	// (Invoke) Token: 0x06000AA6 RID: 2726
	public delegate void AddJSONConents(JSONObject self);

	// Token: 0x0200017A RID: 378
	// (Invoke) Token: 0x06000AAA RID: 2730
	public delegate void FieldNotFound(string name);

	// Token: 0x0200017B RID: 379
	// (Invoke) Token: 0x06000AAE RID: 2734
	public delegate void GetFieldResponse(JSONObject obj);
}
