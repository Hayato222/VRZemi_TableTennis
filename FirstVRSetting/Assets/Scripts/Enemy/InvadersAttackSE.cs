using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvadersAttackSE : MonoBehaviour
{
    [SerializeField] private AudioSource SE;
    [SerializeField] private AudioClip Shot;

    public void shotSE()
    {
        SE.PlayOneShot(Shot);
    }
    
}
