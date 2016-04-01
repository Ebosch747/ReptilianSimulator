using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemySpawner : MonoBehaviour {
    public List<GameObject> enemies = new List<GameObject>();
    public GameObject enemy;
    public int maxenemies;
  
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
        if (enemies.Count <= maxenemies)
        {
            Instantiate(enemy, spawner.position, spawner.rotation);
            enemies.Add(enemy);
        }
        else
        {
            return;
        }
        
    }
}
