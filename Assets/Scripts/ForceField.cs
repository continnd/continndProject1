using UnityEngine;
using System.Collections;

public class ForceField : MonoBehaviour {

    void OnTriggerEnter(Collider collision) {
        if(collision.gameObject.tag == "projectile") {
            collision.attachedRigidbody.AddForce(-collision.gameObject.rigidbody.velocity);
        }
    }
}
