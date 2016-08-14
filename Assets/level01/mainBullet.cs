using UnityEngine;
using System.Collections;

public class mainBullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.position += new Vector3(0, 0.16f, 0);
    }
}
