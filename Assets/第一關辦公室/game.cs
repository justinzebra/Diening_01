using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Fungus;

public class game : MonoBehaviour
{
    public GameObject first;
    public GameObject second;
    public GameObject third;
    public GameObject start;
    public bool iswall=false;
    public bookappear bookappear;
    void OnMouseDrag()
    {
        if(iswall==false)
        {
        Camera cam = Camera.main;      
        Vector3 newPos = cam.ScreenToWorldPoint(Input.mousePosition);  
        this.transform.position = new Vector3(newPos.x, newPos.y, -0.1f);
        }
    }
    void OnMouseUp()
    {
        this.transform.position = start.transform.position;
    }
    void ReMove()
    {
        iswall=false;
    }
     void OnTriggerStay2D(Collider2D other)
    { 
        if(other.gameObject.tag == "wall")
        {
            iswall=true;
            this.transform.position = start.transform.position;
            Invoke("ReMove",1);
        }
        if(other.gameObject.name == "destination1")
        {
            iswall=true;
            this.transform.position = start.transform.position;
            Invoke("ReMove",1);
            first.SetActive(false);
            second.SetActive(true);
        }
        if(other.gameObject.name == "destination2")
        {
            iswall=true;
            this.transform.position = start.transform.position;
            Invoke("ReMove",1);
            second.SetActive(false);
            third.SetActive(true);
        }
        if(other.gameObject.name == "destination3")
        {
            iswall=true;
            this.transform.position = start.transform.position;
            Invoke("ReMove",1);
            third.SetActive(true);
            //first.SetActive(true);
            bookappear.ConTrolAppear();
            Flowchart.BroadcastFungusMessage ( "12345" );
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        second.SetActive(false);
        third.SetActive(false);
        bookappear = bookappear.GetComponent<bookappear>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}

