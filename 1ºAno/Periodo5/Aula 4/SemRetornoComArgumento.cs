
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SemRetornoComArgumento : MonoBehaviour
{ 


    // Use this for initialization
    void Start()
    {
        Somar(5, 3);
        Somar(7, 90);
    }
    //VOID SEM RETORNO- SOMAR()- COM ARGUMENTO
    void Somar(int a, int b)
    {
        print(a + b);
    }
}