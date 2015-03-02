using UnityEngine;
using System.Collections;

public class OnCollisionScript : MonoBehaviour {

    void OnCollisionEnter(Collision collision) {
        print("Collision Enter " + collision.gameObject.name);
    }

    void OnCollisionStay(Collision collision) {
        print("Collision Stay " + collision.gameObject.name);
    }

    void OnCollisionExit(Collision collision) {
        print("Collision Exit " + collision.gameObject.name);
    }
}
