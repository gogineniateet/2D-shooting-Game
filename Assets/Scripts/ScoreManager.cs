using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ScoreManager : MonoBehaviour
{
    public int score;
    public Text scoreText;
    GameManager game;

    void Update()
    {
        scoreText.text = score.ToString();
    }

    public void ScoreUpdate(int value)
    {
        score = score + value;
        Debug.Log("Score : " + score);
        if(score >= 20)
        {
            game.youWin.SetActive(true);
            game.isGameWin = true; ;
        }
    }
    
}
