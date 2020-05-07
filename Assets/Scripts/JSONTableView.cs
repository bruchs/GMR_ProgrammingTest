using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class JSONTableView : MonoBehaviour
{
	public UICreator UICreator;

	public Transform titlePivot;
	public Transform columPivot;
	public Transform rowPivot;

	// Clears the current application view and updates it with the used parameters.
	public void UpdateView(string title, string[] colums, Dictionary<string, string>[] rows)
	{
		// Delete and clear app view.
		UICreator.CleanInstantiatedObjects();

		SetTitle(title);
		SetColums(colums);
		SetRows(rows);
	}

	public void SetTitle(string title)
	{
		Text titleText = UICreator.GetNewText(titlePivot, true);
		titleText.text = title;
	}

	public void SetColums(string[] colums)
	{
		// For each element present on the array, create a new Text element with the columPivot as its parent.
		for(int i = 0; i < colums.Length; i++)
		{
			Text columText = UICreator.GetNewText(columPivot, true);
			columText.text = colums[i];
		}
	}

	public void SetRows(Dictionary<string, string>[] rows)
	{
		// For each element present on the array, create a new row holder element and set the rowPivot as its parent.
		for (int i = 0; i < rows.Length; i++)
		{
			GameObject newRowHolder = UICreator.GetNewRow(rowPivot);

			// For each entry present on the dictionary at [i], create a new text and set the previously created row holder as its parent.
			foreach (KeyValuePair<string, string> entry in rows[i])
			{
				Text rowText = UICreator.GetNewText(newRowHolder.transform, false);
				rowText.text = entry.Value;
			}
		}
	}
}
