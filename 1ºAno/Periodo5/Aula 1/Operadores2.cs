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
    //subtra��o -
    // multiplica��o *
    // divis�o /
    // % mod
    void Start()
    {
        // Entrada
        media = (nota1+nota2+nota3)/3;

        //saida
        print(media);
        print("Resto da divis�o:" + (5%2));
        print("adi��o:" + (nota1 + nota2) + " subtra��o:" + (nota1-nota2) + " multiplica��o:" + (nota1*nota2) + " divis�o:" + (nota1/nota2));
    }

}