using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Socketa : MonoBehaviour
{
    public Player AA;
    public GameObject socket;
    public windowaback sb;
    // Start is called before the first frame update
    void OnMouseDown()
    {
        if (gameObject.tag == "socket")
        {
           socket.SetActive(true);
           AA.StopMove();
           sb.ConTrolAppearb();
        }

    }
    void Start()
    {
        socket.SetActive(false);
        AA = AA.GetComponent<Player>();
        sb = sb.GetComponent<windowaback>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
