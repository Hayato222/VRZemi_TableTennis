using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayData : MonoBehaviour
{
    private float DieInvaderCount = 0f;

    public float KillCount()
    {
        return DieInvaderCount;
    }

    public float addKill()
    {
        return DieInvaderCount++;
    }
}
