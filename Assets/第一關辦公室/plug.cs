using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class plug : MonoBehaviour
{
    public GameObject Plug;
    public GameObject dirty;
    public GameObject clean;
    public socket socket;
    public inserted inserted;
    public bookappear bookappear;

    void OnMouseDrag()
    {
        Camera cam = Camera.main;
        Vector3 newPos = cam.ScreenToWorldPoint(Input.mousePosition);
        this.transform.position = new Vector3(newPos.x, newPos.y, -0.1f);

    }
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "socket")
        {

            // plug2.SetActive(true);
            Plug.SetActive(false);

            socket.ConTrolAppear();
            inserted.ConTrolAppear();
            clean.SetActive(true);
            dirty.SetActive(false);
            bookappear.ConTrolAppear();
            Flowchart.BroadcastFungusMessage ( "789" );
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        socket = socket.GetComponent<socket>();
        inserted = inserted.GetComponent<inserted>();
        clean.SetActive(false);
        bookappear = bookappear.GetComponent<bookappear>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
