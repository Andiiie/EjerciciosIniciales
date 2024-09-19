using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_7 : MonoBehaviour
{
    [SerializeField] int baseTriangulo = 8;
    [SerializeField] int ladoTriangulo = 8;
    int areaTriangulo;
    void Start()
    {
        areaTriangulo = baseTriangulo * ladoTriangulo / 2;

        Debug.Log(areaTriangulo);
    }
}
