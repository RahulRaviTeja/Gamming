using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipemiddle : MonoBehaviour
{
    // Start is called before the first frame update
    public Logic logic;
    void Start()
    {
        logic=GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logic.Addscore(1);
        }
            
        
    }
}
