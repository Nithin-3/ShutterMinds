using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightEnim : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        { 
            Destroy(other.gameObject);
        }
    }
}
