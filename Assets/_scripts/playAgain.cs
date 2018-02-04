using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playAgain : MonoBehaviour {

    public Text myText;

    public void Update()
    {
        myText.text = "5"; //allVariables.winner.toString()
    }
    public void changeMenuScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);

    }
}
