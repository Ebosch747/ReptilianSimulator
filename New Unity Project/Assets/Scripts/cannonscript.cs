using UnityEngine;
using System.Collections;

public class cannonscript : MonoBehaviour {

    public GameObject prefab;
    public AudioClip shots;
    AudioSource audio;

	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();

	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetMouseButtonDown(0))
        {
            audio.PlayOneShot(shots, 0.7f);
            GameObject projectile = Instantiate(prefab) as GameObject;
            projectile.transform.position = transform.position + Camera.main.transform.forward*2;
            Rigidbody rb = projectile.GetComponent<Rigidbody>();
            rb.velocity = Camera.main.transform.forward * 40;
        }
	}
}
