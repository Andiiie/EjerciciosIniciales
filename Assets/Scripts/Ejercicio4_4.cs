using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_4 : MonoBehaviour
{
    int velocidadFinal;
    void Start()
    {
        Debug.Log(velocidadFinal);
    }

    void Velocidad()
    {
        int veloKh = 180;

        velocidadFinal = veloKh * 1000 / 3600;

    }
}
