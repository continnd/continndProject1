using UnityEngine;
using System.Collections;

public class ControllerMoverEnemy : MonoBehaviour {

    CharacterController controller;
    public float ForwardSpeed = 2.5f;
    public float maxRotationSpeed = 5.0f;
    private Vector3 directionVector;
    private GameObject Player;

	void Start () {
	    controller = GetComponent<CharacterController>();
        directionVector = transform.forward;
        Player = GameObject.Find("Player");
	}
	
	void Update () {
	    directionVector = Vector3.Normalize(Player.transform.position - transform.position) * ForwardSpeed;
        directionVector.y = 0.0f;
        transform.forward = Vector3.Slerp(transform.forward, directionVector, Time.deltaTime * maxRotationSpeed);
        controller.Move(directionVector * ForwardSpeed * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, 1.05f, transform.position.z);
	}

    void OnControllerColliderHit(ControllerColliderHit hit) {
        print(hit.gameObject.name);
        if (hit.gameObject.name == "Player")
            Destroy(GameObject.Find("StickyBall"));
    }
}
