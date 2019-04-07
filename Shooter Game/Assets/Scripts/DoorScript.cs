using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

	public int Energy;
	AudioSource audio;
	// Use this for initialization
	public BulletScript bulletScrpt;

	void Start () {
		audio = GetComponent<AudioSource> ();
		bulletScrpt = GameObject.Find ("BulletEmitter").GetComponent <BulletScript>();

	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter(Collision Col){
		if (Col.gameObject.tag == "Bullet") {
			if (Energy <= 0) {
				audio.Play ();
				Destroy (this.gameObject, 0.25f);
			} else {
				if (bulletScrpt.machineGun == true) {
					Destroy (this.gameObject, 0.25f);
				} else
					Energy -= 1;
			}
		}
	}
}
