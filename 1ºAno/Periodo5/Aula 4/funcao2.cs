using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class funcao3 : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        
        CalcularMedia();
        
    }
    void Somar(int a = 8, int b = 9)
    {
        print(a+ b);
    }

    // Update is called once per frame
    string CalcularMedia(double a=8, double b= 9)
    {
        if ((a + b) / 2 >= 6)
        { return "Aprovado"; 
        }else { return" Reprovado";}
    }
}
