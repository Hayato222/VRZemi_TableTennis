using System;
using System.Reflection;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

namespace Enemy
{
    public class MoveTarget : MonoBehaviour
    {
        [SerializeField] private float sideMovementlSpeed = 1f;
        [SerializeField] private float moveRange = 0.6f;
        [SerializeField] private float verticalMovementSpeed = 1f;
        bool overMoveRange = true;
        private bool endOfRange = false;
       void Update()
       {
           Transform target = this.transform;
           Vector3 pos = target.position;
           
           
           if (pos.z >= moveRange)
           {
               overMoveRange = true;
           }
           else if(pos.z <= -moveRange)
           {
               overMoveRange = false;
               endOfRange = true;
           }
           
           if (overMoveRange)
           {
               pos.z -= sideMovementlSpeed;
           }
           else
           {
               pos.z += sideMovementlSpeed;
           }

           if (endOfRange)
           {
               pos.x += verticalMovementSpeed;
               endOfRange = false;
           }
           
             

           target.position = pos;
       }
    }
}