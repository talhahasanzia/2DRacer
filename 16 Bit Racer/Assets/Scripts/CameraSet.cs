using UnityEngine;
using System.Collections;

public class CameraSet : MonoBehaviour {
    public GameObject Car;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 newPositionForward = new Vector3(transform.position.x, Car.transform.position.y + 5, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, newPositionForward, 2 * Time.deltaTime);
     
	}
}
