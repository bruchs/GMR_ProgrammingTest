using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICreator : MonoBehaviour
{
	[Header("UI Prefabs")]
	public GameObject normalTextPrefab;
	public GameObject bolderTextPrefab;
	public GameObject rowPrefab;

	internal List<GameObject> instantiatedUI = new List<GameObject>();

	// Creates a new row gameobject and set its parent.
	public GameObject GetNewRow(Transform parentTransform)
	{
		GameObject newRow = Instantiate(rowPrefab);
		newRow.transform.SetParent(parentTransform, false);

		// Add to list of intantiated objects.
		instantiatedUI.Add(newRow);
		return newRow;
	}

	// Creates a new text gameobject with bold font option and set its parent.
	public Text GetNewText(Transform parentTransform, bool bold)
	{
		GameObject newText = null;

		if (bold)
		{
			newText = Instantiate(bolderTextPrefab);
		}
		else
		{
			newText = Instantiate(normalTextPrefab);
		}

		newText.transform.SetParent(parentTransform, false);
		Text currentText = newText.GetComponent<Text>();

		// Add to list of intantiated objects.
		instantiatedUI.Add(newText);
		return currentText;
	}

	// Destroy all instantiated objects and clears the list.
	public void CleanInstantiatedObjects()
	{
		for(int i = 0; i < instantiatedUI.Count; i++)
		{
			GameObject currentGO = instantiatedUI[i];
			Destroy(currentGO);
		}

		instantiatedUI.Clear();
	}
}
