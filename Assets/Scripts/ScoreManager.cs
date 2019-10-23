using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public Text scoreText;
    public Text highScoreText;

    public float scoreCount;
    public float highScoreCount;

    public float pointsPerSecond;
    public bool scoreIncreasing;


    void Start()
    {
        if(PlayerPrefs.HasKey("HIGHSCORE"))
        {
            highScoreCount = PlayerPrefs.GetFloat("HIGHSCORE");
        }
    }

    
    void Update()
    {
        if (scoreIncreasing)
        {
            scoreCount += pointsPerSecond * Time.deltaTime;
        }
        if (scoreCount > highScoreCount)
        {
            highScoreCount = scoreCount;
            PlayerPrefs.SetFloat("HIGHSCORE", highScoreCount);
        }

        scoreText.text = "SCORE: " + Mathf.Round(scoreCount);
        highScoreText.text = "HIGH SCORE: " + Mathf.Round(highScoreCount);
    }
}
