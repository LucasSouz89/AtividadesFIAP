using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExemploInput : MonoBehaviour
{

    // Variável que recebe o valor da velocidade
    public float velocidade = 5.0f;

    void Update()
    {
        /*
         * Variaveis declaradas dentro do escopo da 
         * funcao para receber os valores gerados pelo input.
         * Lembre-se esses valores são 0 parado -1 para eixo 
         * negativo e 1 para positivo
        */
        float px = Input.GetAxis("Horizontal") * velocidade * Time.deltaTime;
        float py = Input.GetAxis("Vertical") * velocidade * Time.deltaTime;
        /*
         * Translate ira atualizar a posicao do objeto 
         * incrementando ou decrementando
         * sua posicao a cada frame de processamento
         */
        transform.Translate(px, py, 0.0f);
    }
}