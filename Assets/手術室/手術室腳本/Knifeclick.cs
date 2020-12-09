using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Knifeclick : MonoBehaviour
{
    GameManager gameManager;
    // Start is called before the first frame update
    void OnMouseDown() {
        Flowchart.BroadcastFungusMessage ( "呼叫刀子" );
        Debug.Log("0000");
        Destroy(this.gameObject);
    }
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        if(gameManager.bodyisnokey==true)
        {
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
