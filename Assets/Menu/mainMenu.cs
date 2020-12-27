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
    public Canvas menu;
    public Canvas chapter;
    public Canvas playteaching;
    public AudioClip p;
    AudioSource audiosource;
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
        audiosource.PlayOneShot(p,0.5f);
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
        menu.enabled=false;
        chapter.enabled=true;
        audiosource.PlayOneShot(p,0.5f);
    }
    public void Playteaching()
    {
        menu.enabled=false;
        playteaching.enabled=true;
        audiosource.PlayOneShot(p,0.5f);
    }
    public void backtoMainMenu()
    {
        menu.enabled=true;
        chapter.enabled=false;
        playteaching.enabled=false;
        audiosource.PlayOneShot(p,0.5f);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        sceneName = SceneManager.GetActiveScene().name;
        chapter.enabled=false;
        playteaching.enabled=false;
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
      void Update()
    {
        StartCoroutine(WaitBeforeShow());
    }
}
