using UnityEngine;
using System.Collections;

public class CharacterPusher : MonoBehaviour {

    private int coins = 0;

    void Update () {
        string text = System.String.Format("{00}", coins);
        GUI.Label(new Rect(0, 0, 10, 10), text);
    }

    void OnControllerColliderHit(ControllerColliderHit hit) {
        if (hit.gameObject.GetComponent<Rigidbody>() != null) {
            Vector3 direction = Vector3.Normalize(hit.gameObject.transform.position - transform.position);
            hit.gameObject.rigidbody.AddForce( direction * 10);
        }

        if(hit.gameObject.tag.Equals("Currency")) {
            coins++;
            Destroy(hit.gameObject, 0.0f);
        }
    }
}
