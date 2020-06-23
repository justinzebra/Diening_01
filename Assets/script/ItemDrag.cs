using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDrag : MonoBehaviour
{

    private Vector3 screenPoint;
    private Vector3 offset;
    //Rigidbody2D tb;

    //private void Start()
    //{
    //    tb = this.GetComponent<Rigidbody2D>();

    //}
    public GameObject showdead;
   
    
    public bool isdog=false;
    

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

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.name == "box")
        {
            this.gameObject.SetActive(false);
            //Destroy(this.gameObject);
            showdead.SetActive(true);
           
     
            
            isdog = true;
        }
    }
    //void lightgone(Collider2D other)
    //{
    //    if (other.name == "box1")
    //    {
    //        this.gameObject.SetActive(false);
    //        //Destroy(this.gameObject);
           
    //        showlight.SetActive(true);

    //        lightout.SetActive(false);

    //    }
    //}
}
