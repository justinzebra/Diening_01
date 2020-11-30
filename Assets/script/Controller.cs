using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    GameManager gameManager;
    public GameObject player;
    private string sceneName;
    void Lobby()
    {
        if(sceneName=="Lobby")
        {
        if(gameManager.currents==currentS.AtoL)
        {
            player.gameObject.transform.position = new Vector3(-53.73f,1.11f,-1.1f);
        }
        else if(gameManager.currents==currentS.SRtoL)
        {
            player.gameObject.transform.position = new Vector3(46.7f,1.11f,-1.1f);
        }
        }
    }
    void Securityroom()
    {
        if(sceneName=="Securityroom")
        {
        if(gameManager.currents==currentS.LtoSR)
        {
            player.gameObject.transform.position = new Vector3(29.26f,-0.15f,-1.1f);
        }
        }
    }
    void gallery_after()
    {
        if(sceneName=="gallery_after")
        {
        if(gameManager.currents==currentS.EtoA)
        {
            player.gameObject.transform.position = new Vector3(35.8f,8.07f,-1.1f);
        }
        else if(gameManager.currents==currentS.LtoA)
        {
            player.gameObject.transform.position = new Vector3(19f,8.07f,-1.1f);
        }
        else if(gameManager.currents==currentS.StoA)
        {
            player.gameObject.transform.position = new Vector3(-11.14f,8.07f,-1.1f);
        }
        }
    }
    void surgery()
    {
        if(sceneName=="surgery")
        {
        if(gameManager.currents==currentS.AtoS)
        {
            player.gameObject.transform.position = new Vector3(23f,-5.1f,-1.5f);
        }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        sceneName = SceneManager.GetActiveScene().name;
        Lobby();
        Securityroom();
        gallery_after();
        surgery();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
