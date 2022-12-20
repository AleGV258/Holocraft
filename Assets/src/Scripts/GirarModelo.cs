using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirarModelo : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0.0f, Time.deltaTime*5.0f, 0.0f));
    }
}
