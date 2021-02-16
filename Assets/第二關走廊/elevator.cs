using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public enum Elevator
{
    firstfloor,
    secondfloor
}

public class elevator : MonoBehaviour
{
    public string sceneName;
    public Elevator elevatoR;
    Animator door_animator; 
    public AudioClip p1;
    public AudioClip p2;
    AudioSource audiosource;
    public elevatorbutton elevatorbutton;
    public void elevatorfloor()
    {
        if(sceneName=="gallery_firstfloor"&&elevatoR==Elevator.firstfloor)
        {
            elevatorarrival();
        }
        else if(sceneName=="gallery_firstfloor"&&elevatoR==Elevator.secondfloor)
        {
            Invoke("elevatorarrival",3f);
            elevatoR=Elevator.firstfloor;
        }
        else if(sceneName=="2"&&elevatoR==Elevator.secondfloor)
        {
            Invoke("elevatorarrival",3f);
            elevatoR=Elevator.firstfloor;
        }
        else if(sceneName=="2"&&elevatoR==Elevator.secondfloor)
        {
            elevatorarrival();
        }
    }
    void elevatorarrival()
    {
        Invoke("elevatorOpen",1f);
        audiosource.PlayOneShot(p2,1f);
    }
    public void elevatorOpen()
    {
        door_animator.SetBool("elevatorOpen",true);
        door_animator.SetBool("elevatorClose",false);
        Invoke("elevatorClose",7f);
        audiosource.PlayOneShot(p1,1f);
    }
    void elevatorClose()
    {
        door_animator.SetBool("elevatorOpen",false);
        door_animator.SetBool("elevatorClose",true);
        elevatorbutton.elevatoriswork=false;
    }
    // Start is called before the first frame update
    void Start()
    {
        door_animator = GetComponent<Animator>();
        audiosource = GetComponent<AudioSource>();
        sceneName = SceneManager.GetActiveScene().name;
        elevatorbutton = elevatorbutton.GetComponent<elevatorbutton>();
    }

    // Update is called once per frame
    void Update()
    {
        // DoorControl();
    }
}
