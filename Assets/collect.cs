using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collect : MonoBehaviour
{
    [SerializeField] GameObject sprit;
    GameObject flayer;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && flayer != null )
        {
            flayer.GetComponent<FirstPersonMovement>().collect(gameObject.name);
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) {
            flayer = other.gameObject;
            sprit.SetActive(true);
            sprit.transform.LookAt(flayer.transform.position);
            
        }
    }
    void OnTriggerExit(Collider other)
    {
        flayer = null;
        sprit.SetActive(false);

    }
}
