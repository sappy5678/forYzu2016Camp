using UnityEngine;
using System.Collections;

public class ShowCheckPoint : MonoBehaviour {
    public GameObject player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
        //專注模式
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            GetComponent<SpriteRenderer>().enabled = true;
            player.GetComponent<DoubleBullet>().forceLevel = 1;
            player.GetComponent<MainBehaviourScript>().velocity = 0.1f;
        }

        //非專注模式
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            GetComponent<SpriteRenderer>().enabled = false;
            player.GetComponent<DoubleBullet>().forceLevel = 6;
            player.GetComponent<MainBehaviourScript>().velocity = 0.15f;
        }
    }
}
