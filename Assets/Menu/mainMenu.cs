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
    public GameObject menu;
    public GameObject chapter;

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
    public void gameQuit()
    {
        Application.Quit();
        Debug.Log("quit");
    }
    public void Chapter()
    {
        menu.SetActive(false);
        chapter.SetActive(true);
    }
    public void backtoMainMenu()
    {
        menu.SetActive(true);
        chapter.SetActive(false);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        sceneName = SceneManager.GetActiveScene().name;
        chapter.SetActive(false);
    }

    // Update is called once per frame
      void Update()
    {
        StartCoroutine(WaitBeforeShow());
    }
}
