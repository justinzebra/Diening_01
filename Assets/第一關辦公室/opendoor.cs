using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opendoor : MonoBehaviour
{
    bool music = false;
    AudioSource audiosource;
    public switchroom AA;

    public void MusicPlay()
    {
        audiosource.Play();
        AA.doorCanuse();
    }
    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        AA = AA.GetComponent<switchroom>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
