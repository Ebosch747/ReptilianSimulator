using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class CreditsScript : MonoBehaviour {
    public Button leave;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Leave()
    {
        SceneManager.LoadScene("Test");
    }
}
