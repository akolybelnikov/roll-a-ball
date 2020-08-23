using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityScript : MonoBehaviour
{
    public float max = 25;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(0, max), 0, Random.Range(0, max));
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }
}
