using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesafioWhile : MonoBehaviour
{
    public int numero;
    // Start is called before the first frame update
    void Start()
    {
        if (numero >=0)
        {
            while(numero >=0)
            {
                print("Valor do numero:" + numero);
                numero--;

            }
        }else
        {
            print("O nuemro deve ser positivo");
        }
        print("Fim");
    }

}
