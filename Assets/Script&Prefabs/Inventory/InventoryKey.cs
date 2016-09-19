using UnityEngine;
using System.Collections;

public class InventoryKey : MonoBehaviour {
	// Use this for initialization
	public GameObject[] objs;
	private bool upCheck;
	void Start () {
		upCheck = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.E)) {
			if (!upCheck) {
				for (int i = 0; i < objs.Length; i++) {
					objs [i].SetActive (!objs [i].activeInHierarchy);
					Debug.Log (objs.Length + "/" + objs [i].activeInHierarchy);
				}
				upCheck = true;
			}
		} else {
			upCheck = false;
		}
	}
}
