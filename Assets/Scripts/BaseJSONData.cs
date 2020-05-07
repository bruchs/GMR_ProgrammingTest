using System.Collections.Generic;

[System.Serializable]
public class BaseJSONData
{
	public string Title;
	public List<string> ColumnHeaders;
	public List<Dictionary<string, string>> Data;
}