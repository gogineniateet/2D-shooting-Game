using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    GameManager game;
    public GameObject targetPrefab;   
   
    void Start()
    {
        InvokeRepeating("Spawn", 1f, 1f);
        game = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void Update()
    {
        if ((game.isGameWin == true) || (game.isGameOver == true))
        {
            CancelInvoke("Spawn");
        }
    }
    public void Spawn()
    {
       if ((game.isGameWin == false) || (game.isGameOver == false))
        {
            float randomX = UnityEngine.Random.Range(-4.5f, 4.5f);
            float randomY = UnityEngine.Random.Range(-2.3f, 2.3f);
            Instantiate(targetPrefab, new Vector3(randomX, randomY, 0), Quaternion.identity);
        }            
    }
}
