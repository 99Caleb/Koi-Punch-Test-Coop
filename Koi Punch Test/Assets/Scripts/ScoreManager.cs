using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text endScoresVal;
    
    public TMP_Text highScoreText;
    public GameObject newHighScore;

    public int scores;
    public int endScores;
    public int growthRate;
    public int highScore;

    public bool gameOver;

    public void Update()
    {
        endScoresVal.text = endScores.ToString("0");
        highScoreText.text = highScore.ToString();
        
        if (Input.GetKeyDown("space"))
        {
            gameOver = true;
        }

        if (gameOver == true)
        {
            CalculateScore();
        }
    }

    public void CalculateScore()
    {
        if (endScores != scores && scores > endScores)
        {
            endScores += growthRate;
        }

        if (endScores > highScore)
        {
            highScore = endScores;
            newHighScore.SetActive(true);
        }
    }
}
