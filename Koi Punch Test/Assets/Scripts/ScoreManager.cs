using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text aScoresVal;
    public TMP_Text bScoresVal;
    public TMP_Text cScoresVal;
    public TMP_Text dScoresVal;
    public TMP_Text totalScoresVal;
    
    public TMP_Text highScoreText;
    public GameObject newHighScore;

    public int scoresA;
    public int scoresB;
    public int scoresC;
    public int scoresD;
    //public int totalScore;
    public int endScoresA;
    public int endScoresB;
    public int endScoresC;
    public int endScoresD;
    public int totalEndScores;
    public int growthRate = 1;
    public int highScore;

    public bool gameOver;

    private void Start()
    {
        InvokeRepeating("CalculateScore",0f,0.01f);
    }

    public void Update()
    {
        aScoresVal.text = endScoresA.ToString("0");
        bScoresVal.text = endScoresB.ToString("0");
        cScoresVal.text = endScoresC.ToString("0");
        dScoresVal.text = endScoresD.ToString("0");
        totalScoresVal.text = totalEndScores.ToString("0");
        highScoreText.text = highScore.ToString();
        
        if (Input.GetKeyDown("space"))
        {
            gameOver = true;
        }

        if (gameOver == true)
        {
            Debug.Log("Game Over");
            //CalculateScore();
            //InvokeRepeating("CalculateScore",0f,1f);
        }
    }

    public void CalculateScore()
    {
        Debug.Log("Calculating Score");
        if (endScoresA != scoresA && scoresA > endScoresA)
        {
            endScoresA += growthRate;
            totalEndScores += growthRate;
        }
        else if (endScoresB != scoresB && scoresB > endScoresB)
        {
            endScoresB += growthRate;
            totalEndScores += growthRate;
        }
        else if (endScoresC != scoresC && scoresC > endScoresC)
        {
            endScoresC += growthRate;
            totalEndScores += growthRate;
        }
        else if (endScoresD != scoresD && scoresD > endScoresD)
        {
            endScoresD += growthRate;
            totalEndScores += growthRate;
        }
        else if (totalEndScores > highScore)
        {
            //highScore = totalEndScores;
            newHighScore.SetActive(true);
        }
    }
}
