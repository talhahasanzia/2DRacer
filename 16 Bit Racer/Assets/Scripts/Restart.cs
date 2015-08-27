using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Restart : MonoBehaviour {
   
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


        Application.LoadLevel(0);

        
    
    
    
    }
}
