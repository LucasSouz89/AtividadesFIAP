using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gIRAR : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        float ry = Input.GetAxis("Horizontal") * 5.0f;
        transform.Rotate(0.5f, ry, 0.0f);
    }
}
