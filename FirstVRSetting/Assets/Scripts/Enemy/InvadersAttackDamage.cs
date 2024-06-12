using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvadersAttackDamage : MonoBehaviour
{
    public PlayData data;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("InvadersAttack"))
        {
            data.AddDamage();
            Destroy(other.gameObject);
        }
    }
}
