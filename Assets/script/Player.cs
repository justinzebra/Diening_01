﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D playerRigidbody2D;

    [Header("目前的水平速度")]
    public float speedX;

    [Header("目前的水平方向")]
    public float horizontalDirection;//數值會在 -1~1之間

    const string HORIZONTAL = "Horizontal";

    [Header("水平推力")]
    [Range(0, 500)]
    public float xForce;
    //目前垂直速度
    float speedY;

    [Header("最大水平速度")]
    public float maxSpeedX;

    [Header("垂直向上推力")]
    public float yForce;

    [Header("感應地板的距離")]
    [Range(0, 0.5f)]
    public float distance;

    [Header("地面圖層")]
    public LayerMask groundLayer;

    public bool grounded;
    //加入動畫
    public Animator m_Animator;
    public GameObject ss;   //把手電筒包含trigger_flashlight引進來
    public E ww; //新增一個trigger_flashlight的代名詞去取得其他腳本的變數
    bool Canmove = true;


    //public GameObject m_bag;
    //public bool bagisopen;
    /*void badopen()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            bagisopen = !bagisopen;
            m_bag.SetActive(bagisopen);
        }
    }*/

    public void ControlSpeed()
    {
        speedX = playerRigidbody2D.velocity.x;
        speedY = playerRigidbody2D.velocity.y;
        float newSpeedX = Mathf.Clamp(speedX, -maxSpeedX, maxSpeedX);
        playerRigidbody2D.velocity = new Vector2(newSpeedX, speedY);
    }
    public SpriteRenderer m_SpriteRenderer;
    public void StopMove()
    {
        Canmove = false;

    }
    public void ReStartMove()
    {
        Canmove = true;

    }
    void playwalk()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow)||Input.GetKeyDown("d"))
        {
            GetComponent<AudioSource>().Play();
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow)||Input.GetKeyUp("d"))
        {
            GetComponent<AudioSource>().Stop();
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow)||Input.GetKeyDown("a"))
        {
            GetComponent<AudioSource>().Play();
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow)||Input.GetKeyUp("a"))
        {
            GetComponent<AudioSource>().Stop();
        }
    }

    void Start()
    {

        playerRigidbody2D = GetComponent<Rigidbody2D>();
        m_Animator = GetComponent<Animator>();
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        ww = ss.GetComponent<E>();//用那個代名詞取得trigger_flashlight的所有變數

    }

    /// <summary>水平移動</summary>
    void MovementX()
    {
        horizontalDirection = Input.GetAxis(HORIZONTAL);
        playerRigidbody2D.AddForce(new Vector2(xForce * horizontalDirection, 0));
        if (Input.GetKey(KeyCode.RightArrow)||Input.GetKey("d"))
        {
            m_Animator.SetFloat("movespeed", 1);
            m_SpriteRenderer.flipX = false;


        }
        else if (Input.GetKey(KeyCode.LeftArrow)||Input.GetKey("a"))
        {
            m_Animator.SetFloat("movespeed", 1);
            m_SpriteRenderer.flipX = true;

        }
        else
        {
            m_Animator.SetFloat("movespeed", 0);

        }


    }


    void Update()
    {
        if (Canmove == true)
        {
            MovementX();
            playwalk();
        }
        ControlSpeed();
       // badopen();
    }
}