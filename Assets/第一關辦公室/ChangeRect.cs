using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRect : MonoBehaviour {

    
    public Texture2D cursorTexture;
    public Vector2 hotSpot = Vector2.zero;
    public CursorMode cursorMode = CursorMode.Auto;
	void Start () {
        
	}
	void Update () {
		
	}
    void OnMouseEnter()
    {
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }

    void OnMouseExit()
    {
        Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }

}

