using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MeteorCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private void OnTriggerEnter(Collider other){
		Debug.Log (other.gameObject.tag);

		if (other.gameObject.tag == "Ship") {
			Debug.Log ("Restart");
			Destroy (other.gameObject);
			LoadScene ();

		} else if (other.gameObject.tag == "Wall") {
		
			//Destroy (gameObject);
		
		} else if (other.gameObject.tag == "Meteor") {
			
//			Collider col = gameObject.GetComponent<Collider> ();
//
//			Physics.IgnoreCollision(col , collider);
		
		}
	}
	private void LoadScene(){
		SceneManager.LoadScene ("game");

	}
}
