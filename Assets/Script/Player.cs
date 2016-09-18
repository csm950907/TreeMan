using UnityEngine;
using System.Collections;


public class Player : MonoBehaviour {
	private float moveSpeed = 5f;
	private float spinSpeed = 100f;
	private int state;
	private Rigidbody rigidbody;
	private bool isJumping;
	private float jumpPower = 5f;
	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody> ();
		isJumping = false;
	}

	// Update is called once per frame
	void Update () {
		keyInput ();
		move ();
	}

	void keyInput() {
		if (Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.A))
		{
			transform.Rotate (-Vector3.up * spinSpeed * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.D)) 
		{
			transform.Rotate (Vector3.up * spinSpeed * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.W)) 
		{
			transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.DownArrow) || Input.GetKey (KeyCode.S)) 
		{
			transform.Translate (Vector3.back * moveSpeed * Time.deltaTime);
		}
		if (Input.GetButtonDown ("Jump"))
			isJumping = true;
	}
	void FixedUpdate()
	{
		jump ();
	}
	void move() {
		TerrainManager tm = GameObject.Find ("Map").GetComponent<TerrainManager> ();
		if (!tm.isHasActiveTree ()) {
			;
		}
	}
	void jump() {
		if (!isJumping)
			return;
		rigidbody.AddForce (Vector3.up * jumpPower, ForceMode.Impulse);
		isJumping = false;
	}
}
