using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;

public class Switch : MonoBehaviour
{
    public bool opendoor = false;
    [Header("連接到某場景")]
    public string goToTheScene;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            opendoor = true;
        }
    }

    IEnumerator WaitBeforeShow()
    {
        if (opendoor == true)
        {
            Flowchart.BroadcastFungusMessage("0857");
            yield return new WaitForSeconds(1);
            SceneManager.LoadScene(goToTheScene);

        }
    }

    void Update()
    {
        StartCoroutine(WaitBeforeShow());
    }
}