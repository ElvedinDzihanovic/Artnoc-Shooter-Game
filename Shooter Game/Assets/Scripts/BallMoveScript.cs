using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMoveScript : MonoBehaviour {
	public float speed = 50;
	private Rigidbody rb;
	public Vector3 movement;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		movement = new Vector3 (0, 0, -1);
	}
	
	// Update is called once per frame
	void Update () {
		rb.AddForce (movement * speed);

	}
}
