using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 public enum currentS
    {
        AtoB,
        BtoA
    }

public class GameManager : MonoBehaviour
{
    static GameManager instance;
    public currentS currents;
    void Awake () 
    {
        if (instance==null)
        {
            instance = this;
            DontDestroyOnLoad(this);
            
        }
        else if (this!=instance)
        {
            Destroy(gameObject);
        }       
    }
    void State()
    {
        if(currents==currentS.AtoB)
        {

        }
        else if(currents==currentS.BtoA)
        {

        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
