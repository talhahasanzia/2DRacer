using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Car : MonoBehaviour {
    Quaternion startRotation;
    Quaternion constRotation;
   public  Text textMsg;
   public Text score;
   public static float Score;
  public Transform camera;

  public GameObject gameOverText;
  public GameObject restartText;
	public GameObject PauseButton;

  public static bool GameOn = false;
	// Use this for initialization
	void Start () {

        Score = 10;
        GameOn = false;
        textMsg.enabled = false;
        startRotation=transform.rotation;
        constRotation=new Quaternion(startRotation.x,startRotation.y,startRotation.z,startRotation.w);
	}
	
	// Update is called once per frame
    void FixedUpdate()
    {
        if (GameOn) {

			PauseButton.SetActive (true);
			Score += 1;

			HandleInput ();
            
			score.text = "Score \n" + Score;
			Vector3 newPositionForward = new Vector3 (transform.position.x, transform.position.y + 5, transform.position.z);
			transform.position = Vector3.Lerp (transform.position, newPositionForward, 2 * Time.deltaTime);
			this.transform.rotation = constRotation;
            
		} else {
		
			PauseButton.SetActive(false);
		
		}
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Enemy")
        {
			PauseButton.SetActive(false);
            GameOn = false;
            textMsg.enabled = true;
            textMsg.text = "Game Over";
            this.enabled = false;
            gameOverText.SetActive(true);
            restartText.SetActive(true);
           // camera.position = new Vector3(camera.position.x, camera.position.y - 10, camera.position.z);

        }


    }

    void HandleInput()
    {
        
        if ((Input.GetKey(KeyCode.RightArrow) || Input.acceleration.x > 0) && transform.position.x<2.6)
        {


            if (Input.acceleration.x > 0.05 && Input.acceleration.x <=0.15)
            {
                Vector3 newPosition = new Vector3(transform.position.x + 0.1f, transform.position.y, transform.position.z);
                transform.position = Vector3.Lerp(transform.position, newPosition, 30 * Time.deltaTime);
            }
            else if (Input.acceleration.x > 0.15 && Input.acceleration.x <= 0.25)
            {
                Vector3 newPosition = new Vector3(transform.position.x + 0.3f, transform.position.y, transform.position.z);
                transform.position = Vector3.Lerp(transform.position, newPosition, 20 * Time.deltaTime);
            }
            else if (Input.acceleration.x > 0.25 )
            {
                Vector3 newPosition = new Vector3(transform.position.x + 0.5f, transform.position.y, transform.position.z);
                transform.position = Vector3.Lerp(transform.position, newPosition, 30 * Time.deltaTime);
            }
        }

        if ((Input.GetKey(KeyCode.LeftArrow) || Input.acceleration.x < -0) && transform.position.x>-2.6)
        {
            if (Input.acceleration.x < -0.05 && Input.acceleration.x >= -0.15)
            {
                Vector3 newPosition = new Vector3(transform.position.x - 0.1f, transform.position.y, transform.position.z);
                transform.position = Vector3.Lerp(transform.position, newPosition, 30 * Time.deltaTime);
            }
            else if (Input.acceleration.x < -0.15 && Input.acceleration.x >= -0.25)
            {
                Vector3 newPosition = new Vector3(transform.position.x - 0.3f, transform.position.y, transform.position.z);
                transform.position = Vector3.Lerp(transform.position, newPosition, 20 * Time.deltaTime);
            }
            else if (Input.acceleration.x < -0.25)
            {
                Vector3 newPosition = new Vector3(transform.position.x - 0.5f, transform.position.y, transform.position.z);
                transform.position = Vector3.Lerp(transform.position, newPosition, 30 * Time.deltaTime);
            }

        }
    
    }
    
}
