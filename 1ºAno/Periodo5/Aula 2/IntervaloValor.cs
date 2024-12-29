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
     * if([condição] [OPERADOR] [condição]) {
     * 
     * }
     */

    int a = 15;
    int b = 5;
    void Start()
    {
     //condição com operadores
        if (a < 10 && b == 5)
        {

            print("condição satisfeita");
        }
        //intervalo de valor
        if(a >=0 && a <= 10)
        {
            print("dentro do intervalo");
        }
        print("fim");
    }
    }
