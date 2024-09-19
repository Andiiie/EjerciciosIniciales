using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_6 : MonoBehaviour
{
    
    [SerializeField]int velocidadKm = 180;
    int velocidadMs;

    void Start()
    {
        velocidadMs = velocidadKm * 1000 / 3600;

        Debug.Log(velocidadMs);
    }
}
