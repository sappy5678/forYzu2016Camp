using UnityEngine;
using System.Collections;

public class DestoryEnemy : MonoBehaviour {

    public GameObject player;
    public Canvas ScoreText;
    public GameObject PlayerData;
    [SerializeField]
    int score = 3;
    [SerializeField]
    float boom = 0f, power = 0.05f, life=2f;

    // Use this for initialization
    void Start () {
        if (player == null)
        {
            player = GameObject.FindWithTag("Player");
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Bullet")
        {
            //判定生命
            life--;
            if (life < 1)
            {
                DestroyObject(gameObject);
                player.GetComponent<MainBehaviourScript>().power += power;
                player.GetComponent<MainBehaviourScript>().life += life;
                player.GetComponent<MainBehaviourScript>().boom += boom;
            }
            player.GetComponent<MainBehaviourScript>().score += score;
            ShowPlayerData.Instance.Showscore();
            
        }
    }
}
