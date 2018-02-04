using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    private string name;
    private int currentScore;
    private int victoryPoints;
    private bool currentRoundWinner;
    private int currentBet;
    private int moveLocations;
    private int totalBetAmount;
    public Color playerColor;
    private int totalPlayers;
    public Text PlayerScore;
    public Text ColorLeftText;


	// Use this for initialization
	void Start () {
        name = allVariables.getPlayerName();
        currentScore = 0;
        victoryPoints = 0;
        //currentBet = 0;
        playerColor = allVariables.getPlayerColor();
        totalPlayers = allVariables.getTotalPlayerCount();
        totalBetAmount = totalPlayers * 2;
        PlayerScore = GetComponent<Text>();
        //PlayerScore.text = "Score: 0";
        ColorLeftText = GetComponent<Text>();
        //ColorLeftText.text = "Color Left: 0";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public int getColorLeft()
    {
        return totalBetAmount;
    }

    public int getTotalBetAmount()
    {
        return totalBetAmount;
    }

    //Returns the player's current score
    public int getCurrentScore()
    {
        return currentScore;
    }

    //Returns the player's name
    public string getName()
    {
        return name;
    }

    //Returns the player's victory points
    public int getVictoryPoints()
    {
        return victoryPoints;
    }

    public void setName(string givenName)
    {
        name = givenName;
    }

   public void subtractColor()
    {
        totalBetAmount -= 1;
    }

    public void setText(string givenString)
    {
        PlayerScore.text = givenString;
    }

    public void setTextColor(string givenString)
    {
        ColorLeftText.text = givenString;
    }

    public void setTotalBetAmount(int newBetAmount)
    {
        totalBetAmount = newBetAmount;
    }
}
