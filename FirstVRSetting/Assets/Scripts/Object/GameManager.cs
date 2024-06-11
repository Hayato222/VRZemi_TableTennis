using System;
using UnityEngine;
namespace ObjectTarget
{
    public class GameManager : MonoBehaviour
    {
        private bool inPlay = true;
        private float playTime = 0f;

        private void Update()
        {
            if (inPlay)
            {
                playTime += Time.deltaTime;
            }
        }

        public void startGame()
        {
            inPlay = true;
        }

        public void stopGame()
        {
            inPlay = false;
        }

        public float GetPlayTime()
        {
            return playTime;
        }
        
    }
}