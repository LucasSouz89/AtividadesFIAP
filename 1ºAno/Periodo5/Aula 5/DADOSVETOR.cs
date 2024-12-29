using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DADOSVETOR : MonoBehaviour
{
    int[] a = new int[5];
    string[] letras = new string[5] { "a", "b", "c", "d", "e" };
    // Start is called before the first frame update
    void Start()
    {
        a[1] = 10; a[2] = 50; a[3] = 3; a[4] = 4;
        for (int i = 0; i < a.Length; i++)
        {
            print(a[i]);
        }
        letras[2] = "h"; //retrebuir valor
       //listagem
        foreach (string e in letras)
        {
            print(e);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
