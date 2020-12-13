using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;

public class Changeroom : MonoBehaviour
{
    string goToTheScene;
    GameManager gameManager;
    private string sceneName;
    public bool opendoor=false;

    IEnumerator WaitBeforeShow()
    {
        if (opendoor == true&&sceneName=="Office")
        {
            Flowchart.BroadcastFungusMessage("0857");
            yield return new WaitForSeconds(1);
            SceneManager.LoadScene(goToTheScene);
        }
        else if(opendoor == true)
        {
            Flowchart.BroadcastFungusMessage("other");
            yield return new WaitForSeconds(1);
            SceneManager.LoadScene(goToTheScene);
        }
    }
    void OroomChange()
    {
        if(Input.GetKey(KeyCode.Keypad2))
        {
            opendoor = true;
            goToTheScene="electricity";
        }
        else if(Input.GetKey(KeyCode.Keypad3))
        {
            opendoor = true;
            goToTheScene="surgery";
        
            gameManager.currents=currentS.AtoS;
        }
        else if(Input.GetKey(KeyCode.Keypad4))
        {
            opendoor = true;
            goToTheScene="Lobby";
        
            gameManager.currents=currentS.AtoL;
        }
        else if(Input.GetKey(KeyCode.Keypad5))
        {
            opendoor = true;
            goToTheScene="Securityroom";
        
            gameManager.currents=currentS.LtoSR;
        }
    }
    void EroomChange()
    {
        if(Input.GetKey(KeyCode.Keypad1))
        {
            opendoor = true;
            goToTheScene="Office";
        }
        else if(Input.GetKey(KeyCode.Keypad3))
        {
            opendoor = true;
            goToTheScene="surgery";
            gameManager.currents=currentS.AtoS;
        }
        else if(Input.GetKey(KeyCode.Keypad4))
        {
            opendoor = true;
            goToTheScene="Lobby";
            gameManager.currents=currentS.AtoL;
        }
        else if(Input.GetKey(KeyCode.Keypad5))
        {
            opendoor = true;
            goToTheScene="Securityroom";
            gameManager.currents=currentS.LtoSR;
        }
    }
    void SroomChange()
    {
        if(Input.GetKey(KeyCode.Keypad1))
        {
            opendoor = true;
            goToTheScene="Office";
        }
        else if(Input.GetKey(KeyCode.Keypad2))
        {
            opendoor = true;
            goToTheScene="electricity";
        }
        else if(Input.GetKey(KeyCode.Keypad4))
        {
            opendoor = true;
            goToTheScene="Lobby";
            gameManager.currents=currentS.AtoL;
        }
        else if(Input.GetKey(KeyCode.Keypad5))
        {
            opendoor = true;
            goToTheScene="Securityroom";
            gameManager.currents=currentS.LtoSR;
        }
    }
    void LroomChange()
    {
        if(Input.GetKey(KeyCode.Keypad1))
        {
            opendoor = true;
            goToTheScene="Office";
        }
        else if(Input.GetKey(KeyCode.Keypad2))
        {
            opendoor = true;
            goToTheScene="electricity";
        }
        else if(Input.GetKey(KeyCode.Keypad3))
        {
            opendoor = true;
            goToTheScene="surgery";
            gameManager.currents=currentS.AtoS;
        }
        else if(Input.GetKey(KeyCode.Keypad5))
        {
            opendoor = true;
            goToTheScene="Securityroom";
            gameManager.currents=currentS.LtoSR;
        }
    }
    void SRroomChange()
    {
        if(Input.GetKey(KeyCode.Keypad1))
        {
            opendoor = true;
            goToTheScene="Office";
        }
        else if(Input.GetKey(KeyCode.Keypad2))
        {
            opendoor = true;
            goToTheScene="electricity";
        }
        else if(Input.GetKey(KeyCode.Keypad3))
        {
            opendoor = true;
            goToTheScene="surgery";
            gameManager.currents=currentS.AtoS;
        }
        else if(Input.GetKey(KeyCode.Keypad4))
        {
            opendoor = true;
            goToTheScene="Lobby";
            gameManager.currents=currentS.SRtoL;
        }
    }

    
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        sceneName = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
      void Update()
    {
        StartCoroutine(WaitBeforeShow());
        if(sceneName=="Office")
        {
            OroomChange();
        }
        else if(sceneName=="electricity")
        {
            EroomChange();
        }
        else if(sceneName=="surgery")
        {
            SroomChange();
        }
        else if(sceneName=="Lobby")
        {
            LroomChange();
        }
        else if(sceneName=="Securityroom")
        {
            SRroomChange();
        }
    }
}
