using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class switchscenes : MonoBehaviour
{
    public GameObject E;
    public string goToTheScene;
    public GameObject DontObj;
   

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
            DontDestroyOnLoad(DontObj);
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
    }

    // Update is called once per frame
    void Update()
    {

    }
}
