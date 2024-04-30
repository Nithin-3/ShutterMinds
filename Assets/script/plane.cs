using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plane : MonoBehaviour
{
    public GameObject boundaryTxt;
    private void OnTriggerEnter(Collider other)
    {
        boundaryTxt.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        boundaryTxt.SetActive(false);
    }
}
