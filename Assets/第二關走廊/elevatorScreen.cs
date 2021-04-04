using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevatorScreen : MonoBehaviour
{
    GameManager gameManager;
    public elevator elevator;
    Animator screen_animator;
    public void secondfloorTofistfloor()
    {
        screen_animator.SetBool("2to1",true);
    }
    public void firstflooroff()
    {
        screen_animator.SetBool("1on",false);
        screen_animator.SetBool("1off",true);
    }
    public void firstflooron()
    {
        screen_animator.SetBool("1on",true);
        screen_animator.SetBool("1off",false);
    }
    void secondorfirst()
    {
        if(gameManager.elevatoR==Elevator.secondfloor)
        {
            screen_animator.Play("elevator2off");
        }
        else if(gameManager.elevatoR==Elevator.firstfloor)
        {
            screen_animator.Play("elevator1off");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        elevator = elevator.GetComponent<elevator>();
        screen_animator = GetComponent<Animator>();
        gameManager = FindObjectOfType<GameManager>();
        secondorfirst();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
