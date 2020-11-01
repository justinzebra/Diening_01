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
    public float Speed = 5;
    
    SpriteRenderer c;
    void Move()
    {
        if(faceleft)
        {
            dog.velocity = new Vector2(-3,dog.velocity.y);
            if(transform.position.x<leftx)
            {
                transform.localScale = new Vector3(-0.5f,0.5f,0.5f);
                faceleft = false;
            }
        }
        else
        {
            dog.velocity = new Vector2(3,dog.velocity.y);
            if(transform.position.x>rightx)
            {
                transform.localScale = new Vector3(0.5f,0.5f,0.5f);
                faceleft = true;
            }
        }
    }
    void DogState()
    {
        if(Speed>0.0f)
        {
            c.color=new Color(0,20,255,255);
        }
        else if(Speed==0.0f)
        {
            c.color=new Color(255,0,0,255);
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
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        // DogState();
    }
}
