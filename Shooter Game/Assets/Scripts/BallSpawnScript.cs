using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawnScript : MonoBehaviour {
	public GameObject FlameBall;
	public float spawnTime;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}
	
	void Spawn(){
		Instantiate (FlameBall, this.transform.position, FlameBall.transform.rotation);
	}
}
