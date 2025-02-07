using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    private static GameMaster instance;
    public Vector3 lastCheckPointPos;
    public int lastCheckPoint;

    private GameObject player;
    public GameObject[] checkpoints;
    private GameObject checkpoint1;
    private GameObject checkpoint2;
    private GameObject checkpoint3;

    private GameObject key2;
    private GameObject controls;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        } else
        {
            Destroy(gameObject);
        }

        controls = GameObject.Find("ControlsMenu");
        controls.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        lastCheckPoint = 0; /* Keeping track of this so that we can easily refer to what the last checkpoint was*/
        lastCheckPointPos = player.transform.position;

        checkpoint1 = GameObject.Find("Checkpoint1");
        checkpoint2 = GameObject.Find("Checkpoint2");
        checkpoint3 = GameObject.Find("Checkpoint3");

        checkpoints = new GameObject[3] { checkpoint1, checkpoint2, checkpoint3 };

        key2 = GameObject.Find("Key2");
        key2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
