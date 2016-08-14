using UnityEngine;
using System.Collections;

public class line : MonoBehaviour {
    
    //直線(X相對位置,Y相對位置,X初速,Y初速,X加速,Y加速,加速開始秒數,加速結束秒數)
    [SerializeField]
    public float  Xvelocity = 0f, Yvelocity = -0.03f, Xacceleration = 0f, Yacceleration = 0f, Sseconds = -1.0f, Eseconds = -1.0f;
    private float time=0.0F,oneSecond=0F;
    public void Line( )
    {
        time = Time.deltaTime;

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
	
	}
	
	// Update is called once per frame
	void Update () {
        Line();
	}
}
