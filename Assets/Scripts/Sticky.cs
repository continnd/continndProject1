using UnityEngine;
using System.Collections;

public class Sticky : MonoBehaviour {

    CharacterController controller;
    private int numSticked = 0;
    public GameObject ui;
    public GameObject ball;

    void Update() {
    UnityEngine.UI.Text text = ui.GetComponent<UnityEngine.UI.Text>();
        text.text = System.String.Format("Score: {0}", numSticked);
    }

    void OnControllerColliderHit(ControllerColliderHit hit) {
        controller = hit.gameObject.GetComponent<CharacterController>();
        if (hit.gameObject.tag == "Stickable") {
            if (controller != null) {
                Destroy(hit.gameObject.GetComponent<ControllerMover>());
                Destroy(controller);
            } else {
                Destroy(hit.gameObject.rigidbody);
                Destroy(hit.gameObject.GetComponent<Collider>());
            }
            hit.gameObject.transform.parent = ball.transform;
            hit.gameObject.AddComponent<Explode>();
            numSticked++;
        }
    }
}
