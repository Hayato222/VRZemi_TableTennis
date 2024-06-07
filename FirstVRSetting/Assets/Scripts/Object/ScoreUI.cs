using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

namespace ObjectTarget
{
    public class ScoreUI : MonoBehaviour
    {
        public Score score;
        public TextMeshProUGUI inPlayScoreUI;
        void Start()
        {
        }

        void Update()
        {
            inPlayScoreUI.text = "Score : " + score.FallenCanCount;
        }
    }
}