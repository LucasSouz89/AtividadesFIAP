using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Relacionais : MonoBehaviour
{
    float nota1, nota2, nota3, média;

    // Operadores relacionais
    // == igualdade 
    // != diferente
    // > maior
    // < menor
    // <= menor ou igual 
    // >= maior ou igual
    // Saída falsa ou verdadeira
    void Start()
    {
        nota1 = 6.0f; 
        nota2 = 7.0f; 
        nota3 = 4.5f; 
        média = (nota1 + nota2 + nota3) / 3;

        print("media atual" + média + "aprovado" + (média >= 1));
        print("média do aluno é menor igual a 6?" + (média <= 6));
    }

}
