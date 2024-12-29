using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeticaoWhile : MonoBehaviour
{

    int a = 5;

    void Start()
    {

        while (a == 5)
        {
            print("Valor atual de a: " + a.ToString());
            a--;
        }

        print("Fim do programa.");

    }
}