using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookat : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(4 * Time.deltaTime, 0f, 0.0f, Space.Self);

    }
}
