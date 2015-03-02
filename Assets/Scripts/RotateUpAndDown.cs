using UnityEngine;
using System.Collections;

public class RotateUpAndDown : MonoBehaviour {
	
    public float rRate = 20.0f;

	// Update is called once per frame
	void Update () {
	    if (Input.GetKey(KeyCode.UpArrow) && GetPlusMinusAngle(transform.localEulerAngles.x) >= -45) {
            transform.Rotate(rRate * Vector3.left);
        }
	    if (Input.GetKey(KeyCode.DownArrow) && GetPlusMinusAngle(transform.localEulerAngles.x) <= 45) {
            transform.Rotate(-rRate * Vector3.left);
        }
    }

    float GetPlusMinusAngle(float angle) {
        if (angle > 180) {
            return angle -360;
        } else {
            return angle;
        }
    }
}
