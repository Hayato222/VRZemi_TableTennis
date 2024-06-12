using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

namespace ObjectTarget
{
    public class ScoreUI : MonoBehaviour
    {
        public PlayData data;
        public TextMeshProUGUI inPlayScoreUI;

        void Update()
        {
            inPlayScoreUI.text = "Score : " + data.KillScore();
        }
    }
}