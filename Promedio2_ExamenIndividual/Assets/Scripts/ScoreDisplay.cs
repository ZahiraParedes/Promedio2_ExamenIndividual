using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class ScoreDisplay : MonoBehaviour
{
    private void OnEnable()
    {
        GameManager.Instance.ScoreChanged += HandleScoreChanged;
    }

    private void OnDisable()
    {
        GameManager.Instance.ScoreChanged -= HandleScoreChanged;
    }

    private void HandleScoreChanged(int newScore)
    {
        Debug.Log("Score: " + newScore);
    }
}
