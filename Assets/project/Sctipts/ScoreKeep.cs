using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreKeep : MonoBehaviour
{
    public static ScoreKeep instance;
    public TextMeshProUGUI scoreText;
    private int score;
    private bool isGameOver = false;
    // Start is called before the first frame update
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        score = 0;
        UpdatescoreText();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameOver && Time.frameCount % 60 == 0)
        {
            AddScore(1);
        }
    }
    public void AddScore(int points)
    {
        score += points;
        UpdatescoreText();
    }
    void UpdatescoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
    public void StopScore()
    {
        isGameOver = true;
    }
}
