using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using TMPro;

public class DistCalc : MonoBehaviour
{
    private TMP_Text distanceTxt;

    //private NavMeshAgent agent1;
    public float distance1;
    public float distance2;
    public float distance3;
    public float distance4;
    public float distance5;
    public float distance6;

    private GameObject player;

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

        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        distance1 = Vector3.Distance(player.transform.position, leg1.transform.position);
        distance2 = Vector3.Distance(player.transform.position, leg2.transform.position);
        distance3 = Vector3.Distance(player.transform.position, hand1.transform.position);
        distance4 = Vector3.Distance(player.transform.position, hand2.transform.position);
        distance5 = Vector3.Distance(player.transform.position, body.transform.position);
        distance6 = Vector3.Distance(player.transform.position, head.transform.position);

        float smalldist = Mathf.Min(distance1, distance2,distance3,distance4,distance5,distance6);

        distanceTxt.text = "BodyPart Distance " + smalldist;
    }
}
