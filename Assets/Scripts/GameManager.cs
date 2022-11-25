using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject loseUI;
    public GameObject winUI;
    public Text loseScoreText;
    public Text winScoreText;
    public GameObject scoreObject;
    public GameObject effect;
    public int score;
    
    void Start()
    {
        
    }

    public void GameOver()
    {
        loseUI.SetActive(true);
        //Oyun bitti panelini aktif et
        loseScoreText.text = "Skor:" + score;
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
        
        winScoreText.text ="Tebrikler!!! ".ToUpper()+"\n" + " Skor:" + score;
    }
    public void ScoreObject()
    {
        score += 15;//Skoru art�r ve efekt objesini olu�tur
        Instantiate(effect, scoreObject.transform.position, Quaternion.Euler(new Vector3(90,0,0))) ;
    }
    public void NextLEvel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}
