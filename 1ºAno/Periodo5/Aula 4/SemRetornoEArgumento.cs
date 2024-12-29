using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExemploFuncao : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        IniciarJogo();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            IniciarJogo();
        }
    }
    //void - SEM RETORNO ()- SEM ARGUMENTO
    void IniciarJogo()
    {
        print("Boa diversão!");
    }
}