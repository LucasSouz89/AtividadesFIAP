using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simples_aula2 : MonoBehaviour
{
    // Sintaxe:
    //if(condição){
    //instruções;
    //}
    int a = 0;
    void Update()
    {
        if (a == 250)
        {
            print("É igual a 250");
        }
        a = a + 1;
        print("fim");
    }
}
