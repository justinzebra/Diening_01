using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bodyBack : MonoBehaviour
{
    // public GameObject bodyback;
    public GameObject monitor;
    public Player AA;
    public Xrayequipment Xray;
    public void OnMouseDown()
    {
        if (gameObject.name == "backbutton")
        {
            monitor.SetActive(false);
            AA.ReStartMove();
            Xray.OpenBoxCollider();
            // bodyback.SetActive(true);
            Debug.Log("59595959");
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        AA = AA.GetComponent<Player>();
        Xray = Xray.GetComponent<Xrayequipment>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
