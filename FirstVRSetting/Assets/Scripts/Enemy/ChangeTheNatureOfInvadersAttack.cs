using System;
using System.Collections;
using System.Collections.Generic;
using ObjectTarget;
using Unity.VisualScripting;
using UnityEngine;

public class ChangeTheNatureOfInvadersAttack : MonoBehaviour
{ 
    private void OnTriggerEnter(Collider other)
    {
        Rigidbody rb;
        rb = this.GetComponent<Rigidbody>();
        if (other.CompareTag("Racket") && rb.useGravity == false)
        {
            this.gameObject.tag = "Ball";
            //ラケットにあったたら通常の球に戻る
            rb.useGravity = true;
        }
    }
}
