using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_1 : MonoBehaviour
{
    float areaCirculo;
    float areaTriangulo;
    float areaCuadrado;
    float radioCirculo = 2;
    float baseTriangulo = 4;
    float alturaTriangulo = 4;
    float ladoCuadrado = 6;
    void Start()
    {
        Debug.Log(areaCirculo); 

        Debug.Log(areaTriangulo); 
        
        Debug.Log(areaCuadrado);
    }

    void Circulo()
    {
        areaCirculo = Mathf.Pow(radioCirculo, 2) * Mathf.PI;
    }
    void Triangulo()
    {
        areaTriangulo = baseTriangulo * alturaTriangulo / 2;
    }
    void Cuadrado()
    {
        areaCuadrado = ladoCuadrado * ladoCuadrado;
    }

}
