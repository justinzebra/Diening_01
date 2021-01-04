using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ironrollingdoor : MonoBehaviour
{
    public bool doorisopen;
    public bool isplayer;
    public Sprite switchon;
    public Sprite switchoff;
    SpriteRenderer spriteRenderer;
    public GameObject L_door;
    public AudioClip p;
    AudioSource audiosource;
    GameManager gameManager;
    public GameObject E;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="Player")
        {
            isplayer=true;
            E.SetActive(true);
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag=="Player")
        {
            isplayer=false;
            E.SetActive(false);
        }
    }
    void Buttonswitch()
    {
        if(Input.GetKeyDown("e")&&doorisopen==false&&isplayer==true)
        {
            doorisopen=true;
            audiosource.PlayOneShot(p);
            gameManager.rollingdoor=true;
        }
        else if(Input.GetKeyDown("e")&&doorisopen==true&&isplayer==true)
        {
            doorisopen=false;
            audiosource.PlayOneShot(p);
            gameManager.rollingdoor=false;
        }
    }
    void Switch()
    {
        if(doorisopen==true)
        {
            spriteRenderer.sprite=switchon;
            L_door.SetActive(true);
        }
        else if(doorisopen==false)
        {
            spriteRenderer.sprite=switchoff;
            L_door.SetActive(false);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer=GetComponent<SpriteRenderer>();
        doorisopen= false;
        isplayer=false;
        L_door.SetActive(false);
        audiosource = GetComponent<AudioSource>();
        gameManager = FindObjectOfType<GameManager>();
        E.SetActive(false);
        if(gameManager.rollingdoor==true)
        {
            doorisopen=true;
        }
        else
        {
            doorisopen=false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Switch();
        Buttonswitch();
    }
}
