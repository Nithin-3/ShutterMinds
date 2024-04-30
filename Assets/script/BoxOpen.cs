using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxOpen : MonoBehaviour
{
    public GameObject boxclose;
    public GameObject boxopen;
    public GameObject openTxt;
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                boxclose.SetActive(false);
                boxopen.SetActive(true);
                openTxt.SetActive(true);
            }
        }
    }
}
