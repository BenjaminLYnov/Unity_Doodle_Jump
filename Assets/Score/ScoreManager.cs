using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;

    private float score = 0;

    void Start()
    {
        scoreText.text = "Score : " + score.ToString();
    }

    public void Up(float nbr)
    {
        score += nbr;
        scoreText.text = "Score : " + Math.Round(score, 0).ToString();
    }
}
