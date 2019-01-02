using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour {
	public GameObject Meteor;
	public float xAxis;
	public float yAxis;
	// Use this for initialization
	void Start (){
		CreateMeteor ();


	}
	private void CreateMeteor(){
		var position = new Vector3 (xAxis, yAxis, 0f);
		GameObject.Instantiate (Meteor, position, Quaternion.identity);
		Invoke ("CreateMeteor", 1.5f);
	}
	// Update is called once per frame
	void Update () {

	}
}
