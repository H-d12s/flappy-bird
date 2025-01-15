using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ci : MonoBehaviour
{  
    public Rigidbody2D Myrigidbody;
    public float flapstrenght;
    // Start is called before the first frame update
    public LogicScript logic;
    public bool birdalive=true;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)==true && birdalive)
        {
            Myrigidbody.velocity=Vector2.up*flapstrenght;
        }
       trans();
    }
     private void OnCollisionEnter2D(Collision2D collision)
     {
        logic.gameover();
        birdalive=false;
     }
     public void trans()
     {
         if(transform.position.y>=14|| transform.position.y<=-14)
        {
            logic.gameover();
            birdalive=false;
        }
     }
     
     
}
