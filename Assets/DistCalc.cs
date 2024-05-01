using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using TMPro;

public class DistCalc : MonoBehaviour
{
    public TMP_Text distanceTxt;

    //private NavMeshAgent agent1;
    public float[] distance;

    private GameObject player1;

    private GameObject[] gameObjects;
    // Start is called before the first frame update
    void Start()
    {
        gameObjects =  GameObject.FindGameObjectsWithTag("bodyParts");
        distance = new float[gameObjects.Length];
    }

    // Update is called once per frame
    void Update()
    {
        try
        {
            gameObjects = GameObject.FindGameObjectsWithTag("bodyParts");
            player1 = GameObject.Find("Player(Clone)");

        }
        catch
        {

        }

        if(player1 != null)
        {
            int index = 0;
            foreach(GameObject go in gameObjects)
            {
                distance[index] = Vector3.Distance(player1.transform.position, go.transform.position);
                index++;
            }

            float smalldist = Mathf.Min(distance);

            distanceTxt.text = "BodyPart Distance " + smalldist;
        }
        
    }
}
