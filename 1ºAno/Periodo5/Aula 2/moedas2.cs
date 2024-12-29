using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moedas2 : MonoBehaviour
{
    int moeda = 100, vida = 2;
    
    void Start()
    {
        if(moeda == 100)
        {
        if (vida < 3)
            {
                vida = vida + 1;
                print("Total de vidas:" + vida);
            }
            else
            {
                print("Vidas não atribuidas");
            }
            moeda = 0;
        }
    }

}
