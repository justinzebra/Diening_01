using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bag : MonoBehaviour
{
    static Bag instance;
    Load load;
    testdog testdog01;

    public GameObject fakedog;
    public bool showdoginbag;
    void start()
    {
        showdoginbag = false;
        fakedog.SetActive(false);
    }
    void Awake()
    {
        load = FindObjectOfType<Load>();
        testdog01 = FindObjectOfType<testdog>();
    }


    void showinbag()
    {
        if (testdog01.dogiscatch==true)
        {
            showdoginbag = true;
            fakedog.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        showinbag();
    }
}
