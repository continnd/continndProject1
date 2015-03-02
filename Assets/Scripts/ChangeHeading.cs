using UnityEngine;
using System.Collections;

public class ChangeHeading : MonoBehaviour {
	
    public float rRate = 20.0f;

	// Update is called once per frame
	void Update () {
	    if (Input.GetKey(KeyCode.RightArrow)) {
            transform.Rotate(rRate * Vector3.up);
        }
	    if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.Rotate(-rRate * Vector3.up);
        }
	}
}
