using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_3 : MonoBehaviour
{
    int vida = 5;
    float exp = 8.0f;
    int productoVida;
    float cocienteVida;
    float restoVidas;
    int dobleVidas;
    float tripleVidas;


    void Start()
    {
     productoVida = vida * 8;
     cocienteVida = vida / 8;
    }


}
