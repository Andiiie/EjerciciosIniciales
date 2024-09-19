
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_2 : MonoBehaviour
{
    void Start()
    {
        Debug.Log(ConstruirNombre());
    }

    string ConstruirNombre()
    {
        string nombre = "Alex";
        string apellido1 = "Rios";
        string apellido2 = "Rodriguez";
        int edad = 20;

        return("La persona se llama " + nombre + " " + apellido1 + " " + apellido2 + " y tiene " + edad + " años");
    }

}
