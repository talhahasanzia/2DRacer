using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {



    Vector3 moveDirection;


	// Use this for initialization
	void Start () {
        moveDirection = transform.right;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if(Car.Score>1500)
        Move();




	}


    void Move()
    {
        if(Car.GameOn)
        transform.Translate(moveDirection  * Time.deltaTime);
    
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "Wall")
        {


            moveDirection = -moveDirection;
        
        }

    }


    
}
