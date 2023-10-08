using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D myrigid;
    public float flap;
    public Logic logic;
    bool birdisactive = true;

    public GameObject distroy;

    void Start()
    {
        gameObject.name = "Ravi Teja";
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Space)&& birdisactive)
        {
            myrigid.velocity = Vector2.up * flap;
        }

        if(transform.position.y>16||transform.position.y<-16)
        {
            logic.gameover();
            birdisactive=false;
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        Instantiate(distroy, transform.position, transform.rotation);
        logic.gameover();
        birdisactive = false;

    }
}
