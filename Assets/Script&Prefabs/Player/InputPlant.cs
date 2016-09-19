using UnityEngine;
using System.Collections;

public class InputPlant : MonoBehaviour {
	RaycastHit hit;
	public Camera camera;
	public GameObject handInventory;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		int key = CheckKey ();
		if (key >= 0) {
			Ray ray = camera.ScreenPointToRay (
				Input.mousePosition);
			if (Physics.Raycast (ray, out hit)) {
				Transform objectHit = hit.transform;

				if (handInventory) {
					GameObject slot = handInventory.transform.Find ("Slot (" + key + ")").gameObject;
					if (slot) {
						GameObject item = slot.GetComponent<Slot> ().item;
						if (item != null) {
							Debug.Log ("Success!");
						}
					}
				}
			}
		}
	}

	int CheckKey()
	{
		if (Input.GetKey (KeyCode.Alpha1))
			return 1;
		if (Input.GetKey (KeyCode.Alpha2))
			return 2;
		if (Input.GetKey (KeyCode.Alpha3))
			return 3;
		if (Input.GetKey (KeyCode.Alpha4))
			return 4;
		if (Input.GetKey (KeyCode.Alpha5))
			return 5;
		if (Input.GetKey (KeyCode.Alpha6))
			return 6;
		if (Input.GetKey (KeyCode.Alpha7))
			return 7;
		if (Input.GetKey (KeyCode.Alpha8))
			return 8;
		if (Input.GetKey (KeyCode.Alpha9))
			return 9;
		if (Input.GetKey (KeyCode.Alpha0))
			return 0;
		return -1;
	}
}
