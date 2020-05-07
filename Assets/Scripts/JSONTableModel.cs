using UnityEngine;

public class JSONTableModel : MonoBehaviour
{
	public JSONTableController mController;
	public JSONTableView mView;

	public void Start()
	{
		UpdateTable();
	}

	// Use the JSON data provided by the JSONTableController to be displayed by the JSONTableView component.
	public void UpdateTable()
	{
		if (mController != null)
		{
			// Get JSON data as a BaseJSONData object.
			BaseJSONData baseJSON = mController.GetJSONData();

			if (mView != null)
			{
				// Updates the application view with the data provided by the BaseJSONData.
				mView.UpdateView(baseJSON.Title, baseJSON.ColumnHeaders.ToArray(), baseJSON.Data.ToArray());
			}
			else
			{
				Debug.LogWarning("No JSONTableView attached to the " + gameObject.name + " At " + this.GetType().ToString());
			}
		}
		else
		{
			Debug.LogWarning("No JSONTableController attached to the " + gameObject.name + " At " + this.GetType().ToString());
		}
	}
}
