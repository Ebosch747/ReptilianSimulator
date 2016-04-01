using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;
using System.Collections;

public class MoreFPSControllerSettings : MonoBehaviour {
    FirstPersonController controller;
    GameObject gun;
    cannonscript cannonDeath;
    PlayerHealth playerhealth;
    public Canvas pauseCanvas;
    private bool isPaused;
    private bool pausebuttonpressed;
	// Use this for initialization
	void Start () {
        
        controller = GetComponent<FirstPersonController>();
        pauseCanvas.enabled = false;
        isPaused = false;
        gun = GameObject.FindGameObjectWithTag("gun");
        cannonDeath = gun.GetComponent<cannonscript>();
        playerhealth =GetComponent<PlayerHealth>();
	}
	
	// Update is called once per frame
	void Update () {
        PauseManager();
        if (Input.GetKey(KeyCode.S))
        {
            controller.m_WalkSpeed = 5f;
            controller.m_RunSpeed = 10f;
        }

        if (!Input.GetKey(KeyCode.S))
        {
            controller.m_WalkSpeed = 10f;
            controller.m_RunSpeed = 20f;
        }

       
	}

   

    public void PauseQuitPress()
    {
        SceneManager.LoadScene("test");
    }

    public void PauseManager()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
            isPaused = true;
            
        }

        if (isPaused && !playerhealth.Dead)
        {
          
            Time.timeScale = 0;
            pauseCanvas.enabled = true;
            controller.enabled = false;
            Cursor.visible = true;
            cannonDeath.enabled = false;
        }
        if (!isPaused && !playerhealth.Dead)
        {

            Time.timeScale = 1;
            pauseCanvas.enabled = false;
            controller.enabled = true;
            Cursor.visible = false;
            cannonDeath.enabled = true;
        }

        

        
    }
    public void PauseContinuePress()
    {
        isPaused = !isPaused;
    }

}
