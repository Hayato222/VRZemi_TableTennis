using System;
using System.Collections;
using System.Collections.Generic;
using ObjectTarget;
using UnityEngine;
using TMPro;

public class PlayTime : MonoBehaviour
{
    public GameManager game;
    [SerializeField] private TextMeshProUGUI Timer;
    private void Update()
    {
        Timer.text = "Time : " + game.GetPlayTime().ToString("f2");
    }
}
