using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_3 : MonoBehaviour
{
    int vida = 5;
    float exp = 8.0f;
    float productoVida;
    float cocienteVida;
    float restoVida;
    int dobleVida;
    float tripleExp;


    void Start()
    {
        productoVida = vida * exp;
        cocienteVida = vida / exp;
        restoVida = vida * 0.08f;
        dobleVida = vida * 2;
        tripleExp = exp * 3;
    }


}
