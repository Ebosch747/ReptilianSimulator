using UnityEngine;
using System.Collections;

public class lizardCollideScript : MonoBehaviour {

    public GameObject explosion;
    public scoreCounter score;

    EnemySpawner spawnscript;
    GameObject EnemySpawner;
    GameObject player;
   
	// Use this for initialization
	void Start () {
        EnemySpawner = GameObject.FindGameObjectWithTag("spawner");
        player = GameObject.FindGameObjectWithTag("leafy");
        score = player.GetComponent<scoreCounter>();
        spawnscript = EnemySpawner.GetComponent<EnemySpawner>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("cancer"))
        {
            score.AddPoints();
            Instantiate(explosion, transform.position, transform.rotation);
            spawnscript.enemies.Remove(spawnscript.enemy);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        else
        {
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
       
    }
}
