using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_5 : MonoBehaviour
{
     int vidasPlayer1 = 2;
     int vidasPlayer2 = 4;
     int vidasPlayer3 = 6;
     int vidasPlayer4 = 8;
    int vidasTotales;

    void Start()
    {
        vidasTotales = vidasPlayer3;

        vidasPlayer2 = vidasPlayer3;
        vidasPlayer3 = vidasPlayer1;
        vidasPlayer1 = vidasPlayer4;
        vidasPlayer4 = vidasPlayer2;
    }
}
