using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class composta : MonoBehaviour
{
    /*
     * Estrutura de condi��o - Composta
     * if([condi��o]){
     * Instru�oes a;  [verdadeira]    
     * }else{
     * instru�oes b}  [falsa]
     */
    public int vidas;
    void Start()
    {
        if(vidas >0)
        {
            print("vida cheia");
        }
        else
        {
            print("fim de jogo");
        }
    }

   
}
