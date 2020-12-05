using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorlock : MonoBehaviour
{
    public GameObject E;
    GameManager gameManager;
    AudioSource audiosource;
    BoxCollider2D bw;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name=="背包裡的鑰匙")
        {
            gameManager.doorisopen=true;
            audiosource.Play();
            Destroy(other.gameObject);
        }
    }
    void doorappear()
    {
        if(gameManager.doorisopen==true)
        {
            E.SetActive(true);
            bw.enabled=false;
        }
        else
        {
            bw.enabled=true;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        E.SetActive(false);
        audiosource = GetComponent<AudioSource>();
        bw = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        doorappear();
    }
}
