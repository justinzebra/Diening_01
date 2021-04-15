using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class stains : MonoBehaviour
{
    GameManager gameManager;
    SpriteRenderer w;
    BoxCollider2D bw;
    public AudioClip p;
    AudioSource audiosource;
    public GameObject s;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "背包藥水")
        {
            audiosource.PlayOneShot(p, 1f);
           // w.enabled = false;
            bw.enabled = false;
            gameManager.stainsisclean = true;
           // s.SetActive(false);
            Flowchart.BroadcastFungusMessage("潑灑反應");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        audiosource = GetComponent<AudioSource>();
        w = GetComponent<SpriteRenderer>();
        bw = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
