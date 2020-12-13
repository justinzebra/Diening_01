using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;

public class mainMenu : MonoBehaviour
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
    public void OroomChange()
    {
        opendoor = true;
        goToTheScene="Office";
    }
    public void EroomChange()
    {
        opendoor = true;
        goToTheScene="electricity";
    }
    public void SroomChange()
    {
        opendoor = true;
        goToTheScene="surgery";
    }
    public void LroomChange()
    {
        opendoor = true;
        goToTheScene="Lobby";
    }
    public void SRroomChange()
    {
        opendoor = true;
        goToTheScene="Securityroom";
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
    }
}
