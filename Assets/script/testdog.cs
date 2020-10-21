using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testdog : MonoBehaviour
{
    static testdog instance;
    Load load;
Bag Bag01;
    public bool dogiscatch;
    public SpriteRenderer dogsprite;

    void Awake()
   {
       load=FindObjectOfType<Load>();
       Bag01=FindObjectOfType<Bag>();
   }
  void Start()
{
    this.dogsprite=GetComponent<SpriteRenderer>();
    dogiscatch=false;

}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "player")
        {

          this.dogsprite.enabled=false;
          dogiscatch=true;
          Debug.Log("ㄚㄚ ");
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
