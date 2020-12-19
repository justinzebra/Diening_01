using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;

public class gameMenu : MonoBehaviour
{
    string goToTheScene;
    GameManager gameManager;
    private string sceneName;
    public bool opendoor=false;
    public GameObject mainmenu;
    public Canvas menu;
    public Canvas chapter;
    public Player player;
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
    public void menuAppear()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            mainmenu.SetActive(true);
            player.MenuisOpen();
        }
    }
    public void menudisAppear()
    {
        mainmenu.SetActive(false);
        player.MenuisClose();
        audiosource.PlayOneShot(p,0.5f);
    }
    public void gameQuit()
    {
        Application.Quit();
        Debug.Log("quit");
        audiosource.PlayOneShot(p,0.5f);
    }
    public void Chapter()
    {
        menu.enabled=false;
        chapter.enabled=true;
        audiosource.PlayOneShot(p,0.5f);
    }
    public void backtoMainMenu()
    {
        menu.enabled=true;
        chapter.enabled=false;
        audiosource.PlayOneShot(p,0.5f);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        sceneName = SceneManager.GetActiveScene().name;
        mainmenu.SetActive(false);
        chapter.enabled=false;
        player = player.GetComponent<Player>();
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
      void Update()
    {
        StartCoroutine(WaitBeforeShow());
        menuAppear();
    }

}
