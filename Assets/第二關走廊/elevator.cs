﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class elevator : MonoBehaviour
{
    GameManager gameManager;
    public string sceneName;
    public GameObject Edoor;
    Animator door_animator; 
    public AudioClip p1;
    public AudioClip p2;
    public AudioClip p3;
    AudioSource audiosource;
    public elevatorbutton elevatorbutton;
    public void elevatorfloor()
    {
        if(sceneName=="gallery_firstfloor"&&gameManager.elevatoR==Elevator.firstfloor)
        {
            elevatorarrival();
        }
        else if(sceneName=="gallery_firstfloor"&&gameManager.elevatoR==Elevator.secondfloor)
        {
            Invoke("elevatorarrival",3f);
            gameManager.elevatoR=Elevator.firstfloor;
        }
        else if(sceneName=="2"&&gameManager.elevatoR==Elevator.firstfloor)
        {
            Invoke("elevatorarrival",3f);
            gameManager.elevatoR=Elevator.firstfloor;
        }
        else if(sceneName=="2"&&gameManager.elevatoR==Elevator.firstfloor)
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
        Edoor.SetActive(true);
    }
    void elevatorClose()
    {
        door_animator.SetBool("elevatorOpen",false);
        door_animator.SetBool("elevatorClose",true);
        elevatorbutton.elevatoriswork=false;
        audiosource.PlayOneShot(p3,1f);
        Edoor.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        door_animator = GetComponent<Animator>();
        audiosource = GetComponent<AudioSource>();
        sceneName = SceneManager.GetActiveScene().name;
        elevatorbutton = elevatorbutton.GetComponent<elevatorbutton>();
        Edoor.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // DoorControl();
    }
}
