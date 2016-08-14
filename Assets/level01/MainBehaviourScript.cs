using UnityEngine;
using System.Collections;


public class MainBehaviourScript : MonoBehaviour {
    public GameObject Bullet;
    float nextFire=0.0f;

    // Use this for initialization
    

    public int score { get; set; } 
    public float power { get; set; }
    public float boom { get; set; }
    public float life { get; set; }

    //設置 get set

    void Start ()
    {
        score = 0;
        power = 1f;
        boom = 3f;
        life = 5f;
        
    }
	
	// Update is called once per frame
	void Update () {
        Move();

    }

    void Move()
    {
        //向上移動
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.transform.position += new Vector3(0, 0.15f, 0);
        }

        //向下移動
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.position += new Vector3(0, -0.15f, 0);
        }

        //向左移動
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.position += new Vector3(-0.15f, 0, 0);
        }

        //向右移動
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.position += new Vector3(0.15f, 0, 0);
        }

        //開火
        if (Input.GetKey(KeyCode.Z) && Time.time>nextFire)
        {
            nextFire = Time.time + 0.1F;
            //Vector3 pos = gameObject.transform.position + new Vector3(0, 0.1f, 0);

            //Instantiate(Bullet, pos, gameObject.transform.rotation);
            GetComponent<DoubleBullet>().CreateBullet();

        }
    }

    
    
}

