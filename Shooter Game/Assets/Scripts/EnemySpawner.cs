using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {
	public GameObject Enemy;
	public Vector3 spawnValues;
	public float spawnWait;
	public float spawnMostWait;
	public float spawnLeastWait;
	public int startWait;
	public bool stop;

	public int Energy;

	public BulletScript scrpt;
	// Use this for initialization
	void Start () {
		StartCoroutine (Spawner());
		scrpt = GameObject.Find ("BulletEmitter").GetComponent <BulletScript>();

	}
	
	// Update is called once per frame
	void Update () {
		spawnWait = Random.Range (spawnLeastWait, spawnMostWait);
	}


	IEnumerator Spawner(){
		yield return new WaitForSeconds (startWait);
		while (!stop) {
			Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), 0, Random.Range (-spawnValues.z, spawnValues.z));
			Instantiate (Enemy, spawnPosition + transform.TransformPoint (0, 0, 0), gameObject.transform.rotation);
			yield return new WaitForSeconds (spawnWait);
		}
	}

	void OnCollisionEnter(Collision Col){
		if (Col.gameObject.tag == "Bullet") {
			if (Energy <= 0)
				Destroy (this.gameObject);
			else {
				if (scrpt.machineGun == true) {
					Destroy (this.gameObject);
				} else
					Energy -= 1;
			}
		}
	}
}
