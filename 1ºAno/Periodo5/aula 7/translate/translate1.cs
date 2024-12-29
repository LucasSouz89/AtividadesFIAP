using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transformar : MonoBehaviour
{

    void Update()
    {
        // Move o objeto na diagonal direita superior
        transform.Translate(1.0f * Time.deltaTime, 1.0f * Time.deltaTime, 0.0f);
    }
}