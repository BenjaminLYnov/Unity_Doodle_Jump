using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private Vector2 oldPosition;
    public GameObject player;

    private float score = 0;

    void Start()
    {
        oldPosition = player.transform.position;
        scoreText.text = "Score : " + score.ToString();
    }

    private void Update()
    {
        
        if (oldPosition.y < player.transform.position.y)
        {
            Up(player.transform.position.y - oldPosition.y);
            oldPosition = player.transform.position;
        }
    }

    public void Up(float nbr)
    {
        score += nbr;
        scoreText.text = "Score : " + Math.Round(score, 0).ToString();
    }
}
