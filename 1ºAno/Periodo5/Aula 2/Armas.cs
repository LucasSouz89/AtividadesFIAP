using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armas : MonoBehaviour
{
    public string arma;
    // Start is called before the first frame update
    void Start()
    {
        if (arma == "a")
        {
            print("Pistola");

        }
        else if (arma == "b")
        {
            print("metraladora");
        }
        else if (arma == "c")
        {
            print("escopeta");
        }
        else if (arma == "d")
        {
            print("facão");
        }
        else if (arma == "e")
        {
            print("Granada");
        }
        else
        {
            print("esta vazio");
        }

    }
}
