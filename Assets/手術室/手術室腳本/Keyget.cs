using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
public class Keyget : MonoBehaviour
{
    void OnMouseDown()
    {
        Flowchart.BroadcastFungusMessage ( "鑰匙出現" );
        Debug.Log("0000");
    }
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {

    }
}
