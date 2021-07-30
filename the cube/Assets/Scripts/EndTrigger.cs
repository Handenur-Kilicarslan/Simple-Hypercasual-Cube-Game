using UnityEngine;

//oyunun sonundaki yer
public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter() //is trigger işaretli olmalı
    {
        gameManager.CompleteLevel();
    }
}
