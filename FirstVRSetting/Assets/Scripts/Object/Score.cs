using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public float FallenCanCount = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Can"))
        {
            FallenCanCount++;
            Debug.Log("缶が落ちた");
            Destroy(other);
        }
    }
}
