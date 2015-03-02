using UnityEngine;
using System.Collections;

public class BoxAntiGrav : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Rigidbody rg = GetComponent<Rigidbody>();
		if(rg != null) {
			rg.useGravity = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
