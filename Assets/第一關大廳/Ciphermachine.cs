using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ciphermachine : MonoBehaviour
{
    public Player AA;
    public GameObject cipher;
    
    void Start()
    {
        AA = AA.GetComponent<Player>();
        cipher.SetActive(false);
    }
    void OnMouseDown()
    {
        if (gameObject.name == "cipher")
        {
            AA.StopMove();
            cipher.SetActive(true);
        }

    }
    // Update is called once per frame
    void Update()
    {
    }
}
