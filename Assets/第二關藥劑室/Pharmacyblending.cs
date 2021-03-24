using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.Assertions;
using UnityEngine.SceneManagement;
public enum ColorS
{
    colorLess,
    colorWhite,
    colorYellow,
    colorBlue,
    colorGreen,
    colorRed,
    colorOrage,
    colorBlack
}
public class Pharmacyblending : MonoBehaviour
{
    GameManager gameManager;
    public ColorS colors;
    SpriteRenderer spriteRenderer;
    public medicinereturn medicinereturn;
    public GameObject returnbutton;
    Color color1 = Color.yellow;
    Color color2 = Color.blue;
    Color color3 = Color.green;
    Color fincolor;
    public Sprite[] medicines;
    public float smooth;
    public bool rightcolor = false;
    public Flowchart flowchart;
    string CantakeName = "可拿杯子";
    public bool Cantake
    {
        get
        {
            return flowchart.GetBooleanVariable(CantakeName);
        }
        set
        {
            flowchart.SetBooleanVariable(CantakeName, value);
        }
    }
    void OnMouseDrag()
    {
        if (rightcolor == true)
        {
            Camera cam = Camera.main;
            Vector3 newPos = cam.ScreenToWorldPoint(Input.mousePosition);
            this.transform.position = new Vector3(newPos.x, newPos.y, this.transform.position.z);
        }
    }
    void canMove()
    {
        rightcolor = true;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "黃色" && colors == ColorS.colorLess)
        {
            colors = ColorS.colorYellow;
        }
        else if (other.gameObject.name == "黃色" && colors == ColorS.colorRed)
        {
            gameManager.medicineisright=true;
            colors = ColorS.colorOrage;
            Invoke("canMove", 2f);
            Cantake = true;
        }
        else if (other.gameObject.name == "黃色" && colors != ColorS.colorLess && colors != ColorS.colorYellow)
        {
            colors = ColorS.colorBlack;
        }
        else if (other.gameObject.name == "藍色" && colors == ColorS.colorLess)
        {
            colors = ColorS.colorBlue;
        }
        else if (other.gameObject.name == "藍色" && colors != ColorS.colorLess && colors != ColorS.colorBlue)
        {
            colors = ColorS.colorBlack;
        }
        else if (other.gameObject.name == "白色" && colors == ColorS.colorLess)
        {
            colors = ColorS.colorWhite;
        }
        else if (other.gameObject.name == "白色" && colors != ColorS.colorLess && colors != ColorS.colorWhite)
        {
            colors = ColorS.colorBlack;
        }
        else if (other.gameObject.name == "紅色" && colors == ColorS.colorLess)
        {
            colors = ColorS.colorRed;
        }
        else if (other.gameObject.name == "紅色" && colors == ColorS.colorYellow)
        {
            gameManager.medicineisright=true;
            colors = ColorS.colorOrage;
            Invoke("canMove", 2f);
            Cantake = true;
        }
        else if (other.gameObject.name == "紅色" && colors != ColorS.colorLess && colors != ColorS.colorRed)
        {
            colors = ColorS.colorBlack;
        }
        else if (other.gameObject.name == "綠色" && colors == ColorS.colorLess)
        {
            colors = ColorS.colorGreen;
        }
        else if (other.gameObject.name == "綠色" && colors != ColorS.colorLess && colors != ColorS.colorGreen)
        {
            colors = ColorS.colorBlack;
        }

    }
    void ColorJudgment()
    {
        if (colors == ColorS.colorWhite)
        {
            // fincolor = Color.white;
            spriteRenderer.sprite = medicines[1];
        }
        else if (colors == ColorS.colorYellow)
        {
            // fincolor = color1;
            spriteRenderer.sprite = medicines[3];
        }
        else if (colors == ColorS.colorBlue)
        {
            // fincolor= color2;
            spriteRenderer.sprite = medicines[4];
        }
        else if (colors == ColorS.colorGreen)
        {
            // fincolor = color3;
            spriteRenderer.sprite = medicines[2];
        }
        else if (colors == ColorS.colorRed)
        {
            // fincolor = color3;
            spriteRenderer.sprite = medicines[5];
        }
        else if (colors == ColorS.colorBlack)
        {
            // fincolor = color3;
            spriteRenderer.sprite = medicines[6];
        }
        else if (colors == ColorS.colorOrage)
        {
            // fincolor = color3;
            spriteRenderer.sprite = medicines[7];
        }
        else if (colors == ColorS.colorLess)
        {
            // fincolor = color3;
            spriteRenderer.sprite = medicines[0];
        }
        // spriteRenderer.color = Color.Lerp(spriteRenderer.color, fincolor, smooth * Time.deltaTime);
    }
    void MedicineReturn()
    {
        if (medicinereturn.returnbutton == true)
        {
            colors = ColorS.colorLess;
            rightcolor = false;
        }
    }
    void ReturnButton()
    {
        if (colors == ColorS.colorBlack)
        {
            returnbutton.SetActive(true);
        }
        else
        {
            returnbutton.SetActive(false);
        }
    }
    // Start is called before the first frame update
    void OnMouseDown()
    {
        if (Cantake == true)
            Flowchart.BroadcastFungusMessage("得到藥水");
            Destroy(this.gameObject);
        Debug.Log("0000");

    }
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        medicinereturn = medicinereturn.GetComponent<medicinereturn>();
        colors = ColorS.colorLess;
        returnbutton.SetActive(false);
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        ColorJudgment();
        MedicineReturn();
        ReturnButton();
    }
}
