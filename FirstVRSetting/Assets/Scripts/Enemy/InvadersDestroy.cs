using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvadersDestroy : MonoBehaviour
{
    public Score score;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            Debug.Log("ぴゅーん！！");
            score.DieInvaderCount++;
            Destroy(this.gameObject);
        }
    }
}
