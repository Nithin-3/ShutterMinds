using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSystem : MonoBehaviour
{
    public GameObject player;
    public GameObject playerPos;
    public GameObject sceneCam;
    public GameObject swnManager;
    public GameObject jumpTxt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            sceneCam.SetActive(false);
            Instantiate(player, playerPos.transform.position, Quaternion.identity);
            Destroy(jumpTxt);
            Destroy(swnManager);
        }
    }
}
