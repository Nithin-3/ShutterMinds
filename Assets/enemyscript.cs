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
    public bool isCollide = false;
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
           
            if (Vector3.Distance(transform.position, player.transform.position) < 10)
            {
                animator.SetBool("isRun",true);
                agent.destination = player.transform.position;
            }
            else
            {
                animator.SetBool("isRun", false);
            }

            if(isCollide == true)
            {
                animator.SetBool("isCollide", true);
            }

            else
            {
                animator.SetBool("isCollide", false);
            }
            
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isCollide = true;
        }
    }
}
