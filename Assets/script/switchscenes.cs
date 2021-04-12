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
            Flowchart.BroadcastFungusMessage("0857");
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
            else if(sceneName=="Elevator")
            {
                E_changecurrentS();
            }
        }
    }

    void S_changecurrentS()
    {
        if(goToTheScene=="Lobby")//0857
        {
            gameManager.currents=currentS.SRtoL;
            Flowchart.BroadcastFungusMessage("普通門轉場");
        }
    }
    void L_changecurrentS()
    {
        if(goToTheScene=="gallery_after")//s
        {
            gameManager.currents=currentS.LtoA;
            Flowchart.BroadcastFungusMessage("樓梯轉場");
        }
        else if(goToTheScene=="Lobby")//s
        {
            gameManager.currents=currentS.AtoL;
            Flowchart.BroadcastFungusMessage("樓梯轉場");
        }
        else if(goToTheScene=="Securityroom")//0857
        {
            gameManager.currents=currentS.LtoSR;
            Flowchart.BroadcastFungusMessage("普通門轉場");
        }
        else if(goToTheScene=="surgery")//0857
        {
            gameManager.currents=currentS.AtoS;
            Flowchart.BroadcastFungusMessage("自動門轉場");
        }
        else if(goToTheScene=="gallery_firstfloor")//0857
        {
            gameManager.currents=currentS.LtoeG;
            Flowchart.BroadcastFungusMessage("自動門轉場");
        }
    }
    void A_changecurrentS()
    {
        if(goToTheScene=="gallery_after"&&gameManager.currents==currentS.AtoS)//0857
        {
            gameManager.currents=currentS.StoA;
            Flowchart.BroadcastFungusMessage("自動門轉場");
        }
    }
    void g_E_changecurrentS()
    {
        if(goToTheScene=="Pharmacyroom")//0857
        {
            gameManager.currents=currentS.eGtoP;
            Flowchart.BroadcastFungusMessage("普通門轉場");
        }
        else if(goToTheScene=="gallery_B1")//s
        {
            gameManager.currents=currentS.eGtob1G;
            Flowchart.BroadcastFungusMessage("樓梯轉場");
        }
        else if(goToTheScene=="gallery_firstfloor")//s
        {
            gameManager.currents=currentS.PtoeG;
            Flowchart.BroadcastFungusMessage("普通門轉場");
        }
    }
    void g_B1_changecurrentS()
    {
        if(goToTheScene=="gallery_firstfloor")//s
        {
            gameManager.currents=currentS.b1GtoeG;
            Flowchart.BroadcastFungusMessage("樓梯轉場");
        }
        else if(goToTheScene=="incineration")//0857
        {
            gameManager.currents=currentS.b1GtoI;
            Flowchart.BroadcastFungusMessage("普通門轉場");
        }
        else if(goToTheScene=="gallery_B1")//0857
        {
            gameManager.currents=currentS.Itob1G;
            Flowchart.BroadcastFungusMessage("普通門轉場");
        }
    }
    void E_changecurrentS()
    {
        if(goToTheScene=="gallery_firstfloor")
        {
            gameManager.currents=currentS.inEtoeG;
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
