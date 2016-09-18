using UnityEngine;
using System.Collections;

public class TerrainManager : MonoBehaviour {
	public GameObject tree1, tree2, tree3;
	public GameObject realTreeGroup;
	public RaycastHit hitInfo;
	public Ray ray;
	public GameObject prev;
	void Start () {
		tree1.SetActive (false);
		tree2.SetActive (false);
		tree3.SetActive (false);
	}
	void Update() {
		if (Input.GetKey (KeyCode.Alpha1)) {
			if (prev != null) {
				prev.SetActive (false);
				prev = null;
			}
		} else if (Input.GetKey (KeyCode.Alpha2)) {
			setTree (tree1);
		} else if (Input.GetKey (KeyCode.Alpha3)) {
			setTree (tree2);
		} else if (Input.GetKey (KeyCode.Alpha4)) {
			setTree (tree3);
		}
		if (Input.GetMouseButtonDown (0)) {
			Debug.Log ("left click");
		}
		if(prev != null) followTree (prev);
	}
	void setTree(GameObject tree) {
		if (prev != null) prev.SetActive (false);
		prev = tree;
		prev.SetActive (true);
	}
	void followTree(GameObject tree) {
		ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		if (Physics.Raycast (ray, out hitInfo)) {
			if (hitInfo.transform.gameObject == gameObject) {
				Material m = tree.GetComponent<Renderer> ().material;
				m.color = new Color(m.color.r, m.color.g, m.color.b, 0.1f);
				tree.SetActive (true);
				tree.transform.position = hitInfo.point;
			}
		} else {
			tree.SetActive (false);
		}
		if (tree.activeInHierarchy) {
			if (Input.GetMouseButtonDown (0) || Input.GetKey(KeyCode.P)) {
				plantTree (tree);
			}
		}
	}
	void plantTree(GameObject tree) {
		GameObject tree2 = 
			(GameObject)Instantiate 
			(tree, tree.transform.position, tree.transform.rotation);
		tree2.GetComponent<TreeManager> ().ReturnTo ();
		tree2.transform.parent = realTreeGroup.transform;
	}
	public bool isHasActiveTree() {
		return tree1.activeInHierarchy
		|| tree2.activeInHierarchy
		|| tree3.activeInHierarchy;
	}
}
