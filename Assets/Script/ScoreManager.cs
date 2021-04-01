using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    int score;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        UiManager.instance.UpdateScoreText(score);
    }

    public int ReadScore()
    {
        return score;
    }

    public void AddScore(int amount)
    {
        score += amount;
        UiManager.instance.UpdateScoreText(score);
    }
}
