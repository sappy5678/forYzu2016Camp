using UnityEngine;
using System.Collections;

public class enemywave_symmetry : MonoBehaviour {
    public GameObject enemy;
    float Xlocal = 4f;
    [SerializeField]
    float Xvelocity = 0f, Yvelocity = 0f, Xacceleration = 0f, Yacceleration = 0f, Sseconds = -1f, Eseconds = -1f, worktime = 10f+ Time.time;
    // Use this for initialization
    void Start ()
    {
        InvokeRepeating("CreateEnemy", 0f, 1f);

    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > worktime)
        {
            DestroyObject(gameObject);
        }
    }

    void CreateEnemy()
    {
        
        //右邊的怪物
        GameObject obj = (GameObject)Instantiate(enemy,new Vector3(Xlocal, 4f,0f), transform.rotation);
        obj.GetComponent<line>().Xvelocity = Xvelocity;
        obj.GetComponent<line>().Xacceleration = Xacceleration;
        obj.GetComponent<line>().Yvelocity = Yvelocity;
        obj.GetComponent<line>().Yacceleration = Yacceleration;
        obj.GetComponent<line>().Sseconds = Sseconds;
        obj.GetComponent<line>().Eseconds = Eseconds;

        //左邊的怪物
        obj = (GameObject)Instantiate(enemy, new Vector3(Xlocal * -1f, 4f, 0f), transform.rotation);
        obj.GetComponent<line>().Xvelocity = Xvelocity * -1f;
        obj.GetComponent<line>().Xacceleration = Xacceleration * -1f;
        obj.GetComponent<line>().Yvelocity = Yvelocity;
        obj.GetComponent<line>().Yacceleration = Yacceleration;
        obj.GetComponent<line>().Sseconds = Sseconds;
        obj.GetComponent<line>().Eseconds = Eseconds;
        
    }

}
