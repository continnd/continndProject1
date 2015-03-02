using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour {

    public GameObject cbInstance;
    public GameObject graphics;

	void Start () {
	    InvokeRepeating("Shoot", 2f, 2.0f);
	}

    void Shoot() {
        Vector3 endOfGun = transform.TransformDirection(new Vector3(0.0f, 0.0f, 4.0f));
        GameObject instance = Instantiate(cbInstance, transform.position + endOfGun, transform.rotation) as GameObject;
        instance.rigidbody.velocity = transform.TransformDirection(Vector3.forward * 20.0f);
        Physics.IgnoreCollision(graphics.collider, instance.collider);
        Destroy(instance, 10.0f);
    }
}
