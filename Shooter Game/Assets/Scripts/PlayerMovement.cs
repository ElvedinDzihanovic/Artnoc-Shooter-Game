using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	static Animator anim;
	public float speed = 1.0f;
	public float rotationSpeed = 100.0f;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();	
	}
	
	// Update is called once per frame
	void Update () {
		float translation = Input.GetAxis ("Vertical") * speed;
		float rotation = Input.GetAxis ("Horizontal") * rotationSpeed;

		translation *= Time.deltaTime;
		rotation *= Time.deltaTime;

		transform.Translate (0, 0, translation);
		transform.Rotate (0, rotation, 0);

		if (translation == 0) {
			anim.SetInteger ("Condition", 0);
		} else if (translation < 0) {
			anim.SetInteger ("Condition", -1);
		} else {
			anim.SetInteger ("Condition", 1);
		}
	}
}
