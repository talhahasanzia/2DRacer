using UnityEngine;
using System.Collections;

public class CameraSet : MonoBehaviour {
    public GameObject Car;
    public static bool startGame=false;
	// Use this for initialization
	void Start () {
        startGame = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (startGame)
        {
            Vector3 newPositionForward = new Vector3(transform.position.x, Car.transform.position.y + 7, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, newPositionForward, 2 * Time.deltaTime);
        }
	}
}
