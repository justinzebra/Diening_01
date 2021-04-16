using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackMusic : MonoBehaviour
{
    public AudioClip Bgmmusic;
    private AudioSource back;

    void Start () {
        back = GetComponent<AudioSource>();
        back.loop = true; //設置循環播放  
        back.volume = 0.25f;//設置音量最大，區間在0-1之間
        back.clip = Bgmmusic;
        back.Play(); //播放背景音樂，

       
    }
}
