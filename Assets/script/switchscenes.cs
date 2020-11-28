using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;
public class switchscenes : MonoBehaviour
{
    public GameObject E;
    public string goToTheScene;
    GameManager gameManager;

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
            changecurrentS();
        }
    }
    
    void changecurrentS()
    {
        if(goToTheScene=="Lobby")
        {
            gameManager.currents=currentS.BtoA;
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
    }

    // Update is called once per frame
    void Update()
    {

    }
}
