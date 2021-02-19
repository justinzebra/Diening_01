using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevatorbutton : MonoBehaviour
{
    public elevator elevator;
    public bool elevatorcanmove;
    public bool elevatoriswork;
    public GameObject E;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="Player")
        {
            E.SetActive(true);
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.name=="player")
        {
            elevatorcanmove=true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.name=="player")
        {
            elevatorcanmove=false;
            E.SetActive(false);
        }
    }
    void Openelevator()
    {
        if(Input.GetKeyDown(KeyCode.E)&&elevatoriswork==false)
        {
            elevator.elevatorfloor();
            elevatoriswork=true;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        elevator = elevator.GetComponent<elevator>();
        elevatorcanmove=false;
        elevatoriswork=false;
        E.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(elevatorcanmove==true)
        {
            Openelevator();
        }
    }
}
