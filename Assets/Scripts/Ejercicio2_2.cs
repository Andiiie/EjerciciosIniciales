using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_2 : MonoBehaviour
{
    int vida = 5;
    float exp = 10.3f;
    bool quemado;
    char carac = 'M';
    float resultadoSuma;
    float resultadoResta;


    void Start()
    {
        resultadoSuma = vida + exp;

        resultadoResta = vida - exp;


        Debug.Log("vida " + vida);
        Debug.Log("exp " + exp);
        Debug.Log(resultadoSuma);
        Debug.Log(resultadoResta);
    }
}

