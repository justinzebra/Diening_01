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
    public void buttonHover()
    {
       ishover=true;
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
    }

    // Update is called once per frame
    void Update()
    {
        imageisHover();
    }
}

