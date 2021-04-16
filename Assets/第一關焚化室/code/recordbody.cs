using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class recordbody : MonoBehaviour
{
   public Flowchart flowchart;
    public bool test=false;

    public GameObject ash;
    public GameObject body;
    public GameObject card;


    string burnbody01Name = "燒完屍體";
    public bool burnbody01
    {
        get
        {
            return flowchart.GetBooleanVariable(burnbody01Name);
        }
        set
        {
            flowchart.SetBooleanVariable(burnbody01Name, value);
        }
    }


    // Start is called before the first frame update
    GameManager gameManager;

    public void checkifbody()
    {
        if (burnbody01 == false)
        {
            Debug.Log("有喔");
            gameManager.burnbody = true;
            ash.SetActive(true);
            card.SetActive(false);
            body.SetActive(false);
        }

    }
    void Start()
    {
        checkifbody();
        gameManager = FindObjectOfType<GameManager>();
        if (gameManager.burnbody == true)
        {
           ash.SetActive(true);
            card.SetActive(false);
            body.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        checkifbody();
    }
}
