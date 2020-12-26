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
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="Player")
        {
            isplayer=true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag=="Player")
        {
            isplayer=false;
        }
    }
    void Buttonswitch()
    {
        if(Input.GetKeyDown("e")&&doorisopen==false&&isplayer==true)
        {
            doorisopen=true;
        }
        else if(Input.GetKeyDown("e")&&doorisopen==true&&isplayer==true)
        {
            doorisopen=false;
        }
    }
    void Switch()
    {
        if(doorisopen==true)
        {
            spriteRenderer.sprite=switchon;
        }
        else if(doorisopen==false)
        {
            spriteRenderer.sprite=switchoff;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer=GetComponent<SpriteRenderer>();
        doorisopen= false;
        isplayer=false;
    }

    // Update is called once per frame
    void Update()
    {
        Switch();
        Buttonswitch();
    }
}
