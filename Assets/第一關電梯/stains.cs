using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stains : MonoBehaviour
{
    SpriteRenderer w;
    BoxCollider2D bw;
    public AudioClip p;
    AudioSource audiosource;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "player")
        {
            audiosource.PlayOneShot(p,1f);
            w.enabled=false;
            bw.enabled=false;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        w = GetComponent<SpriteRenderer>();
        bw = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
