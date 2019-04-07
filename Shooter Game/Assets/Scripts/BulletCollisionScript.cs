using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollisionScript : MonoBehaviour {
	public AudioSource audio;
	// Use this for initialization
	void Start (){
		audio = GameObject.Find ("EnemyAudio").GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision Col){	
		//check for enemies
		if (Col.gameObject.tag == "Enemy" || Col.gameObject.tag == "Enemy2") {
			audio.Play ();
			Destroy (Col.gameObject);
		}

		Destroy (this.gameObject);

	}
}
