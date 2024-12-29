using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntervaloValores : MonoBehaviour
{
    // Start is called before the first frame update
    public int Numero;
    void Start()
    {
        if(Numero >= 0 && Numero <= 10)
        {
            print("O numero esta entre 0 e 10");
        }
        else
        {
            print("o numero não esta entre 0 e 10");
        }
    }

}
