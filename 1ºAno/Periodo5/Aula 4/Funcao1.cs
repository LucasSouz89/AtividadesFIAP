using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funcao1 : MonoBehaviour
{
    /*FUN��O
     * retorno nome (){
     * }
     */
    void Start()
    {
        Mensagem();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey) {
            Mensagem();
        }
       
    }
    //criar uma fun��o economiza tempo ao inves de copiar e colar, ficando muito mais facil de consertar o codigo
    void Mensagem()
    {
        print("Inicar");
        print("Preparando jogo");
        print("Iniciando partida");
        print("Jogando");
    }
     public string DarBomDia() {
        return "Bom dia";
            }
}
