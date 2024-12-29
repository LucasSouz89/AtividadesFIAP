using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variaveis : MonoBehaviour
{
    // Criando algumas variaveis 
    // [tipo] [nome/identificador] = [valor] 

    /*
    * int -numeros inteiros
    * string -textos (letras,simbolos e numeros)
    * float - numeros decimais 
    */
    int idade;
    string nome;
    float altura;
    bool olhosPreto;
    void Start()
    {
        nome = "Ellen";
        altura = 1.65f;
        olhosPreto = true;
        idade = 23;
        print(nome + " Ela tem " + altura + "m de altura e olhos pretos?" + olhosPreto + " idade:" + idade);

    }

}