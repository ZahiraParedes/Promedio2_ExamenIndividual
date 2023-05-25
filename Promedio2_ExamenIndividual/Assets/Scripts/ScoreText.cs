using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    private Text scoreText;
    private GameManager gameManager;

    private void Awake()
    {
        scoreText = GetComponent<Text>();
        gameManager = GameManager.Instance;
    }

    private void OnEnable()
    {
        gameManager.ScoreChanged += UpdateScoreText;
    }

    private void OnDisable()
    {
        gameManager.ScoreChanged -= UpdateScoreText;
    }

    private void UpdateScoreText(int newScore)
    {
        scoreText.text = "Score: " + newScore.ToString();
    }
}
