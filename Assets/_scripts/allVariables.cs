using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class allVariables
{
    private static string playerName;
    private static int currentScore;
    private static int victoryPoints;
    private static bool currentRoundWinner;
    private static int currentBet;
    private static int moveLocations;
    private static Color playerColor;
    private static int totalPlayers;

    public static int getTotalPlayerCount()
    {
        return totalPlayers;
    }

    public static void setTotalPlayerCount(int givenTotalPlayers)
    {
        totalPlayers = givenTotalPlayers;
    }

    public static string getPlayerName()
    {
        return playerName;
    }

    public static void setPlayerName(string givenPlayerName)
    {
        playerName = givenPlayerName;
    }

    public static int getCurrentScore()
    {
        return currentScore;
    }

    public static void setCurrentScore(int givenScore)
    {
        currentScore = givenScore;
    }

    public static int getVictoryPoints()
    {
        return victoryPoints;
    }

    public static void setVictoryPoints(int givenVictoryPoints)
    {
        victoryPoints = givenVictoryPoints;
    }

    public static int getCurrentBet()
    {
        return currentBet;
    }

    public static void setCurrentBet(int givenCurrentBet)
    {
        currentBet = givenCurrentBet;
    }

    public static Color getPlayerColor()
    {
        return playerColor;
    }

    public static void setPlayerColor(Color givenColor)
    {
        playerColor = givenColor;
        Debug.Log(playerColor);
    }

}