using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plug : MonoBehaviour
{
    public GameObject plug1;
    public GameObject plug2;
    public AudioClip p;
    AudioSource audiosource;
    void OnMouseDrag()
    {
        Camera cam = Camera.main;      
        Vector3 newPos = cam.ScreenToWorldPoint(Input.mousePosition);  
        this.transform.position = new Vector3(newPos.x, newPos.y,0.1f);
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
       
        if(other.gameObject.tag=="D")
        {
            audiosource.PlayOneShot(p);
            
            plug2.SetActive(true);
            plug1.SetActive(false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        plug2.SetActive(false);
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
