using UnityEngine;

public class playerCollision : MonoBehaviour
{

    public PlayerMovement movement;


    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle") 
        {
            
            movement.enabled = false;  //playermovement scripti disabled. Yani çarpınca duracak.
            
            //Debug.Log("Bir obstacle ile çarpıştık");

            FindObjectOfType<GameManager>().EndGame(); //gamemanagerde 
        }
    }
}
