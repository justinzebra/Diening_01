using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maindog : MonoBehaviour
{
   private Rigidbody2D dog;
    public Transform leftpoint,rightpoint;
    private float leftx,rightx;
    public bool faceleft = true;
    private bool isPlayer;
    public float Speed;
    bool iswalk=false;
    SpriteRenderer c;
    Animator dogani;
    void Move()
    {
        dogani.SetBool("walk",true);
        dog.velocity = new Vector2(Speed,dog.velocity.y);
        transform.localScale = new Vector3(-0.5f,0.5f,0.5f);
        
        // if(faceleft)
        // {
        //     dog.velocity = new Vector2(-3,dog.velocity.y);
        //     if(transform.position.x<leftx)
        //     {
        //         transform.localScale = new Vector3(-0.5f,0.5f,0.5f);
        //         faceleft = false;
        //     }
        // }
        // else
        // {
        //     dog.velocity = new Vector2(3,dog.velocity.y);
        //     if(transform.position.x>rightx)
        //     {
        //         transform.localScale = new Vector3(0.5f,0.5f,0.5f);
        //         faceleft = true;
        //     }
        // }
    }
    void Stop()
    {
        dog.velocity = new Vector2(0,dog.velocity.y);
        dogani.SetBool("walk",false);
    }
    void OnTriggerEnter2D(Collider2D other)
    { 
      if(other.gameObject.tag=="Player")
      {
          iswalk=true;
      }
      else if(other.gameObject.name=="dogdestroy")
      {
          Destroy(this.gameObject);
      }
    }
    // Start is called before the first frame update
    void Start()
    {
        dog = GetComponent<Rigidbody2D>();
        leftx = leftpoint.position.x;
        rightx = rightpoint.position.x;
        Destroy(leftpoint.gameObject);
        Destroy(rightpoint.gameObject);
        c = GetComponent<SpriteRenderer>();
        dogani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(iswalk==true)
        {
            Move();
        }
        else
        {
            Stop();
        }
    }
}
