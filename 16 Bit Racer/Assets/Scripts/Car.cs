using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Car : MonoBehaviour {
    Quaternion startRotation;
    Quaternion constRotation;
   public  Text textMsg;
   public Text score;
   float Score=10;
  public Transform camera;

  public GameObject gameOverText;
  public GameObject restartText;

  public static bool GameOn = false;
	// Use this for initialization
	void Start () {
        GameOn = false;
        textMsg.enabled = false;
        startRotation=transform.rotation;
        constRotation=new Quaternion(startRotation.x,startRotation.y,startRotation.z,startRotation.w);
	}
	
	// Update is called once per frame
    void Update()
    {
        if (GameOn)
        {
            Score += 1;


            score.text = "Score: " + Score;
            Vector3 newPositionForward = new Vector3(transform.position.x, transform.position.y + 5, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, newPositionForward, 2 * Time.deltaTime);
            this.transform.rotation = constRotation;

            if (Input.GetKey(KeyCode.RightArrow) || Input.acceleration.x > 0.1)
            {
                Vector3 newPosition = new Vector3(transform.position.x + 2, transform.position.y, transform.position.z);
                transform.position = Vector3.Lerp(transform.position, newPosition, 2 * Time.deltaTime);


            }

            if (Input.GetKey(KeyCode.LeftArrow) || Input.acceleration.x < -0.1)
            {
                Vector3 newPosition = new Vector3(transform.position.x - 2, transform.position.y, transform.position.z);
                transform.position = Vector3.Lerp(transform.position, newPosition, 2 * Time.deltaTime);


            }
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Enemy")
        {
            textMsg.enabled = true;
            textMsg.text = "Game Over";
            this.enabled = false;
            gameOverText.SetActive(true);
            restartText.SetActive(true);
           // camera.position = new Vector3(camera.position.x, camera.position.y - 10, camera.position.z);

        }


    }
    
}
