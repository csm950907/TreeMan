using UnityEngine;
using System.Collections;

public class TreeManager : MonoBehaviour {
	// Use this for initialization
	Material m1, m2;
	void Start () {
		Material[] materials = GetComponent<Renderer> ().materials;
		m1 = new Material(materials [0].shader);
		m2 = new Material(materials [1].shader);
		//materials [0].color = Color.green;
		//materials [1].color = Color.green;
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void ReturnTo()
	{
		//GetComponent<Renderer> ().materials [0].color = Color.red;
		//GetComponent<Renderer> ().materials [1].color = Color.red;
		Debug.Log ("Return To" + GetComponent<Renderer> ().materials [0].color);
	}
}
