using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class medicinereturn : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public bool returnbutton=false;
    public AudioClip p;
    AudioSource audioSource;
    Color c;
    void OnMouseDown()
    {
        // returnbutton=true;
        audioSource.PlayOneShot(p);
        c = new Color(1f,1f,1f,0.5f);
        this.GetComponent<SpriteRenderer>().color=c;
    }
    void OnMouseUp()
    {
        returnbutton=true;
        // audioSource.PlayOneShot(p);
        c = new Color(1f,1f,1f,1f);
        this.GetComponent<SpriteRenderer>().color=c;
    }
    // Start is called before the first frame update
    void Start()
    {
        audioSource=GetComponent<AudioSource>();
        spriteRenderer=GetComponent<SpriteRenderer>();
        c=spriteRenderer.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
