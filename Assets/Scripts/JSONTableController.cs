using System.IO;
using UnityEngine;
using Newtonsoft.Json;

public class JSONTableController : MonoBehaviour
{
	public string fileName;

	// Returns a BaseJSONData base on the '.json' file provided.
	public BaseJSONData GetJSONData()
	{
		string filePath = Application.streamingAssetsPath + "/" + fileName + ".json";

		if (File.Exists(filePath))
		{
			string dataAsJson = File.ReadAllText(filePath);
			BaseJSONData baseJSON = JsonConvert.DeserializeObject<BaseJSONData>(dataAsJson);
			return baseJSON;
		}

		return null;
	}
}
