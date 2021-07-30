using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuLight : MonoBehaviour
{
    public Transform oyuncu;   
    public Vector3 offset;     


    void Update()
    {
        transform.position = oyuncu.position + offset;
        //light ı oyuncu ile eşledim

    }
}
