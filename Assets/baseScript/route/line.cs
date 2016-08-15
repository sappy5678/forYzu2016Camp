﻿using UnityEngine;
using System.Collections;

public class line : MonoBehaviour {
    
    //直線(X相對位置,Y相對位置,X初速,Y初速,X加速,Y加速,加速開始秒數,加速結束秒數)
    [SerializeField]
    public float  velocity = 0.15f,Xvelocity = 0f, Yvelocity = -0.03f, Xacceleration = 0f, Yacceleration = 0f, Sseconds = -1.0f, Eseconds = -1.0f;
    private float time=0.0F,oneSecond=0F;
    public GameObject player;
    public int trace = 0;
    public void Line( )
    {
        time = Time.time;

        if (time > Sseconds && time < Eseconds && (Eseconds - Sseconds) > 0 && time > oneSecond)
        {
            Xvelocity += Xacceleration;
            Yvelocity += Yacceleration;
            oneSecond = time + 1f;
        }

        gameObject.transform.position += new Vector3(Xvelocity, Yvelocity, 0);
    }

    // Use this for initialization
    void Start () {
        time = Time.time;
        Sseconds += time;
        Eseconds += time;
	    if(player == null)
        {
            player = GameObject.FindWithTag("Player");
        }
	}
	
	// Update is called once per frame
	void Update () {
        switch (trace)
        {
            case 0:
                Line();
                break;
            //自機狙
            case 1:
                Xvelocity = (player.transform.position - gameObject.transform.position).normalized.x * velocity;
                Yvelocity = (player.transform.position - gameObject.transform.position).normalized.y * velocity;
                gameObject.transform.Rotate(new Vector3(0, 0, Mathf.Acos(Vector3.Dot(player.transform.position.normalized, gameObject.transform.position.normalized))));
                trace = 0;
                break;
            //追蹤彈
            case 2:
                Xvelocity = (player.transform.position - gameObject.transform.position).normalized.x * velocity;
                Yvelocity = (player.transform.position - gameObject.transform.position).normalized.y * velocity;
                gameObject.transform.Rotate(new Vector3(0, 0, Mathf.Acos(Vector3.Dot(player.transform.position.normalized, gameObject.transform.position.normalized))));
                Line();
                break;

        }
        
	}
}
