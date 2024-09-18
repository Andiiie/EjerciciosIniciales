using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_7 : MonoBehaviour
{
    // segundos en una hora : 3600
    // segundos en 4 horas : 14400
    int oro = 7;
    int tiempo = 14400;
    int oroTotal;
   
    void Start()
    {
        oroTotal = oro * tiempo;

        Debug.Log(oroTotal);
    }

}
