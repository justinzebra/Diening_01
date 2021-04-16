using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class induction : MonoBehaviour
{
     GameManager gameManager;



    // Start is called before the first frame update




     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "背包磁卡")
        {
           Flowchart.BroadcastFungusMessage("逼卡反應");
        }
    }
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
