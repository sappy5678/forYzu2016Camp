using UnityEngine;
using System.Collections;

public class EventController : MonoBehaviour {
    public GameObject Event;
    public float WaitTime = 0f;
	// Use this for initialization
	void Start () {
        Invoke("CreateEvent", WaitTime);
        Invoke("Destory", WaitTime+10f);
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    void OnDestroy()
    {
        
    }

    void CreateEvent()
    {
        GameObject obj = (GameObject)Instantiate(Event, new Vector3(0, 0, 0f), transform.rotation);
    }
    void Destory()
    {
        DestroyObject(gameObject);
    }
}
