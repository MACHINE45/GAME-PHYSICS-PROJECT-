using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text scoreText;
    public Text highscoreText;

    public int score = 0;
    int highscore = 0;
    
    private void Awake(){
        instance = this;
    }

    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = "Score: " + score.ToString();
        highscoreText.text = "High Score: " + highscore.ToString();
    }
    public void AddPoint(){
        score += 1;
        scoreText.text = "Score: " + score.ToString();
        if (highscore < score)
            PlayerPrefs.SetInt("highscore", score);
    }
}
