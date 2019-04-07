using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowPlayer : MonoBehaviour {
	public Transform target;
	public Transform myTransform;
	public int speed = 5;

	// Update is called once per frame
	void Update () {
		target = GameObject.Find ("Player").gameObject.transform;
		transform.LookAt (target);
		transform.Translate (Vector3.forward * speed * Time.deltaTime);
	}

	//void OnCollisionEnter(Collision Col){
	//	if (Col.gameObject.name == "Player") {
	//		Destroy (Col.gameObject);
	//	}
	//}

}
