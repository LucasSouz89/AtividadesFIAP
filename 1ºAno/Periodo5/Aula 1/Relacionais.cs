using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Relacionais : MonoBehaviour
{
    float nota1, nota2, nota3, m�dia;

    // Operadores relacionais
    // == igualdade 
    // != diferente
    // > maior
    // < menor
    // <= menor ou igual 
    // >= maior ou igual
    // Sa�da falsa ou verdadeira
    void Start()
    {
        nota1 = 6.0f; 
        nota2 = 7.0f; 
        nota3 = 4.5f; 
        m�dia = (nota1 + nota2 + nota3) / 3;

        print("media atual" + m�dia + "aprovado" + (m�dia >= 1));
        print("m�dia do aluno � menor igual a 6?" + (m�dia <= 6));
    }

}
