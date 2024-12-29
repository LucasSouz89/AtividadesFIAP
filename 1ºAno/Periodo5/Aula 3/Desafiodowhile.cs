using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafiodowhile : MonoBehaviour
{
    public int a;
    // Start is called before the first frame update
    void Start()
    {
        int b = a - 5;
        do
        {
            print(a);
            a--;
        } while (a > b);
        
    }

}
