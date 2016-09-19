using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour, IDropHandler {
	//public int number = -1;
	public GameObject item {
		get {
			if (transform.childCount > 0) {
				return transform.GetChild (0).gameObject;
			}
			return null;
		}
	}

	public void Update()
	{
		
	}
	#region IDropHandler implementation

	public void OnDrop (PointerEventData eventData)
	{
		if (!item) {
			Debug.Log (DragHandler.itemBeingDragged);
			DragHandler.itemBeingDragged.transform.SetParent (transform);
		}
	}

	#endregion
}
