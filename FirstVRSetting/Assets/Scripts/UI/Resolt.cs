using System;
using System.Collections;
using System.Collections.Generic;
using ObjectTarget;
using UnityEngine;
using TMPro;

public class Resolt : MonoBehaviour
{
    public PlayData data;
    public GameManager game;
    [SerializeField] private TextMeshProUGUI result;
    [SerializeField] private Canvas gameEndCanvas;
    void Update()
    {
        AnnouncementOfResult();
    }

    void AnnouncementOfResult()
    {
        if (!game.inPlay)
        {
            gameEndCanvas.enabled = true;
            
            result.text = "Time : " + game.GetPlayTime() + "\n"
                          + "KillScore : " + data.KillScore() + "\n"
                          + "Damage : " + data.DamageScore() + "\n"
                          + "---------------\n"
                          + "Total Score : " + (data.KillScore() - game.GetPlayTime() - data.DamageScore());
        }
    }
    
}
