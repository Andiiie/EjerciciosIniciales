using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_5 : MonoBehaviour
{
    [SerializeField]int radio;
    float longitud;
    float area;
    void Start()
    {
        longitud = 2 * Mathf.PI * radio;

        area = Mathf.PI * Mathf.Pow(radio, 2);
        //tambien puedo multiplicar el radio * radio si es al cuadrado
    }
}
