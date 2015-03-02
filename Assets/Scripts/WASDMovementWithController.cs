using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]

public class WASDMovementWithController : MonoBehaviour {
    public float fSpeed = 3.0f;
    private CharacterController controller;
    private float fallSpeed;
    public float jumpSpeed = 0.1f;

    void Start() {
        controller = GetComponent<CharacterController>();
    }

	void Update() {
        Vector3 moveVector = Vector3.zero;

        if (!controller.isGrounded) {
            fallSpeed += Physics.gravity.y / 2 * Time.deltaTime;
        } else if (Input.GetKey(KeyCode.J)) {
            fallSpeed = jumpSpeed;
        } else {
            fallSpeed = 0;
        }

        if (Input.GetKey(KeyCode.W)) {
            moveVector = transform.TransformDirection(Vector3.forward) * fSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S)) {
            moveVector += transform.TransformDirection(Vector3.back) * fSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A)) {
            moveVector += transform.TransformDirection(Vector3.left) * fSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D)) {
            moveVector += transform.TransformDirection(Vector3.right) * fSpeed * Time.deltaTime;
        }

        moveVector.y = fallSpeed;
        controller.Move(moveVector);
    }
}
