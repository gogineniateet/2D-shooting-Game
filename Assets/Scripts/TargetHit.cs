using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetHit : MonoBehaviour
{
    ScoreManager score;
    public float time;
    void Start()
    {
        score = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }
    private void Update()
    {
        time = time + Time.deltaTime;
        if (time >= 3f)
        {
            Destroy(gameObject);
        }
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
        score.ScoreUpdate(1);
    }
}
