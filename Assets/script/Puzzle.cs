﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour
{
    public Player AA;
    public GameObject puzzle;
    void Start()
    {
        AA = AA.GetComponent<Player>();
        puzzle.SetActive(false);
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

    }
}
