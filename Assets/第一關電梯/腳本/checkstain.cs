using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class checkstain : MonoBehaviour
{
   public Flowchart flowchart;
    public bool test=false;
    public GameObject smallblood;
public GameObject bigblood;
public GameObject smallstain;

public GameObject bigstain;
public GameObject inductionarea;




    string staingone01Name = "判斷污漬是否還在";
    public bool staingone01
    {
        get
        {
            return flowchart.GetBooleanVariable(staingone01Name);
        }
        set
        {
            flowchart.SetBooleanVariable(staingone01Name, value);
        }
    }


    // Start is called before the first frame update
    GameManager gameManager;

    public void checkifstain()
    {
        if (staingone01 == false)
        {
            Debug.Log("有喔");
            gameManager.staingone = true;
            gameObject.SetActive(false);
            bigblood.SetActive(true);
            smallblood.SetActive(true);
            bigstain.SetActive(false);
            smallstain.SetActive(false);
         inductionarea.SetActive(true);
          
        }

    }
    void Start()
    {
        checkifstain();
        gameManager = FindObjectOfType<GameManager>();
        if (gameManager.staingone == true)
        {
             gameObject.SetActive(false);
          
                 bigblood.SetActive(true);
            smallblood.SetActive(true);
            bigstain.SetActive(false);
            smallstain.SetActive(false);
         inductionarea.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        checkifstain();
    }
}
