using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.AI;

public class DistCalc : MonoBehaviour
{
    //private NavMeshAgent agent1;
    public float distance1;
    public float distance2;
    public float distance3;
    public float distance4;
    public float distance5;
    public float distance6;

    private GameObject leg1;
    private GameObject leg2;
    private GameObject hand1;
    private GameObject hand2;
    private GameObject body;
    private GameObject head;
    // Start is called before the first frame update
    void Start()
    {;
        leg1 = GameObject.Find("leg1");
        leg2 = GameObject.Find("leg2");
        hand1 = GameObject.Find("hand1");
        hand2 = GameObject.Find("hand2");
        body = GameObject.Find("body");
        head = GameObject.Find("head");
    }

    // Update is called once per frame
    void Update()
    {
        distance1 = Vector3.Distance(transform.position, leg1.transform.position);
        distance2 = Vector3.Distance(transform.position, leg2.transform.position);
        distance3 = Vector3.Distance(transform.position, hand1.transform.position);
        distance4 = Vector3.Distance(transform.position, hand2.transform.position);
        distance5 = Vector3.Distance(transform.position, body.transform.position);
        distance6 = Vector3.Distance(transform.position, head.transform.position);
        
    }
}
