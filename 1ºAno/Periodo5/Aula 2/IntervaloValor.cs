using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntervaloValor : MonoBehaviour
{

    /*
     * Sintaxe 
     * && - E
     * || - OU
     * 
     * if([condi��o] [OPERADOR] [condi��o]) {
     * 
     * }
     */

    int a = 15;
    int b = 5;
    void Start()
    {
     //condi��o com operadores
        if (a < 10 && b == 5)
        {

            print("condi��o satisfeita");
        }
        //intervalo de valor
        if(a >=0 && a <= 10)
        {
            print("dentro do intervalo");
        }
        print("fim");
    }
    }
