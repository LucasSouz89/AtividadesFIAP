using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class primos : MonoBehaviour
{
    public int numero;
    void Start()
    {
        int sub =numero - 1;
        bool primo = true;
        /*
         * Conhecer forumas(numeros primos)
         * Dividir o problema grande em peuqenos problemas
         * - Gerar os antecessores
         *-verificar se o numero é divisivel pelos antecessores
            * Verificar se o numero
         */
        print("é um numero primo?");

        while (sub > 1)
        {
            if (numero % sub == 0) {
                primo = false;
                break;
            }
            print(numero % sub);
            sub--;
        }
        if (primo == true)
        {
            print("Primo");
        }else {
            print("Não é primo");
                }
    }

}
