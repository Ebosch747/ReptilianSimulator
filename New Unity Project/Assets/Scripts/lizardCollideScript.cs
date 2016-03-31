using UnityEngine;
using System.Collections;

public class lizardCollideScript : MonoBehaviour {

    public GameObject explosion;
    public scoreCounter score;

    GameObject player;
   
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("leafy");
        score = player.GetComponent<scoreCounter>();
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
