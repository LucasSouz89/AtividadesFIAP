using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover2 : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        float px = Input.GetAxis("Horizontal") * 10.0f;
        float pz = Input.GetAxis("Vertical") * 10.0f;
        transform.Translate(px, 0.0f, pz );
    }
}
