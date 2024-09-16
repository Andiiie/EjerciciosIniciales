using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_4 : MonoBehaviour
{
    int vidas = 8;
    int incrementarVida;
    int decrementarVida;
    int cuatriVida;

    void Start()
    {
        incrementarVida = vidas + 69;
        Debug.Log(incrementarVida);

        decrementarVida = vidas - 3;
        Debug.Log(decrementarVida);

        cuatriVida = vidas * 4;
        Debug.Log(cuatriVida);
    }
}
