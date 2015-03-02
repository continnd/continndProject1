using UnityEngine;
using System.Collections;

public class CannonLaunch : MonoBehaviour {

    public GameObject cbPrefab;
    public GameObject graphics;
    public float cannonSpeed = 500.0f;

    void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) {
            GameObject cbInstance;
            cbInstance = Instantiate(cbPrefab, gameObject.transform.position, gameObject.transform.rotation) as GameObject;
            cbInstance.rigidbody.velocity = transform.TransformDirection(Vector3.forward * cannonSpeed);
            Physics.IgnoreCollision(graphics.collider, cbInstance.collider);
            Destroy(cbInstance, 10.0f);
        }
    }
}
