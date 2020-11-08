using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mousecursor : MonoBehaviour
{
    public Texture2D mouseeye;
    public Texture2D mousehand;

    void Start()
    {

          //Cursor.visible = false;
        Cursor.SetCursor(mousehand, Vector2.zero, CursorMode.ForceSoftware);
    }
    // Update is called once per frame
    void Update()
    {




        // Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // transform.position = cursorPos;
    }


    void OnmouseEnter()
    {
        Cursor.SetCursor(mouseeye, Vector2.zero, CursorMode.ForceSoftware);


    }
    void OnMouseExit()
    {
        Cursor.SetCursor(mousehand, Vector2.zero, CursorMode.ForceSoftware);
    }

}

