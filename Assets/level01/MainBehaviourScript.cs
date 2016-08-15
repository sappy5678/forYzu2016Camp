using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class MainBehaviourScript : MonoBehaviour {
    public GameObject Bullet , CheckPoint;
    float nextFire=0.0f;
    public float velocity = 0.15f;

    // Use this for initialization

    [SerializeField]
    public int score = 0;
    public float power = 1f;
    public float boom = 3f;
    public float life = 5f;

    //設置 get set

    void Start ()
    {
        
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
            gameObject.transform.position += new Vector3(0, velocity, 0);
        }

        //向下移動
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.position += new Vector3(0, velocity * -1, 0);
        }

        //向左移動
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.position += new Vector3(velocity * -1, 0, 0);
        }

        //向右移動
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.position += new Vector3(velocity, 0, 0);
        }
        CheckPoint.transform.position = gameObject.transform.position;
        //開火
        if (Input.GetKey(KeyCode.Z) && Time.time>nextFire)
        {
            nextFire = Time.time + 0.1F;
            //Vector3 pos = gameObject.transform.position + new Vector3(0, 0.1f, 0);

            //Instantiate(Bullet, pos, gameObject.transform.rotation);
            GetComponent<DoubleBullet>().numberOfBullet = (int)power / 1;
            GetComponent<DoubleBullet>().CreateBullet();

        }
    }

    //被敵方子彈抓到
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "EnemyBullet")
        {
            life--;
            if (life < 1)
            {
                DestroyObject(gameObject);
                SceneManager.LoadScene("start");
            }
            ShowPlayerData.Instance.Showscore();
        }
    }



}

