using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swicth2 : MonoBehaviour
{
   public int comando;
    // Start is called before the first frame update
    void Start()
    {
        
        switch (comando)
        {
            case 1:
                print("O programa ira desligar");
                break;

            case 2:
                print("O programa ira ligar");
                break;
            
        }
        
    }
}
