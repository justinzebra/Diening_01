using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L_opendoor : MonoBehaviour
{
    bool music = false;
    AudioSource audiosource;
    // public switchroom AA;
    public AudioClip right;
    public AudioClip rong;

    public void MusicPlay()
    {
        // audiosource.Play();
        audiosource.PlayOneShot(right,0.2f);
        // AA.doorCanuse();
    }
    public void rongMusic()
    {
        audiosource.PlayOneShot(rong,0.6f);
    }
    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        // AA = AA.GetComponent<switchroom>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
