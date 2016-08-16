using UnityEngine;
using System.Collections;

public class enemywave_U2D : MonoBehaviour
{
    public GameObject enemy;
    float Xlocal = 0f, Ylocal=5.5f,oneSecond=1f;
    [SerializeField]
    float frequence = 1.2f,deletime=0f,Xvelocity = 0f, Yvelocity = -0.01f, Xacceleration = 0f, Yacceleration = 0.001f, Sseconds = 0f, Eseconds = 10f, worktime = 5f;
    public int numberOfEnemy = 5;
    [SerializeField]
    float[] Xl = { 0, 1, -1, 2, -2, 0f };
    float diff;
    int tmp = 0;
    // Use this for initialization
    void Start()
    {
        
        //InvokeRepeating("CreateEnemy", deletime, frequence);
        worktime += Time.time+ deletime;
        oneSecond = Time.time + deletime;
        diff = Time.time + deletime;


    }

    // Update is called once per frame
    void Update()
    {
        
        if (Time.time > worktime)
        {
            //DestroyObject(gameObject);
            this.enabled = false;
            CancelInvoke();
        }

        if (numberOfEnemy <= 0)
        {
            this.enabled = false;
            CancelInvoke();
        }
        if (Time.time - oneSecond>frequence)
        {
            Invoke("CreateEnemy", 0);
            Xlocal = Xl[tmp];
            oneSecond = frequence+ Time.time;
            numberOfEnemy--;
            tmp++;
        }

    }

    void CreateEnemy()
    {

            //右邊的怪物
            GameObject obj = (GameObject)Instantiate(enemy, new Vector3(Xlocal, Ylocal, 0f), transform.rotation);
            obj.GetComponent<line>().Xvelocity = Xvelocity;
            obj.GetComponent<line>().Xacceleration = Xacceleration;
            obj.GetComponent<line>().Yvelocity = Yvelocity;
            obj.GetComponent<line>().Yacceleration = Yacceleration;
            obj.GetComponent<line>().Sseconds = Sseconds;
            obj.GetComponent<line>().Eseconds = Eseconds;


    }

}
