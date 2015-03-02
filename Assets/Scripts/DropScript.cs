using UnityEngine;
using System.Collections;

public class DropScript : MonoBehaviour {
	public void Drop() {
		Rigidbody rg = GetComponent<Rigidbody>();
		if (rg != null) {
			rg.useGravity=true;
		}
	}
}
