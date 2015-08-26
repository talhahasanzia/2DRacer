using UnityEngine;
using System.Collections;

public class Spawning : MonoBehaviour {
    
    
    public GameObject obj;
    public float S_Max = 1f;
    public float S_Min = 2f;
    float incY = 9.36f;


    public GameObject CarEnemy;



    





	// Use this for initialization
	void Start () {
        Spawn();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void Spawn()
    {

        Vector3 newPosition = new Vector3(obj.transform.position.x, obj.transform.position.y +incY , obj.transform.position.z);
        Object newObject=Instantiate(obj,newPosition,Quaternion.identity);

        //Destroy(newObject, 30);



        float xPos = Random.Range(-1, 1);
        xPos=Mathf.Ceil(xPos);

        Debug.Log("X Position: " + xPos);

        CarEnemy.transform.localPosition = new Vector3(xPos, CarEnemy.transform.localPosition.y, CarEnemy.transform.localPosition.z);
        Invoke("Spawn",0.3f);
        
        incY += 9.36f;
    
    }
}
