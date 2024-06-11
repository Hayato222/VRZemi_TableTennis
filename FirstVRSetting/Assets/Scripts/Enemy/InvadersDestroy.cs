using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvadersDestroy : MonoBehaviour
{
    public PlayData data;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            Debug.Log("ぴゅーん！！");
            data.addKill();
            Destroy(this.gameObject);
        }
    }
}
