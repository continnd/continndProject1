using UnityEngine;
using System.Collections;
[RequireComponent(typeof(CharacterController))]

public class ControllerMover : MonoBehaviour {

    CharacterController controller;
    public float ForwardSpeed=3.0f;
    public float maxRotationSpeed=5.0f;
    private Vector3 directionVector;
    private GameObject Player;

	// Use this for initialization
	void Start () {
	    controller = GetComponent<CharacterController>();
        directionVector = transform.forward;
        Player = GameObject.Find("Player");
	}

    // Update is called once per frame
    void Update () {
        if (Vector3.Magnitude(transform.position -
                    Player.transform.position) < 3.0f) {
            directionVector = transform.position -
                Player.transform.position;
            directionVector.y = 0f;
            directionVector = Vector3.Normalize(directionVector);
        }
        transform.forward = Vector3.Slerp(transform.forward,
                directionVector, Time.deltaTime * maxRotationSpeed);
        controller.Move(directionVector * ForwardSpeed * Time.deltaTime);
    }

    void OnControllerColliderHit (ControllerColliderHit hit) {
        directionVector = Vector3.Reflect(directionVector, hit.normal);
        directionVector.y = 0;
        directionVector.Normalize();
    }
}
