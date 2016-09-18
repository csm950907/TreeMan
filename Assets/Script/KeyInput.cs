using UnityEngine;
using System.Collections;

public class KeyInput : MonoBehaviour {
	public GameObject inventory;
	private bool upCheck;
	// Use this for initialization
	void Start () {
		upCheck = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.E)) {
			if (!upCheck) {
				inventory.SetActive (!inventory.activeInHierarchy);
				upCheck = true;
			}
		} else {
			upCheck = false;
		}
	}
}
