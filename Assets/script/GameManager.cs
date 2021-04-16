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
    AtoS,
    EtoB,
    eGtoP,
    PtoeG,
    eGtob1G,
    b1GtoeG,
    b1GtoI,
    Itob1G,
    LtoeG,
    inEtoeG
}
public enum Elevator
{
    firstfloor,
    secondfloor
}

public class GameManager : MonoBehaviour
{
    static GameManager instance;
    public currentS currents;
    public Elevator elevatoR;
    public bool doorisopen = false;
    public bool bodyisnokey = false;
    public bool dogisgoout = false;
    public bool rollingdoor = false;
    public bool medicineisright = false;
    public bool cipherisopen = false;
    public bool stainsisclean = false;

   
    public bool elevatorghost=false;
    
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
           DontDestroyOnLoad(this);

        }
        else if (this != instance)
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
