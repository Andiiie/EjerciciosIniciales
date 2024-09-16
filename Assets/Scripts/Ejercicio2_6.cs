using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_6 : MonoBehaviour
{
    int puntuacion1 = 3;
    int puntuacion2 = 5;
    int puntuacion3 = 7;

    int mediaPuntuacion;
    void Start()
    {
        Debug.Log(puntuacion1);
        Debug.Log(puntuacion2);
        Debug.Log(puntuacion3);

        mediaPuntuacion = puntuacion1 + puntuacion2 + puntuacion3;
        mediaPuntuacion = mediaPuntuacion / 3;
        Debug.Log(mediaPuntuacion);
    }

   
}
