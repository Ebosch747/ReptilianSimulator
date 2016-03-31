using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;
using System.Collections;

public class PlayerHealth : MonoBehaviour {
    public int startingHealth = 100;
    public int currentHealth;
    public Text healthText;
    public Image damageImage;
    public Canvas DeathCanvas;
    public AudioClip hurtClip;
    public float flashSpeed = 5f;
    public Color flashColor = new Color(1f, 0f, 0f, 0.1f);
  

    AudioSource playerAudio;
    public bool Dead;
    bool damaged;

    FirstPersonController FPSController;
    cannonscript cannon;
	// Use this for initialization

    void Awake()
    {
        
    
      
    }
	void Start () {
       
        playerAudio = GetComponent<AudioSource>();
        currentHealth = startingHealth;
        DeathCanvas.enabled = false;
        FPSController = GetComponent<FirstPersonController>();
        Cursor.visible = false;
    }
	
	// Update is called once per frame
	void Update () {
        healthText.text = ("HP " + currentHealth.ToString());
        if (damaged)
        {
            damageImage.color = flashColor;
            playerAudio.PlayOneShot(hurtClip, 0.7f);
        }
        else
        {
            damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);

        }

        damaged = false;
	}
    public void TakeDamage (int amount)
    {
        damaged = true;

        currentHealth -= amount;
     

        if (currentHealth <= 0 && !Dead)
        {
            Death();

        }

       
    }
    public void Death()
    {
        Dead = true;
        FPSController.enabled = false;
        healthText.enabled = false;
        DeathCanvas.enabled = true;
        Cursor.visible = true;

    }

    public void ContinuePress()
    {
        SceneManager.LoadScene("game");
    }

    public void QuitPress()
    {
        SceneManager.LoadScene("test");
    }
}
