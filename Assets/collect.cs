using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collect : MonoBehaviour
{
    [SerializeField] GameObject sprit;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) {
            sprit.SetActive(true);
            if(Input.GetKeyDown(KeyCode.E))
            {
                other.GetComponent<FirstPersonMovement>().collect(gameObject.name);
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        sprit.SetActive(false);

    }
}
