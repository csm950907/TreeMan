using UnityEngine;
using System.Collections;

public class Rectangle : MonoBehaviour {
	public Ray ray;
	public RaycastHit hitInfo;
	// Use this for initialization
	void Start () {	
	}
	
	// Update is called once per frame
	void Update () {
		ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		if (Input.GetMouseButtonDown (0)) {
			if (Physics.Raycast (ray, out hitInfo, 10)) {
				Debug.Log (hitInfo.point.x);
				Debug.Log (hitInfo.point.y);
				Debug.Log (hitInfo.point.z);
			}
		}
	}
}
