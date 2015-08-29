using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StartScript : MonoBehaviour {
    public GameObject exitButton;
    public GameObject scoreText;
    public Button butt;
   // public GameObject startButton;
	// Use this for initialization
	void Start () {
        butt.onClick.AddListener(OnClick);
	}
	
	// Update is called once per frame
	void Update () {
	

        

	}

    


    void OnClick()
    {

        Debug.Log("On click");
        exitButton.SetActive(false);
        Spawning.justBloodyStartTheGame = true;
        Car.GameOn = true;
        CameraSet.startGame = true;
        gameObject.SetActive(false);
        scoreText.SetActive(true);
    }

}
