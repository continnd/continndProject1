using UnityEngine;
using System.Collections;

public class Pickuper : MonoBehaviour {

    private int coins = 0;

	void Update () {
        string text = System.String.Format("{00}", coins);
        GUI.Label(new Rect(0, 0, 10, 10), text);
	}

    void OnControllerColliderHit(ControllerColliderHit hit) {
        if (hit.gameObject.tag.Equals("Currency")) {
            coins++;
            print("Picked up a coin!");
            Destroy(hit.gameObject, 0.0f);
        }
    }
}
