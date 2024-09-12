using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_2 : MonoBehaviour
{
    int vida = 5;
    float exp = 10.0f;
    bool quemado;
    char carac = 'M';

    void Start()
    {
        
    }

    void Update()
    {
        Debug.Log("vida " + vida);
        Debug.Log("exp " + exp);
    }
}
