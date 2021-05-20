using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using Fungus;
using UnityEngine.Assertions;


public class Player : MonoBehaviour
{
    Rigidbody2D playerRigidbody2D;

    [Header("目前的水平速度")]
    public float speedX;

    [Header("目前的水平方向")]
    public float horizontalDirection;//數值會在 -1~1之間

    const string HORIZONTAL = "Horizontal";

    [Header("水平推力")]
    [Range(0, 1000)]
    public float xForce;
    public float xNum;
    public float xstopNum;
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
    //public GameObject ss;   //把手電筒包含trigger_flashlight引進來
    //public E ww; //新增一個trigger_flashlight的代名詞去取得其他腳本的變數
    public Flowchart flowchart;
     public Flowchart flowchart2;
    string CanmoveName = "控制走動";
    public bool Canmove
    {
        get
        {
            return flowchart.GetBooleanVariable(CanmoveName);
        }
        set
        {
            flowchart.SetBooleanVariable(CanmoveName, value);
        }
    }

    public bool menuisopen = false;

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
    public void MenuisOpen()
    {
        menuisopen = true;
    }
    public void MenuisClose()
    {
        menuisopen = false;
    }
    void playwalk()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown("d"))
        {
            GetComponent<AudioSource>().Play();
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp("d"))
        {
            GetComponent<AudioSource>().Stop();
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown("a"))
        {
            GetComponent<AudioSource>().Play();
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp("a"))
        {
            GetComponent<AudioSource>().Stop();
        }
    }

    void Start()
    {

        playerRigidbody2D = GetComponent<Rigidbody2D>();
        m_Animator = GetComponent<Animator>();
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        //ww = ss.GetComponent<E>();//用那個代名詞取得trigger_flashlight的所有變數
    }

    /// <summary>水平移動</summary>
    void MovementX()
    {
        horizontalDirection = Input.GetAxis(HORIZONTAL);
        playerRigidbody2D.AddForce(new Vector2(xForce * horizontalDirection, 0));
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey("d"))
        {
            m_Animator.SetFloat("movespeed", 1);
            m_SpriteRenderer.flipX = false;
            xForce = xNum;

        }
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey("a"))
        {
            m_Animator.SetFloat("movespeed", 1);
            m_SpriteRenderer.flipX = true;
            xForce = xNum;
        }
        else
        {
            m_Animator.SetFloat("movespeed", 0);

        }


    }
    void playsprite()
    {
        horizontalDirection = Input.GetAxis(HORIZONTAL);
        playerRigidbody2D.AddForce(new Vector2(xForce * horizontalDirection, 0));


        if (Input.GetKey("d") && Input.GetKey(KeyCode.LeftShift))
        {
            Debug.Log("sad");
            m_Animator.SetFloat("movespeed", 2);
            m_SpriteRenderer.flipX = false;
            xForce = 10 * xForce;
        }
        else if (Input.GetKey("a") && Input.GetKey(KeyCode.LeftShift))
        {
            m_Animator.SetFloat("movespeed", 2);
            m_SpriteRenderer.flipX = true;
            xForce = 10 * xForce;
        }
    }

    void Update()
    {
        if (Canmove == true && menuisopen == false)
        {
            MovementX();
            playwalk();
            playsprite();
        }
        else//玩家在移動時點擊解謎走路聲停止一切動作
        {

            GetComponent<AudioSource>().Stop();
            m_Animator.SetFloat("movespeed", 0);
        }


        ControlSpeed();
        // playsprite();
        // badopen();
    }
}