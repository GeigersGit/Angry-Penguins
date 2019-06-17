using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour {
	public Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		//this.transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z + .01f);

		if (Input.GetMouseButton (0)) {
			rb.AddForce (0, 20, 20);
		}


	}
}
