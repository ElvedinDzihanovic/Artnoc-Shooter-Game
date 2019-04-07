using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour
{
	public GameObject BulletEmitter;

	public GameObject Bullet;

	public float BulletForwardForce;

	AudioSource audio;
	// Use this for initialization
	public bool machineGun;
	public GameObject machineAudio;
	AudioSource audio2;

	void Start ()
	{
		machineGun = false;
		audio = GetComponent<AudioSource> ();	
		audio2 = machineAudio.GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update ()
	{
		
		//Shooting

		if (machineGun == false) {
			if (Input.GetKeyDown ("space")) {
				audio.Play ();
				GameObject TemporaryBulletHandler;
				TemporaryBulletHandler = Instantiate (Bullet, BulletEmitter.transform.position, BulletEmitter.transform.rotation) as GameObject;
		


				//Radi i sa i bez ovoga
				//Temporary_Bullet_Handler.transform.Rotate(Vector3.left * 90);

				Rigidbody TemporaryRigidBody = TemporaryBulletHandler.GetComponent<Rigidbody> ();



				TemporaryRigidBody.AddForce (transform.forward * BulletForwardForce);


				Destroy (TemporaryBulletHandler, 3.0f);
			}
		}
		else if (machineGun == true) {
			if (Input.GetKeyDown ("space")) 
			{
				audio2.Play ();
				this.gameObject.transform.localScale = new Vector3 (0.8f, 0.8f, 0.8f);
				GameObject TemporaryBulletHandler;
				TemporaryBulletHandler = Instantiate(Bullet,BulletEmitter.transform.position,BulletEmitter.transform.rotation) as GameObject;



				//Radi i sa i bez ovoga
				//Temporary_Bullet_Handler.transform.Rotate(Vector3.left * 90);
				TemporaryBulletHandler.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);

				Rigidbody TemporaryRigidBody = TemporaryBulletHandler.GetComponent<Rigidbody>();



				TemporaryRigidBody.AddForce(transform.forward * BulletForwardForce);


				Destroy(TemporaryBulletHandler, 3.0f);
			}
		}
	}
}