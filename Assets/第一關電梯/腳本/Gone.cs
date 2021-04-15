using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Gone : MonoBehaviour
{
    // Start is called before the first frame update
     private Vector3 screenPoint;
    private Vector3 offset;
  void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        //tb.gravityScale = 0;
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;
    }
   void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="staingone")
        {
            Destroy(this.gameObject);
            
            Debug.Log("5566");
        }
      
    }
}
