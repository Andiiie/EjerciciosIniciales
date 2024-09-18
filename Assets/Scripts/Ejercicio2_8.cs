using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_8 : MonoBehaviour
{
    int player = 120;
    float vidaFinal;
    float vidaTotal;
    // se le quita un 3% acumulable cada vez
    void Start()
    {
        vidaFinal = player * 0.03f;
        vidaTotal = player - vidaFinal;
        Debug.Log(vidaTotal);

        vidaFinal = player * 0.06f;
        vidaTotal = player - vidaFinal;
        Debug.Log(vidaTotal);

        vidaFinal = player * 0.09f;
        vidaTotal = player - vidaFinal;
        Debug.Log(vidaTotal);

        vidaFinal = player * 0.12f;
        vidaTotal = player - vidaFinal;
        Debug.Log(vidaTotal);

        vidaFinal = player * 0.15f;
        vidaTotal = player - vidaFinal;
        Debug.Log(vidaTotal);

    }


    void Update()
    {
        
    }
}
