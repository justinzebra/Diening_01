using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour
{
    static Load instance;
    public bool loaddog;
    testdog testdog01;
    Bag Bag01;
    void Awake()
    {
        testdog01 = FindObjectOfType<testdog>();
        Bag01 = FindObjectOfType<Bag>();

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
            name = "最初的遊戲管理物件";

        }
        else if (this != instance)
        {
            string sceneName = SceneManager.GetActiveScene().name;
            Debug.Log("刪除" + sceneName + "的" + name);
            Destroy(gameObject);
        }
    }
    void Start()
    {
        loaddog = false;
    }

    void checkdoginbag()
    {
        if (testdog01.dogiscatch == true)
        {
            Debug.Log("阿阿阿");
            loaddog = true;


        }
    }
    // Update is called once per frame
    void update()
    {
        checkdoginbag();
    }
}
