using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObjectTarget
{
    public class BoundSE : MonoBehaviour
         {
             private void OnTriggerEnter(Collider other)
             {
                 if (other.CompareTag("Ball"))
                 {
                     GetComponent<AudioSource>().Play();
                     Debug.Log("かつっ！");
                 }
                 
             }
         }
}


