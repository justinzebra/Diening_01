using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lighttrigger : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.name == "box1")
        {
            Debug.Log("AA");
            this.gameObject.SetActive(false);
            //Destroy(this.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
