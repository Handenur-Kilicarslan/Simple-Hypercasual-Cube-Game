using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 300f;  //ilerleme hızı
    public float sidewaysForce = 300f; //sağ sol hızı

    public int candyCounter = 0;

    public Text scoreText2;
    string candyCounterString;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Candy")
        {
            candyCounter = candyCounter + 1;
            Debug.Log("Candy Sayısı:" + candyCounter);
            Destroy(other.gameObject);
            candyCounterString = candyCounter.ToString();
            scoreText2.text = "Score: " + candyCounterString;
        }
        else if(other.gameObject.tag == "Speed")
        {
            forwardForce = 4500f;
            sidewaysForce = 100f;
            Destroy(other.gameObject);
            candyCounter = candyCounter + 10;
        }
    }

    

    // her frame'de çağrılır fixedupdate fizik kuralları için iyidir.
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d") ) //D ye basıldığında sağa
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);  //mass ignore -> velocityChange
        }

        if (Input.GetKey("a") ) //A ye basıldığında sola
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); //eksi koyduk
        }

        if(rb.position.y < -1f) //ground dan düşerse yani y positionu eksi olursa
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
   
}

