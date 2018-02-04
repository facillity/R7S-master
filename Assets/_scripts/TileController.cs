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
        //GetComponent<Button>().colors = playerBlockColor; // = playerColor;
        Debug.Log("Clicked");
        if (GetComponent<Image>().color != playerColor) {
            Debug.Log(GameObject.Find("PlayerStuff").GetComponent<Player>().getTotalBetAmount());
            if (transform.Find("PlayerStuff").GetComponent<Player>().getTotalBetAmount() > 0)//GetComponentInParent<Player>().getTotalBetAmount() > 0)
            {
                Debug.Log("Went in here");
                GetComponent<Image>().color = playerColor;
                GetComponent<Gameboard>().addToSet(myID);
                GetComponent<Player>().setTextColor("Color Left: " + (GetComponent<Player>().getTotalBetAmount()-1).ToString());
                GetComponent<Player>().setTotalBetAmount(GetComponent<Player>().getTotalBetAmount() - 1);
                GetComponent<Player>().setText("Score: " + GetComponent<Player>().getCurrentScore().ToString());
            }
        }
        else {
            GetComponent<Image>().color = defaultColor;
            GetComponentInParent<Gameboard>().removeFromSet(myID);
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
