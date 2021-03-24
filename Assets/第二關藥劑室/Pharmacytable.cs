using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pharmacytable : MonoBehaviour
{
   GameManager gameManager;
    public Player AA;
    public GameObject puzzle;
    BoxCollider2D bw;
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        AA = AA.GetComponent<Player>();
        puzzle.SetActive(false);
        bw = GetComponent<BoxCollider2D>();
    }
    void tableappear()
    {
        if(gameManager.medicineisright==true)
        {
            bw.enabled=false;
        }
        else
        {
            bw.enabled=true;
        }
    }
    void OnMouseDown()
    {
        if (this.gameObject.tag == "Puzzle")
        {
            AA.StopMove();
            puzzle.SetActive(true);
        }
    }
    public void closepuzzle()
    {
        puzzle.SetActive(false);
        AA.ReStartMove();
    }
    // Update is called once per frame
    void Update()
    {
        tableappear();
    }
}
