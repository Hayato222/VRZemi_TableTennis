using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvadersDestroy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            Debug.Log("ぴゅーん！！");
            Destroy(this.gameObject);
        }
    }
}
