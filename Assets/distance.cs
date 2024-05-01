using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distance : MonoBehaviour
{
    public float distance1;
    private GameObject player;
    public GameObject bodyPart;
    private bool entered = false;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(entered == true)
        {
            distance1 = Vector3.Distance(bodyPart.transform.position, player.transform.position);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        entered = true;
    }
}
