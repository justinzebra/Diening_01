using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isknife : MonoBehaviour
{
    public picture2 p;
    public GameObject K;
    public AudioClip s;
    AudioSource audiosource;
    void OnTriggerEnter2D(Collider2D other)//碰撞後交換位置
    {
        if(other.gameObject.tag=="knife")
        {
            p.DisAppear();
            audiosource.PlayOneShot(s);
            K.SetActive(false);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        p = p.GetComponent<picture2>();
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
