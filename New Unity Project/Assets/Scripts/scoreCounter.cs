using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class scoreCounter : MonoBehaviour {
    public Text scoreText;
    public Text Clock;
    public Text highScoreText;
    public Text highTimeText;
    public float Timer;
    public float HighTime;
    public int kills;
    public int highScore;

    GameObject player;
    PlayerHealth playerhealth;
    // Use this for initialization
    void Start() {

        player = GameObject.FindGameObjectWithTag("leafy");
        playerhealth = player.GetComponent<PlayerHealth>();
        
    }

    // Update is called once per frame
    void Update() {
        TimerFunction();
        RetrieveHighScore();
        RetrieveHighTime();
        if (kills >= highScore)
        {
            highScore = kills;
        }

        if (Timer >= HighTime)
        {
            HighTime = Timer;
        }
        
        scoreText.text = ("Kills: " + kills.ToString());
        Clock.text = ("Time Alive: " + Timer);

        PlayerPrefs.SetInt("High Score", highScore);
        PlayerPrefs.SetFloat("High Time", HighTime);

    }

    public void AddPoints()
    {
        kills = kills + 1;
    }

    public void RetrieveHighScore()
    {
        highScoreText.text = ("High Score: " + (PlayerPrefs.GetInt("High Score")));
    }

    public void RetrieveHighTime()
    {
        highTimeText.text = ("Longest Time: " + (PlayerPrefs.GetFloat("High Time")));
    }

    public void TimerFunction()
    {
        if(playerhealth.Dead)
        {
            return;
        }
        Timer = Timer + Time.deltaTime;
    }
}
