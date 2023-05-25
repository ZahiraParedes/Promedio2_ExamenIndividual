using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private int score = 0;
    public Text scoreText;

    public static GameManager getInstance()
    {
        return Instance;
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Puntaje: "+ score;
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    public void UpdateScore(int value)
    {
        score += value;
        NotifyScoreChanged();
    }

    private void NotifyScoreChanged()
    {
        UpdateScoreText();
    }
}

