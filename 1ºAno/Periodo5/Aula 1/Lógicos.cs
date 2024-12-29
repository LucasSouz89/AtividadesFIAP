using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lógicos : MonoBehaviour {

   int a = 100; 
   int b = 50; 
   int c = 10;
   bool item_a;
   bool item_b;
   bool porta;

    // Operadores Lógicos 
    // Operadores Lógicos E/Ou
    //&& - E
    // || - OU

    void Start()
    {
        print((a != b) && (a > b));
        //Tabela (E) &&
        //A B S
        //0 0 0
        //0 1 0
        //1 0 0
        //1 1 1

        //Tabela (OU) ||
        //A B S
        //0 0 0
        //0 1 1
        //1 0 1
        //1 1 1
        item_a = false;
        item_b = true;
        porta = (item_a == true || item_b == true);
        print (porta);
    }


}
