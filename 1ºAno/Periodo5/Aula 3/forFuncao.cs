using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForFuncao : MonoBehaviour
{
    /*
     * for(variavel;condição;contador){instrução}
     * for(int o = 2; o<20; o++){print(o);}
     */
    void Start()
    {

        
        int numero = 7;
        for (int mult = 0; mult <= 20; mult++)
        {
            print(numero + "X" + mult + ": " + (numero * mult));
           
        }

 
    }
}