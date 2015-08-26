using UnityEngine;
using System.Collections;

public class Spawning : MonoBehaviour {
    
    
    public GameObject obj;
    public float S_Max = 1f;
    public float S_Min = 2f;
    float incY = 9.36f;
    int waitFor = 0;

    public GameObject CarEnemy;

   

    float[] poses = new float[2];


    public static bool justBloodyStartTheGame=false;


	// Use this for initialization
	void Start () {
        
        
        
        poses[0] = -1.05f;
        poses[1] = 1.02f;
	}
	
	// Update is called once per frame
	void Update () {
	        
        if(justBloodyStartTheGame)
            {

                Spawn();
                justBloodyStartTheGame = false;

            }
	}

    void Spawn()
    {

        Vector3 newPosition = new Vector3(obj.transform.position.x, obj.transform.position.y +incY , obj.transform.position.z);


       
            Object newObject = Instantiate(obj, newPosition, Quaternion.identity);

            //Destroy(newObject, 30);


            if (waitFor > 3)
            {
            
           

            CarEnemy.transform.localPosition = new Vector3(poses[Random.Range(0,2)], CarEnemy.transform.localPosition.y, CarEnemy.transform.localPosition.z);
        }



        waitFor++;
        Invoke("Spawn", 0.3f);
        
        incY += 9.36f;
    
    }
}
