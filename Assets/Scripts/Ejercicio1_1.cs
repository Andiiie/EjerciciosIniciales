using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1_1 : MonoBehaviour
{
    string explorador = "Andie";

    void Start()
    {
        Debug.Log("�Hola mundo!");
        Debug.Log("Este es el primer videojuego de" + explorador);
        Debug.Log("Estoy aprendiendo C#");
    }

    void Update()
    {
        Debug.Log("Ha pasado un frame");
        /*Este mensaje seguir� apareciendo en la consola porque est� ubicado
          en el update, el cual se refresca cada cierto tiempo, haciendo que
          el c�digo haga lo mismo*/
    }


}
