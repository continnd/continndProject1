using UnityEngine;
using System.Collections;

public class OnTriggerScript : MonoBehaviour {

    void OnTriggerEnter(Collider other) {
        print("Trigger Enter " + other.gameObject.name);
        if(other.gameObject.tag == "projectile") {
            print("poop");
            other.attachedRigidbody.AddForce(-2*other.gameObject.rigidbody.velocity);
        }
    }
    void OnTriggerStay(Collider other) {
        print("Trigger Stay " + other.gameObject.name);
    }
    void OnTriggerExit(Collider other) {
        print("Trigger Exit " + other.gameObject.name);
    }
}
