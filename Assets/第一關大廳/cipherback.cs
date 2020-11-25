using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cipherback : MonoBehaviour
{
    public GameObject cipher;
    public Player AA;
    public Ciphermachine ciphermachine;
    public void OnMouseDown()
    {
        if (gameObject.name == "backbutton")
        {
            cipher.SetActive(false);
            AA.ReStartMove();
            ciphermachine.OpenBoxCollider();
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        AA = AA.GetComponent<Player>();
        ciphermachine = ciphermachine.GetComponent<Ciphermachine>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
