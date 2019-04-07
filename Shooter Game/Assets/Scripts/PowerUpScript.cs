using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PowerUpScript : MonoBehaviour {
	public int Health;

	// Use this for initialization
	public AudioSource audio; //power up audio
	public AudioSource PlayerAudio; //player audio
	public Text healtBar;

	void Start () {
		Health = 10;
		audio = GameObject.Find ("ParticleAudio").gameObject.GetComponent<AudioSource> ();
		PlayerAudio = GetComponent<AudioSource> ();
	}

		
	void Update(){
		
		healtBar.text = "Health: " + Health;	
	}

	void OnCollisionEnter(Collision Col){
		if (Col.gameObject.tag == "PowerUp") {
			if (Health < 10) {
				if (Health == 9)
					Health += 1;
				else
					Health += 2;
			}
			audio.Play ();
			Destroy (Col.gameObject);
		} else if (Col.gameObject.tag == "PowerUp2") {
			GameObject.Find ("BulletEmitter").GetComponent<BulletScript> ().machineGun = true;
			audio.Play ();
			Destroy (Col.gameObject);
		}
		else if (Col.gameObject.tag == "Enemy") {
			Health -= 1;
			PlayerAudio.Play ();
			Destroy (Col.gameObject);

			//Destroy (this.gameObject);
		} else if (Col.gameObject.tag == "Enemy2"){
			Health -= 3;
			PlayerAudio.Play ();
			Destroy (Col.gameObject);
		} else if (Col.gameObject.name == "FinalDoor") {
			GameObject.Find ("DoorText").GetComponent<TextMesh> ().text = "Find the key!";
		} else if (Col.gameObject.name == "Key") {
			audio.Play ();
			Destroy (Col.gameObject);
			Destroy (GameObject.Find ("FinalDoor"));
			Destroy (GameObject.Find ("DoorText"));
		} else if (Col.gameObject.name == "Finish") {
			SceneManager.LoadScene ("Level2");

		} else if (Col.gameObject.name == "Finish2") {
			SceneManager.LoadScene ("Level3");
		} else if (Col.gameObject.name == "Finish3") {
			SceneManager.LoadScene ("EndingMenuWin");
		} else if (Col.gameObject.tag == "Lava") {
			Health -= 4;
			PlayerAudio.Play ();
		} else if (Col.gameObject.tag == "Ball") {
			SceneManager.LoadScene ("Level3");
		}

		if (Health <= 0)
			SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
	}
}
