using System;
using System.Collections;
using System.Collections.Generic;
using ObjectTarget;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameManager game;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Invader"))
        {
            game.stopGame();
        }
    }
}
