using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simples_aula2 : MonoBehaviour
{
    // Sintaxe:
    //if(condi��o){
    //instru��es;
    //}
    int a = 0;
    void Update()
    {
        if (a == 250)
        {
            print("� igual a 250");
        }
        a = a + 1;
        print("fim");
    }
}
