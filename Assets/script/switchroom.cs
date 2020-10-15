using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchroom : MonoBehaviour
{
    public GameObject E;
    bool d_canuse = false;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "player"&&d_canuse==true)
        {
          E.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "player"&&d_canuse==true)
        {
          E.SetActive(false);
        }
    }

    public void doorCanuse()
    {
        d_canuse = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        E.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
