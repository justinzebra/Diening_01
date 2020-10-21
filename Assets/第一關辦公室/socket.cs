using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class socket : MonoBehaviour
{
    public GameObject fishtank;
    public GameObject d_fishtank;
    private bool isclear = false;
    public AudioClip p;
    AudioSource audiosource;
    void OnMouseDown()
    {
        if(isclear==false)
        {
            fishtank.SetActive(true);
            d_fishtank.SetActive(false);
            isclear=true;
        }
        else if(isclear==true)
        {
            fishtank.SetActive(false);
            d_fishtank.SetActive(true);
            isclear=false;
        }
        audiosource.PlayOneShot(p);
    }
    // Start is called before the first frame update
    void Start()
    {
        fishtank.SetActive(false);
        d_fishtank.SetActive(true);
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
