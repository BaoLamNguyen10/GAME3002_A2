using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour
{
    public bool isStarter;
    public bool isCounter;
    [Space]
    public int triggerId;

    void OnTriggerEnter(Collider col)
    {
        bool startedAlready = MissionManager.instance.CheckIfMissionStarted(triggerId);
        if (isStarter)
        {
            MissionManager.instance.StartMission(triggerId);
        }

        if (isCounter && startedAlready)
        {
            MissionManager.instance.UpdateMission(triggerId);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        bool startedAlready = MissionManager.instance.CheckIfMissionStarted(triggerId);
        if (isStarter)
        {
            MissionManager.instance.StartMission(triggerId);
        }

        if (isCounter && startedAlready)
        {
            MissionManager.instance.UpdateMission(triggerId);
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = new Color32(0, 0, 255, 125);
        Gizmos.matrix = transform.localToWorldMatrix;
        Gizmos.DrawCube(Vector3.zero, Vector3.one);
    }
}
