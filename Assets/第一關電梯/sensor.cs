using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sensor : MonoBehaviour
{
    GameManager gameManager;
    BoxCollider2D bw;
    public AudioClip p;
    AudioSource audiosource;
    public GameObject s;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "背包磁卡")
        {
            audiosource.PlayOneShot(p,1f);
            bw.enabled=false;
        }
    }
    void Controlappear()
    {
        if(gameManager.stainsisclean==false)
        {
            bw.enabled=false;
            s.SetActive(true);
        }
        else if(gameManager.stainsisclean==true)
        {
            bw.enabled=true;
            s.SetActive(false);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        audiosource = GetComponent<AudioSource>();
        bw = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Controlappear();
    }
}
