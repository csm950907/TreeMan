using UnityEngine;
using System.Collections;

public class InputMove : MonoBehaviour {
	public int moveSpeed, spinSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Move (new KeyCode[] { KeyCode.W, KeyCode.UpArrow }, Vector3.forward);
		Move (new KeyCode[] { KeyCode.S, KeyCode.DownArrow }, Vector3.back);
		Move (new KeyCode[] { KeyCode.Space }, Vector3.up);
		Rotate (new KeyCode[] { KeyCode.A, KeyCode.LeftArrow }, -Vector3.up);
		Rotate (new KeyCode[] { KeyCode.D, KeyCode.RightArrow }, Vector3.up * 2);
		MouseRotate (100);

		if (Input.GetKey (KeyCode.L))
			transform.localRotation = new Quaternion (0, 0, 0, 0);
		if (Input.GetKey (KeyCode.P))
			transform.localPosition = new Vector3 (2, 2, 2);
	}

	void Move(KeyCode[] key, Vector3 vec)
	{
		for (int i = 0; i < key.Length; i++) {
			if (Input.GetKey (key[i])) {
				transform.Translate (vec * moveSpeed * Time.deltaTime);
				break;
			}
		}
	}

	void Rotate(KeyCode[] key, Vector3 vec)
	{
		for (int i = 0; i < key.Length; i++) {
			if (Input.GetKey (key[i])) {
				transform.Rotate (vec * moveSpeed);
				break;
			}
		}
	}

	void MouseRotate(int range)
	{
		float x = Input.mousePosition.x;
		if (x < range)
			transform.Rotate (new Vector3(0, -1 * moveSpeed, 0));
		if (x > Screen.width - range)
			transform.Rotate (new Vector3(0, moveSpeed, 0));
	}
}
