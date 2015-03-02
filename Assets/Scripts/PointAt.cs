using UnityEngine;
using System.Collections;

public class PointAt : MonoBehaviour {

    public Transform target;

	void Update () {
	    transform.LookAt(target);
	}
}
