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
        if(gameManager.currents==currentS.AtoB)
        {
            player.gameObject.transform.position = new Vector3(-53.73f,1.11f,-1.1f);
        }
        else if(gameManager.currents==currentS.BtoA)
        {
            player.gameObject.transform.position = new Vector3(46.7f,1.11f,-1.1f);
        }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        sceneName = SceneManager.GetActiveScene().name;
        Lobby();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
