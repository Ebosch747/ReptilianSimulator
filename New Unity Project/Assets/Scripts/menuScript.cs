using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class menuScript : MonoBehaviour {

    public Canvas quitMenu;
    public Button startText;
    public Button exitText;
    public Button creditsText;
    public Text highScore;
    public Text highTime;

	// Use this for initialization
	void Start () {
       
        quitMenu = quitMenu.GetComponent<Canvas>();
        startText = startText.GetComponent<Button>();
        exitText = startText.GetComponent<Button>();
        creditsText = creditsText.GetComponent<Button>();
        quitMenu.enabled = false;
	
	}

    
	
    public void ExitPress()
    {
        quitMenu.enabled = true;
        startText.enabled = false;
        exitText.enabled = false;
        creditsText.enabled = false;

    }

    public void NoPress()
    {
        quitMenu.enabled = false;
        startText.enabled = true;
        exitText.enabled = true;
        creditsText.enabled = true;
    }

    public void StartLevel()
    {
        SceneManager.LoadScene("game");
    }

    public void ExitGame()
    {
        Application.Quit();

    }

    public void StartCredits()
    {
        SceneManager.LoadScene("credits");
    }

    

	// Update is called once per frame
	void Update () {
        highScore.text = ("High Score: " + (PlayerPrefs.GetInt("High Score")));
        highTime.text = ("High Score: " + (PlayerPrefs.GetFloat("High Time")));
	}
}
