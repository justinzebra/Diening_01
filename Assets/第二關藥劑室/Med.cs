using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Med : MonoBehaviour
{
    public Flowchart flowchart;
    public bool test=false;


    string med01Name = "判斷是否2次進出";
    public bool med01
    {
        get
        {
            return flowchart.GetBooleanVariable(med01Name);
        }
        set
        {
            flowchart.SetBooleanVariable(med01Name, value);
        }
    }


    // Start is called before the first frame update
    GameManager gameManager;

    public void checkifmed()
    {
        if (med01 == false)
        {
            Debug.Log("有喔");
            gameManager.med = true;
            gameObject.SetActive(false);
        }

    }
    void Start()
    {
        checkifmed();
        gameManager = FindObjectOfType<GameManager>();
        if (gameManager.med == true)
        {
             gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        checkifmed();
    }
}
