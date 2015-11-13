using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class Pause : MonoBehaviour {
	public Button Exit;
	public Button Resume;
	public Button butt;
	// Use this for initialization
	void Start () {
		butt.onClick.AddListener(OnClick);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnClick()
	{
		
if (Time.timeScale == 0)
			Time.timeScale = 1;
		else
			Time.timeScale = 0;
		
		//Car.GameOn = false;


		//this.enabled = false;
		//Resume.enabled=(true);
		//Exit.enabled=(true);
		
		
	}
}
