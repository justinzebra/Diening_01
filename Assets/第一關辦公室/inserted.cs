using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inserted : MonoBehaviour
{
    bool s_appear = false;
    SpriteRenderer w;
    public AudioClip p;
    AudioSource audiosource;
    public void ConTrolAppear()
    {
        s_appear = true;
        audiosource.PlayOneShot(p);
    }
    void Appear()
    {
        if (s_appear == true)
        {
            w.enabled = true;
        }
        else
        {
            w.enabled = false;
        }
    }
    public void DisAppear()
    {
        s_appear = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        w = GetComponent<SpriteRenderer>();
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Appear();
    }
}
