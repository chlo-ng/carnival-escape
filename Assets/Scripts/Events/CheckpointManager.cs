using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointManager : MonoBehaviour
{
    private GameMaster gm;

    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (name == "Checkpoint1" && gm.lastCheckPoint == 0)
            { 
                gm.lastCheckPoint = 1;
                gm.lastCheckPointPos = transform.position;

            }
            else if (name == "Checkpoint2" && gm.lastCheckPoint == 1)
            {
                gm.lastCheckPoint = 2;
                gm.lastCheckPointPos = transform.position;

            }
            else if (name == "Checkpoint3" && gm.lastCheckPoint == 2)
            {
                gm.lastCheckPoint = 3;
                gm.lastCheckPointPos = transform.position;

            }
        }
    }
}

