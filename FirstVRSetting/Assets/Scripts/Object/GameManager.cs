using System;
using UnityEngine;
namespace ObjectTarget
{
    public class GameManager : MonoBehaviour
    {
        
        public bool inPlay = true;
        private float playTime = 0f;
        public PlayData data;
        [SerializeField] private float enemyCount = 0;
        

        private void Update()
        {
            enemyCount = data.NumberAlive();
            if (inPlay)
            {
                playTime += Time.deltaTime;
            }

            if (enemyCount == 0)
            {
                inPlay = false;
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

        public bool GetFlag()
        {
            return inPlay;
        }
        
    }
}