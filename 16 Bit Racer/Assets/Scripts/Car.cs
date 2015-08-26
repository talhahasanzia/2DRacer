using UnityEngine;
using System.Collections;

public class Car : MonoBehaviour {
    Quaternion startRotation;
    Quaternion constRotation;



	// Use this for initialization
	void Start () {
        startRotation=transform.rotation;
        constRotation=new Quaternion(startRotation.x,startRotation.y,startRotation.z,startRotation.w);
	}
	
	// Update is called once per frame
	void Update () {



        Vector3 newPositionForward=new Vector3(transform.position.x,transform.position.y+5,transform.position.z);
        transform.position = Vector3.Lerp(transform.position, newPositionForward, 2 * Time.deltaTime);
        this.transform.rotation = constRotation;

        if (Input.GetKey(KeyCode.RightArrow))
        { 
        Vector3 newPosition=new Vector3(transform.position.x+2,transform.position.y,transform.position.z);
        transform.position = Vector3.Lerp(transform.position, newPosition,2*Time.deltaTime);
        
        
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 newPosition = new Vector3(transform.position.x - 2, transform.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, newPosition, 2 * Time.deltaTime);


        }
	}
}
