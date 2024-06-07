using System;
using UnityEngine;

namespace ObjectTarget
{
    public class BallSE : MonoBehaviour
    {
        [SerializeField] private AudioSource BoundBallSet;
        [SerializeField] private AudioSource HitRacketSet;
        [SerializeField] private AudioClip BoundBallSE;
        [SerializeField] private AudioClip HitRacketSE;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Table"))
            {
                BoundBall();
            }

            if (other.CompareTag("Racket"))
            {
                HitRacket();
            }
            
        }
        

        void BoundBall()
        {
            BoundBallSet.PlayOneShot(BoundBallSE);
        }

        void HitRacket()
        {
            HitRacketSet.PlayOneShot(HitRacketSE);
        }
        
        
    }
}