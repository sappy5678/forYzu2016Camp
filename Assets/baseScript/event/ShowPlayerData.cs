using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShowPlayerData : MonoBehaviour {
    public Text ScoreText;
    public Text DataText;
    public static ShowPlayerData Instance;
    MainBehaviourScript playerdata;

    // Use this for initialization
    void Start () {
        Instance = this;
        playerdata = GameObject.Find("player").GetComponent<MainBehaviourScript>();
        ScoreText.text = "Score: " + playerdata.score;
        DataText.text = "Life: " + playerdata.life + "\n"
                        + "Boom: " + playerdata.boom + "\n"
                        + "Power: " + playerdata.power;
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    public void Showscore()
    {
        ScoreText.text = "Score: " + playerdata.score;
        DataText.text = "Life: " + playerdata.life + "\n"
                        + "Boom: " + playerdata.boom + "\n"
                        + "Power: " + playerdata.power;
    }
}
