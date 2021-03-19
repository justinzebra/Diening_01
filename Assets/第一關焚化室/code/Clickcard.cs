using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;

public class Clickcard : MonoBehaviour
{
    // Start is called before the first frame update
    void OnMouseDown()
    {

        Flowchart.BroadcastFungusMessage("得到磁卡");
        Destroy(this.gameObject);
        Debug.Log("0000");

    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
