using UnityEngine;

public class OyuncuKamerası : MonoBehaviour
{
    public Transform oyuncu;   // transform bir data type float, int gibi.
    public Vector3 offset;     //3 vektörlü konum bilgisi? (offset= dengeleme, denkleştirme)

    
    void Update()
    {
        // Debug.Log(oyuncu.position); //console log'da Küpün konumunu görüyoruz.

        transform.position = oyuncu.position + offset;  
        //Kamera pozisyonu oyuncu pozisyonu + belirlediğimiz vektörel konum ile toplanarak eşlendi .
        
    }
}
