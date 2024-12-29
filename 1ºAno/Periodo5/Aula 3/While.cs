using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repetição : MonoBehaviour
{
    /*sintaxe:
     * 
     * while([condição]){
     *  print("Hello world");
     * }
     */
    public int numero;
    void Start()
    {
        while(numero < 100)
        {
            print(numero);
            numero = numero + 1;
        }
        print("Fim");
    }

}
