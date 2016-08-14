using UnityEngine;
using System.Collections;

public class DestoryBullet : MonoBehaviour {
    


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //如果子彈碰到牆
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Bullet" || col.tag == "Enemy" || col.tag == "EnemyBullet")
        {
            DestroyObject(col.gameObject);
        }
    }
}
