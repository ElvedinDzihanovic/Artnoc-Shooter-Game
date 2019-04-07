using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleToWalk : MonoBehaviour {
	public Animator anim;
	public float InputX;
	public float InputZ;

	// Use this for initialization
	void Start () {
		anim = this.gameObject.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		InputZ = Input.GetAxis ("Vertical");
		anim.SetFloat ("InputZ", InputZ);
	}
}
