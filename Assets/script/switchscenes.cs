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
    public bool opendoor=false;
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
            opendoor=true;
           
        }
    }
     IEnumerator WaitBeforeShow()
    {
        if (opendoor == true)
        {
            Flowchart.BroadcastFungusMessage("other");
            yield return new WaitForSeconds(1);
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
            else if(sceneName=="gallery_firstfloor")
            {
                g_E_changecurrentS();
            }
            else if(sceneName=="Pharmacyroom")
            {
                g_E_changecurrentS();
            }
            else if(sceneName=="gallery_B1")
            {
                g_B1_changecurrentS();
            }
            else if(sceneName=="incineration")
            {
                g_B1_changecurrentS();
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
    void g_E_changecurrentS()
    {
        if(goToTheScene=="Pharmacyroom")
        {
            gameManager.currents=currentS.eGtoP;
        }
        else if(goToTheScene=="gallery_B1")
        {
            gameManager.currents=currentS.eGtob1G;
        }
        else if(goToTheScene=="gallery_firstfloor")
        {
            gameManager.currents=currentS.PtoeG;
        }
    }
    void g_B1_changecurrentS()
    {
        if(goToTheScene=="gallery_firstfloor")
        {
            gameManager.currents=currentS.b1GtoeG;
        }
        else if(goToTheScene=="incineration")
        {
            gameManager.currents=currentS.b1GtoI;
        }
        else if(goToTheScene=="gallery_B1")
        {
            gameManager.currents=currentS.Itob1G;
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
        StartCoroutine(WaitBeforeShow());
    }
}
