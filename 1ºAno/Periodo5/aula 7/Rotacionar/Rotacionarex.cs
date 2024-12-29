using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacionarex : MonoBehaviour
{

    // Update is called once per frame
   
        void Update()
        {
            // Gira o objeto no eixo Z
            transform.Rotate(Vector3.back * 10.0f * Time.deltaTime);
        }
}
