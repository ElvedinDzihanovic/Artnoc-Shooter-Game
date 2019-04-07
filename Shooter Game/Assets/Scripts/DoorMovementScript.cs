using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMovementScript : MonoBehaviour {
	// Movement Speed (0 means don't move)
	public float speed = 2f;
	public bool reverse;
	bool machineGun;

	void Start() {
		reverse = false;
	}

	void Update(){
		if (reverse == false) {
			if (transform.position.y >= 6) {
				reverse = true;
			}
			else
				transform.Translate (0, speed * Time.deltaTime, 0);
		} else {
			if (transform.position.y <= 1) {
				reverse = false;
			} else
				transform.Translate (0, -1 * speed * Time.deltaTime, 0);
		}
	}

	void OnCollisionEnter(Collision Col){
		
		if (Col.gameObject.tag == "Bullet"){
			if (GameObject.Find ("BulletEmitter").GetComponent<BulletScript> ().machineGun == true) {
				Destroy (this.gameObject);
			}
		}
	}
}
