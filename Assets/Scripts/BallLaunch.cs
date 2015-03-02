using UnityEngine;
using System.Collections;

public class BallLaunch : MonoBehaviour {

    public GameObject cbPrefab;
    public float projectileSpeed = 10.0f;

    void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) {
                GameObject cbInstance;
                cbInstance = Instantiate(cbPrefab, transform.position, transform.rotation) as GameObject;
                cbInstance.rigidbody.velocity = transform.TransformDirection(Vector3.forward * projectileSpeed);
                Destroy(cbInstance, 10.0f);
        }
     }
}
