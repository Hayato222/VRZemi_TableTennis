using System;
using System.Reflection;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

namespace ObjectTarget
{
    public class MoveTarget : MonoBehaviour
    {
        [SerializeField] private float speed = 1f;
        [SerializeField] private float moveRange = 0.6f;
        bool overMoveRange = true;
        void Start()
        {
            
        }

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
           }
           
           

           if (overMoveRange)
           {
               pos.z -= speed;
           }
           else
           {
               pos.z += speed;
           }

           target.position = pos;
       }

        private void OnCollisionEnter(Collision other)
        {
            Debug.Log("hit");
        }
    }
}