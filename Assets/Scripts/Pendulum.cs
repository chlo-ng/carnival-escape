using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pendulum : MonoBehaviour
{
    public float speed = 1.5f;
    public float limit = 75f;
    public bool randomStart = false;
    private float random = 0;
    // Start is called before the first frame update
    void Awake()
    {
        if (randomStart) {
            random = Random.Range(0.7f, 0.75f);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        float angle = limit * Mathf.Sin(Time.time * random * speed);
        transform.localRotation = Quaternion.Euler(angle,0,0);
    }
}
