using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorController : MonoBehaviour {


    public Vector3 rotate = new Vector3 (0f, 0f, 0f);
	public float speed;
	// Use this for initialization
	void Start () {
		var hipotenus = 18;

		var edge = Random.Range (0f, 3f);

		rotate.x = edge;
		rotate.y = Mathf.Sqrt(hipotenus - edge * edge);

		var rot = Random.Range (0, 3);

		if (rot == 0) {
			rotate.x *= -1;

		} else if (rot == 1) {
			rotate.y *= -1;
		
		} else if (rot == 2) {
			rotate.x *= -1;
			rotate.y *= -1;
		}

	}
	
	// Update is called once per frame
	void Update () {
		
		transform.position += rotate * Time.deltaTime * speed;
	}
}
