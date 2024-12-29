using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoWhile : MonoBehaviour
{
    // Start is called before the first frame update
    int a = 100;
    void Start()
    {
        
        /*
         * do{Instrução
         * }While(condição);
         */
        do
        {
            print(a);
            a--;
        } while (a > 0);
        print("Fim");
    }
    

}
