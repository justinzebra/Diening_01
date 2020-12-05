using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftandrightbtn : MonoBehaviour
{
    public monitormove monitormove;
    void OnMouseDown()
    {
        if(this.gameObject.name=="往右")
        {
            monitormove.Moveright();
        }
        else if(this.gameObject.name=="往左")
        {
             monitormove.Moveleft();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        monitormove = monitormove.GetComponent<monitormove>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
