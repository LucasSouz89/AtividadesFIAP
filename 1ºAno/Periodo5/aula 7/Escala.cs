using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escala : MonoBehaviour
{
    float s = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump")) 
        {
            s= s+0.3f;
            transform.localScale = new Vector3(s, s ,s);
        }
    }
}
