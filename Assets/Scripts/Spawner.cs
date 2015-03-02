using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
    public GameObject ObjectToSpawn;
    public GameObject ObjectToSpawn1;
    public int totalToSpawn = 40;
    public float spawnInterval = 5.0f;
    private int numSpawned = 0;
    private float timer = 0;
    public GameObject Dog;

    void Start () {
        StartCoroutine("Spawn");
        InvokeRepeating("SpawnDog", 2.1f, 60.0f);
    }

    void Update() {
        timer += Time.deltaTime;
    }

    IEnumerator Spawn() {
        while (true) {

            float rand = Random.value;
            Quaternion randomRotation = Quaternion.AngleAxis(
                    Random.Range(0,360), Vector3.up);

            if (rand <= 0.5f) {
            GameObject temp = Instantiate(ObjectToSpawn,
                    new Vector3(Random.Range(-25, 25),
                        0.0f, Random.Range(-25, 25)),
                    randomRotation) as GameObject;
            } else {
            GameObject temp = Instantiate(ObjectToSpawn1,
                    new Vector3(Random.Range(-25, 25),
                        2.0f, Random.Range(-25, 25)),
                    randomRotation) as GameObject;
            }

            numSpawned++;
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    void SpawnDog() {
            Quaternion randomRotation = Quaternion.AngleAxis(
                    Random.Range(0,360), Vector3.up);
            GameObject temp = Instantiate(Dog,
                    new Vector3(Random.Range(-25, 25),
                        1.05f, Random.Range(-25, 25)),
                    randomRotation) as GameObject;
    }
}
