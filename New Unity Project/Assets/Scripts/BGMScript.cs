using UnityEngine;
using System.Collections;

public class BGMScript : MonoBehaviour {
    public AudioClip[] musicpieces;

    GameObject player;
    PlayerHealth playerhealth;
    AudioSource audioSource;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("leafy");
        playerhealth = player.GetComponent<PlayerHealth>();
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        if (!audioSource.isPlaying && !playerhealth.Dead)
        {
            audioSource.clip = musicpieces[Random.Range(0, musicpieces.Length)];
            audioSource.Play();
        }

        if (playerhealth.Dead)
        {
            audioSource.Stop();
        }
	}
}
