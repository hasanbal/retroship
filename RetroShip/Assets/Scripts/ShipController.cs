using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour {
	public float angle;
	public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += transform.right * Time.deltaTime * speed;

		if (Input.GetKey (KeyCode.Space)) {
			
			transform.Rotate (Vector3.back * Time.deltaTime * angle);
		}
	}
}
