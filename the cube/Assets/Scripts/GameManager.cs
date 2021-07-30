using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;

    public float restartDelay = 3f;
    public float restartDelay2 = 8f;

    public GameObject CompleteLevelUI;

    public void CompleteLevel()
    {
        CompleteLevelUI.SetActive(true);  //level tamamlandığında complete arayüzü ekranda belirsin

        Debug.Log("Level başarıyla tamamlandı");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    public void EndGame() //gameover
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            //bu kısımda restart yapabiliriz --- Restart();
            Invoke("Restart", restartDelay);
        }
    }
    
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        // SceneManager.LoadScene("Level-1"); ile aynı işlevdedir current scene i tekrar başlatmasını istiyoruz çünkü.

    }
}
