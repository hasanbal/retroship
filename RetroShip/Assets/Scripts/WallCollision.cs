using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WallCollision : MonoBehaviour {

	private void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Ship") {
			Destroy (other.gameObject);
			LoadScene ();
		}
	}
	private void LoadScene(){
		SceneManager.LoadScene ("game");
	}
}
