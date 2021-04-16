using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;

public class Opswitch : MonoBehaviour
{
    public string goToTheScene;
    // Start is called before the first frame update
    private string sceneName;

     public Flowchart flowchart;
     public Flowchart flowchart2;
    string goName = "去辦公室";
    public bool go
    {
        get
        {
            return flowchart.GetBooleanVariable(goName);
        }
        set
        {
            flowchart.SetBooleanVariable(goName, value);
        }
    }
    IEnumerator WaitBeforeShow()
    {
        if (go == true)
        {
           
            yield return new WaitForSeconds(1);
            SceneManager.LoadScene(goToTheScene);

        }
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(WaitBeforeShow());
    }
}
