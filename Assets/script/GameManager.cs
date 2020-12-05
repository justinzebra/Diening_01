using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 public enum currentS
    {
        AtoL,
        SRtoL,
        LtoSR,
        LtoA,
        EtoA,
        StoA,
        AtoS
    }

public class GameManager : MonoBehaviour
{
    static GameManager instance;
    public currentS currents;
    public bool doorisopen=false;
    public bool bodyisnokey=false;
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
  
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
