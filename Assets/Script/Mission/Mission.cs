using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Mission
{
    public int missionId;
    [Space]
    public bool active;
    public bool missionComplete;
    [Space]
    public bool restartOnNextBall;
    public bool stopOnBallEnd;
    public bool resetOnComplete;
    [Space]
    public float timeToComplete;
    [Space]
    public int score;
    public int amountToComplete;
    public int currentAmount;

    public void ResetMission()
    {
        if (resetOnComplete)
        {
            active = false;
            missionComplete = false;
            currentAmount = 0;
        }
    }

    public void DeactivateMission()
    {
        active = false;
        currentAmount = 0;
    }

    public void UpdateMission()
    {
        if(active && !missionComplete)
        {
            currentAmount++;
            //Check to see if the mission is complete
            CheckMissionComplete();
        }
    }

    void CheckMissionComplete()
    {
        if(currentAmount >= amountToComplete)
        {
            missionComplete = true;
            active = false;

            if(timeToComplete > 0)
            {
                //Stop timer > Mission Manager
                MissionManager.instance.StopTimer();
            }

            ScoreManager.instance.AddScore(score);

            ResetMission();
            Debug.Log("Mission Complete");
        }
    }

    public bool GetMissionActive()
    {
        return active;
    }

}
