using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevatorScreen : MonoBehaviour
{
    public elevator elevator;
    // Start is called before the first frame update
    void Start()
    {
        elevator = elevator.GetComponent<elevator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
