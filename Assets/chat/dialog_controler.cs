using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class dialog_controler : MonoBehaviour 
{
	public GameObject dialog01;
	public GameObject dialog02;
	public GameObject dialog03;
	public GameObject dialog04;
	public GameObject dialog_field;
	public bool IsInDialog;
	int down_time=0;
	void Awake()
	{
		IsInDialog = false;
		down_time = 0;
	}
	// Use this for initialization
	void Start () 
	{
		
		IsInDialog = true;
		dialog01.SetActive (false);
		dialog02.SetActive (false);
		dialog03.SetActive (false);
		dialog04.SetActive (false);
		dialog_field.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () 
	{
		//時間暫停
		if (IsInDialog==true) 
		{
			dialog_field.SetActive (true);
			Time.timeScale = 0;
		} 
		else if(IsInDialog==false)
		{
			dialog_field.SetActive (false);
			Time.timeScale = 1;
		}
		//end
		//感應按鍵
		if (down_time < 20) {
			if (Input.GetKeyDown(KeyCode.Z)) 
			{
				down_time += 1;
			}			
			if (Input.GetKeyDown(KeyCode.Escape)) 
			{
				down_time += 50;
			}
		}
		//按的次數來算第幾個對話
		if (down_time == 0) {
			dialog01.SetActive (true);
		} else if (down_time == 1) {
			dialog01.SetActive (false);
			dialog02.SetActive (true);
		} else if (down_time == 2) {
			dialog02.SetActive (false);
			dialog03.SetActive (true);
		} else if (down_time == 3) {
			dialog03.SetActive (false);
			dialog04.SetActive (true);
		} else if (down_time == 4||down_time>=20) {
			dialog04.SetActive (false);
			IsInDialog = false;
		}


	}
}
