using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using TMPro;

public class DistCalc : MonoBehaviour
{
    public TMP_Text distanceTxt;

    //private NavMeshAgent agent1;
    public float distance1;
    public float distance2;
    public float distance3;
    public float distance4;
    public float distance5;
    public float distance6;

    private GameObject player1;

    private GameObject leg1;
    private GameObject leg2;
    private GameObject hand1;
    private GameObject hand2;
    private GameObject body;
    private GameObject head;
    // Start is called before the first frame update
    void Start()
    {
        
        leg1 = GameObject.Find("leftleg");
        leg2 = GameObject.Find("rightleg");
        hand1 = GameObject.Find("lefthand");
        hand2 = GameObject.Find("righthand");
        body = GameObject.Find("body");
        head = GameObject.Find("head");
    }

    // Update is called once per frame
    void Update()
    {
        try
        {
            player1 = GameObject.Find("Player(Clone)");

        }
        catch
        {

        }

        if(player1 != null)
        {
            distance1 = Vector3.Distance(player1.transform.position, leg1.transform.position);
            distance2 = Vector3.Distance(player1.transform.position, leg2.transform.position);
            distance3 = Vector3.Distance(player1.transform.position, hand1.transform.position);
            distance4 = Vector3.Distance(player1.transform.position, hand2.transform.position);
            distance5 = Vector3.Distance(player1.transform.position, body.transform.position);
            distance6 = Vector3.Distance(player1.transform.position, head.transform.position);

            float smalldist = Mathf.Min(distance1, distance2, distance3, distance4, distance5, distance6);

            distanceTxt.text = "BodyPart Distance " + smalldist;
        }
        
    }
}
