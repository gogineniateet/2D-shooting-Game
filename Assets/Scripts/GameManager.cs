using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject youWin;
    public GameObject gameOver;
    public Button playAgain;
    public bool isGameOver = false;
    public bool isGameWin = false;
    public float time;


    void Update()
    {
        time = time + Time.deltaTime;

        if ((time > 10f) && (isGameWin == false))
        {
            gameOver.SetActive(true);
            isGameOver = true;
            Button button = playAgain.GetComponent<Button>();
            button.onClick.AddListener(TaskOnClick);
        }
    }

    public void TaskOnClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
