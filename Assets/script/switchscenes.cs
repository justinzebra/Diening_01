using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class switchscenes : MonoBehaviour
{
    public GameObject E;
    public string goToTheScene;
    GameManager gameManager;
    
    private string sceneName;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "player")
        {
            E.SetActive(true);
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
         if (other.name == "player"&& Input.GetKey("e"))
        {
            SceneManager.LoadScene(goToTheScene);
            if(sceneName=="Securityroom")
            {
                S_changecurrentS();
            }
            else if(sceneName=="Lobby")
            {
                L_changecurrentS();
            }
            else if(sceneName=="gallery_after")
            {
                L_changecurrentS();
            }
            else if(sceneName=="surgery")
            {
                A_changecurrentS();
            }
        }
    }
    void S_changecurrentS()
    {
        if(goToTheScene=="Lobby")
        {
            gameManager.currents=currentS.SRtoL;
        }
    }
    void L_changecurrentS()
    {
        if(goToTheScene=="gallery_after")
        {
            gameManager.currents=currentS.LtoA;
        }
        else if(goToTheScene=="Lobby")
        {
            gameManager.currents=currentS.AtoL;
        }
        else if(goToTheScene=="Securityroom")
        {
            gameManager.currents=currentS.LtoSR;
        }
        else if(goToTheScene=="surgery")
        {
            gameManager.currents=currentS.AtoS;
        }
    }
    void A_changecurrentS()
    {
        if(goToTheScene=="gallery_after"&&gameManager.currents==currentS.AtoS)
        {
            gameManager.currents=currentS.StoA;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "player")
        {
            E.SetActive(false);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        E.SetActive(false);
        gameManager = FindObjectOfType<GameManager>();
        sceneName = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
