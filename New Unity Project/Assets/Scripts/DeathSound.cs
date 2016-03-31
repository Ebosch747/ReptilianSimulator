using UnityEngine;
using System.Collections;

public class DeathSound : MonoBehaviour {

    public AudioClip deathClip;

    AudioSource deathSound;
    PlayerHealth playerhealth;
    GameObject player;
    bool hasPlayed = false;


	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("leafy");
        playerhealth = player.GetComponent<PlayerHealth>();
        deathSound = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

        if (playerhealth.Dead && !hasPlayed)
        {
            deathSound.PlayOneShot(deathClip, 1f);
            hasPlayed = true;
           
        }

        
	}

    
}
