using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SRA2 : MonoBehaviour
{
    /*saída entrada
     * retorno nome(){
     * }
     */
    void Start()
    {
        if (média(8f, 9f, 10f) == true)
        {

            {
                print("oi");
            }
        }
        bool média(float a, float b, float c)
        {


            if ((a + b + c) / 3 >= 7)
            {
                print("Aprovado");
                return true;
            }
            print("Reprovado");
            return false;
        }



    }
}
