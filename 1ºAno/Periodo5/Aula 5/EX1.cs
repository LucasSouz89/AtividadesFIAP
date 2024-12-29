using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExemploArray : MonoBehaviour
{
    // Declarando o vetor
    string[] armas = new string[4];

    void Start()
    {
        // Atribuindo valores
        armas[0] = "Faca";
        armas[1] = "Pistola";
        armas[2] = "Granada";
        armas[3] = "Metralhadora";

        // Listando o vetor no console
        for (int i = 0; i < armas.Length; i++)
        {
            print(armas[i]);
        }
    }
}