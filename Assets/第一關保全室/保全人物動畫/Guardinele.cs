using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Guardinele : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("222");
            Flowchart.BroadcastFungusMessage("遇到阿伯");
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
