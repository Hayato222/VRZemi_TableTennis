using System;
using UnityEngine;

namespace ObjectTarget
{
    public class DeleteObject : MonoBehaviour
    {
        [SerializeField] private float DestroyTime = 5.0f;
        private void Update()
        {
            Destroy(this.gameObject, DestroyTime);
        }
    }
}