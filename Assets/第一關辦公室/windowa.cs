using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class windowa : MonoBehaviour
{
    bool b_appear = false;
    SpriteRenderer w;
    BoxCollider2D bw;
    public AudioClip p;
    AudioSource audiosource;

    public void ConTrolAppear()
    {
        b_appear = true;
    }
    void Appear()
    {
        if (b_appear == true)
        {
            w.enabled = true;
            bw.enabled = true;
        }
        else
        {
            w.enabled = false;
            bw.enabled = false;
        }
    }
    public void DisAppear()
    {
        b_appear = false;
    }
    void OnMouseDown()
    {
        if (gameObject.tag == "windowa")
        {
            b_appear = false;
            audiosource.PlayOneShot(p);
        }

    }
    void Start()
    {
        w = GetComponent<SpriteRenderer>();
        bw = GetComponent<BoxCollider2D>();
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Appear();
    }
}
