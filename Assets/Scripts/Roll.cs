using UnityEngine;
using System.Collections;

public class Roll : MonoBehaviour {

    private float circumference;
    private Mesh mesh;
    public ChangeHeading changeHeading;
    private Vector3 prevPos;

	void Start () {
        mesh = GetComponent<MeshFilter>().mesh;
        circumference = mesh.bounds.size.x * 2 * Mathf.PI;
        prevPos = transform.position;
    }

    void Update () {
        Vector3 disp = transform.position - prevPos;
        if(Input.GetKey(KeyCode.RightArrow)) {
            transform.Rotate(-changeHeading.rRate * Vector3.up);
        }
        if(Input.GetKey(KeyCode.LeftArrow)) {
            transform.Rotate(changeHeading.rRate * Vector3.up);
        }

        transform.RotateAround(transform.position,
                Vector3.Cross(Vector3.up, disp),
                disp.magnitude / circumference * 360.0f);
        prevPos = transform.position;
    }
}
