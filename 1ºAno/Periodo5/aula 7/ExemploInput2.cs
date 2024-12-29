using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExemploInput2 : MonoBehaviour
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
        // Rotaciona o objeto Fire1 (CTRL Esquerdo/Clique esquerdo)
        if (Input.GetButton("Fire1"))
        {
            transform.Rotate(0.0f, 0.0f, velocidade);
        }
        // Reseta os transformadores do objeto (ALT esquerdo)
        if (Input.GetButtonDown("Fire2"))
        {
            transform.eulerAngles = Vector3.zero;
            transform.position = new Vector2(0.0f, 0.0f);
        }
    }
}