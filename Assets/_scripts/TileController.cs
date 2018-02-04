using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TileController : MonoBehaviour
{
    public Color playerColor = allVariables.getPlayerColor(); // R G B A
    private Color defaultColor = Color.white;
    public ColorBlock playerBlockColor = new ColorBlock();
    public int myID;
    public GameObject pParent;

    public Button yourButton;
    // Use this for initialization
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(clickF);
        playerColor = allVariables.getPlayerColor();
        //myID = GetComponent<Gameboard>().getID();
    }

    void clickF()
    {
        //Debug.Log(transform.parent.transform.parent.GetComponent<Player>().getTotalBetAmount().ToString());
        //GetComponent<Button>().colors = playerBlockColor; // = playerColor;
        //Debug.Log("Clicked");
        if (GetComponent<Image>().color != playerColor) {
            //Debug.Log("lol");
            if (transform.parent.transform.parent.GetComponent<Player>().getTotalBetAmount() > 0)//GetComponentInParent<Player>().getTotalBetAmount() > 0)
            {
                //Debug.Log("Went in here");
                GetComponent<Image>().color = playerColor;
                GetComponentInParent<Gameboard>().addToSet(myID);
                transform.parent.transform.parent.GetComponent<Player>().setTextColor("Color Left: " + (transform.parent.transform.parent.GetComponent<Player>().getTotalBetAmount()-1).ToString());
                transform.parent.transform.parent.GetComponent<Player>().setTotalBetAmount(transform.parent.transform.parent.GetComponent<Player>().getTotalBetAmount() - 1);
                //transform.parent.transform.parent.GetComponent<Player>().setText("Score: " + transform.parent.transform.parent.GetComponent<Player>().ToString());
            }
        }
        else {
            GetComponent<Image>().color = defaultColor;
            GetComponentInParent<Gameboard>().removeFromSet(myID);
            transform.parent.transform.parent.GetComponent<Player>().setTextColor("Color Left: " + (transform.parent.transform.parent.GetComponent<Player>().getTotalBetAmount() + 1).ToString());
            transform.parent.transform.parent.GetComponent<Player>().setTotalBetAmount(transform.parent.transform.parent.GetComponent<Player>().getTotalBetAmount() + 1);
        }
    }

    void setID(int IDnum)
    {
        myID = IDnum;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
