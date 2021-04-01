using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public static UiManager instance;

    public Text ballAmountText, scoreText;
    

    void Awake()
    {
        instance = this;
    }

    public void UpdateBallText(int amount)
    {
        ballAmountText.text = "Ball: " + amount;
    }

    public void UpdateScoreText(int amount)
    {
        scoreText.text = amount.ToString("D10");
    }

}
