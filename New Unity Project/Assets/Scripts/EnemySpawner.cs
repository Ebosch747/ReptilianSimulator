using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {
    public GameObject enemy;
     Transform spawner;
    public float spawnTime;
	// Use this for initialization
	void Start () {
        spawner = GetComponent<Transform>();
        InvokeRepeating("Spawn", spawnTime, spawnTime);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void Spawn()
    {
        Instantiate(enemy, spawner.position, spawner.rotation);
    }
}
