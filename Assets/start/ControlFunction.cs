using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class ControlFunction : MonoBehaviour {
    public static ControlFunction Controller;
    public  GameObject PlayButton;
    public  GameObject ExitButton;
    // Use this for initialization
    void Start () {
        Controller = this;
    }
	
	// Update is called once per frame
	void Update () {
	

	}
    public void GameStart()
    {
        
        SceneManager.LoadScene("level01");
        
    }
    public void GameExit()
    {
        Application.Quit();
    }
}

