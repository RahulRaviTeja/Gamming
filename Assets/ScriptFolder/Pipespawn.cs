using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Pipespawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pipe;

    public float pipespawn = 2;
    public float timer = 0;
    public float heightoffset = 10;

    void Start()
    {
        spawnpipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < pipespawn)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnpipe();
            timer = 0;
        }

        
    }
    void spawnpipe()
    {
        float lowestpoint = transform.position.y - heightoffset;
        float heightpoint = transform.position.y + heightoffset;
        Instantiate(pipe,new Vector3(transform.position.x,Random.Range(lowestpoint,heightpoint),0),transform.rotation);

    }
}
