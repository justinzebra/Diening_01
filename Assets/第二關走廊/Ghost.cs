using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Ghost : MonoBehaviour
{
    public Flowchart flowchart;
    public bool test=false;


    string elevatorghost01Name = "電梯鬼開關";
    public bool elevatorghost01
    {
        get
        {
            return flowchart.GetBooleanVariable(elevatorghost01Name);
        }
        set
        {
            flowchart.SetBooleanVariable(elevatorghost01Name, value);
        }
    }


    // Start is called before the first frame update
    GameManager gameManager;

    public void checkifghost()
    {
        if (elevatorghost01 == false)
        {
            Debug.Log("有喔");
            gameManager.elevatorghost = true;
            gameObject.SetActive(false);
        }

    }
    void Start()
    {
        checkifghost();
        gameManager = FindObjectOfType<GameManager>();
        if (gameManager.elevatorghost == true)
        {
             gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        checkifghost();
    }
}
