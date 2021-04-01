using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    int startBallAmount = 3;
    int currentBallAmount;
    //SPAWNBALL
    public GameObject ballPrefab;
    public Transform spawnPoint;

    bool gameStarted;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        ResetGame();
    }

    public void ResetGame()
    {
        currentBallAmount = startBallAmount;
        UiManager.instance.UpdateBallText(currentBallAmount);
        CreateNewBall();
    }

    public void CreateNewBall()
    {
        if (currentBallAmount > 0)
        {
            Instantiate(ballPrefab, spawnPoint.position, Quaternion.identity);
            currentBallAmount--;
            UiManager.instance.UpdateBallText(currentBallAmount);
        }
        else
        {
            Debug.Log("Game Over");
        }
    }
}
