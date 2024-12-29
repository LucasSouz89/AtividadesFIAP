using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetornoeArgumento : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        print("Média do Lucas:" + Média(7.4f, 8.6f, 5.9f));
        print("Média da Ellen:" + Média(10f, 10f, 10f));


    }
    string Média(float a, float b, float c)
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

