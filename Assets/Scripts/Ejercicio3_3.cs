using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_3 : MonoBehaviour
{
    [SerializeField] int numero = 4;
    int dobleNumero;
    int tripleNumero;
    void Start()
    {
        dobleNumero = numero * 2;
        Debug.Log(dobleNumero);

        tripleNumero = numero * 3;
        Debug.Log(tripleNumero);
    }
}
