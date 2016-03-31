using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MouseSettings : MonoBehaviour {
    GameObject player;
    PlayerHealth playerhealth;
	// Use this for initialization
	void Start () {

        Cursor.visible = false;
        player = GameObject.FindGameObjectWithTag("leafy");
        playerhealth = player.GetComponent<PlayerHealth>();

	}
	
	// Update is called once per frame
	void Update () {
        if (playerhealth.Dead == true)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
	}
}
