using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moeda : MonoBehaviour {

    int moeda = 0, vida = 0;
    void Update()
    {
        if(moeda == 100) {
            vida = vida + 1;
            moeda = 0;

        }
        moeda = moeda + 1;
        print("Quantidade de moedas:" + moeda);
        print("quantidade de vidas:" + vida);
       
    }
}
