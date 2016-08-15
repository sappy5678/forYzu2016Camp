using UnityEngine;
using System.Collections;

public class DoubleBullet : MonoBehaviour {
    public GameObject bullet;
    public int numberOfBullet = 1;
    public float forceLevel = 6;
    public float velocity = 0.16f;
    public float startRoate = 90f;
    public float frequence = 2f;

    // Use this for initialization
    void Start()
    {
        if (gameObject.tag != "Player")
        {
            InvokeRepeating("CreateBullet", 2f, frequence);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void CreateBullet()
    {
        //基數判斷(子彈置中)

        //設定角度
        float rotate = (float)(forceLevel *10f) / numberOfBullet;
        
        float tmp = rotate;
        rotate = startRoate + (forceLevel/2f*10f);
        //Quaternion tmp = Quaternion.Euler(0f, 0f, 180 - forceLevel * 10);
        //Quaternion tmp = Quaternion.identity;
        //gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 180f- forceLevel * 10f);
        // tmp.eulerAngles=new Vector3(0f, 0f, 180f - forceLevel * 10f);
        rotate -= tmp / 2f;
        for (int i = 0; i < numberOfBullet; i++)
        {
            
            GameObject obj = (GameObject)Instantiate(bullet, transform.position, transform.rotation);
            //obj.GetComponent<line>().Xvelocity = velocity * (tmp *Vector3.forward).x;
            //obj.GetComponent<line>().Yvelocity = velocity * (tmp * Vector3.forward).y;
            obj.transform.Rotate(new Vector3(0f, 0f, rotate));

            // obj.GetComponent<line>().Xvelocity = (Quaternion.Euler(0, 90, 0) * (new Vector3(0f, 0f, rotate))).x;
            // obj.GetComponent<line>().Yvelocity = (Quaternion.Euler(0, 90, 0) * (new Vector3(0f, 0f, rotate))).y;
            obj.GetComponent<line>().Xvelocity = Mathf.Cos(rotate * Mathf.Deg2Rad) * velocity;
            obj.GetComponent<line>().Yvelocity = Mathf.Sin(rotate * Mathf.Deg2Rad) * velocity;

            //obj.GetComponent<Rigidbody2D>().velocity = velocity;
            //tmp *= Quaternion.Euler(0f, 0f, 180f - forceLevel * 10f);
            rotate -= tmp;
        }
    }
}
