using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rollingdoor : MonoBehaviour
{
    GameManager gameManager;
    public Ironrollingdoor ironrollingdoor;
    Animator door_animator;
    void DoorControl()
    {
        if(ironrollingdoor.doorisopen==true)
        {
            door_animator.SetBool("doorUp",true);
            door_animator.SetBool("doorDwon",false);
        }
        else if(ironrollingdoor.doorisopen==false)
        {
            door_animator.SetBool("doorUp",false);
            door_animator.SetBool("doorDwon",true);
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        ironrollingdoor = ironrollingdoor.GetComponent<Ironrollingdoor>();
        door_animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        DoorControl();
    }
}
