using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swicth1 : MonoBehaviour
{
    // Start is called before the first frame update
    public string comando = "Iniciar";
    void Start()
    {
        
        switch (comando)
        {
            case "Iniciar":
                print("O programa iniciou");
                break;

            case "Desligar":
                print("O programa ira desligar");
                break;
            default:
                print("Comando: " + comando + " desconhecido");
                break;
        }
      
        
    }
}
