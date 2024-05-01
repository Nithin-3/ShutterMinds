using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyscript : MonoBehaviour
{
    public GameObject enem1;
    private GameObject player;
    private Animator animator;
    private NavMeshAgent agent;
    public static bool isEnter = false;
    void Awake()
    {
        animator = enem1.GetComponent<Animator>();
        agent = enem1.GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        try
        {
        player = GameObject.Find("Player(Clone)");

        }
        catch {
            
        }
        if (player != null)
        {
            //Debug.Log(Vector3.Distance(transform.position, player.transform.position));
           
            if (Vector3.Distance(transform.position, player.transform.position) < 10)
            {
                animator.SetBool("isRun",true);
                agent.destination = player.transform.position;
            }
            else
            {
                animator.SetBool("isRun", false);
            }
            
        }
    }
}
