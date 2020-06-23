using System.Collections;
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

    //[Header("偵測地板的射線起點")]
    //public Transform groundCheck;

    [Header("地面圖層")]
    public LayerMask groundLayer;

    public bool grounded;





    //加入動畫
    public Animator m_Animator;










    public GameObject ss;   //把手電筒包含trigger_flashlight引進來
    public E ww; //新增一個trigger_flashlight的代名詞去取得其他腳本的變數

    



  





    public void ControlSpeed()
    {
        speedX = playerRigidbody2D.velocity.x;
        speedY = playerRigidbody2D.velocity.y;
        float newSpeedX = Mathf.Clamp(speedX, -maxSpeedX, maxSpeedX);
        playerRigidbody2D.velocity = new Vector2(newSpeedX, speedY);
    }
    public SpriteRenderer m_SpriteRenderer;
    public bool JumpKey
    {
        get
        {
            return Input.GetKeyDown(KeyCode.Space);
        }
    }

    //void TryJump()
    //{
    //    if (IsGround && JumpKey)
    //    {
    //        playerRigidbody2D.AddForce(Vector2.up * yForce);
    //    }
    //}


    //在玩家的底部射一條很短的射線 如果射線有打到地板圖層的話 代表正在踩著地板
    //bool IsGround
    //{
    //    get
    //    {
    //        Vector2 start = groundCheck.position;
    //        Vector2 end = new Vector2(start.x, start.y - distance);

    //        Debug.DrawLine(start, end, Color.blue);
    //        grounded = Physics2D.Linecast(start, end, groundLayer);
    //        return grounded;
    //    }
    //}
    void playwalk()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            GetComponent<AudioSource>().Play();
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            GetComponent<AudioSource>().Stop();
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GetComponent<AudioSource>().Play();
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
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
        if (Input.GetKey(KeyCode.RightArrow))
        {
            m_Animator.SetFloat("movespeed", 1);
            m_SpriteRenderer.flipX = false;
         
          
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
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
        MovementX();
        ControlSpeed();
        playwalk();
        //checklight();
        //TryJump();
        //speedX = playerRigidbody2D.velocity.x;
    }
}