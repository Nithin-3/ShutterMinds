using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class watchlight : MonoBehaviour
{
    [SerializeField] GameObject spans;
    
    void Update()
    {
        transform.Rotate(0.0f, 5.0f * Time.deltaTime, 0.0f, Space.Self);

    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.position = spans.transform.position;
        }
    }
}
