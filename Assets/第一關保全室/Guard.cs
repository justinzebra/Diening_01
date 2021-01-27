using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guard : MonoBehaviour
{
    private Rigidbody2D guard;
    public Transform leftpoint,rightpoint;
    private float leftx,rightx;
    public bool faceleft = true;
    private bool isPlayer;
    public float Speed;
    bool iswalk=false;
    SpriteRenderer c;
    Animator guardani;
    GameManager gameManager;
    void Move()
    {
        if(faceleft)
        {
            guard.velocity = new Vector2(-3,guard.velocity.y);
            if(transform.position.x<leftx)
            {
                transform.localScale = new Vector3(-0.4424389f,0.4424389f,0.4424389f);
                faceleft = false;
            }
        }
        else
        {
            guard.velocity = new Vector2(3,guard.velocity.y);
            if(transform.position.x>rightx)
            {
                transform.localScale = new Vector3(0.4424389f,0.4424389f,0.4424389f);
                faceleft = true;
            }
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    { 
    }
    // Start is called before the first frame update
    void Start()
    {
        guard = GetComponent<Rigidbody2D>();
        leftx = leftpoint.position.x;
        rightx = rightpoint.position.x;
        Destroy(leftpoint.gameObject);
        Destroy(rightpoint.gameObject);
        c = GetComponent<SpriteRenderer>();
        guardani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
}
