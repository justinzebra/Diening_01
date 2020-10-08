using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pt : MonoBehaviour
{

    public CharacterController2D controller;

    public float runSpeed = 40f;

    float horizontalMove = 0f;

    bool jump = false;
    bool crouch = false;
    bool Canmove = true;
    public Animator player;
    AudioSource audiosource;
    
    void StartMove()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        
        
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;

        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;

        }
    }
    public void StopMove()
    {
        Canmove = false;
        
    }
    public void ReStartMove()
    {
        Canmove = true;
        
    }
   
    void Update()
    {
        bool isWalking=false;
        if (Canmove == true)
        {
            StartMove();  
             if(Input.GetKey(KeyCode.RightArrow)||Input.GetKey(KeyCode.LeftArrow)||Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            isWalking=true; 
            
        }
         if(Input.GetKeyDown(KeyCode.RightArrow)||Input.GetKeyDown(KeyCode.LeftArrow)||Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        {
            audiosource.Play();
        }
        else if(Input.GetKeyUp(KeyCode.RightArrow)||Input.GetKeyUp(KeyCode.LeftArrow)||Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            audiosource.Stop();
        }        
        }
       

       
        if(isWalking)
        {
            if(player.GetInteger("walk")==0)
            {
                player.SetInteger("walk",1);
                
            }
        }
        else
        {
            if(player.GetInteger("walk")==1)
            {
                player.SetInteger("walk",0);
                
            }
        }

    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }
}
