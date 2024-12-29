using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int a;
    void Start()
    {
        if(a >= 0)
        {
            print("Ele é um numero positivo");
        }
        else
        {
            print("Ele é um numero negativo");
        } 
    }

}
