using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operadores : MonoBehaviour
{
    //[acesso] [tipo] [nome/identificador] =[valor];
    //entradas
    public float nota1;
    public float nota2;
    public float nota3;
    float media;

    //operadores matematicos
    //soma +
    //subtração -
    // multiplicação *
    // divisão /
    // % mod
    void Start()
    {
        // Entrada
        media = (nota1+nota2+nota3)/3;

        //saida
        print(media);
        print("Resto da divisão:" + (5%2));
        print("adição:" + (nota1 + nota2) + " subtração:" + (nota1-nota2) + " multiplicação:" + (nota1*nota2) + " divisão:" + (nota1/nota2));
    }

}