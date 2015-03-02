using UnityEngine;
using System.Collections;

public class RemoteControlDifferentWays : MonoBehaviour {
	GameObject d1;
	GameObject d2;
	public GameObject d3;

	// Use this for initialization
	void Start () {
		d1 = GameObject.Find("Dropper1");
		d2 = GameObject.FindWithTag("Drop Me");
		if (d1 != null) {
			print ("Object with \"Dropper1\" name found.");
		} else {
			print ("Object with \"Dropper1\" name found.");
		}
		if (d2 != null) {
			print ("Object with \"Drop Me\" tag found.");
		} else {
			print ("Object with \"Drop Me\" tag found.");
		}
	}

	void OnMouseDown() { 
		GameObject d4 = GameObject.Find("Dropper4");
		DropScript d4Script = d4.GetComponent<DropScript>();
		GameObject d5 = GameObject.Find("Dropper5");
		d1.rigidbody.useGravity = true;
		d2.rigidbody.useGravity = true;
		d3.rigidbody.useGravity = true;
		d4Script.Drop();
		d5.rigidbody.useGravity = true;
		GameObject.Find("Drop Group").BroadcastMessage("DropMessage", 10.0f);
	}
}
