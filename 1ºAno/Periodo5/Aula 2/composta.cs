using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class composta : MonoBehaviour
{
    /*
     * Estrutura de condição - Composta
     * if([condição]){
     * Instruçoes a;  [verdadeira]    
     * }else{
     * instruçoes b}  [falsa]
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
