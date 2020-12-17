using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHover : MonoBehaviour
{
    Image image;
    public Sprite inimage;
    public Sprite hoverimage;
    private bool ishover=false;
    public AudioClip p;
    AudioSource audiosource;
    public void buttonHover()
    {
       ishover=true;
       audiosource.PlayOneShot(p,0.1f);
    }
    public void buttonExit()
    {
       ishover=false;
    }
    void imageisHover()
    {
        if(ishover==true)
        {
            image.sprite=hoverimage;
        }
        else
        {
            image.sprite=inimage;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        imageisHover();
    }
}

