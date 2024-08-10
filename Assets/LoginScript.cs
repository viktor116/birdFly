using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoginScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameObjectScreen; 

    [ContextMenu("Increase score")]
    public void addScore(int scopeToAdd)
    {
        playerScore += scopeToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameObjectScreen.SetActive(true);
    }
}
