using UnityEngine;
using System.Collections;

public class WASDMovement : MonoBehaviour {
    public float fSpeed = 5.0f;

	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W)) {
	        gameObject.transform.Translate(fSpeed * Vector3.forward);
        }
        if (Input.GetKey(KeyCode.S)) {
	        gameObject.transform.Translate(fSpeed * Vector3.back / 3);
        }
        if (Input.GetKey(KeyCode.A)) {
	        gameObject.transform.Translate(fSpeed * Vector3.left * 2 / 3);
        }
        if (Input.GetKey(KeyCode.D)) {
	        gameObject.transform.Translate(fSpeed * Vector3.right * 2 / 3);
        }
	}
}
