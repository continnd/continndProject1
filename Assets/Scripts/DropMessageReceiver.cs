using UnityEngine;
using System.Collections;

public class DropMessageReceiver : MonoBehaviour {
	public void DropMessage (float value = 5.0f) {
		rigidbody.useGravity = true;
		print(gameObject.name + " dropped with a " + value + ".");
	}
}
