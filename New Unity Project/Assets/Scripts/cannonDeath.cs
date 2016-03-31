using UnityEngine;
using System.Collections;

public class cannonDeath : MonoBehaviour {

    PlayerHealth playerhealth;
    cannonscript cannon;
    GameObject player;
    GameObject gun;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("leafy");
        playerhealth = player.GetComponent<PlayerHealth>();
        gun = GameObject.FindGameObjectWithTag("gun");
        cannon = gun.GetComponent<cannonscript>();
	}
	
	// Update is called once per frame
	void Update () {
        if (playerhealth.Dead)
        {
            cannon.enabled = false;
        }
	}
}
