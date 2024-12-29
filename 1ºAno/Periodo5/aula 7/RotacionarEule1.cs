using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionarEule1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.eulerAngles = new Vector3(0.0f, 45.0f ,0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown) { transform.eulerAngles = new Vector3(0.0f, 0.0f, 0.0f); }
    }
}
