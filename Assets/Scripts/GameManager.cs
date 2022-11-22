using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject loseUI;
    public GameObject winUI;
    public Text scoreText;
    public int score;
    void Start()
    {
        
    }

    public void GameOver()
    {
        loseUI.SetActive(true);
        //Oyun bitti panelini aktif et
        scoreText.text = "Skor:" + score;
        //skor textine score de�i�kenindeki de�eri ata.
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //Aktif sahneyi tekrar y�kler
    }
    public void GameQuit()
    {
        Application.Quit();
        //Uygulamadan ��k��
    }
    public void LevelComplete()
    {
        winUI.SetActive(true);
    }
    public void NextLEvel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}
