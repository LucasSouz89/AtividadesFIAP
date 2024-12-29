using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class encadeado : MonoBehaviour
{
    /*
     * if([condição]){
     * if([condição])
     * 
     */
    // Start is called before the first frame update
    // porta =false esta fechada
    bool porta = true;
    public int moedas;
    void Start()
    {
        if (porta == true)
        {
            print("porta pode ser aberta");
            if (moedas >= 100)
            {
                print("Porta aberta");
            }else
            {
                print("Quantidade de moedas insuficiente");
            }
        }else
        {
            print("Porta fechada");
        }
       
        
    }
}
