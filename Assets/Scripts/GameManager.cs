using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject loseUI;
    public Text scoreText;
    public int score;
    void Start()
    {
        
    }

    public void GameOver()
    {
        loseUI.SetActive(true);
        scoreText.text = "Skor:" + score;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void GameQuit()
    {
        Application.Quit();
    }
}
