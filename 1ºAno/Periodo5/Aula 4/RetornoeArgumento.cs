using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetornoeArgumento : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        print("M�dia do Lucas:" + M�dia(7.4f, 8.6f, 5.9f));
        print("M�dia da Ellen:" + M�dia(10f, 10f, 10f));


    }
    string M�dia(float a, float b, float c)
    {
        float Calculo = (a + b + c) / 3;
        print("Nota:" + Calculo);
        if (Calculo >= 7)
        {
            return "aprovado";
        }
        return "Reprovado";
    }
}

