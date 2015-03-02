using UnityEngine;
using System.Collections;

public class RigidBodyMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Rigidbody rg = GetComponent<Rigidbody>();
		if(rg != null) {
			rg.velocity = new Vector3(-6.0f, 0.0f, 0.0f);
			rg.useGravity = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
