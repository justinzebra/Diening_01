using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opendoor : MonoBehaviour
{
    bool music = false;
    public switchroom AA;

    public void MusicPlay()
    {
       
        AA.doorCanuse();
    }
    // Start is called before the first frame update
    void Start()
    {
        AA = AA.GetComponent<switchroom>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
