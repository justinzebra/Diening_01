using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeverD : MonoBehaviour
{
    public static NeverD Instance;
    // Start is called before the first frame update
    // void Start()
    // {
    //     if (Instance != null)
    //     {
    //         Destroy(this.gameObject);
    //         return;
    //     }
    //     GameObject.DontDestroyOnLoad(this.gameObject);

    // }
    void Awake () 
    {
        if (Instance==null)
        {
            Instance = this;
            DontDestroyOnLoad(this);
            
        }
        else if (this!=Instance)
        {
            Destroy(gameObject);
        }       
    }
    // Update is called once per frame
    void Update()
    {

    }
}
