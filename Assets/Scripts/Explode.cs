using UnityEngine;
using System.Collections;

public class Explode : MonoBehaviour {

public GameObject explosion;

    // Update is called once per frame
    void Update () {
        if (Input.GetKey(KeyCode.E)) {
            gameObject.AddComponent<Rigidbody>();
            gameObject.rigidbody.AddForce(Vector3.Normalize(
                    transform.position - transform.parent.position) * 5000);
            GameObject temp = Instantiate(Resources.Load(
                    "Small explosion with sound"), transform.position,
                    Quaternion.identity) as GameObject;
            Destroy(gameObject, 1);
            Destroy(temp, 2);
        }
    }
}
