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
        if (GetComponent<Image>().color != playerColor) {
            GetComponent<Image>().color = playerColor;
            GetComponentInParent<Gameboard>().addToSet(myID);
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
