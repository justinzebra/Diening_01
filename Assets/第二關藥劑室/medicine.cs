using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class medicine : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    BoxCollider2D boxCollider2D;
    public Pharmacyblending colorjudgment;
    public medicinereturn medicinereturn;
    public GameObject Pos;
    public bool fadein;
    public bool fadeout;
    public GameObject color;
    Color c;
    public float smooth;
    float f;
    public AudioClip p;
    AudioSource audioSource;
    
    void OnMouseDrag()
    {
        Camera cam = Camera.main;      
        Vector3 newPos = cam.ScreenToWorldPoint(Input.mousePosition);  
        this.transform.position = new Vector3(newPos.x, newPos.y,-4.2f);//this.transform.position.z
        medicinereturn.returnbutton=false;
    }
    void OnMouseUp()
    { 
        this.transform.position = Pos.transform.position;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name=="透明")
        {
            fadeout=true;
            audioSource.PlayOneShot(p);
            boxCollider2D.enabled=false;
            // Invoke("Destroy",2f);
        }
    }
    public void Destroy()
    {
        Destroy(color);
    }
    void FadeInandOut()
    {
        if(fadein==true)
        {
            FadeIn();
        }
        else if(fadeout==true)
        {
            FadeOut();
        }
    }
    void FadeIn()
    {
        if(this.GetComponent<SpriteRenderer>().color.a<=1f)
        {
            f = c.a+(smooth*Time.deltaTime);
        }
        c = new Color(c.r,c.g,c.b,f);
        this.GetComponent<SpriteRenderer>().color=c;
        if(this.GetComponent<SpriteRenderer>().color.a>=1f)
        {
            fadein=false;
        }
    }
    void FadeOut()
    {
        if(this.GetComponent<SpriteRenderer>().color.a>=0f)
        {
            f = c.a-(smooth*Time.deltaTime);
        }
        c = new Color(c.r,c.g,c.b,f);
        this.GetComponent<SpriteRenderer>().color=c;
        if(this.GetComponent<SpriteRenderer>().color.a<=0f)
        {
            fadeout=false;
        }
    }
    void MedicineReturn()
    {
        if(medicinereturn.returnbutton==true)
        {
            fadein=true;
            boxCollider2D.enabled=true;
        }
    }
    public void boxColliderclose()
    {
        if(colorjudgment.rightcolor==true||colorjudgment.colors==ColorS.colorBlack)
        boxCollider2D.enabled=false;
    }
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer=GetComponent<SpriteRenderer>();
        boxCollider2D=GetComponent<BoxCollider2D>();
        colorjudgment=colorjudgment.GetComponent<Pharmacyblending>();
        medicinereturn=medicinereturn.GetComponent<medicinereturn>();
        c=spriteRenderer.color;
        fadein=false;
        fadeout=false;
        audioSource=GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // FadeIn();
        // FadeOut();
        FadeInandOut();
        boxColliderclose();
        MedicineReturn();
    }
}
